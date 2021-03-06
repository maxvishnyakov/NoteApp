
namespace NoteApp.View
{
    partial class NoteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxNoteTitle = new System.Windows.Forms.TextBox();
            this.ComboBoxNoteCategory = new System.Windows.Forms.ComboBox();
            this.NoteDateCreate = new System.Windows.Forms.DateTimePicker();
            this.NoteDateModify = new System.Windows.Forms.DateTimePicker();
            this.TextBoxNoteText = new System.Windows.Forms.RichTextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Created:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Modified:";
            // 
            // TextBoxNoteTitle
            // 
            this.TextBoxNoteTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxNoteTitle.Location = new System.Drawing.Point(91, 20);
            this.TextBoxNoteTitle.Name = "TextBoxNoteTitle";
            this.TextBoxNoteTitle.Size = new System.Drawing.Size(638, 22);
            this.TextBoxNoteTitle.TabIndex = 4;
            this.TextBoxNoteTitle.TextChanged += new System.EventHandler(this.TitleTextBox_TextChanged);
            // 
            // ComboBoxNoteCategory
            // 
            this.ComboBoxNoteCategory.FormattingEnabled = true;
            this.ComboBoxNoteCategory.Items.AddRange(new object[] {
            "Documents",
            "Finance",
            "Health and Sports",
            "Home",
            "People",
            "Work",
            "Miscellaneous"});
            this.ComboBoxNoteCategory.Location = new System.Drawing.Point(91, 48);
            this.ComboBoxNoteCategory.Name = "ComboBoxNoteCategory";
            this.ComboBoxNoteCategory.Size = new System.Drawing.Size(138, 24);
            this.ComboBoxNoteCategory.TabIndex = 5;
            // 
            // NoteDateCreate
            // 
            this.NoteDateCreate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.NoteDateCreate.Location = new System.Drawing.Point(91, 78);
            this.NoteDateCreate.Name = "NoteDateCreate";
            this.NoteDateCreate.Size = new System.Drawing.Size(138, 22);
            this.NoteDateCreate.TabIndex = 6;
            // 
            // NoteDateModify
            // 
            this.NoteDateModify.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.NoteDateModify.Location = new System.Drawing.Point(328, 78);
            this.NoteDateModify.Name = "NoteDateModify";
            this.NoteDateModify.Size = new System.Drawing.Size(138, 22);
            this.NoteDateModify.TabIndex = 7;
            // 
            // TextBoxNoteText
            // 
            this.TextBoxNoteText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxNoteText.Location = new System.Drawing.Point(12, 104);
            this.TextBoxNoteText.Name = "TextBoxNoteText";
            this.TextBoxNoteText.Size = new System.Drawing.Size(724, 377);
            this.TextBoxNoteText.TabIndex = 8;
            this.TextBoxNoteText.Text = "";
            // 
            // OkButton
            // 
            this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkButton.FlatAppearance.BorderSize = 0;
            this.OkButton.Location = new System.Drawing.Point(542, 489);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(97, 31);
            this.OkButton.TabIndex = 9;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.FlatAppearance.BorderSize = 0;
            this.CancelButton.Location = new System.Drawing.Point(645, 489);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(91, 31);
            this.CancelButton.TabIndex = 10;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 530);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.TextBoxNoteText);
            this.Controls.Add(this.NoteDateModify);
            this.Controls.Add(this.NoteDateCreate);
            this.Controls.Add(this.ComboBoxNoteCategory);
            this.Controls.Add(this.TextBoxNoteTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NoteForm";
            this.Text = "Add/Edit Note";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxNoteTitle;
        private System.Windows.Forms.ComboBox ComboBoxNoteCategory;
        private System.Windows.Forms.DateTimePicker NoteDateCreate;
        private System.Windows.Forms.DateTimePicker NoteDateModify;
        private System.Windows.Forms.RichTextBox TextBoxNoteText;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
    }
}