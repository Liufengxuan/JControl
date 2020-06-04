using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JControl.Params;

namespace JControl
{
    [ToolboxItem(true)]
    public partial class JConveyorBelt : BaseControl
    {
        public JConveyorBelt()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.Selectable, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.Size = new Size(200, 200);
        }


        private Params.ConveyorBeltPostion _JStartPostion = ConveyorBeltPostion.LowerLeft;
        [Description("转动轴的起始轴位置"), Category("J"), Browsable(true)]
        public ConveyorBeltPostion JStartPostion
        {
            get { return _JStartPostion; }
            set
            {
                if (value != ConveyorBeltPostion.LowerLeft && value != ConveyorBeltPostion.UpperLeft)
                {
                    _JStartPostion = ConveyorBeltPostion.LowerLeft;
                }
                else
                {
                    _JStartPostion = value;
                }              
                Invalidate();
            }
        }


        private Params.ConveyorBeltPostion _JEndPostion = ConveyorBeltPostion.LowerRight;
        [Description("转动轴的起结束位置"), Category("J"), Browsable(true)]
        public ConveyorBeltPostion JEndPostion
        {
            get { return _JEndPostion; }
            set
            {
                if (value != ConveyorBeltPostion.LowerRight && value != ConveyorBeltPostion.UpperRight)
                {
                    _JEndPostion = ConveyorBeltPostion.LowerRight;
                }
                else
                {
                    _JEndPostion = value;
                }
                Invalidate();
            }
        }



        private int _JCircleRadius = 13;
        [Description("转动轴圆圈的半径"), Category("J"), Browsable(true)]
        public int JCircleRadius
        {
            get { return _JCircleRadius; }
            set
            {
                _JCircleRadius = value;
                Invalidate();
            }
        }

        private int _JOpacity = 132;
        [Description("背景不透明度"), Category("J"), Browsable(true)]
        public int JOpacity
        {
            get { return _JOpacity; }
            set { _JOpacity = value; Invalidate(); }
        }

     
        [Description("大小"), Category("J"), Browsable(true)]
        public new Size Size
        {
            get { return base.Size; }
            set
            {

                if (((JStartPostion | JEndPostion) == (ConveyorBeltPostion.LowerLeft | ConveyorBeltPostion.UpperRight))|| ((JStartPostion | JEndPostion) == (ConveyorBeltPostion.UpperLeft | ConveyorBeltPostion.LowerRight)))
                {
                    base.Size = new Size(value.Height, value.Height);
                }      
                else
                {
                    base.Size = value;
                }

            }
        }

        private Color _JColor = Color.Gray;
        [Description("大小"), Category("J"), Browsable(true)]
        public  Color JColor
        {
            get {
               return JUseTheme?ThemeColor: _JColor;
            }
            set
            {
                _JColor = value;
            }
        }








        private int ThisWidth
        {
            get
            {
                return this.ClientRectangle.Width - 1;
            }
        }
        private int ThisHeight
        {
            get
            {
                return this.ClientRectangle.Height - 1;
            }
        }
        private int Padding = 4;
        private Rectangle StartRectangle;
        private Rectangle EndRectangle;
        private Point[] StartPoint=new Point[4];//0：上边、1下边、2左边、3右边
        private Point[] EndPoint = new Point[4];//0：上边、1下边、2左边、3右边

        private Rectangle GetRectangle(ConveyorBeltPostion c)
        {
            //Rectangle left1 = new Rectangle(Padding, Padding, JCircleRadius, JCircleRadius);
            //Rectangle left2 = new Rectangle(Padding, ThisHeight - Padding - JCircleRadius, JCircleRadius, JCircleRadius);

            //Rectangle Right1 = new Rectangle(ThisWidth - Padding - JCircleRadius, Padding, JCircleRadius, JCircleRadius);
            //Rectangle Right2 = new Rectangle(ThisWidth - Padding - JCircleRadius, ThisHeight - Padding - JCircleRadius, JCircleRadius, JCircleRadius);
            switch (c)
            {
                case ConveyorBeltPostion.UpperLeft:
                    return new Rectangle(Padding, Padding, JCircleRadius, JCircleRadius);
                case ConveyorBeltPostion.LowerLeft:
                    return new Rectangle(Padding, ThisHeight - Padding - JCircleRadius, JCircleRadius, JCircleRadius);
                case ConveyorBeltPostion.UpperRight:
                    return new Rectangle(ThisWidth - Padding - JCircleRadius, Padding, JCircleRadius, JCircleRadius);
                case ConveyorBeltPostion.LowerRight:
                    return new Rectangle(ThisWidth - Padding - JCircleRadius, ThisHeight - Padding - JCircleRadius, JCircleRadius, JCircleRadius);
            }
            return  new Rectangle(Padding, Padding, JCircleRadius, JCircleRadius);
        }

