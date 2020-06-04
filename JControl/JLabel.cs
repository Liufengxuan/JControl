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
    public partial class JLabel : BaseControl
    {
       
      
    
        public JLabel()
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



            _JText = base.Name;
            BackColor = Color.Transparent;
        }

     


        private void DrawLabelMask(Graphics g)
        {
            GraphicsPath gPath = new GraphicsPath();
            Rectangle  rectangle = this.ClientRectangle;
            gPath.AddRectangle(rectangle);
            SolidBrush sb = new SolidBrush(Color.FromArgb(JOpacity, JMaskColor));
            g.FillPath(sb, gPath);


        
            sb.Dispose();
            gPath.Dispose();

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            StringFormat stringFormat = new StringFormat();
            if (JTextCenter) stringFormat.Alignment = StringAlignment.Center;


            DrawLabelMask(g);
            SolidBrush solidBrush = new SolidBrush(JForeColor);
            RectangleF FDrawStringRectangle = this.ClientRectangle;
            g.DrawString(JText, JFont, solidBrush, FDrawStringRectangle, stringFormat);



            stringFormat.Dispose();
            solidBrush.Dispose();
            base.OnPaint(e);

        }


        #region 面板属性
        private string _JText;
        private Color _JMaskColor=Color.Yellow;
        private int _JOpacity = 60;
        private bool _JTextCenter = false;


        [Description("显示文本"), Category("J"), Browsable(true)]
        public string JText
        {
            get { return _JText; }
            set { _JText = value; Invalidate(); }
        }


        [Description("显示文本的字体"), Category("J"), Browsable(true)]
        public Font JFont
        {
            get {
                return JUseTheme ?  ThemeFont: base.Font;
            }
            set { base.Font = value; Invalidate(); }
        }

        [Description("显示文本的颜色"), Category("J"), Browsable(true)]
        public Color JForeColor
        {
            get {
                return JUseTheme ? ThemeForeColor : base.ForeColor;
            }
            set { base.ForeColor = value; Invalidate(); }
        }


        [Description("蒙版背景的颜色"), Category("J"), Browsable(true)]
        public Color JMaskColor
        {
            get {
                return JUseTheme ? ThemeColor : _JMaskColor;

            }
            set { _JMaskColor = value; Invalidate(); }
        }


        [Description("不透明度"), Category("J"), Browsable(true)]
        public int JOpacity
        {
            get
            {
                return _JOpacity;

            }
            set {
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

        [Description("文本是否居中"), Category("J"), Browsable(true)]
        public bool JTextCenter
        {
            get
            {
                return _JTextCenter;

            }
            set
            {
                _JTextCenter = value;

            }
        }



        #endregion



    }
}
