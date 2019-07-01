namespace WindowsFormsApp1
{
    partial class play
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
            this.label1 = new System.Windows.Forms.Label();
            this.Go = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "play russian roullete";
            // 
            // Go
            // 
            this.Go.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Go.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Go.Location = new System.Drawing.Point(573, 109);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(92, 48);
            this.Go.TabIndex = 1;
            this.Go.Text = "Go";
            this.Go.UseVisualStyleBackColor = false;
            this.Go.Click += new System.EventHandler(this.Go_Click);
            // 
            // play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.main;
            this.ClientSize = new System.Drawing.Size(800, 299);
            this.Controls.Add(this.Go);
            this.Controls.Add(this.label1);
            this.Name = "play";
            this.Text = "play";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Go;
    }
}

