
namespace MegaDesk_Israelsen
{
    partial class AddQuote
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
            this.saveQuote = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saveQuote
            // 
            this.saveQuote.Location = new System.Drawing.Point(169, 323);
            this.saveQuote.Name = "saveQuote";
            this.saveQuote.Size = new System.Drawing.Size(195, 74);
            this.saveQuote.TabIndex = 0;
            this.saveQuote.Text = "Save Quote";
            this.saveQuote.UseVisualStyleBackColor = true;
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(428, 323);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(195, 74);
            this.close.TabIndex = 1;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.close);
            this.Controls.Add(this.saveQuote);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddQuote_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saveQuote;
        private System.Windows.Forms.Button close;
    }
}