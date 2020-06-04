using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using JControl.Helper;

namespace JControl
{

    [ToolboxItem(true), DefaultEvent("Click")]
    public partial class JButton : BaseControl
    {
        public JButton()
        {
            //  InitializeComponent();
            ////支持重绘和背景透明化
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.Selectable, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.UserPaint, true);

            this.Size = new Size(87, 32);
            base.BackColor = Color.Transparent;

        }

        private Color _BackColor = Color.LightGray;
        private Color _ForeColor = Color.Black;
        private string _JText;


        [Description("边框设置"), Category("J"), Browsable(false)]
        public new BorderStyle BorderStyle
        {
            get;set;
        }
        [Description(""), Category("J"), Browsable(false)]
        public new Color BackColor
        {
            get;set;
        }
        [Description(""), Category("J"), Browsable(false)]
        public new Font Font
        {
            get; set;
        }

        [Description("背景颜色"), Category("J"), Browsable(true)]
        public  Color JBackColor
        {
            get
            {
                if (JUseTheme)
                {
                    return Color.FromArgb(255,ThemeColor);
                }
                else
                {
                    return Color.FromArgb(255, _BackColor);
                }
            }
            set {
                _BackColor = value;
                this.Invalidate();
            }
        }

        [Description("字体颜色"), Category("J"), Browsable(true)]
        public Color JForeColor
        {
            get
            {
                if (JUseTheme)
                {
                    return ThemeForeColor;
                }
                else
                {
                    return _ForeColor;
                }
            }
            set
            {
                _ForeColor = value;
                this.Invalidate();
            }
        }

        [Description("字体"), Category("J"), Browsable(true)]
        public Font JFont
        {
            get
            {
                if (JUseTheme)
                {
                    return ThemeFont;
                }
                else
                {
                    return base.Font;
                }
            }
            set
            {
                base.Font = value;
                this.Invalidate();
            }
        }

        [Description("显示文本"), Category("J"), Browsable(true)]
        public string JText
        {
            get
            {
                return _JText;
            }
            set
            {
                _JText = value;
                this.Invalidate();
            }
        }
     
        protected override void OnPaint(PaintEventArgs e)
        {
           

           
        

            int radius = 20;
            if (this.Width < 8 || this.Height < 8) return;
            if (this.Width < 30 || this.Height < 30) radius = 1;
            e.Graphics.Clear(Parent.BackColor);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;


            int width = this.Width - 2;
            int height = this.Height - 1;
            int x = this.ClientRectangle.X;
            int y = this.ClientRectangle.Y;

            Color upperColor = this.JBackColor;
            Color nearClor = this.JBackColor;
            Color borderColor = this.JBackColor;
            int borderWidth = 0;

            switch (mouseActionType)
            {
                case MouseActionType.None:
                    nearClor = ColorHelper.GetNearColor(this.JBackColor, 0.8f);
                    borderColor = ColorHelper.GetNearColor(this.JBackColor, -0.5f);
                    break;
                case MouseActionType.Hover:
                    nearClor = ColorHelper.GetNearColor(this.JBackColor, 1.2f);
                    borderColor = ColorHelper.GetNearColor(this.JBackColor, -0.8f);
                    break;
                case MouseActionType.Click:
                    borderWidth = 1;
                    upperColor = ColorHelper.GetNearColor(this.JBackColor, 0.5f);
                    nearClor = this.JBackColor;

                    borderColor = ColorHelper.GetNearColor(this.JBackColor, -1.2f);
                    break;
                default:
                    break;
            }






            // Draw(e.ClipRectangle, e.Graphics, 16);
            GraphicsPath gp = new GraphicsPath();
            Pen shadowPen = new Pen(borderColor, borderWidth);
            LinearGradientBrush myLinearGradientBrush = new LinearGradientBrush(
                 ClientRectangle,
                upperColor,
                 nearClor,
                 LinearGradientMode.Vertical);


            gp.AddArc(x + 1, y + 1, radius, radius, 180, 90);//左上角
            gp.AddArc(width - radius - 1, y + 1, radius, radius, 270, 90);//右上角
            gp.AddArc(width - radius - 1, height - (radius + 1), radius, radius, 0, 90);//右下角
            gp.AddArc(x + 1, height - (radius + 1), radius, radius, 90, 90);
            gp.CloseAllFigures();
            e.Graphics.DrawPath(shadowPen, gp);
            e.Graphics.FillPath(myLinearGradientBrush, gp);


            RectangleF StringRectangle = this.ClientRectangle;
            int fontHeight = (int)e.Graphics.MeasureString(JText, JFont, 1000, new StringFormat(StringFormat.GenericTypographic)).Height;
            StringRectangle.Height = fontHeight;
            StringRectangle.Y = StringRectangle.Y + ((this.ClientRectangle.Height - fontHeight) / 2);



            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            SolidBrush solidBrush = new SolidBrush(JForeColor);
            e.Graphics.DrawString(JText, JFont, solidBrush, StringRectangle, stringFormat);







            gp.Dispose();
            shadowPen.Dispose();
            solidBrush.Dispose();
            stringFormat.Dispose();
            myLinearGradientBrush.Dispose();

            base.OnPaint(e);
        }


        #region 鼠标事件
        private enum MouseActionType
        {
            None,
            Hover,
            Click
        }
        private MouseActionType mouseActionType;
        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            if (mevent.Button == MouseButtons.Left)
            {
                this.mouseActionType = MouseActionType.Click;
                this.Invalidate();
            }
            base.OnMouseDown(mevent);
        }
        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            this.mouseActionType = MouseActionType.Hover;
            this.Invalidate();
            base.OnMouseUp(mevent);
        }
        protected override void OnMouseHover(EventArgs e)
        {
            this.mouseActionType = MouseActionType.Hover;
            this.Invalidate();
            base.OnMouseHover(e);
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            this.mouseActionType = MouseActionType.Hover;
            this.Invalidate();
            base.OnMouseEnter(e);
        }
        protected override void OnMouseLeave(EventArgs e)//鼠标离开事件
        {
            this.mouseActionType = MouseActionType.None;
            this.Invalidate();
            base.OnMouseLeave(e);
        }
        #endregion
    }
}
