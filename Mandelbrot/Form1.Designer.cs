namespace Mandelbrot {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.Output = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Output)).BeginInit();
            this.SuspendLayout();
            // 
            // Output
            // 
            this.Output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Output.Location = new System.Drawing.Point(0, 0);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(484, 461);
            this.Output.TabIndex = 0;
            this.Output.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.Output);
            this.Name = "Form1";
            this.Text = "Mandelbrot";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Output)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Output;
    }
}

