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
    public partial class JPipeSingleTest : Form
    {
        public JPipeSingleTest()
        {
            InitializeComponent();
        }

        private void jPipeSingle1_Load(object sender, EventArgs e)
        {

        }

        private void jButton1_Click(object sender, EventArgs e)
        {
            jPipeSingle1.JIsFlow = !jPipeSingle1.JIsFlow;
        }
    }
}
