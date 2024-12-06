﻿namespace MovieRentalProject
{
    partial class NewCustomer
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
            CancelBtn = new Button();
            createCustomerButton = new Button();
            customerFirstNameBox = new TextBox();
            customerLastNameBox = new TextBox();
            customerEmailBox = new TextBox();
            customerAddressBox = new TextBox();
            customerCityBox = new TextBox();
            customerPostalCodeBox = new TextBox();
            customerCardBox = new TextBox();
            customerRatingBox = new TextBox();
            label1 = new Label();
            customerProvinceBox = new TextBox();
            SuspendLayout();
            // 
            // CancelBtn
            // 
            CancelBtn.Location = new Point(12, 388);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(120, 50);
            CancelBtn.TabIndex = 2;
            CancelBtn.Text = "BACK";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // createCustomerButton
            // 
            createCustomerButton.Location = new Point(668, 388);
            createCustomerButton.Name = "createCustomerButton";
            createCustomerButton.Size = new Size(120, 50);
            createCustomerButton.TabIndex = 3;
            createCustomerButton.Text = "CREATE";
            createCustomerButton.UseVisualStyleBackColor = true;
            createCustomerButton.Click += createCustomerButton_Click;
            // 
            // customerFirstNameBox
            // 
            customerFirstNameBox.Location = new Point(12, 78);
            customerFirstNameBox.Name = "customerFirstNameBox";
            customerFirstNameBox.PlaceholderText = "First Name";
            customerFirstNameBox.Size = new Size(212, 23);
            customerFirstNameBox.TabIndex = 4;
            // 
            // customerLastNameBox
            // 
            customerLastNameBox.Location = new Point(230, 78);
            customerLastNameBox.Name = "customerLastNameBox";
            customerLastNameBox.PlaceholderText = "Last Name";
            customerLastNameBox.Size = new Size(212, 23);
            customerLastNameBox.TabIndex = 5;
            // 
            // customerEmailBox
            // 
            customerEmailBox.Location = new Point(12, 127);
            customerEmailBox.Name = "customerEmailBox";
            customerEmailBox.PlaceholderText = "Email";
            customerEmailBox.Size = new Size(212, 23);
            customerEmailBox.TabIndex = 6;
            // 
            // customerAddressBox
            // 
            customerAddressBox.Location = new Point(12, 175);
            customerAddressBox.Name = "customerAddressBox";
            customerAddressBox.PlaceholderText = "Address";
            customerAddressBox.Size = new Size(363, 23);
            customerAddressBox.TabIndex = 7;
            // 
            // customerCityBox
            // 
            customerCityBox.Location = new Point(12, 224);
            customerCityBox.Name = "customerCityBox";
            customerCityBox.PlaceholderText = "City";
            customerCityBox.Size = new Size(212, 23);
            customerCityBox.TabIndex = 8;
            // 
            // customerPostalCodeBox
            // 
            customerPostalCodeBox.Location = new Point(12, 274);
            customerPostalCodeBox.Name = "customerPostalCodeBox";
            customerPostalCodeBox.PlaceholderText = "PostalCode";
            customerPostalCodeBox.Size = new Size(212, 23);
            customerPostalCodeBox.TabIndex = 9;
            // 
            // customerCardBox
            // 
            customerCardBox.Location = new Point(230, 127);
            customerCardBox.Name = "customerCardBox";
            customerCardBox.PlaceholderText = "Credit Card";
            customerCardBox.Size = new Size(212, 23);
            customerCardBox.TabIndex = 10;
            // 
            // customerRatingBox
            // 
            customerRatingBox.Location = new Point(230, 274);
            customerRatingBox.Name = "customerRatingBox";
            customerRatingBox.PlaceholderText = "Rating";
            customerRatingBox.Size = new Size(212, 23);
            customerRatingBox.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(138, 28);
            label1.TabIndex = 12;
            label1.Text = "Add Customer";
            // 
            // customerProvinceBox
            // 
            customerProvinceBox.Location = new Point(230, 224);
            customerProvinceBox.Name = "customerProvinceBox";
            customerProvinceBox.PlaceholderText = "Province";
            customerProvinceBox.Size = new Size(212, 23);
            customerProvinceBox.TabIndex = 13;
            // 
            // NewCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(customerProvinceBox);
            Controls.Add(label1);
            Controls.Add(customerRatingBox);
            Controls.Add(customerCardBox);
            Controls.Add(customerPostalCodeBox);
            Controls.Add(customerCityBox);
            Controls.Add(customerAddressBox);
            Controls.Add(customerEmailBox);
            Controls.Add(customerLastNameBox);
            Controls.Add(customerFirstNameBox);
            Controls.Add(createCustomerButton);
            Controls.Add(CancelBtn);
            Name = "NewCustomer";
            Text = "NewCustomer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CancelBtn;
        private Button createCustomerButton;
        private TextBox customerFirstNameBox;
        private TextBox customerLastNameBox;
        private TextBox customerEmailBox;
        private TextBox customerAddressBox;
        private TextBox customerCityBox;
        private TextBox customerPostalCodeBox;
        private TextBox customerCardBox;
        private TextBox customerRatingBox;
        private Label label1;
        private TextBox customerProvinceBox;
    }
}