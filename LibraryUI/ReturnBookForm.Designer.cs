
namespace LibraryUI
{
    partial class ReturnBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBookForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.searchIndexTextBox = new System.Windows.Forms.TextBox();
            this.lblIndexNumber = new System.Windows.Forms.Label();
            this.studentBooksListBox = new System.Windows.Forms.ListBox();
            this.studentsbookslbl = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.lblBookName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Controls.Add(this.clearButton);
            this.panel1.Controls.Add(this.searchIndexTextBox);
            this.panel1.Controls.Add(this.lblIndexNumber);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 417);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(81, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // searchButton
            // 
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchButton.Location = new System.Drawing.Point(178, 337);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(119, 50);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearButton.Location = new System.Drawing.Point(22, 337);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(119, 50);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // searchIndexTextBox
            // 
            this.searchIndexTextBox.Location = new System.Drawing.Point(22, 274);
            this.searchIndexTextBox.Name = "searchIndexTextBox";
            this.searchIndexTextBox.Size = new System.Drawing.Size(275, 34);
            this.searchIndexTextBox.TabIndex = 1;
            // 
            // lblIndexNumber
            // 
            this.lblIndexNumber.AutoSize = true;
            this.lblIndexNumber.Location = new System.Drawing.Point(76, 217);
            this.lblIndexNumber.Name = "lblIndexNumber";
            this.lblIndexNumber.Size = new System.Drawing.Size(221, 27);
            this.lblIndexNumber.TabIndex = 0;
            this.lblIndexNumber.Text = "Student Index number:";
            // 
            // studentBooksListBox
            // 
            this.studentBooksListBox.FormattingEnabled = true;
            this.studentBooksListBox.ItemHeight = 27;
            this.studentBooksListBox.Location = new System.Drawing.Point(345, 47);
            this.studentBooksListBox.Name = "studentBooksListBox";
            this.studentBooksListBox.Size = new System.Drawing.Size(327, 382);
            this.studentBooksListBox.TabIndex = 4;
            // 
            // studentsbookslbl
            // 
            this.studentsbookslbl.AutoSize = true;
            this.studentsbookslbl.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentsbookslbl.Location = new System.Drawing.Point(410, 12);
            this.studentsbookslbl.Name = "studentsbookslbl";
            this.studentsbookslbl.Size = new System.Drawing.Size(180, 32);
            this.studentsbookslbl.TabIndex = 5;
            this.studentsbookslbl.Text = "Student\'s Books";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(248, 559);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(342, 34);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(248, 435);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(342, 34);
            this.textBox1.TabIndex = 8;
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Location = new System.Drawing.Point(248, 648);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(119, 50);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // returnButton
            // 
            this.returnButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.returnButton.Location = new System.Drawing.Point(410, 648);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(119, 50);
            this.returnButton.TabIndex = 9;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Location = new System.Drawing.Point(97, 438);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(122, 27);
            this.lblBookName.TabIndex = 10;
            this.lblBookName.Text = "Book Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 507);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 27);
            this.label1.TabIndex = 11;
            this.label1.Text = "Issue Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 565);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 27);
            this.label2.TabIndex = 12;
            this.label2.Text = "Return Date:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(248, 504);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(342, 34);
            this.textBox2.TabIndex = 13;
            // 
            // ReturnBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(710, 723);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBookName);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.studentsbookslbl);
            this.Controls.Add(this.studentBooksListBox);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ReturnBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return Book";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox searchIndexTextBox;
        private System.Windows.Forms.Label lblIndexNumber;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox studentBooksListBox;
        private System.Windows.Forms.Label studentsbookslbl;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
    }
}