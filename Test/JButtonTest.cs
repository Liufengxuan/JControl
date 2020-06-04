using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test
{
    public partial class JButtonTest : Form
    {
        public JButtonTest()
        {
            InitializeComponent();
            JControl.BaseControl.AddJKey("name");
        }

        private void jButton1_Click(object sender, EventArgs e)
        {
            jButton1.SetTag("name", "123");
            MessageBox.Show(jButton1.GetObjectTag("name").ToString());
        }
    }
}
