namespace UtilityApp
{
    partial class Utility
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
            this.buttonCloseIE = new System.Windows.Forms.Button();
            this.buttonResetIIS = new System.Windows.Forms.Button();
            this.buttonDeleteTempFiles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCloseIE
            // 
            this.buttonCloseIE.Location = new System.Drawing.Point(12, 12);
            this.buttonCloseIE.Name = "buttonCloseIE";
            this.buttonCloseIE.Size = new System.Drawing.Size(173, 35);
            this.buttonCloseIE.TabIndex = 0;
            this.buttonCloseIE.Text = "Close IE";
            this.buttonCloseIE.UseVisualStyleBackColor = true;
            this.buttonCloseIE.Click += new System.EventHandler(this.buttonCloseIE_Click);
            // 
            // buttonResetIIS
            // 
            this.buttonResetIIS.Location = new System.Drawing.Point(12, 62);
            this.buttonResetIIS.Name = "buttonResetIIS";
            this.buttonResetIIS.Size = new System.Drawing.Size(173, 35);
            this.buttonResetIIS.TabIndex = 1;
            this.buttonResetIIS.Text = "Reset IIS";
            this.buttonResetIIS.UseVisualStyleBackColor = true;
            this.buttonResetIIS.Click += new System.EventHandler(this.buttonResetIIS_Click);
            // 
            // buttonDeleteTempFiles
            // 
            this.buttonDeleteTempFiles.Location = new System.Drawing.Point(12, 116);
            this.buttonDeleteTempFiles.Name = "buttonDeleteTempFiles";
            this.buttonDeleteTempFiles.Size = new System.Drawing.Size(173, 35);
            this.buttonDeleteTempFiles.TabIndex = 2;
            this.buttonDeleteTempFiles.Text = "Delete Temp Files";
            this.buttonDeleteTempFiles.UseVisualStyleBackColor = true;
            this.buttonDeleteTempFiles.Click += new System.EventHandler(this.buttonDeleteTempFiles_Click);
            // 
            // Utility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 356);
            this.Controls.Add(this.buttonDeleteTempFiles);
            this.Controls.Add(this.buttonResetIIS);
            this.Controls.Add(this.buttonCloseIE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(220, 390);
            this.MinimumSize = new System.Drawing.Size(220, 390);
            this.Name = "Utility";
            this.Text = "Utility";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCloseIE;
        private System.Windows.Forms.Button buttonResetIIS;
        private System.Windows.Forms.Button buttonDeleteTempFiles;
    }
}

