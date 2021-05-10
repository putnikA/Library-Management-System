
namespace LibraryUI
{
    partial class ViewBooksForm
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
            this.lblBookName = new System.Windows.Forms.Label();
            this.searchBookTextBox = new System.Windows.Forms.TextBox();
            this.bookDetailsDataGrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.purchaseDatepicker = new System.Windows.Forms.DateTimePicker();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.publisherTextBox = new System.Windows.Forms.TextBox();
            this.authorNameTextBox = new System.Windows.Forms.TextBox();
            this.bookNameTextBox = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPurchaseDate = new System.Windows.Forms.Label();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lblAuthorName = new System.Windows.Forms.Label();
            this.bookNamelbl = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bookDetailsDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookName.Location = new System.Drawing.Point(378, 24);
            this.lblBookName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(122, 27);
            this.lblBookName.TabIndex = 0;
            this.lblBookName.Text = "Book Name:";
            // 
            // searchBookTextBox
            // 
            this.searchBookTextBox.Location = new System.Drawing.Point(525, 21);
            this.searchBookTextBox.Name = "searchBookTextBox";
            this.searchBookTextBox.Size = new System.Drawing.Size(251, 34);
            this.searchBookTextBox.TabIndex = 1;
            this.searchBookTextBox.Text = "Search...";
            // 
            // bookDetailsDataGrid
            // 
            this.bookDetailsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookDetailsDataGrid.Location = new System.Drawing.Point(12, 61);
            this.bookDetailsDataGrid.Name = "bookDetailsDataGrid";
            this.bookDetailsDataGrid.RowHeadersWidth = 51;
            this.bookDetailsDataGrid.RowTemplate.Height = 24;
            this.bookDetailsDataGrid.Size = new System.Drawing.Size(1176, 412);
            this.bookDetailsDataGrid.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Controls.Add(this.updateButton);
            this.panel1.Controls.Add(this.deleteButton);
            this.panel1.Controls.Add(this.purchaseDatepicker);
            this.panel1.Controls.Add(this.quantityTextBox);
            this.panel1.Controls.Add(this.priceTextBox);
            this.panel1.Controls.Add(this.publisherTextBox);
            this.panel1.Controls.Add(this.authorNameTextBox);
            this.panel1.Controls.Add(this.bookNameTextBox);
            this.panel1.Controls.Add(this.lblQuantity);
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Controls.Add(this.lblPurchaseDate);
            this.panel1.Controls.Add(this.lblPublisher);
            this.panel1.Controls.Add(this.lblAuthorName);
            this.panel1.Controls.Add(this.bookNamelbl);
            this.panel1.Location = new System.Drawing.Point(12, 495);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1176, 336);
            this.panel1.TabIndex = 3;
            // 
            // cancelButton
            // 
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelButton.Location = new System.Drawing.Point(667, 262);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(118, 43);
            this.cancelButton.TabIndex = 27;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateButton.Location = new System.Drawing.Point(961, 262);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(118, 43);
            this.updateButton.TabIndex = 26;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteButton.Location = new System.Drawing.Point(818, 262);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(118, 43);
            this.deleteButton.TabIndex = 25;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // purchaseDatepicker
            // 
            this.purchaseDatepicker.Location = new System.Drawing.Point(818, 32);
            this.purchaseDatepicker.Name = "purchaseDatepicker";
            this.purchaseDatepicker.Size = new System.Drawing.Size(261, 34);
            this.purchaseDatepicker.TabIndex = 24;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(818, 162);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(261, 34);
            this.quantityTextBox.TabIndex = 23;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(818, 98);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(261, 34);
            this.priceTextBox.TabIndex = 22;
            // 
            // publisherTextBox
            // 
            this.publisherTextBox.Location = new System.Drawing.Point(217, 156);
            this.publisherTextBox.Name = "publisherTextBox";
            this.publisherTextBox.Size = new System.Drawing.Size(261, 34);
            this.publisherTextBox.TabIndex = 21;
            // 
            // authorNameTextBox
            // 
            this.authorNameTextBox.Location = new System.Drawing.Point(217, 92);
            this.authorNameTextBox.Name = "authorNameTextBox";
            this.authorNameTextBox.Size = new System.Drawing.Size(261, 34);
            this.authorNameTextBox.TabIndex = 20;
            // 
            // bookNameTextBox
            // 
            this.bookNameTextBox.Location = new System.Drawing.Point(217, 35);
            this.bookNameTextBox.Name = "bookNameTextBox";
            this.bookNameTextBox.Size = new System.Drawing.Size(261, 34);
            this.bookNameTextBox.TabIndex = 19;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(631, 165);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(97, 27);
            this.lblQuantity.TabIndex = 18;
            this.lblQuantity.Text = "Quantity:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(631, 101);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(62, 27);
            this.lblPrice.TabIndex = 17;
            this.lblPrice.Text = "Price:";
            // 
            // lblPurchaseDate
            // 
            this.lblPurchaseDate.AutoSize = true;
            this.lblPurchaseDate.Location = new System.Drawing.Point(631, 38);
            this.lblPurchaseDate.Name = "lblPurchaseDate";
            this.lblPurchaseDate.Size = new System.Drawing.Size(143, 27);
            this.lblPurchaseDate.TabIndex = 16;
            this.lblPurchaseDate.Text = "Purchase date:";
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Location = new System.Drawing.Point(30, 159);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(104, 27);
            this.lblPublisher.TabIndex = 15;
            this.lblPublisher.Text = "Publisher:";
            // 
            // lblAuthorName
            // 
            this.lblAuthorName.AutoSize = true;
            this.lblAuthorName.Location = new System.Drawing.Point(30, 95);
            this.lblAuthorName.Name = "lblAuthorName";
            this.lblAuthorName.Size = new System.Drawing.Size(137, 27);
            this.lblAuthorName.TabIndex = 14;
            this.lblAuthorName.Text = "Author name:";
            // 
            // bookNamelbl
            // 
            this.bookNamelbl.AutoSize = true;
            this.bookNamelbl.Location = new System.Drawing.Point(30, 38);
            this.bookNamelbl.Name = "bookNamelbl";
            this.bookNamelbl.Size = new System.Drawing.Size(117, 27);
            this.bookNamelbl.TabIndex = 13;
            this.bookNamelbl.Text = "Book name:";
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Silver;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearButton.Location = new System.Drawing.Point(808, 21);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(118, 34);
            this.clearButton.TabIndex = 28;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            // 
            // ViewBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(1200, 353);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bookDetailsDataGrid);
            this.Controls.Add(this.searchBookTextBox);
            this.Controls.Add(this.lblBookName);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewBooksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Books";
            ((System.ComponentModel.ISupportInitialize)(this.bookDetailsDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.TextBox searchBookTextBox;
        private System.Windows.Forms.DataGridView bookDetailsDataGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker purchaseDatepicker;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox publisherTextBox;
        private System.Windows.Forms.TextBox authorNameTextBox;
        private System.Windows.Forms.TextBox bookNameTextBox;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblPurchaseDate;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Label lblAuthorName;
        private System.Windows.Forms.Label bookNamelbl;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button clearButton;
    }
}