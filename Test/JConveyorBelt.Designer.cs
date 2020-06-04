namespace Test
{
    partial class JConveyorBelt
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
            this.jConveyorBelt1 = new JControl.JConveyorBelt();
            this.jConveyorBelt2 = new JControl.JConveyorBelt();
            this.jConveyorBelt3 = new JControl.JConveyorBelt();
            this.SuspendLayout();
            // 
            // jConveyorBelt1
            // 
            this.jConveyorBelt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.jConveyorBelt1.JCircleRadius = 30;
            this.jConveyorBelt1.JEndPostion = JControl.Params.ConveyorBeltPostion.LowerRight;
            this.jConveyorBelt1.JOpacity = 132;
            this.jConveyorBelt1.JStartPostion = JControl.Params.ConveyorBeltPostion.UpperLeft;
            this.jConveyorBelt1.JUseTheme = false;
            this.jConveyorBelt1.Location = new System.Drawing.Point(46, 42);
            this.jConveyorBelt1.Name = "jConveyorBelt1";
            this.jConveyorBelt1.Size = new System.Drawing.Size(154, 154);
            this.jConveyorBelt1.TabIndex = 0;
            // 
            // jConveyorBelt2
            // 
            this.jConveyorBelt2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.jConveyorBelt2.JCircleRadius = 30;
            this.jConveyorBelt2.JEndPostion = JControl.Params.ConveyorBeltPostion.LowerRight;
            this.jConveyorBelt2.JOpacity = 132;
            this.jConveyorBelt2.JStartPostion = JControl.Params.ConveyorBeltPostion.LowerLeft;
            this.jConveyorBelt2.JUseTheme = false;
            this.jConveyorBelt2.Location = new System.Drawing.Point(314, 86);
            this.jConveyorBelt2.Name = "jConveyorBelt2";
            this.jConveyorBelt2.Size = new System.Drawing.Size(172, 176);
            this.jConveyorBelt2.TabIndex = 1;
            // 
            // jConveyorBelt3
            // 
            this.jConveyorBelt3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.jConveyorBelt3.JCircleRadius = 30;
            this.jConveyorBelt3.JEndPostion = JControl.Params.ConveyorBeltPostion.UpperRight;
            this.jConveyorBelt3.JOpacity = 132;
            this.jConveyorBelt3.JStartPostion = JControl.Params.ConveyorBeltPostion.LowerLeft;
            this.jConveyorBelt3.JUseTheme = false;
            this.jConveyorBelt3.Location = new System.Drawing.Point(24, 303);
            this.jConveyorBelt3.Name = "jConveyorBelt3";
            this.jConveyorBelt3.Size = new System.Drawing.Size(176, 176);
            this.jConveyorBelt3.TabIndex = 2;
            // 
            // JConveyorBelt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 550);
            this.Controls.Add(this.jConveyorBelt3);
            this.Controls.Add(this.jConveyorBelt2);
            this.Controls.Add(this.jConveyorBelt1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "JConveyorBelt";
            this.Text = "JConveyorBelt";
            this.ResumeLayout(false);

        }

        #endregion

        private JControl.JConveyorBelt jConveyorBelt1;
        private JControl.JConveyorBelt jConveyorBelt2;
        private JControl.JConveyorBelt jConveyorBelt3;
    }
}