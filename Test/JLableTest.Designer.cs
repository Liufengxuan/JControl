namespace Test
{
    partial class JLableTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JLableTest));
            this.panel1 = new System.Windows.Forms.Panel();
            this.jLabel1 = new JControl.JLabel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(210, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 182);
            this.panel1.TabIndex = 0;
            // 
            // jLabel1
            // 
            this.jLabel1.BackColor = System.Drawing.Color.Transparent;
            this.jLabel1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.jLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.jLabel1.JFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.jLabel1.JForeColor = System.Drawing.SystemColors.ControlText;
            this.jLabel1.JMaskColor = System.Drawing.Color.Yellow;
            this.jLabel1.JOpacity = 60;
            this.jLabel1.JText = "JLabel";
            this.jLabel1.JTextCenter = false;
            this.jLabel1.JUseTheme = false;
            this.jLabel1.Location = new System.Drawing.Point(570, 143);
            this.jLabel1.Name = "jLabel1";
            this.jLabel1.Size = new System.Drawing.Size(112, 46);
            this.jLabel1.TabIndex = 1;
            // 
            // JLableTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(768, 458);
            this.Controls.Add(this.jLabel1);
            this.Controls.Add(this.panel1);
            this.Name = "JLableTest";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.JLableTest_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private JControl.JLabel jLabel1;
    }
}