using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JControl
{
    [ToolboxItem(false)]
    public partial class BaseControl : UserControl
    {
        private bool _JUseTheme = false;

        public string JName = "";
        [Description("是否使用主题样式"), Category("J"), Browsable(true)]
        public bool JUseTheme
        {
            get { return _JUseTheme; }
            set { _JUseTheme = value; Invalidate(); }
        }




        #region 公共方法
        internal Dictionary<string, object> keyValuePairs = new Dictionary<string, object>();


        /// <summary>
        /// 根据键获取Tag
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public object GetObjectTag(string key)
        {
            if (!JKeys.Contains(key))
            {
                return null;
            }
            if (!keyValuePairs.ContainsKey(key))
            {
                keyValuePairs.Add(key, null);
                return null;
            }
            else
            {
                return keyValuePairs[key];
            }
        }
        /// <summary>
        /// 根据键获取Tag
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string GetStringTag(string key)
        {
            if (!JKeys.Contains(key))
            {
                return "";
            }
            if (!keyValuePairs.ContainsKey(key))
            {
                keyValuePairs.Add(key, "");
                return "";
            }
            else
            {
                object a = keyValuePairs[key];
                if (a == null) return "";
                return (string)a;
            }
        }


        /// <summary>
        /// 设置一个键值结构的Tag
        /// </summary>
        /// <param name="key"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public bool SetTag(string key, object val)
        {
            if (!JKeys.Contains(key))
            {
                return false;
            }
            if (keyValuePairs.ContainsKey(key))
            {
                keyValuePairs[key] = val;
                return true;

            }
            else
            {
                keyValuePairs.Add(key, val);
                return true;
            }
        }

        #endregion



        #region 全局属性
        //全局键值对
        private static List<string> JKeys = new List<string>();
        public static void AddJKey(string keyName)
        {
            if (JKeys.Contains(keyName)) return;
            JKeys.Add(keyName);
        }



     

         




        //主题
        private static Color _ThemeColor = UserControl.DefaultBackColor;
        private static Font _ThemeFont = UserControl.DefaultFont;
        private static Color _ThemeForeColor = UserControl.DefaultForeColor;

        public static Color ThemeColor
        {
           get {
                return _ThemeColor;
            }
            private set {
                _ThemeColor = value;
            }
        }
        public static Font ThemeFont
        {
            get
            {
                return _ThemeFont;
            }
            private set
            {
                _ThemeFont = value;
            }
        }
        public static Color ThemeForeColor
        {
            get
            {
                return _ThemeForeColor;
            }
            private set
            {
                _ThemeForeColor = value;
            }
        }
        #endregion

        public BaseControl()
        {
            InitializeComponent();
        }
    }
}
