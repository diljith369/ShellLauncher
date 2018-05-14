namespace ShellLauncher
{
    partial class WinUpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinUpdateForm));
            this.UpdateCheckbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UpdateCheckbutton
            // 
            this.UpdateCheckbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateCheckbutton.Location = new System.Drawing.Point(147, 95);
            this.UpdateCheckbutton.Name = "UpdateCheckbutton";
            this.UpdateCheckbutton.Size = new System.Drawing.Size(189, 45);
            this.UpdateCheckbutton.TabIndex = 0;
            this.UpdateCheckbutton.Text = "Check Missing Updates";
            this.UpdateCheckbutton.UseVisualStyleBackColor = true;
            this.UpdateCheckbutton.Click += new System.EventHandler(this.UdpateCheck_Click);
            // 
            // WinUpdateForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(502, 268);
            this.Controls.Add(this.UpdateCheckbutton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(520, 315);
            this.MinimumSize = new System.Drawing.Size(520, 315);
            this.Name = "WinUpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Check missing updates...";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UpdateCheckbutton;
    }
}