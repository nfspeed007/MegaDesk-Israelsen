
namespace MegaDesk_Israelsen
{
    partial class MainMenu
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
            this.addNewQuote = new System.Windows.Forms.Button();
            this.viewQuotes = new System.Windows.Forms.Button();
            this.searchQuotes = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.mainMenuImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainMenuImage)).BeginInit();
            this.SuspendLayout();
            // 
            // addNewQuote
            // 
            this.addNewQuote.Location = new System.Drawing.Point(59, 36);
            this.addNewQuote.Name = "addNewQuote";
            this.addNewQuote.Size = new System.Drawing.Size(292, 80);
            this.addNewQuote.TabIndex = 0;
            this.addNewQuote.Text = "Add New Quote";
            this.addNewQuote.UseVisualStyleBackColor = true;
            this.addNewQuote.Click += new System.EventHandler(this.addNewQuote_Click);
            // 
            // viewQuotes
            // 
            this.viewQuotes.Location = new System.Drawing.Point(59, 136);
            this.viewQuotes.Name = "viewQuotes";
            this.viewQuotes.Size = new System.Drawing.Size(292, 80);
            this.viewQuotes.TabIndex = 1;
            this.viewQuotes.Text = "View Quotes";
            this.viewQuotes.UseVisualStyleBackColor = true;
            this.viewQuotes.Click += new System.EventHandler(this.viewQuotes_Click);
            // 
            // searchQuotes
            // 
            this.searchQuotes.Location = new System.Drawing.Point(59, 237);
            this.searchQuotes.Name = "searchQuotes";
            this.searchQuotes.Size = new System.Drawing.Size(292, 80);
            this.searchQuotes.TabIndex = 2;
            this.searchQuotes.Text = "Search Quotes";
            this.searchQuotes.UseVisualStyleBackColor = true;
            this.searchQuotes.Click += new System.EventHandler(this.searchQuotes_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(59, 341);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(292, 80);
            this.exit.TabIndex = 3;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // mainMenuImage
            // 
            this.mainMenuImage.Image = global::MegaDesk_Israelsen.Properties.Resources.clipart_desk_club_penguin_7_transparent;
            this.mainMenuImage.Location = new System.Drawing.Point(419, 74);
            this.mainMenuImage.Name = "mainMenuImage";
            this.mainMenuImage.Size = new System.Drawing.Size(298, 298);
            this.mainMenuImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.mainMenuImage.TabIndex = 4;
            this.mainMenuImage.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainMenuImage);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.searchQuotes);
            this.Controls.Add(this.viewQuotes);
            this.Controls.Add(this.addNewQuote);
            this.Name = "MainMenu";
            this.Text = "MegaDesk";
            ((System.ComponentModel.ISupportInitialize)(this.mainMenuImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addNewQuote;
        private System.Windows.Forms.Button viewQuotes;
        private System.Windows.Forms.Button searchQuotes;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.PictureBox mainMenuImage;
    }
}