        private Point[] GetRectangleLinePoint(ConveyorBeltPostion c, Rectangle rtg)
        {
            Point[] ps = new Point[4];
            ps[0] = new Point(rtg.X+(JCircleRadius / 2), rtg.Y);
            ps[1] = new Point(rtg.X + (JCircleRadius / 2), rtg.Y + JCircleRadius);
            ps[2] = new Point(rtg.X, rtg.Y + (JCircleRadius / 2));
            ps[3] = new Point(rtg.X + JCircleRadius, rtg.Y + (JCircleRadius / 2));
            //switch (c)
            //{
            //    case ConveyorBeltPostion.UpperLeft:
            //        ps[0] = new Point(rtg.X, rtg.Y);
            //        ps[1] = new Point(rtg.X + (JCircleRadius / 2),rtg.Y+ JCircleRadius);
            //        ps[2]=new Point(rtg.X , rtg.Y + (JCircleRadius / 2));
            //        ps[3] = new Point(rtg.X + JCircleRadius, rtg.Y + (JCircleRadius / 2));

            //    case ConveyorBeltPostion.LowerLeft:

            //    case ConveyorBeltPostion.UpperRight:

            //    case ConveyorBeltPostion.LowerRight:

            //}
            return ps;
        }






        protected override void OnPaint(PaintEventArgs e)
        {
            if (((JStartPostion | JEndPostion) == (ConveyorBeltPostion.LowerLeft | ConveyorBeltPostion.UpperRight)) || ((JStartPostion | JEndPostion) == (ConveyorBeltPostion.UpperLeft | ConveyorBeltPostion.LowerRight)))
            {
                base.Size = new Size(Size.Height, Size.Height);
            }
            this.BackColor = Color.FromArgb(JOpacity, this.BackColor);
            base.OnPaint(e);
            //获取起始转轴和结束转轴的坐标矩形。
            StartRectangle = GetRectangle(JStartPostion);
            EndRectangle = GetRectangle(JEndPostion);
            //获取每个矩形四条边线的中间位置的坐标  //0：上边、1下边、2左边、3右边
            StartPoint =  GetRectangleLinePoint(JStartPostion, StartRectangle);
            EndPoint= GetRectangleLinePoint(JEndPostion, EndRectangle);


            Point pA1, pA2, pB1, pB2;

            //判断连接方式
            switch (JStartPostion | JEndPostion)
            {
                case ConveyorBeltPostion.LowerLeft | ConveyorBeltPostion.UpperLeft:  //垂直
                    pA1 = StartPoint[2];
                    pA2 = EndPoint[2];
                    pB1 = StartPoint[3];
                    pB2 = EndPoint[3];
                    break;
                case ConveyorBeltPostion.LowerLeft | ConveyorBeltPostion.LowerRight://水平
                    pA1 = StartPoint[0];
                    pA2 = EndPoint[0];
                    pB1 = StartPoint[1];
                    pB2 = EndPoint[1];
                    break;
                case ConveyorBeltPostion.LowerLeft | ConveyorBeltPostion.UpperRight://往右上斜

                    pA1 = new Point(StartPoint[0].X - (JCircleRadius / 5), StartPoint[0].Y);
                    pA2 = new Point(EndPoint[2].X, EndPoint[2].Y - (JCircleRadius / 5));
                    pB1 = new Point(StartPoint[3].X, StartPoint[3].Y + (JCircleRadius / 5));//StartPoint[1];
                    pB2 = new Point(EndPoint[1].X + (JCircleRadius / 5), EndPoint[1].Y);
                    break;
                case ConveyorBeltPostion.UpperLeft | ConveyorBeltPostion.LowerRight://往右下斜
                    pA1 = new Point(StartPoint[3].X, StartPoint[3].Y - (JCircleRadius / 5));
                    pA2 = new Point(EndPoint[0].X+ (JCircleRadius / 5), EndPoint[0].Y);
                    pB1 = new Point(StartPoint[1].X - (JCircleRadius / 5), StartPoint[1].Y );//StartPoint[1];
                    pB2 = new Point(EndPoint[2].X, EndPoint[2].Y + (JCircleRadius / 5));
                    break;


                default:
                    e.Graphics.DrawString("不支持的组合方式", new Font("Arial", 16),new SolidBrush(Color.Red),0f,0f);return;

            }





            int p1Width = 3;
            Pen p1 = new Pen(JColor, p1Width);
            Pen s = new Pen(Color.Red,2);


           

            e.Graphics.DrawLine(p1, pA1, pA2);
            e.Graphics.DrawLine(p1, pB1, pB2);
            e.Graphics.DrawEllipse(p1, StartRectangle);
            e.Graphics.DrawEllipse(p1, EndRectangle);
            e.Graphics.DrawLine(s, pA1.X, pA1.Y - p1Width, pA2.X, pA2.Y - p1Width);
            //e.Graphics.FillEllipse(new SolidBrush(Color.Transparent), StartRectangle);
            //e.Graphics.FillEllipse(new SolidBrush(Color.Transparent), EndRectangle);
            //e.Graphics.DrawRectangle(p, StartRectangle);
            //e.Graphics.DrawRectangle(p, EndRectangle);

        }

    }
}
