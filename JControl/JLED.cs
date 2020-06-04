using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.ComponentModel;
namespace JControl
{
    [ToolboxItem(true)]
    public partial class JLED: BaseControl
    {
        public JLED()
        {
            InitializeComponent();
            //支持重绘和背景透明化
            SetStyle(ControlStyles.UserPaint | ControlStyles.SupportsTransparentBackColor, true);
            //调整大小
            SetStyle(ControlStyles.ResizeRedraw,true);
            //双缓存
            SetStyle(ControlStyles.OptimizedDoubleBuffer,true);
            //不在接收系统的Message
            SetStyle(ControlStyles.AllPaintingInWmPaint,true);

        }
        private bool state = false;
        private Color StatebordeColor_F = Color.LightGray;
        private Color StatecenterColor_F = Color.White;
        private Color StategridentColor_F = Color.Gray;
        
        private Color StatebordeColor_T = Color.Gray;
        private Color StatecenterColor_T = Color.LightGray;
        private Color StategridentColor_T = Color.Red;
        
        private int borderwidth = 2;
        private int distance   = 3;

       [Description("设置LED状态"), Category("自定义")]
        public bool JState
        {
            get { return state; }
            set { state = value; Invalidate(); }
        }
        [Description("状态为OFF时中心颜色"), Category("自定义")]
        public Color JStateFCenterColor
        {
            get { return StatecenterColor_F; }
            set { StatecenterColor_F = value; Invalidate(); }
        }


        [Description("状态为OFF时渐变颜色"), Category("自定义")]
        public Color JStateFGridentColor
        {
            get {
               return JUseTheme?ThemeColor:StategridentColor_F;
            }
            set { StategridentColor_F = value; Invalidate(); }
        }


         [Description("状态为OFF时边框颜色"), Category("自定义")]
        public Color JStateFBordeColor
        {
            get { return StatebordeColor_F; }
            set { StatebordeColor_F = value; Invalidate(); }
        }


        [Description("状态为ON时中心颜色"), Category("自定义")]
        public Color JStateTCenterColor
        {
            get { return StatecenterColor_T; }
            set { StatecenterColor_T = value; Invalidate(); }
        }
        [Description("状态为ON时渐变颜色"), Category("自定义")]
        public Color JStateTGridentColor
        {
            get { return StategridentColor_T; }
            set { StategridentColor_T = value; Invalidate(); }
        }
        [Description("状态为ON时边框颜色"), Category("自定义")]
        public Color JStateTBordeColor
        {
            get { return StatebordeColor_T; }
            set { StatebordeColor_T = value; Invalidate(); }
        }
        /// <summary>
        /// 内外圆宽度
        /// </summary>
        public int BorderWidth
        {
            get { return borderwidth; }
            set { borderwidth = value; Invalidate(); }
        }
        

        /// <summary>
        /// 内外圆间距
        /// </summary>
        public int Distance
        {
            get { return distance; }
            set { distance = value; Invalidate(); }
        }


        /// <summary>   
        /// 重绘控件
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
          
         
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;

           
            Rectangle rectOut = new Rectangle(borderwidth,borderwidth,this.Width-2*borderwidth,this.Height-2*borderwidth);
            Pen pen =null ;
            if (!JState)
            {
                 pen = new Pen(StatebordeColor_F, borderwidth);
            }
            else
            {
            
                 pen = new Pen(StatebordeColor_T, borderwidth);
            }
            e.Graphics.DrawEllipse(pen , rectOut);
            Rectangle rectIn = new Rectangle(borderwidth+distance,borderwidth+distance,
                               this.Width-2*borderwidth-2*distance,this.Height-2*borderwidth-2*distance);

            e.Graphics.DrawEllipse(pen,rectIn);

            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(rectIn);
            if (rectIn.Height > 1 && rectIn.Width > 1)
            {
                PathGradientBrush pathBursh = new PathGradientBrush(path);

                if (!state)
                {
                    pathBursh.SurroundColors = new Color[] { JStateFGridentColor };
                    pathBursh.CenterColor = StatecenterColor_F;
                }
                else
                {
                    pathBursh.SurroundColors = new Color[] { StategridentColor_T };
                    pathBursh.CenterColor = StatecenterColor_T;
                }
                e.Graphics.FillPath(pathBursh, path);
                pathBursh.Dispose();
            }


            pen.Dispose();
            path.Dispose();
          
            base.OnPaint(e);
        }
        
    }
}
