namespace LIBRARY_APP
{
    partial class Readingbook
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BookIdR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookNameR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorBookR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceBookR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryBookR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountBookR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteBookBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookIdR,
            this.BookNameR,
            this.AuthorBookR,
            this.PriceBookR,
            this.CategoryBookR,
            this.CountBookR});
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 428);
            this.dataGridView1.TabIndex = 0;
            // 
            // BookIdR
            // 
            this.BookIdR.HeaderText = "Id";
            this.BookIdR.Name = "BookIdR";
            this.BookIdR.Visible = false;
            // 
            // BookNameR
            // 
            this.BookNameR.HeaderText = "Name";
            this.BookNameR.Name = "BookNameR";
            // 
            // AuthorBookR
            // 
            this.AuthorBookR.HeaderText = "Author";
            this.AuthorBookR.Name = "AuthorBookR";
            // 
            // PriceBookR
            // 
            this.PriceBookR.HeaderText = "Price";
            this.PriceBookR.Name = "PriceBookR";
            // 
            // CategoryBookR
            // 
            this.CategoryBookR.HeaderText = "Category";
            this.CategoryBookR.Name = "CategoryBookR";
            // 
            // CountBookR
            // 
            this.CountBookR.HeaderText = "Count";
            this.CountBookR.Name = "CountBookR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(562, 13);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chose the book you want to delete";
            // 
            // DeleteBookBtn
            // 
            this.DeleteBookBtn.Location = new System.Drawing.Point(565, 41);
            this.DeleteBookBtn.Name = "DeleteBookBtn";
            this.DeleteBookBtn.Size = new System.Drawing.Size(169, 39);
            this.DeleteBookBtn.TabIndex = 2;
            this.DeleteBookBtn.Text = "Delete";
            this.DeleteBookBtn.UseVisualStyleBackColor = true;
            // 
            // Readingbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 453);
            this.Controls.Add(this.DeleteBookBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Readingbook";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Readingbook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookIdR;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookNameR;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorBookR;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceBookR;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryBookR;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountBookR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeleteBookBtn;
    }
}