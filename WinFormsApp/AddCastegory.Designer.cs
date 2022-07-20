namespace WinFormsApp
{
    partial class AddCastegory
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
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CastegoryConfirmButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CategoryTextBox
            // 
            this.CategoryTextBox.Location = new System.Drawing.Point(46, 136);
            this.CategoryTextBox.Multiline = true;
            this.CategoryTextBox.Name = "CategoryTextBox";
            this.CategoryTextBox.Size = new System.Drawing.Size(292, 28);
            this.CategoryTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(116, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Add new Category";
            // 
            // CastegoryConfirmButton
            // 
            this.CastegoryConfirmButton.BackColor = System.Drawing.Color.LightBlue;
            this.CastegoryConfirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CastegoryConfirmButton.Location = new System.Drawing.Point(136, 190);
            this.CastegoryConfirmButton.Name = "CastegoryConfirmButton";
            this.CastegoryConfirmButton.Size = new System.Drawing.Size(100, 40);
            this.CastegoryConfirmButton.TabIndex = 3;
            this.CastegoryConfirmButton.Text = "Confirm";
            this.CastegoryConfirmButton.UseVisualStyleBackColor = false;
            this.CastegoryConfirmButton.Click += new System.EventHandler(this.CastegoryConfirmButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(127, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter category name";
            // 
            // AddCastegory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CategoryTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CastegoryConfirmButton);
            this.Name = "AddCastegory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCastegory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CategoryTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CastegoryConfirmButton;
        private System.Windows.Forms.Label label2;
    }
}