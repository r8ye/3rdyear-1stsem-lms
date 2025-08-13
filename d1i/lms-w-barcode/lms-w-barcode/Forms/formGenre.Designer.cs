namespace lms_w_barcode.Forms
{
    partial class formGenre
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
            this.button = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.CheckedState.Parent = this.button;
            this.button.CustomImages.Parent = this.button;
            this.button.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button.ForeColor = System.Drawing.Color.White;
            this.button.HoverState.Parent = this.button;
            this.button.Location = new System.Drawing.Point(584, 493);
            this.button.Margin = new System.Windows.Forms.Padding(2);
            this.button.Name = "button";
            this.button.ShadowDecoration.Parent = this.button;
            this.button.Size = new System.Drawing.Size(134, 38);
            this.button.TabIndex = 0;
            this.button.Text = "guna2Button1";
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // formGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(729, 542);
            this.Controls.Add(this.button);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formGenre";
            this.Text = "Genres";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button button;
    }
}