namespace Test
{
    partial class JButtonTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JButtonTest));
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.jButton1 = new JControl.JButton();
            this.jLabel1 = new JControl.JLabel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(431, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(124, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 182);
            this.panel1.TabIndex = 3;
            // 
            // jButton1
            // 
            this.jButton1.BackColor = System.Drawing.Color.Empty;
            this.jButton1.Font = null;
            this.jButton1.JBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.jButton1.JFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.jButton1.JForeColor = System.Drawing.Color.Black;
            this.jButton1.JText = null;
            this.jButton1.JUseTheme = false;
            this.jButton1.Location = new System.Drawing.Point(611, 161);
            this.jButton1.Name = "jButton1";
            this.jButton1.Size = new System.Drawing.Size(87, 32);
            this.jButton1.TabIndex = 6;
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
            this.jLabel1.Location = new System.Drawing.Point(611, 344);
            this.jLabel1.Name = "jLabel1";
            this.jLabel1.Size = new System.Drawing.Size(112, 46);
            this.jLabel1.TabIndex = 5;
            // 
            // JButtonTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.jButton1);
            this.Controls.Add(this.jLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "JButtonTest";
            this.Text = "JButtonTest";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private JControl.JLabel jLabel1;
        private JControl.JButton jButton1;
    }
}