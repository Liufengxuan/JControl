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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            JControl.BaseControl.JAllowDragMovement = !JControl.BaseControl.JAllowDragMovement;
            label1.Text = JControl.BaseControl.JAllowDragMovement.ToString();
        }

      
    }
}
