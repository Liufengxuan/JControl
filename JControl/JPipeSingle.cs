using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using JControl.Params;


namespace JControl
{


    [ToolboxItem(true)]
    public partial class JPipeSingle : BaseControl
    {
        public JPipeSingle()
        {

            InitializeComponent();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.Selectable, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.UserPaint, true);
        }








        private List<PipeSingleParams> _JPipeSingleParams = new List<PipeSingleParams>();
        [TypeConverter(typeof(CollectionConverter))]//指定类型装换器
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Category("J"), Description("组合管道集合")]
        public List<PipeSingleParams> JPipeSingleParams
        {
            get { return _JPipeSingleParams; }
            set { _JPipeSingleParams = value; }
        }


        private int _PipeWidth = 13;
        [Description("管道宽度"), Category("J"), Browsable(true)]
        public int JPipeWidth
        {
            get { return _PipeWidth; }
            set { if (value % 2 == 0)
                {
                    _PipeWidth = value + 1;
                }
                else
                {
                    _PipeWidth = value;
                }

                    ; Invalidate(); }
        }


        private int _JStartPostion = 13;
        [Description("管道起始部分的位置"), Category("J"), Browsable(true)]
        public int JStartPostion
        {
            get { return _JStartPostion; }
            set
            {
                _JStartPostion = value;

                ; Invalidate();
            }
        }


        private bool _JIsFlow = false;
        [Description("是否流动"), Category("J"), Browsable(true)]
        public bool JIsFlow
        {
            get { return _JIsFlow; }
            set
            {
                _JIsFlow = value;
                timer_Flow.Enabled = value;
                ; Invalidate();
            }
        }





        private int _JOpacity = 132;
        [Description("背景不透明度"), Category("J"), Browsable(true)]
        public int JOpacity
        {
            get { return _JOpacity; }
            set { _JOpacity = value; Invalidate(); }
        }


        private Color _JPipeColor = Color.LimeGreen;
        [Description("管道颜色"), Category("J"), Browsable(true)]
        public Color JPipeColor
        {
            get { return JUseTheme ? ThemeColor : _JPipeColor; }
            set { _JPipeColor = value; Invalidate(); }
        }

        private Color _JFlowColor = Color.Gray;
        [Description("流动块颜色"), Category("J"), Browsable(true)]
        public Color JFlowColor
        {
            get {

                return JUseTheme ? ThemeForeColor : _JFlowColor;

            }
            set { _JFlowColor = value; timer_Flow_Tick(null, null); }
        }






        #region MyRegion

        #endregion
        private void DrawBackGround(Graphics g)
        {
            //GraphicsPath gPath = new GraphicsPath();
            //Rectangle rectangle = this.ClientRectangle;
            //gPath.AddRectangle(rectangle);
            //SolidBrush sb = new SolidBrush(Color.FromArgb(JOpacity, this.BackColor));
            //g.FillPath(sb, gPath);
            //sb.Dispose();
            //gPath.Dispose();
            this.BackColor = Color.FromArgb(JOpacity, this.BackColor);

        }


        Pen InsidePen = new Pen(Color.Red);
        Pen OutsidePen = new Pen(Color.Red);
        Pen dashPen = new Pen(Color.Red);
        LinearGradientBrush myLinearGradientBrush = null;
        List<Point> endPoints = new List<Point>();

        private void DrawSingleXPipe(Graphics g,Point p1,Point p2)
        {
            myLinearGradientBrush = new LinearGradientBrush(
            new Rectangle(0,p1.Y-((int)InsidePen.Width / 2), 1, (int)InsidePen.Width),
            Helper.ColorHelper.GetNearColor(JPipeColor, 0.4f),
            Helper.ColorHelper.GetNearColor(JPipeColor, 0.9f),
            LinearGradientMode.Vertical);

           

            InsidePen.Brush = myLinearGradientBrush;           
            g.DrawLine(OutsidePen, p1, p2);
            g.DrawLine(InsidePen, p1, p2);
            if(JIsFlow) g.DrawLine(dashPen, p1.X, p1.Y, p2.X, p2.Y);



            myLinearGradientBrush.Dispose();

        }


        private void DrawSingleYPipe(Graphics g, Point p1, Point p2)
        {
            myLinearGradientBrush = new LinearGradientBrush(
            new Rectangle(p1.X - ((int)InsidePen.Width / 2), p1.Y , (int)InsidePen.Width, 1),
            Helper.ColorHelper.GetNearColor(JPipeColor, 0.4f),
            Helper.ColorHelper.GetNearColor(JPipeColor, 0.9f),
            LinearGradientMode.Horizontal);



            InsidePen.Brush = myLinearGradientBrush;
            g.DrawLine(OutsidePen, p1, p2);
            g.DrawLine(InsidePen, p1, p2);
            if (JIsFlow) g.DrawLine(dashPen, p1.X, p1.Y, p2.X, p2.Y);


            myLinearGradientBrush.Dispose();
        }

        
        private void DrawPipeTail(Graphics g,Point p)
        {
         Pen pen = new Pen(JPipeColor, 1);
         Rectangle rec = new Rectangle(p.X - (JPipeWidth / 2), p.Y-(JPipeWidth/2), JPipeWidth, JPipeWidth);
            //  myLinearGradientBrush = new LinearGradientBrush(
            //rec,
            // Helper.ColorHelper.GetNearColor(JPipeColor, 0.4f),
            // Helper.ColorHelper.GetNearColor(JPipeColor, 0.9f),
            // LinearGradientMode.Horizontal);
            SolidBrush solidBrush = new SolidBrush(JPipeColor);

           // g.FillRectangle(solidBrush, rec);
            g.FillEllipse(solidBrush, rec);

            pen.Dispose();
            solidBrush.Dispose();
            // g.DrawEllipse(pen, rec);
        }

        protected override void OnPaint(PaintEventArgs e)
        {


            this.BackColor = Color.FromArgb(JOpacity, this.BackColor);
            endPoints.Clear();


            InsidePen.Width = JPipeWidth / 2;
            OutsidePen.Width = JPipeWidth;
            OutsidePen.Color = JPipeColor;
            dashPen.DashStyle = DashStyle.Dot;
            dashPen.DashOffset = FlowOffSet;
            dashPen.DashCap = DashCap.Flat;
            dashPen.Width = JPipeWidth / 2;
            dashPen.Color = JFlowColor;



            Point sPoint = new Point(3, 20);
            Point ePoint = new Point(300, 20);

            JPipeSingleParams.Sort();
            foreach (Params.PipeSingleParams item in JPipeSingleParams)
            {
                if (item == JPipeSingleParams[0])//计算第一根的起始坐标。
                {
                    sPoint.Y = this.ClientRectangle.Height - 1 - JPipeWidth;
                    sPoint.X = JStartPostion;
                }
                else//接下来的起始坐标都是上一根的结束坐标
                {
                    sPoint  = ePoint;
                }
                switch (item.ControlDirection)
                {
                    case Direction.Up:
                        ePoint.X = sPoint.X;
                        ePoint.Y = sPoint.Y - item.Length;
                        DrawSingleYPipe(e.Graphics, sPoint, ePoint);
                        break;

                    case Direction.Left:
                        ePoint.X=sPoint.X- item.Length;
                        ePoint.Y = sPoint.Y;
                        DrawSingleXPipe(e.Graphics, sPoint, ePoint);
                        break;

                    case Direction.Down:
                        ePoint.X = sPoint.X;
                        ePoint.Y = sPoint.Y +item.Length;
                        DrawSingleYPipe(e.Graphics, sPoint, ePoint);
                        break;

                    case Direction.Right:
                        ePoint.X = sPoint.X +item.Length;
                        ePoint.Y = sPoint.Y;
                        DrawSingleXPipe(e.Graphics, sPoint, ePoint);
                        break;
                }
                if (item != JPipeSingleParams.Last())
                {
                    endPoints.Add(ePoint);
                }

            }



            foreach (Point item in endPoints)
            {
                DrawPipeTail(e.Graphics, item);
            }



            //p1 = new Point(300, 20);
            //p2 = new Point(300, 300);
            //DrawSingleYPipe(e.Graphics, p1, p2);







            base.OnPaint(e);
        }

        private  float FlowOffSet =1.0f;
        private void timer_Flow_Tick(object sender, EventArgs e)
        {
            if (FlowOffSet == 1.0f)
            {
                FlowOffSet = 0f;
            } else
            {
                FlowOffSet = 1.0f;
            }
            Invalidate();
        }
    }
}
