namespace Test
{
    partial class JLEDTest
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
            this.button1 = new System.Windows.Forms.Button();
            this.jled1 = new JControl.JLED();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(550, 362);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // jled1
            // 
            this.jled1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.jled1.BorderWidth = 2;
            this.jled1.Distance = 3;
            this.jled1.JState = false;
            this.jled1.JStateFBordeColor = System.Drawing.Color.LightGray;
            this.jled1.JStateFCenterColor = System.Drawing.Color.White;
            this.jled1.JStateFGridentColor = System.Drawing.Color.Gray;
            this.jled1.JStateTBordeColor = System.Drawing.Color.Gray;
            this.jled1.JStateTCenterColor = System.Drawing.Color.LightGray;
            this.jled1.JStateTGridentColor = System.Drawing.Color.Red;
            this.jled1.JUseTheme = false;
            this.jled1.Location = new System.Drawing.Point(814, 224);
            this.jled1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.jled1.Name = "jled1";
            this.jled1.Size = new System.Drawing.Size(106, 100);
            this.jled1.TabIndex = 2;
            // 
            // JLEDTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.jled1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "JLEDTest";
            this.Text = "JLEDTest";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private JControl.JLED jled1;
    }
}