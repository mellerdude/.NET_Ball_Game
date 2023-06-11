namespace HW2_2
{
    partial class GameForm
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.plusButton = new System.Windows.Forms.ToolStripButton();
            this.minusButton = new System.Windows.Forms.ToolStripButton();
            this.S_button = new System.Windows.Forms.ToolStripButton();
            this.A_button = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.end_button = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.DB_button = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plusButton,
            this.minusButton,
            this.S_button,
            this.A_button,
            this.toolStripSeparator1,
            this.end_button,
            this.toolStripSeparator3,
            this.DB_button,
            this.toolStripSeparator2,
            this.exitButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // plusButton
            // 
            this.plusButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.plusButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(23, 22);
            this.plusButton.Text = "+";
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.minusButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(23, 22);
            this.minusButton.Text = "-";
            this.minusButton.Click += new System.EventHandler(this.minusButton_Click);
            // 
            // S_button
            // 
            this.S_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.S_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.S_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.S_button.Name = "S_button";
            this.S_button.Size = new System.Drawing.Size(23, 22);
            this.S_button.Text = "S";
            this.S_button.Click += new System.EventHandler(this.S_Button_Click);
            // 
            // A_button
            // 
            this.A_button.BackColor = System.Drawing.Color.Black;
            this.A_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.A_button.ForeColor = System.Drawing.Color.Yellow;
            this.A_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.A_button.Name = "A_button";
            this.A_button.Size = new System.Drawing.Size(23, 22);
            this.A_button.Text = "A";
            this.A_button.Click += new System.EventHandler(this.A_button_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // end_button
            // 
            this.end_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.end_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.end_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.end_button.Name = "end_button";
            this.end_button.Size = new System.Drawing.Size(65, 22);
            this.end_button.Text = "End Game";
            this.end_button.Click += new System.EventHandler(this.end_button_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // DB_button
            // 
            this.DB_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DB_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DB_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DB_button.Name = "DB_button";
            this.DB_button.Size = new System.Drawing.Size(26, 22);
            this.DB_button.Text = "DB";
            this.DB_button.Click += new System.EventHandler(this.DB_button_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.exitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(23, 22);
            this.exitButton.Text = "E";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton plusButton;
        private System.Windows.Forms.ToolStripButton minusButton;
        private System.Windows.Forms.ToolStripButton S_button;
        private System.Windows.Forms.ToolStripButton A_button;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton end_button;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton DB_button;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton exitButton;
    }
}

