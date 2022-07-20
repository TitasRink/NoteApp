namespace WinFormsApp
{
    partial class EditNote
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
            this.EditNoteTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EditNoteConfirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(149, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "New Note";
            // 
            // EditNoteTextBox
            // 
            this.EditNoteTextBox.Location = new System.Drawing.Point(46, 88);
            this.EditNoteTextBox.Multiline = true;
            this.EditNoteTextBox.Name = "EditNoteTextBox";
            this.EditNoteTextBox.Size = new System.Drawing.Size(292, 87);
            this.EditNoteTextBox.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(149, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Edit Note";
            // 
            // EditNoteConfirmButton
            // 
            this.EditNoteConfirmButton.BackColor = System.Drawing.Color.LightBlue;
            this.EditNoteConfirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditNoteConfirmButton.Location = new System.Drawing.Point(136, 201);
            this.EditNoteConfirmButton.Name = "EditNoteConfirmButton";
            this.EditNoteConfirmButton.Size = new System.Drawing.Size(100, 40);
            this.EditNoteConfirmButton.TabIndex = 13;
            this.EditNoteConfirmButton.Text = "Confirm";
            this.EditNoteConfirmButton.UseVisualStyleBackColor = false;
            this.EditNoteConfirmButton.Click += new System.EventHandler(this.EditNoteConfirmButton_Click);
            // 
            // EditNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EditNoteTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EditNoteConfirmButton);
            this.Name = "EditNote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditNote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EditNoteTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EditNoteConfirmButton;
    }
}