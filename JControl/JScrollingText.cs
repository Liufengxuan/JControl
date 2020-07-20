using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace JControl
{

    [ToolboxItem(true)]
    public partial class JScrollingText : BaseControl
    {
        public JScrollingText()
        {
            InitializeComponent();
            //支持重绘和背景透明化
            SetStyle(ControlStyles.UserPaint | ControlStyles.SupportsTransparentBackColor, true);
            //调整大小
            SetStyle(ControlStyles.ResizeRedraw, true);
            //双缓存
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            //不在接收系统的Message
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);           
            BackColor = Color.Transparent;
            timer.Tick += Timer_Tick;
        }

     
        private Timer timer = new Timer();

        private Color _JMaskColor = Color.Yellow;
        private int _JOpacity = 60;
        private string _JText;
        private int _JOffsetLength=2;
        [Description("显示文本"), Category("J"), Browsable(true)]
        public string JText
        {
            get { return _JText; }
            set { _JText = value; Invalidate(); }
        }


        [Description("显示文本的字体"), Category("J"), Browsable(true)]
        public Font JFont
        {
            get
            {
                return JUseTheme ? ThemeFont : base.Font;
            }
            set { base.Font = value; Invalidate(); }
        }

        [Description("显示文本的颜色"), Category("J"), Browsable(true)]
        public Color JForeColor
        {
            get
            {
                return JUseTheme ? ThemeForeColor : base.ForeColor;
            }
            set { base.ForeColor = value; Invalidate(); }
        }

        [Description("文本滚动速度"), Category("J"), Browsable(true)]
        public int JScrollingSpeed
        {
            get
            {
                return timer.Interval;
            }
            set { timer.Interval = value; Invalidate(); }
        }

        [Description("文本滚动开关"), Category("J"), Browsable(true)]
        public bool JIsScrolling
        {
            get
            {
                return timer.Enabled;
            }
            set { timer.Enabled = value;
                if (!value)
                {
                    startPointF = new PointF(0, 0);
                }
                Invalidate();
            }
        }

        [Description("不透明度"), Category("J"), Browsable(true)]
        public int JOpacity
        {
            get
            {
                return _JOpacity;

            }
            set
            {
                if (value > 255)
                {
                    _JOpacity = 255;
                }
                else if (value < 0)
                {
                    _JOpacity = 0;
                }
                else
                {
                    _JOpacity = value;
                }

            }
        }

        [Description("每次位移长度"), Category("J"), Browsable(true)]
        public int JOffsetLength
        {
            get
            {
                return _JOffsetLength;

            }
            set
            {
                _JOffsetLength = value; Invalidate();

            }
        }

        [Description("蒙版背景的颜色"), Category("J"), Browsable(true)]
        public Color JMaskColor
        {
            get
            {
                return JUseTheme ? ThemeColor : _JMaskColor;

            }
            set { _JMaskColor = value; Invalidate(); }
        }

        private void DrawLabelMask(Graphics g)
        {
            GraphicsPath gPath = new GraphicsPath();
            Rectangle rectangle = this.ClientRectangle;
            gPath.AddRectangle(rectangle);
            SolidBrush sb = new SolidBrush(Color.FromArgb(JOpacity, JMaskColor));
            g.FillPath(sb, gPath);
            sb.Dispose();
            gPath.Dispose();
        }





        private PointF startPointF = new PointF(0, 0);
        private SizeF textSize = new SizeF(0, 0);

        private void Timer_Tick(object sender, EventArgs e)
        {
            float i = startPointF.X+ JOffsetLength;
            if (i > this.ClientRectangle.Width - 1)
            {
                i = 0;
            }
            PointF newPointf = new PointF(i, startPointF.Y);
            startPointF = newPointf;
            Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            DrawLabelMask(g);
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            SolidBrush solidBrush = new SolidBrush(JForeColor);
            textSize = GetFontSize(g, JFont, JText);
            RectangleF FDrawStringRectangle = new RectangleF(startPointF, textSize);
            g.DrawString(JText, JFont, solidBrush, FDrawStringRectangle, stringFormat);
         //   g.DrawRectangle(new Pen(Color.Red), FDrawStringRectangle.X, FDrawStringRectangle.Y, FDrawStringRectangle.Width,FDrawStringRectangle.Height);
            if (startPointF.X + textSize.Width > this.ClientRectangle.Width)
            {
                float width = textSize.Width - ((startPointF.X + textSize.Width) - this.ClientRectangle.Width);
                PointF p2 = new PointF(0- width,startPointF.Y);
                RectangleF FDrawStringRectangle2 = new RectangleF(p2, textSize);
              //  g.DrawRectangle(new Pen(Color.Blue), FDrawStringRectangle2.X, FDrawStringRectangle2.Y, FDrawStringRectangle2.Width, FDrawStringRectangle2.Height);
                g.DrawString(JText, JFont, solidBrush, FDrawStringRectangle2, stringFormat);
            }
            solidBrush.Dispose();
            stringFormat.Dispose();
      

            base.OnPaint(e);

        }



    }
}
