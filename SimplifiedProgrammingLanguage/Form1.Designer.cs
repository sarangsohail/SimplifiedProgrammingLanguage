namespace SimplifiedProgrammingLanguage
{
    partial class Form1
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
            this.commandInputter = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.drawingCanvas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.drawingCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // commandInputter
            // 
            this.commandInputter.Location = new System.Drawing.Point(12, 437);
            this.commandInputter.Multiline = true;
            this.commandInputter.Name = "commandInputter";
            this.commandInputter.Size = new System.Drawing.Size(641, 61);
            this.commandInputter.TabIndex = 0;
            this.commandInputter.TextChanged += new System.EventHandler(this.commandInputter_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(679, 475);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // drawingCanvas
            // 
            this.drawingCanvas.Location = new System.Drawing.Point(12, 12);
            this.drawingCanvas.Name = "drawingCanvas";
            this.drawingCanvas.Size = new System.Drawing.Size(1308, 408);
            this.drawingCanvas.TabIndex = 2;
            this.drawingCanvas.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 510);
            this.Controls.Add(this.drawingCanvas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.commandInputter);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.drawingCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox commandInputter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox drawingCanvas;
    }
}

