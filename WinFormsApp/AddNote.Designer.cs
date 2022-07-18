namespace WinFormsApp
{
    partial class AddNote
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
            this.label2 = new System.Windows.Forms.Label();
            this.NoteNameTextBox = new System.Windows.Forms.TextBox();
            this.NoteTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NoteConfirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(80, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Name";
            // 
            // NoteNameTextBox
            // 
            this.NoteNameTextBox.Location = new System.Drawing.Point(171, 59);
            this.NoteNameTextBox.Name = "NoteNameTextBox";
            this.NoteNameTextBox.Size = new System.Drawing.Size(167, 23);
            this.NoteNameTextBox.TabIndex = 11;
            // 
            // NoteTextBox
            // 
            this.NoteTextBox.Location = new System.Drawing.Point(46, 88);
            this.NoteTextBox.Multiline = true;
            this.NoteTextBox.Name = "NoteTextBox";
            this.NoteTextBox.Size = new System.Drawing.Size(292, 87);
            this.NoteTextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(126, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Add new Note";
            // 
            // NoteConfirmButton
            // 
            this.NoteConfirmButton.Location = new System.Drawing.Point(136, 201);
            this.NoteConfirmButton.Name = "NoteConfirmButton";
            this.NoteConfirmButton.Size = new System.Drawing.Size(100, 40);
            this.NoteConfirmButton.TabIndex = 8;
            this.NoteConfirmButton.Text = "Confirm";
            this.NoteConfirmButton.UseVisualStyleBackColor = true;
            this.NoteConfirmButton.Click += new System.EventHandler(this.NoteConfirmButton_Click);
            // 
            // AddNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NoteNameTextBox);
            this.Controls.Add(this.NoteTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NoteConfirmButton);
            this.Name = "AddNote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NoteNameTextBox;
        private System.Windows.Forms.TextBox NoteTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NoteConfirmButton;
    }
}