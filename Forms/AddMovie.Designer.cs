﻿namespace MovieRentalProject.Forms
{
    partial class AddMovie
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
            TitleAdd = new TextBox();
            MovieMaintenance = new Label();
            FeeAdd = new TextBox();
            TypeAdd = new TextBox();
            CopiesAdd = new TextBox();
            Save = new Button();
            Cancel = new Button();
            remove = new Button();
            add = new Button();
            SelectedNames = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            ActorNameQuery = new DataGridView();
            ActorID = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            GoButton = new Button();
            ActorLastName = new TextBox();
            AddActor = new Label();
            ActorFirstName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)SelectedNames).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ActorNameQuery).BeginInit();
            SuspendLayout();
            // 
            // TitleAdd
            // 
            TitleAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TitleAdd.Location = new Point(14, 50);
            TitleAdd.Name = "TitleAdd";
            TitleAdd.PlaceholderText = "Title";
            TitleAdd.Size = new Size(330, 29);
            TitleAdd.TabIndex = 0;
            // 
            // MovieMaintenance
            // 
            MovieMaintenance.AutoSize = true;
            MovieMaintenance.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            MovieMaintenance.Location = new Point(12, 9);
            MovieMaintenance.Name = "MovieMaintenance";
            MovieMaintenance.Size = new Size(109, 28);
            MovieMaintenance.TabIndex = 1;
            MovieMaintenance.Text = "Add Movie";
            // 
            // FeeAdd
            // 
            FeeAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FeeAdd.Location = new Point(171, 120);
            FeeAdd.Name = "FeeAdd";
            FeeAdd.PlaceholderText = "Fee";
            FeeAdd.Size = new Size(173, 29);
            FeeAdd.TabIndex = 2;
            // 
            // TypeAdd
            // 
            TypeAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TypeAdd.Location = new Point(12, 85);
            TypeAdd.Name = "TypeAdd";
            TypeAdd.PlaceholderText = "Type";
            TypeAdd.Size = new Size(332, 29);
            TypeAdd.TabIndex = 3;
            // 
            // CopiesAdd
            // 
            CopiesAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CopiesAdd.Location = new Point(12, 120);
            CopiesAdd.Name = "CopiesAdd";
            CopiesAdd.PlaceholderText = "Copies";
            CopiesAdd.Size = new Size(151, 29);
            CopiesAdd.TabIndex = 4;
            // 
            // Save
            // 
            Save.Location = new Point(668, 386);
            Save.Name = "Save";
            Save.Size = new Size(120, 50);
            Save.TabIndex = 5;
            Save.Text = "SAVE";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // Cancel
            // 
            Cancel.Location = new Point(14, 388);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(120, 50);
            Cancel.TabIndex = 6;
            Cancel.Text = "BACK";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // remove
            // 
            remove.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            remove.Location = new Point(348, 248);
            remove.Name = "remove";
            remove.Size = new Size(104, 50);
            remove.TabIndex = 37;
            remove.Text = "REMOVE";
            remove.UseVisualStyleBackColor = true;
            remove.Click += remove_Click;
            // 
            // add
            // 
            add.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            add.Location = new Point(348, 192);
            add.Name = "add";
            add.Size = new Size(104, 50);
            add.TabIndex = 36;
            add.Text = "ADD";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // SelectedNames
            // 
            SelectedNames.AllowUserToAddRows = false;
            SelectedNames.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SelectedNames.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            SelectedNames.Location = new Point(14, 155);
            SelectedNames.Name = "SelectedNames";
            SelectedNames.ReadOnly = true;
            SelectedNames.RowTemplate.Height = 25;
            SelectedNames.Size = new Size(330, 225);
            SelectedNames.TabIndex = 35;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "ActorID";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "First Name";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Last Name";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // ActorNameQuery
            // 
            ActorNameQuery.AllowUserToAddRows = false;
            ActorNameQuery.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ActorNameQuery.Columns.AddRange(new DataGridViewColumn[] { ActorID, FirstName, LastName });
            ActorNameQuery.Location = new Point(458, 155);
            ActorNameQuery.Name = "ActorNameQuery";
            ActorNameQuery.RowTemplate.Height = 25;
            ActorNameQuery.Size = new Size(330, 225);
            ActorNameQuery.TabIndex = 34;
            // 
            // ActorID
            // 
            ActorID.HeaderText = "ActorID";
            ActorID.Name = "ActorID";
            ActorID.Visible = false;
            // 
            // FirstName
            // 
            FirstName.HeaderText = "First Name";
            FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            LastName.HeaderText = "Last Name";
            LastName.Name = "LastName";
            // 
            // GoButton
            // 
            GoButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            GoButton.Location = new Point(668, 99);
            GoButton.Name = "GoButton";
            GoButton.Size = new Size(120, 50);
            GoButton.TabIndex = 33;
            GoButton.Text = "SEARCH";
            GoButton.UseVisualStyleBackColor = true;
            GoButton.Click += GoButton_Click;
            // 
            // ActorLastName
            // 
            ActorLastName.Location = new Point(665, 50);
            ActorLastName.Name = "ActorLastName";
            ActorLastName.PlaceholderText = "Last Name";
            ActorLastName.Size = new Size(123, 23);
            ActorLastName.TabIndex = 32;
            // 
            // AddActor
            // 
            AddActor.AutoSize = true;
            AddActor.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            AddActor.Location = new Point(686, 9);
            AddActor.Name = "AddActor";
            AddActor.Size = new Size(102, 28);
            AddActor.TabIndex = 31;
            AddActor.Text = "Add Actor";
            // 
            // ActorFirstName
            // 
            ActorFirstName.Location = new Point(536, 50);
            ActorFirstName.Name = "ActorFirstName";
            ActorFirstName.PlaceholderText = "First Name";
            ActorFirstName.Size = new Size(123, 23);
            ActorFirstName.TabIndex = 30;
            // 
            // AddMovie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(remove);
            Controls.Add(add);
            Controls.Add(SelectedNames);
            Controls.Add(ActorNameQuery);
            Controls.Add(GoButton);
            Controls.Add(ActorLastName);
            Controls.Add(AddActor);
            Controls.Add(ActorFirstName);
            Controls.Add(Cancel);
            Controls.Add(Save);
            Controls.Add(CopiesAdd);
            Controls.Add(TypeAdd);
            Controls.Add(FeeAdd);
            Controls.Add(MovieMaintenance);
            Controls.Add(TitleAdd);
            Name = "AddMovie";
            Text = "AddMovie";
            ((System.ComponentModel.ISupportInitialize)SelectedNames).EndInit();
            ((System.ComponentModel.ISupportInitialize)ActorNameQuery).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TitleAdd;
        private Label MovieMaintenance;
        private TextBox FeeAdd;
        private TextBox TypeAdd;
        private TextBox CopiesAdd;
        private Button Save;
        private Button Cancel;
        private Button remove;
        private Button add;
        private DataGridView SelectedNames;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridView ActorNameQuery;
        private DataGridViewTextBoxColumn ActorID;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private Button GoButton;
        private TextBox ActorLastName;
        private Label AddActor;
        private TextBox ActorFirstName;
    }
}