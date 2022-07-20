namespace WinFormsApp
{
    partial class RenameCategory
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
            this.RenameCategoryTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RenameCastegoryConfirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(127, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Enter category name";
            // 
            // RenameCategoryTextBox
            // 
            this.RenameCategoryTextBox.Location = new System.Drawing.Point(46, 136);
            this.RenameCategoryTextBox.Multiline = true;
            this.RenameCategoryTextBox.Name = "RenameCategoryTextBox";
            this.RenameCategoryTextBox.Size = new System.Drawing.Size(292, 28);
            this.RenameCategoryTextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(116, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Rename Category";
            // 
            // RenameCastegoryConfirmButton
            // 
            this.RenameCastegoryConfirmButton.BackColor = System.Drawing.Color.LightBlue;
            this.RenameCastegoryConfirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RenameCastegoryConfirmButton.Location = new System.Drawing.Point(136, 190);
            this.RenameCastegoryConfirmButton.Name = "RenameCastegoryConfirmButton";
            this.RenameCastegoryConfirmButton.Size = new System.Drawing.Size(100, 40);
            this.RenameCastegoryConfirmButton.TabIndex = 7;
            this.RenameCastegoryConfirmButton.Text = "Confirm";
            this.RenameCastegoryConfirmButton.UseVisualStyleBackColor = false;
            this.RenameCastegoryConfirmButton.Click += new System.EventHandler(this.RenameCastegoryConfirmButton_Click);
            // 
            // RenameCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RenameCategoryTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RenameCastegoryConfirmButton);
            this.Name = "RenameCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RenameCategory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RenameCategoryTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RenameCastegoryConfirmButton;
    }
}