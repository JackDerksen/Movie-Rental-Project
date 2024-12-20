﻿namespace MovieRentalProject
{
    partial class EditCustomer
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
            FinishBtn = new Button();
            CancelBtn = new Button();
            FirstNmLbl = new Label();
            LastNmLbl = new Label();
            FirstNmTxtBox = new TextBox();
            LastNmTxtBox = new TextBox();
            EmailLbl = new Label();
            AddressLbl = new Label();
            EmailTxtBox = new TextBox();
            AddressTxtBox = new TextBox();
            CityLbl = new Label();
            CityTxtBox = new TextBox();
            ProvinceTxtBox = new TextBox();
            ProvinceLbl = new Label();
            CreditCardLbl = new Label();
            CreditCardTxtBox = new TextBox();
            SearchText = new Label();
            CustEditPostalCode = new TextBox();
            label1 = new Label();
            label2 = new Label();
            customerRatingBox = new TextBox();
            SuspendLayout();
            // 
            // FinishBtn
            // 
            FinishBtn.Location = new Point(668, 388);
            FinishBtn.Name = "FinishBtn";
            FinishBtn.Size = new Size(120, 50);
            FinishBtn.TabIndex = 0;
            FinishBtn.Text = "SAVE";
            FinishBtn.UseVisualStyleBackColor = true;
            FinishBtn.Click += FinishBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.Location = new Point(12, 388);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(120, 50);
            CancelBtn.TabIndex = 1;
            CancelBtn.Text = "BACK";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // FirstNmLbl
            // 
            FirstNmLbl.AutoSize = true;
            FirstNmLbl.Location = new Point(12, 72);
            FirstNmLbl.Name = "FirstNmLbl";
            FirstNmLbl.Size = new Size(64, 15);
            FirstNmLbl.TabIndex = 2;
            FirstNmLbl.Text = "First Name";
            // 
            // LastNmLbl
            // 
            LastNmLbl.AutoSize = true;
            LastNmLbl.Location = new Point(246, 72);
            LastNmLbl.Name = "LastNmLbl";
            LastNmLbl.Size = new Size(63, 15);
            LastNmLbl.TabIndex = 3;
            LastNmLbl.Text = "Last Name";
            // 
            // FirstNmTxtBox
            // 
            FirstNmTxtBox.Location = new Point(12, 90);
            FirstNmTxtBox.Name = "FirstNmTxtBox";
            FirstNmTxtBox.Size = new Size(212, 23);
            FirstNmTxtBox.TabIndex = 4;
            // 
            // LastNmTxtBox
            // 
            LastNmTxtBox.Location = new Point(246, 90);
            LastNmTxtBox.Name = "LastNmTxtBox";
            LastNmTxtBox.Size = new Size(212, 23);
            LastNmTxtBox.TabIndex = 5;
            // 
            // EmailLbl
            // 
            EmailLbl.AutoSize = true;
            EmailLbl.Location = new Point(12, 122);
            EmailLbl.Name = "EmailLbl";
            EmailLbl.Size = new Size(36, 15);
            EmailLbl.TabIndex = 6;
            EmailLbl.Text = "Email";
            // 
            // AddressLbl
            // 
            AddressLbl.AutoSize = true;
            AddressLbl.Location = new Point(12, 165);
            AddressLbl.Name = "AddressLbl";
            AddressLbl.Size = new Size(49, 15);
            AddressLbl.TabIndex = 7;
            AddressLbl.Text = "Address";
            // 
            // EmailTxtBox
            // 
            EmailTxtBox.Location = new Point(12, 140);
            EmailTxtBox.Name = "EmailTxtBox";
            EmailTxtBox.Size = new Size(212, 23);
            EmailTxtBox.TabIndex = 8;
            // 
            // AddressTxtBox
            // 
            AddressTxtBox.Location = new Point(12, 183);
            AddressTxtBox.Name = "AddressTxtBox";
            AddressTxtBox.Size = new Size(363, 23);
            AddressTxtBox.TabIndex = 9;
            // 
            // CityLbl
            // 
            CityLbl.AutoSize = true;
            CityLbl.Location = new Point(12, 213);
            CityLbl.Name = "CityLbl";
            CityLbl.Size = new Size(28, 15);
            CityLbl.TabIndex = 10;
            CityLbl.Text = "City";
            // 
            // CityTxtBox
            // 
            CityTxtBox.Location = new Point(12, 231);
            CityTxtBox.Name = "CityTxtBox";
            CityTxtBox.Size = new Size(212, 23);
            CityTxtBox.TabIndex = 11;
            // 
            // ProvinceTxtBox
            // 
            ProvinceTxtBox.Location = new Point(246, 231);
            ProvinceTxtBox.Name = "ProvinceTxtBox";
            ProvinceTxtBox.Size = new Size(212, 23);
            ProvinceTxtBox.TabIndex = 12;
            // 
            // ProvinceLbl
            // 
            ProvinceLbl.AutoSize = true;
            ProvinceLbl.Location = new Point(246, 213);
            ProvinceLbl.Name = "ProvinceLbl";
            ProvinceLbl.Size = new Size(53, 15);
            ProvinceLbl.TabIndex = 13;
            ProvinceLbl.Text = "Province";
            // 
            // CreditCardLbl
            // 
            CreditCardLbl.AutoSize = true;
            CreditCardLbl.Location = new Point(246, 122);
            CreditCardLbl.Name = "CreditCardLbl";
            CreditCardLbl.Size = new Size(67, 15);
            CreditCardLbl.TabIndex = 14;
            CreditCardLbl.Text = "Credit Card";
            // 
            // CreditCardTxtBox
            // 
            CreditCardTxtBox.Location = new Point(246, 140);
            CreditCardTxtBox.Name = "CreditCardTxtBox";
            CreditCardTxtBox.Size = new Size(212, 23);
            CreditCardTxtBox.TabIndex = 15;
            // 
            // SearchText
            // 
            SearchText.AutoSize = true;
            SearchText.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            SearchText.ForeColor = Color.Black;
            SearchText.Location = new Point(12, 9);
            SearchText.Name = "SearchText";
            SearchText.Size = new Size(145, 28);
            SearchText.TabIndex = 16;
            SearchText.Text = "Edit Customer";
            // 
            // CustEditPostalCode
            // 
            CustEditPostalCode.Location = new Point(12, 279);
            CustEditPostalCode.Name = "CustEditPostalCode";
            CustEditPostalCode.Size = new Size(212, 23);
            CustEditPostalCode.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 261);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 18;
            label1.Text = "Postal Code";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(246, 261);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 20;
            label2.Text = "Rating";
            // 
            // customerRatingBox
            // 
            customerRatingBox.Location = new Point(246, 279);
            customerRatingBox.Name = "customerRatingBox";
            customerRatingBox.Size = new Size(212, 23);
            customerRatingBox.TabIndex = 19;
            // 
            // EditCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(customerRatingBox);
            Controls.Add(label1);
            Controls.Add(CustEditPostalCode);
            Controls.Add(SearchText);
            Controls.Add(CreditCardTxtBox);
            Controls.Add(CreditCardLbl);
            Controls.Add(ProvinceLbl);
            Controls.Add(ProvinceTxtBox);
            Controls.Add(CityTxtBox);
            Controls.Add(CityLbl);
            Controls.Add(AddressTxtBox);
            Controls.Add(EmailTxtBox);
            Controls.Add(AddressLbl);
            Controls.Add(EmailLbl);
            Controls.Add(LastNmTxtBox);
            Controls.Add(FirstNmTxtBox);
            Controls.Add(LastNmLbl);
            Controls.Add(FirstNmLbl);
            Controls.Add(CancelBtn);
            Controls.Add(FinishBtn);
            Name = "EditCustomer";
            Text = "EditCustomer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button FinishBtn;
        private Button CancelBtn;
        private Label FirstNmLbl;
        private Label LastNmLbl;
        private TextBox FirstNmTxtBox;
        private TextBox LastNmTxtBox;
        private Label EmailLbl;
        private Label AddressLbl;
        private TextBox EmailTxtBox;
        private TextBox AddressTxtBox;
        private Label CityLbl;
        private TextBox CityTxtBox;
        private TextBox ProvinceTxtBox;
        private Label ProvinceLbl;
        private Label CreditCardLbl;
        private TextBox CreditCardTxtBox;
        private Label SearchText;
        private TextBox CustEditPostalCode;
        private Label label1;
        private Label label2;
        private TextBox customerRatingBox;
    }
}