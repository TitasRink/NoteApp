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
            this.categorieNameList = new System.Windows.Forms.ComboBox();
            this.NotelistView = new System.Windows.Forms.ListView();
            this.Name = new System.Windows.Forms.ColumnHeader();
            this.Mesage = new System.Windows.Forms.ColumnHeader();
            this.Img = new System.Windows.Forms.ColumnHeader();
            this.RemoveNoteButton = new System.Windows.Forms.Button();
            this.MoveToCategory = new System.Windows.Forms.Button();
            this.WelcomeNoteApp = new System.Windows.Forms.Label();
            this.FillterByCategoryButton = new System.Windows.Forms.Button();
            this.ShowAllButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(232, 855);
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
            this.AddNoteButton.Location = new System.Drawing.Point(274, 561);
            this.AddNoteButton.Name = "AddNoteButton";
            this.AddNoteButton.Size = new System.Drawing.Size(94, 38);
            this.AddNoteButton.TabIndex = 14;
            this.AddNoteButton.Text = "ADD NOTE";
            this.AddNoteButton.UseVisualStyleBackColor = false;
            this.AddNoteButton.Click += new System.EventHandler(this.AddNoteButton_Click);
            // 
            // AddCategoryButton
            // 
            this.AddCategoryButton.BackColor = System.Drawing.Color.LightBlue;
            this.AddCategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddCategoryButton.Location = new System.Drawing.Point(496, 130);
            this.AddCategoryButton.Name = "AddCategoryButton";
            this.AddCategoryButton.Size = new System.Drawing.Size(114, 38);
            this.AddCategoryButton.TabIndex = 13;
            this.AddCategoryButton.Text = "ADD CATEGORY";
            this.AddCategoryButton.UseVisualStyleBackColor = false;
            this.AddCategoryButton.Click += new System.EventHandler(this.AddCategoryButton_Click);
            // 
            // RenameCategoryButton
            // 
            this.RenameCategoryButton.BackColor = System.Drawing.Color.LightBlue;
            this.RenameCategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RenameCategoryButton.Location = new System.Drawing.Point(383, 130);
            this.RenameCategoryButton.Name = "RenameCategoryButton";
            this.RenameCategoryButton.Size = new System.Drawing.Size(94, 38);
            this.RenameCategoryButton.TabIndex = 20;
            this.RenameCategoryButton.Text = "RENAME";
            this.RenameCategoryButton.UseVisualStyleBackColor = false;
            this.RenameCategoryButton.Click += new System.EventHandler(this.RenameCategory_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.Color.LightBlue;
            this.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RemoveButton.Location = new System.Drawing.Point(274, 130);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(94, 38);
            this.RemoveButton.TabIndex = 15;
            this.RemoveButton.Text = "REMOVE";
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.AllowDrop = true;
            this.EditButton.AutoEllipsis = true;
            this.EditButton.BackColor = System.Drawing.Color.LightBlue;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditButton.Location = new System.Drawing.Point(496, 561);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(114, 38);
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
            // categorieNameList
            // 
            this.categorieNameList.Location = new System.Drawing.Point(274, 88);
            this.categorieNameList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.categorieNameList.Name = "categorieNameList";
            this.categorieNameList.Size = new System.Drawing.Size(212, 23);
            this.categorieNameList.TabIndex = 14;
            this.categorieNameList.Text = "Select categorie";
            // 
            // NotelistView
            // 
            this.NotelistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.Mesage,
            this.Img});
            this.NotelistView.FullRowSelect = true;
            this.NotelistView.HideSelection = false;
            this.NotelistView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.NotelistView.Location = new System.Drawing.Point(274, 178);
            this.NotelistView.Name = "NotelistView";
            this.NotelistView.Size = new System.Drawing.Size(605, 358);
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
            this.Mesage.Width = 250;
            // 
            // Img
            // 
            this.Img.Text = "Img";
            this.Img.Width = 250;
            // 
            // RemoveNoteButton
            // 
            this.RemoveNoteButton.BackColor = System.Drawing.Color.LightBlue;
            this.RemoveNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RemoveNoteButton.Location = new System.Drawing.Point(383, 561);
            this.RemoveNoteButton.Name = "RemoveNoteButton";
            this.RemoveNoteButton.Size = new System.Drawing.Size(94, 38);
            this.RemoveNoteButton.TabIndex = 16;
            this.RemoveNoteButton.Text = "REMOVE";
            this.RemoveNoteButton.UseVisualStyleBackColor = false;
            this.RemoveNoteButton.Click += new System.EventHandler(this.RemoveNoteButton_Click);
            // 
            // MoveToCategory
            // 
            this.MoveToCategory.BackColor = System.Drawing.Color.LightBlue;
            this.MoveToCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MoveToCategory.Location = new System.Drawing.Point(742, 561);
            this.MoveToCategory.Name = "MoveToCategory";
            this.MoveToCategory.Size = new System.Drawing.Size(137, 38);
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
            this.FillterByCategoryButton.Location = new System.Drawing.Point(496, 87);
            this.FillterByCategoryButton.Name = "FillterByCategoryButton";
            this.FillterByCategoryButton.Size = new System.Drawing.Size(114, 27);
            this.FillterByCategoryButton.TabIndex = 23;
            this.FillterByCategoryButton.Text = "Fillter by Category";
            this.FillterByCategoryButton.UseVisualStyleBackColor = false;
            this.FillterByCategoryButton.Click += new System.EventHandler(this.FillterByCategoryButton_Click);
            // 
            // ShowAllButton
            // 
            this.ShowAllButton.BackColor = System.Drawing.Color.LightBlue;
            this.ShowAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ShowAllButton.Location = new System.Drawing.Point(616, 88);
            this.ShowAllButton.Name = "ShowAllButton";
            this.ShowAllButton.Size = new System.Drawing.Size(81, 27);
            this.ShowAllButton.TabIndex = 24;
            this.ShowAllButton.Text = "Show All";
            this.ShowAllButton.UseVisualStyleBackColor = false;
            this.ShowAllButton.Click += new System.EventHandler(this.ShowAllButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 639);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 24);
            this.button1.TabIndex = 25;
            this.button1.Text = "Find Photo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(383, 639);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(496, 23);
            this.textBox1.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(274, 683);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(496, 805);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 38);
            this.button2.TabIndex = 28;
            this.button2.Text = "Add Photo to Note";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1029, 855);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ShowAllButton);
            this.Controls.Add(this.FillterByCategoryButton);
            this.Controls.Add(this.WelcomeNoteApp);
            this.Controls.Add(this.MoveToCategory);
            this.Controls.Add(this.RenameCategoryButton);
            this.Controls.Add(this.AddNoteButton);
            this.Controls.Add(this.RemoveNoteButton);
            this.Controls.Add(this.AddCategoryButton);
            this.Controls.Add(this.NotelistView);
            this.Controls.Add(this.categorieNameList);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RemoveButton);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Note APP";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        public System.Windows.Forms.ComboBox categorieNameList;
        private System.Windows.Forms.ListView NotelistView;
        private System.Windows.Forms.Button RemoveNoteButton;
        private System.Windows.Forms.Button MoveToCategory;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Mesage;
        private System.Windows.Forms.Label WelcomeNoteApp;
        private System.Windows.Forms.ColumnHeader Img;
        private System.Windows.Forms.Button FillterByCategoryButton;
        private System.Windows.Forms.Button ShowAllButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
    }
}