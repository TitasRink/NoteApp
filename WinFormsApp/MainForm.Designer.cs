namespace WinFormsApp
{
    partial class MainForm
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            ""}, -1);
            this.UsernameTextBox = new System.Windows.Forms.Label();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.PasswordInputBox = new System.Windows.Forms.TextBox();
            this.UserInputBox = new System.Windows.Forms.TextBox();
            this.PaswordLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LogedInLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.AddUserButton = new System.Windows.Forms.Button();
            this.AddNoteButton = new System.Windows.Forms.Button();
            this.AddCategoryButton = new System.Windows.Forms.Button();
            this.RenameCategoryButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.NotelistView = new System.Windows.Forms.ListView();
            this.Name = new System.Windows.Forms.ColumnHeader();
            this.Mesage = new System.Windows.Forms.ColumnHeader();
            this.RemoveNoteButton = new System.Windows.Forms.Button();
            this.MoveToCategory = new System.Windows.Forms.Button();
            this.WelcomeNoteApp = new System.Windows.Forms.Label();
            this.FillterByCategoryButton = new System.Windows.Forms.Button();
            this.ShowAllButton = new System.Windows.Forms.Button();
            this.CategoryTextBoxAddRemove = new System.Windows.Forms.TextBox();
            this.CategoryListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.NoteNameTextBox = new System.Windows.Forms.TextBox();
            this.NoteMessageTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.AddImageButton = new System.Windows.Forms.Button();
            this.LoadImageButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.AutoSize = true;
            this.UsernameTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UsernameTextBox.Location = new System.Drawing.Point(91, 467);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(52, 25);
            this.UsernameTextBox.TabIndex = 7;
            this.UsernameTextBox.Text = "User";
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WelcomeLabel.Location = new System.Drawing.Point(30, 16);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(176, 45);
            this.WelcomeLabel.TabIndex = 6;
            this.WelcomeLabel.Text = "WELCOME";
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackColor = System.Drawing.Color.LightBlue;
            this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LogoutButton.Location = new System.Drawing.Point(62, 495);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(114, 37);
            this.LogoutButton.TabIndex = 5;
            this.LogoutButton.Text = "Log out";
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.LightBlue;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoginButton.Location = new System.Drawing.Point(57, 251);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(126, 37);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Log in";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click_1);
            // 
            // PasswordInputBox
            // 
            this.PasswordInputBox.Location = new System.Drawing.Point(57, 222);
            this.PasswordInputBox.Name = "PasswordInputBox";
            this.PasswordInputBox.Size = new System.Drawing.Size(126, 23);
            this.PasswordInputBox.TabIndex = 3;
            this.PasswordInputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PasswordInputBox.UseSystemPasswordChar = true;
            // 
            // UserInputBox
            // 
            this.UserInputBox.Location = new System.Drawing.Point(57, 178);
            this.UserInputBox.Name = "UserInputBox";
            this.UserInputBox.Size = new System.Drawing.Size(126, 23);
            this.UserInputBox.TabIndex = 2;
            this.UserInputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PaswordLabel
            // 
            this.PaswordLabel.AutoSize = true;
            this.PaswordLabel.Location = new System.Drawing.Point(126, 204);
            this.PaswordLabel.Name = "PaswordLabel";
            this.PaswordLabel.Size = new System.Drawing.Size(57, 15);
            this.PaswordLabel.TabIndex = 1;
            this.PaswordLabel.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "User";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.LogedInLabel);
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Controls.Add(this.AddUserButton);
            this.panel1.Controls.Add(this.WelcomeLabel);
            this.panel1.Controls.Add(this.LoginButton);
            this.panel1.Controls.Add(this.UsernameTextBox);
            this.panel1.Controls.Add(this.PasswordInputBox);
            this.panel1.Controls.Add(this.LogoutButton);
            this.panel1.Controls.Add(this.UserInputBox);
            this.panel1.Controls.Add(this.PaswordLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 713);
            this.panel1.TabIndex = 3;
            // 
            // LogedInLabel
            // 
            this.LogedInLabel.AutoSize = true;
            this.LogedInLabel.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.LogedInLabel.Location = new System.Drawing.Point(62, 436);
            this.LogedInLabel.Name = "LogedInLabel";
            this.LogedInLabel.Size = new System.Drawing.Size(114, 21);
            this.LogedInLabel.TabIndex = 19;
            this.LogedInLabel.Text = "Logged in as :";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.LightBlue;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitButton.Location = new System.Drawing.Point(57, 647);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(126, 41);
            this.ExitButton.TabIndex = 18;
            this.ExitButton.Text = "EXIT";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // AddUserButton
            // 
            this.AddUserButton.BackColor = System.Drawing.Color.LightBlue;
            this.AddUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddUserButton.Location = new System.Drawing.Point(57, 356);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(126, 37);
            this.AddUserButton.TabIndex = 17;
            this.AddUserButton.Text = "Create User";
            this.AddUserButton.UseVisualStyleBackColor = false;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // AddNoteButton
            // 
            this.AddNoteButton.BackColor = System.Drawing.Color.LightBlue;
            this.AddNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddNoteButton.Location = new System.Drawing.Point(259, 665);
            this.AddNoteButton.Name = "AddNoteButton";
            this.AddNoteButton.Size = new System.Drawing.Size(94, 23);
            this.AddNoteButton.TabIndex = 14;
            this.AddNoteButton.Text = "ADD NOTE";
            this.AddNoteButton.UseVisualStyleBackColor = false;
            this.AddNoteButton.Click += new System.EventHandler(this.AddNoteButton_Click);
            // 
            // AddCategoryButton
            // 
            this.AddCategoryButton.BackColor = System.Drawing.Color.LightBlue;
            this.AddCategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddCategoryButton.Location = new System.Drawing.Point(474, 236);
            this.AddCategoryButton.Name = "AddCategoryButton";
            this.AddCategoryButton.Size = new System.Drawing.Size(114, 23);
            this.AddCategoryButton.TabIndex = 13;
            this.AddCategoryButton.Text = "ADD CATEGORY";
            this.AddCategoryButton.UseVisualStyleBackColor = false;
            this.AddCategoryButton.Click += new System.EventHandler(this.AddCategoryButton_Click);
            // 
            // RenameCategoryButton
            // 
            this.RenameCategoryButton.BackColor = System.Drawing.Color.LightBlue;
            this.RenameCategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RenameCategoryButton.Location = new System.Drawing.Point(474, 265);
            this.RenameCategoryButton.Name = "RenameCategoryButton";
            this.RenameCategoryButton.Size = new System.Drawing.Size(114, 23);
            this.RenameCategoryButton.TabIndex = 20;
            this.RenameCategoryButton.Text = "RENAME";
            this.RenameCategoryButton.UseVisualStyleBackColor = false;
            this.RenameCategoryButton.Click += new System.EventHandler(this.RenameCategory_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.Color.LightBlue;
            this.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RemoveButton.Location = new System.Drawing.Point(259, 299);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(81, 23);
            this.RemoveButton.TabIndex = 15;
            this.RemoveButton.Text = "REMOVE";
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.LightBlue;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditButton.Location = new System.Drawing.Point(491, 663);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(114, 25);
            this.EditButton.TabIndex = 16;
            this.EditButton.Text = "EDIT";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // NotelistView
            // 
            this.NotelistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.Mesage});
            this.NotelistView.FullRowSelect = true;
            this.NotelistView.HideSelection = false;
            this.NotelistView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.NotelistView.Location = new System.Drawing.Point(259, 403);
            this.NotelistView.Name = "NotelistView";
            this.NotelistView.Size = new System.Drawing.Size(505, 201);
            this.NotelistView.TabIndex = 15;
            this.NotelistView.UseCompatibleStateImageBehavior = false;
            this.NotelistView.View = System.Windows.Forms.View.Details;
            // 
            // Name
            // 
            this.Name.Text = "Name";
            this.Name.Width = 100;
            // 
            // Mesage
            // 
            this.Mesage.Text = "Message";
            this.Mesage.Width = 400;
            // 
            // RemoveNoteButton
            // 
            this.RemoveNoteButton.BackColor = System.Drawing.Color.LightBlue;
            this.RemoveNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RemoveNoteButton.Location = new System.Drawing.Point(670, 636);
            this.RemoveNoteButton.Name = "RemoveNoteButton";
            this.RemoveNoteButton.Size = new System.Drawing.Size(94, 23);
            this.RemoveNoteButton.TabIndex = 16;
            this.RemoveNoteButton.Text = "REMOVE";
            this.RemoveNoteButton.UseVisualStyleBackColor = false;
            this.RemoveNoteButton.Click += new System.EventHandler(this.RemoveNoteButton_Click);
            // 
            // MoveToCategory
            // 
            this.MoveToCategory.BackColor = System.Drawing.Color.LightBlue;
            this.MoveToCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MoveToCategory.Location = new System.Drawing.Point(627, 663);
            this.MoveToCategory.Name = "MoveToCategory";
            this.MoveToCategory.Size = new System.Drawing.Size(137, 25);
            this.MoveToCategory.TabIndex = 22;
            this.MoveToCategory.Text = "MOVE TO CATEGORY";
            this.MoveToCategory.UseVisualStyleBackColor = false;
            this.MoveToCategory.Click += new System.EventHandler(this.MoveToCategory_Click);
            // 
            // WelcomeNoteApp
            // 
            this.WelcomeNoteApp.AutoSize = true;
            this.WelcomeNoteApp.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WelcomeNoteApp.Location = new System.Drawing.Point(398, 16);
            this.WelcomeNoteApp.Name = "WelcomeNoteApp";
            this.WelcomeNoteApp.Size = new System.Drawing.Size(392, 45);
            this.WelcomeNoteApp.TabIndex = 20;
            this.WelcomeNoteApp.Text = "WELCOME TO NOTE APP";
            // 
            // FillterByCategoryButton
            // 
            this.FillterByCategoryButton.BackColor = System.Drawing.Color.LightBlue;
            this.FillterByCategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FillterByCategoryButton.Location = new System.Drawing.Point(474, 80);
            this.FillterByCategoryButton.Name = "FillterByCategoryButton";
            this.FillterByCategoryButton.Size = new System.Drawing.Size(114, 25);
            this.FillterByCategoryButton.TabIndex = 23;
            this.FillterByCategoryButton.Text = "Fillter by Category";
            this.FillterByCategoryButton.UseVisualStyleBackColor = false;
            this.FillterByCategoryButton.Click += new System.EventHandler(this.FillterByCategoryButton_Click);
            // 
            // ShowAllButton
            // 
            this.ShowAllButton.BackColor = System.Drawing.Color.LightBlue;
            this.ShowAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ShowAllButton.Location = new System.Drawing.Point(259, 362);
            this.ShowAllButton.Name = "ShowAllButton";
            this.ShowAllButton.Size = new System.Drawing.Size(81, 25);
            this.ShowAllButton.TabIndex = 24;
            this.ShowAllButton.Text = "Show All";
            this.ShowAllButton.UseVisualStyleBackColor = false;
            this.ShowAllButton.Click += new System.EventHandler(this.ShowAllButton_Click);
            // 
            // CategoryTextBoxAddRemove
            // 
            this.CategoryTextBoxAddRemove.Location = new System.Drawing.Point(474, 207);
            this.CategoryTextBoxAddRemove.Name = "CategoryTextBoxAddRemove";
            this.CategoryTextBoxAddRemove.Size = new System.Drawing.Size(114, 23);
            this.CategoryTextBoxAddRemove.TabIndex = 20;
            this.CategoryTextBoxAddRemove.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CategoryListView
            // 
            this.CategoryListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.CategoryListView.FullRowSelect = true;
            this.CategoryListView.HideSelection = false;
            this.CategoryListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.CategoryListView.Location = new System.Drawing.Point(259, 80);
            this.CategoryListView.Name = "CategoryListView";
            this.CategoryListView.Size = new System.Drawing.Size(205, 208);
            this.CategoryListView.TabIndex = 25;
            this.CategoryListView.UseCompatibleStateImageBehavior = false;
            this.CategoryListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Category";
            this.columnHeader1.Width = 200;
            // 
            // NoteNameTextBox
            // 
            this.NoteNameTextBox.Location = new System.Drawing.Point(259, 636);
            this.NoteNameTextBox.Name = "NoteNameTextBox";
            this.NoteNameTextBox.Size = new System.Drawing.Size(114, 23);
            this.NoteNameTextBox.TabIndex = 26;
            this.NoteNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NoteMessageTextBox
            // 
            this.NoteMessageTextBox.Location = new System.Drawing.Point(398, 636);
            this.NoteMessageTextBox.Name = "NoteMessageTextBox";
            this.NoteMessageTextBox.Size = new System.Drawing.Size(207, 23);
            this.NoteMessageTextBox.TabIndex = 27;
            this.NoteMessageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 618);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(552, 618);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 28;
            this.label3.Text = "Message";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(606, 80);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(270, 239);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 37;
            this.pictureBox.TabStop = false;
            // 
            // AddImageButton
            // 
            this.AddImageButton.BackColor = System.Drawing.Color.LightBlue;
            this.AddImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddImageButton.Location = new System.Drawing.Point(552, 362);
            this.AddImageButton.Name = "AddImageButton";
            this.AddImageButton.Size = new System.Drawing.Size(99, 25);
            this.AddImageButton.TabIndex = 38;
            this.AddImageButton.Text = "Add Image";
            this.AddImageButton.UseVisualStyleBackColor = false;
            this.AddImageButton.Click += new System.EventHandler(this.AddImageButton_Click);
            // 
            // LoadImageButton
            // 
            this.LoadImageButton.BackColor = System.Drawing.Color.LightBlue;
            this.LoadImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoadImageButton.Location = new System.Drawing.Point(670, 362);
            this.LoadImageButton.Name = "LoadImageButton";
            this.LoadImageButton.Size = new System.Drawing.Size(94, 25);
            this.LoadImageButton.TabIndex = 39;
            this.LoadImageButton.Text = "Load Image";
            this.LoadImageButton.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(904, 713);
            this.Controls.Add(this.LoadImageButton);
            this.Controls.Add(this.AddImageButton);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NoteMessageTextBox);
            this.Controls.Add(this.NoteNameTextBox);
            this.Controls.Add(this.CategoryListView);
            this.Controls.Add(this.CategoryTextBoxAddRemove);
            this.Controls.Add(this.ShowAllButton);
            this.Controls.Add(this.FillterByCategoryButton);
            this.Controls.Add(this.WelcomeNoteApp);
            this.Controls.Add(this.MoveToCategory);
            this.Controls.Add(this.RenameCategoryButton);
            this.Controls.Add(this.AddNoteButton);
            this.Controls.Add(this.RemoveNoteButton);
            this.Controls.Add(this.AddCategoryButton);
            this.Controls.Add(this.NotelistView);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RemoveButton);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Note APP";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label UsernameTextBox;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox PasswordInputBox;
        private System.Windows.Forms.TextBox UserInputBox;
        private System.Windows.Forms.Label PaswordLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button AddNoteButton;
        private System.Windows.Forms.Button AddCategoryButton;
        private System.Windows.Forms.Button AddUserButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label LogedInLabel;
        private System.Windows.Forms.Button RenameCategoryButton;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.ListView NotelistView;
        private System.Windows.Forms.Button RemoveNoteButton;
        private System.Windows.Forms.Button MoveToCategory;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Mesage;
        private System.Windows.Forms.Label WelcomeNoteApp;
        private System.Windows.Forms.Button FillterByCategoryButton;
        private System.Windows.Forms.Button ShowAllButton;
        private System.Windows.Forms.TextBox CategoryTextBoxAddRemove;
        private System.Windows.Forms.ListView CategoryListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TextBox NoteNameTextBox;
        private System.Windows.Forms.TextBox NoteMessageTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button AddImageButton;
        private System.Windows.Forms.Button LoadImageButton;
    }
}