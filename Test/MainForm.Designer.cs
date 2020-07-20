namespace Test
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.jButton1 = new JControl.JButton();
            this.jConveyorBelt1 = new JControl.JConveyorBelt();
            this.jLabel1 = new JControl.JLabel();
            this.jled1 = new JControl.JLED();
            this.jConveyorBelt2 = new JControl.JConveyorBelt();
            this.jConveyorBelt3 = new JControl.JConveyorBelt();
            this.jPipeSingle1 = new JControl.JPipeSingle();
            this.jScrollingText1 = new JControl.JScrollingText();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(77, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "允许移动控件";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // jButton1
            // 
            this.jButton1.BackColor = System.Drawing.Color.Empty;
            this.jButton1.Font = null;
            this.jButton1.JBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.jButton1.JFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.jButton1.JForeColor = System.Drawing.Color.Black;
            this.jButton1.JText = "13";
            this.jButton1.JUseTheme = false;
            this.jButton1.Location = new System.Drawing.Point(270, 219);
            this.jButton1.Name = "jButton1";
            this.jButton1.Size = new System.Drawing.Size(87, 32);
            this.jButton1.TabIndex = 4;
            // 
            // jConveyorBelt1
            // 
            this.jConveyorBelt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.jConveyorBelt1.JCircleRadius = 13;
            this.jConveyorBelt1.JColor = System.Drawing.Color.Gray;
            this.jConveyorBelt1.JEndPostion = JControl.Params.ConveyorBeltPostion.LowerRight;
            this.jConveyorBelt1.JOpacity = 132;
            this.jConveyorBelt1.JStartPostion = JControl.Params.ConveyorBeltPostion.LowerLeft;
            this.jConveyorBelt1.JUseTheme = false;
            this.jConveyorBelt1.Location = new System.Drawing.Point(337, 530);
            this.jConveyorBelt1.Name = "jConveyorBelt1";
            this.jConveyorBelt1.Size = new System.Drawing.Size(200, 77);
            this.jConveyorBelt1.TabIndex = 5;
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
            this.jLabel1.Location = new System.Drawing.Point(245, 307);
            this.jLabel1.Name = "jLabel1";
            this.jLabel1.Size = new System.Drawing.Size(112, 46);
            this.jLabel1.TabIndex = 6;
            // 
            // jled1
            // 
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
            this.jled1.Location = new System.Drawing.Point(99, 358);
            this.jled1.Margin = new System.Windows.Forms.Padding(2);
            this.jled1.Name = "jled1";
            this.jled1.Size = new System.Drawing.Size(53, 53);
            this.jled1.TabIndex = 7;
            // 
            // jConveyorBelt2
            // 
            this.jConveyorBelt2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.jConveyorBelt2.JCircleRadius = 13;
            this.jConveyorBelt2.JColor = System.Drawing.Color.Gray;
            this.jConveyorBelt2.JEndPostion = JControl.Params.ConveyorBeltPostion.LowerRight;
            this.jConveyorBelt2.JOpacity = 132;
            this.jConveyorBelt2.JStartPostion = JControl.Params.ConveyorBeltPostion.UpperLeft;
            this.jConveyorBelt2.JUseTheme = false;
            this.jConveyorBelt2.Location = new System.Drawing.Point(99, 450);
            this.jConveyorBelt2.Name = "jConveyorBelt2";
            this.jConveyorBelt2.Size = new System.Drawing.Size(115, 115);
            this.jConveyorBelt2.TabIndex = 5;
            // 
            // jConveyorBelt3
            // 
            this.jConveyorBelt3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.jConveyorBelt3.JCircleRadius = 13;
            this.jConveyorBelt3.JColor = System.Drawing.Color.Gray;
            this.jConveyorBelt3.JEndPostion = JControl.Params.ConveyorBeltPostion.UpperRight;
            this.jConveyorBelt3.JOpacity = 132;
            this.jConveyorBelt3.JStartPostion = JControl.Params.ConveyorBeltPostion.LowerLeft;
            this.jConveyorBelt3.JUseTheme = false;
            this.jConveyorBelt3.Location = new System.Drawing.Point(337, 409);
            this.jConveyorBelt3.Name = "jConveyorBelt3";
            this.jConveyorBelt3.Size = new System.Drawing.Size(115, 115);
            this.jConveyorBelt3.TabIndex = 5;
            // 
            // jPipeSingle1
            // 
            this.jPipeSingle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.jPipeSingle1.JFlowColor = System.Drawing.Color.Gray;
            this.jPipeSingle1.JIsFlow = true;
            this.jPipeSingle1.JOpacity = 132;
            this.jPipeSingle1.JPipeColor = System.Drawing.Color.LimeGreen;
            this.jPipeSingle1.JPipeWidth = 13;
            this.jPipeSingle1.JStartPostion = 13;
            this.jPipeSingle1.JUseTheme = false;
            this.jPipeSingle1.Location = new System.Drawing.Point(549, 209);
            this.jPipeSingle1.Name = "jPipeSingle1";
            this.jPipeSingle1.Size = new System.Drawing.Size(179, 235);
            this.jPipeSingle1.TabIndex = 8;
            // 
            // jScrollingText1
            // 
            this.jScrollingText1.BackColor = System.Drawing.Color.Transparent;
            this.jScrollingText1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.jScrollingText1.JFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.jScrollingText1.JForeColor = System.Drawing.SystemColors.ControlText;
            this.jScrollingText1.JIsScrolling = true;
            this.jScrollingText1.JMaskColor = System.Drawing.Color.Yellow;
            this.jScrollingText1.JOffsetLength = 2;
            this.jScrollingText1.JOpacity = 60;
            this.jScrollingText1.JScrollingSpeed = 100;
            this.jScrollingText1.JText = "d哈哈哈哈";
            this.jScrollingText1.JUseTheme = false;
            this.jScrollingText1.Location = new System.Drawing.Point(521, 99);
            this.jScrollingText1.Name = "jScrollingText1";
            this.jScrollingText1.Size = new System.Drawing.Size(296, 85);
            this.jScrollingText1.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 693);
            this.Controls.Add(this.jScrollingText1);
            this.Controls.Add(this.jPipeSingle1);
            this.Controls.Add(this.jled1);
            this.Controls.Add(this.jLabel1);
            this.Controls.Add(this.jConveyorBelt3);
            this.Controls.Add(this.jConveyorBelt2);
            this.Controls.Add(this.jConveyorBelt1);
            this.Controls.Add(this.jButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private JControl.JButton jButton1;
        private JControl.JConveyorBelt jConveyorBelt1;
        private JControl.JLabel jLabel1;
        private JControl.JLED jled1;
        private JControl.JConveyorBelt jConveyorBelt2;
        private JControl.JConveyorBelt jConveyorBelt3;
        private JControl.JPipeSingle jPipeSingle1;
        private JControl.JScrollingText jScrollingText1;
    }
}