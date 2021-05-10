
namespace LibraryUI
{
    partial class BookHistoryForm
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
            this.issuedBooksGrid = new System.Windows.Forms.DataGridView();
            this.returnedBooksGrid = new System.Windows.Forms.DataGridView();
            this.issuedBookLabel = new System.Windows.Forms.Label();
            this.returnedBooksLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.issuedBooksGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnedBooksGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // issuedBooksGrid
            // 
            this.issuedBooksGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.issuedBooksGrid.Location = new System.Drawing.Point(12, 49);
            this.issuedBooksGrid.Name = "issuedBooksGrid";
            this.issuedBooksGrid.RowHeadersWidth = 51;
            this.issuedBooksGrid.RowTemplate.Height = 24;
            this.issuedBooksGrid.Size = new System.Drawing.Size(1071, 303);
            this.issuedBooksGrid.TabIndex = 0;
            // 
            // returnedBooksGrid
            // 
            this.returnedBooksGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.returnedBooksGrid.Location = new System.Drawing.Point(12, 398);
            this.returnedBooksGrid.Name = "returnedBooksGrid";
            this.returnedBooksGrid.RowHeadersWidth = 51;
            this.returnedBooksGrid.RowTemplate.Height = 24;
            this.returnedBooksGrid.Size = new System.Drawing.Size(1071, 303);
            this.returnedBooksGrid.TabIndex = 1;
            // 
            // issuedBookLabel
            // 
            this.issuedBookLabel.AutoSize = true;
            this.issuedBookLabel.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issuedBookLabel.Location = new System.Drawing.Point(453, 9);
            this.issuedBookLabel.Name = "issuedBookLabel";
            this.issuedBookLabel.Size = new System.Drawing.Size(178, 37);
            this.issuedBookLabel.TabIndex = 2;
            this.issuedBookLabel.Text = "Issued Books";
            // 
            // returnedBooksLabel
            // 
            this.returnedBooksLabel.AutoSize = true;
            this.returnedBooksLabel.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnedBooksLabel.Location = new System.Drawing.Point(437, 358);
            this.returnedBooksLabel.Name = "returnedBooksLabel";
            this.returnedBooksLabel.Size = new System.Drawing.Size(210, 37);
            this.returnedBooksLabel.TabIndex = 3;
            this.returnedBooksLabel.Text = "Returned Books";
            // 
            // BookHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(1095, 712);
            this.Controls.Add(this.returnedBooksLabel);
            this.Controls.Add(this.issuedBookLabel);
            this.Controls.Add(this.returnedBooksGrid);
            this.Controls.Add(this.issuedBooksGrid);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BookHistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book History";
            ((System.ComponentModel.ISupportInitialize)(this.issuedBooksGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnedBooksGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView issuedBooksGrid;
        private System.Windows.Forms.DataGridView returnedBooksGrid;
        private System.Windows.Forms.Label issuedBookLabel;
        private System.Windows.Forms.Label returnedBooksLabel;
    }
}