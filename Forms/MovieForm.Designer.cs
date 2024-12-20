﻿namespace MovieRentalProject
{
    partial class MovieForm
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
            MovieMaintenance = new Label();
            TitleSearch = new TextBox();
            Edit = new Button();
            addmovie = new Button();
            Delete = new Button();
            dataGridView1 = new DataGridView();
            MovieID = new DataGridViewTextBoxColumn();
            Title = new DataGridViewTextBoxColumn();
            Fee = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            Copies = new DataGridViewTextBoxColumn();
            Available = new DataGridViewTextBoxColumn();
            Rating = new DataGridViewTextBoxColumn();
            searchbutton = new Button();
            backButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // MovieMaintenance
            // 
            MovieMaintenance.AutoSize = true;
            MovieMaintenance.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            MovieMaintenance.Location = new Point(12, 9);
            MovieMaintenance.Name = "MovieMaintenance";
            MovieMaintenance.Size = new Size(184, 28);
            MovieMaintenance.TabIndex = 0;
            MovieMaintenance.Text = "Movie Maintenance";
            // 
            // TitleSearch
            // 
            TitleSearch.Location = new Point(12, 40);
            TitleSearch.Name = "TitleSearch";
            TitleSearch.PlaceholderText = "Title";
            TitleSearch.Size = new Size(152, 23);
            TitleSearch.TabIndex = 1;
            // 
            // Edit
            // 
            Edit.Location = new Point(12, 181);
            Edit.Name = "Edit";
            Edit.Size = new Size(120, 50);
            Edit.TabIndex = 2;
            Edit.Text = "EDIT";
            Edit.UseVisualStyleBackColor = true;
            Edit.Click += Edit_Click;
            // 
            // addmovie
            // 
            addmovie.Location = new Point(12, 125);
            addmovie.Name = "addmovie";
            addmovie.Size = new Size(120, 50);
            addmovie.TabIndex = 4;
            addmovie.Text = "ADD A MOVIE";
            addmovie.UseVisualStyleBackColor = true;
            addmovie.Click += addmovie_Click;
            // 
            // Delete
            // 
            Delete.Location = new Point(12, 237);
            Delete.Name = "Delete";
            Delete.Size = new Size(120, 50);
            Delete.TabIndex = 5;
            Delete.Text = "DELETE";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MovieID, Title, Fee, Type, Copies, Available, Rating });
            dataGridView1.Location = new Point(170, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(627, 404);
            dataGridView1.TabIndex = 6;
            // 
            // MovieID
            // 
            MovieID.HeaderText = "MovieID";
            MovieID.Name = "MovieID";
            MovieID.Visible = false;
            MovieID.Width = 21;
            // 
            // Title
            // 
            Title.HeaderText = "Title";
            Title.MinimumWidth = 10;
            Title.Name = "Title";
            // 
            // Fee
            // 
            Fee.HeaderText = "Fee";
            Fee.Name = "Fee";
            // 
            // Type
            // 
            Type.HeaderText = "Type";
            Type.Name = "Type";
            // 
            // Copies
            // 
            Copies.HeaderText = "Copies";
            Copies.Name = "Copies";
            // 
            // Available
            // 
            Available.HeaderText = "Available";
            Available.Name = "Available";
            // 
            // Rating
            // 
            Rating.HeaderText = "Rating";
            Rating.Name = "Rating";
            // 
            // searchbutton
            // 
            searchbutton.Location = new Point(12, 69);
            searchbutton.Name = "searchbutton";
            searchbutton.Size = new Size(120, 50);
            searchbutton.TabIndex = 7;
            searchbutton.Text = "SEARCH";
            searchbutton.UseVisualStyleBackColor = true;
            searchbutton.Click += searchbutton_Click;
            // 
            // backButton
            // 
            backButton.Location = new Point(12, 388);
            backButton.Name = "backButton";
            backButton.Size = new Size(120, 50);
            backButton.TabIndex = 8;
            backButton.Text = "BACK";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // MovieForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(backButton);
            Controls.Add(searchbutton);
            Controls.Add(dataGridView1);
            Controls.Add(Delete);
            Controls.Add(addmovie);
            Controls.Add(Edit);
            Controls.Add(TitleSearch);
            Controls.Add(MovieMaintenance);
            Name = "MovieForm";
            Text = "MovieForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MovieMaintenance;
        private TextBox TitleSearch;
        private Button Edit;
        private Button addmovie;
        private Button Delete;
        private DataGridView dataGridView1;
        private Button searchbutton;
        private DataGridViewTextBoxColumn ID;
        private Button backButton;
        private DataGridViewTextBoxColumn MovieID;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Fee;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn Copies;
        private DataGridViewTextBoxColumn Available;
        private DataGridViewTextBoxColumn Rating;
    }
}