namespace LIBRARY_APP
{
    partial class newbook
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
            this.label1 = new System.Windows.Forms.Label();
            this.BookNametxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Pricetxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Counttxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AuthorCmb = new System.Windows.Forms.ComboBox();
            this.Categorytxt = new System.Windows.Forms.ComboBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // BookNametxt
            // 
            this.BookNametxt.Location = new System.Drawing.Point(75, 12);
            this.BookNametxt.Name = "BookNametxt";
            this.BookNametxt.Size = new System.Drawing.Size(294, 20);
            this.BookNametxt.TabIndex = 1;
            this.BookNametxt.Validating += new System.ComponentModel.CancelEventHandler(this.BookNametxt_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Price";
            // 
            // Pricetxt
            // 
            this.Pricetxt.Location = new System.Drawing.Point(75, 162);
            this.Pricetxt.Name = "Pricetxt";
            this.Pricetxt.Size = new System.Drawing.Size(294, 20);
            this.Pricetxt.TabIndex = 1;
            this.Pricetxt.Validating += new System.ComponentModel.CancelEventHandler(this.Pricetxt_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(23, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Count";
            // 
            // Counttxt
            // 
            this.Counttxt.Location = new System.Drawing.Point(75, 323);
            this.Counttxt.Name = "Counttxt";
            this.Counttxt.Size = new System.Drawing.Size(294, 20);
            this.Counttxt.TabIndex = 1;
            this.Counttxt.Validating += new System.ComponentModel.CancelEventHandler(this.Counttxt_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Author";
            // 
            // AuthorCmb
            // 
            this.AuthorCmb.FormattingEnabled = true;
            this.AuthorCmb.Location = new System.Drawing.Point(75, 86);
            this.AuthorCmb.Name = "AuthorCmb";
            this.AuthorCmb.Size = new System.Drawing.Size(294, 21);
            this.AuthorCmb.TabIndex = 2;
            // 
            // Categorytxt
            // 
            this.Categorytxt.FormattingEnabled = true;
            this.Categorytxt.Location = new System.Drawing.Point(75, 247);
            this.Categorytxt.Name = "Categorytxt";
            this.Categorytxt.Size = new System.Drawing.Size(294, 21);
            this.Categorytxt.TabIndex = 3;
            this.Categorytxt.Validating += new System.ComponentModel.CancelEventHandler(this.Categorytxt_Validating);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(75, 382);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(139, 38);
            this.SaveBtn.TabIndex = 4;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(231, 382);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(138, 38);
            this.ResetBtn.TabIndex = 5;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // newbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(423, 450);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.Categorytxt);
            this.Controls.Add(this.AuthorCmb);
            this.Controls.Add(this.Counttxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Pricetxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BookNametxt);
            this.Controls.Add(this.label1);
            this.Name = "newbook";
            this.Text = "New book";
            this.Load += new System.EventHandler(this.newbook_Load);
            this.MouseHover += new System.EventHandler(this.newbook_MouseHover);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BookNametxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Pricetxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Counttxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox AuthorCmb;
        private System.Windows.Forms.ComboBox Categorytxt;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button ResetBtn;
    }
}