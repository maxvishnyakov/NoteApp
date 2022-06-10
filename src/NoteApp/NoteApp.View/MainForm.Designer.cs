
namespace NoteApp.View
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.DeleteNoteButton = new System.Windows.Forms.Button();
            this.NotesListBox = new System.Windows.Forms.ListBox();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.EditNoteButton = new System.Windows.Forms.Button();
            this.NewNoteButton = new System.Windows.Forms.Button();
            this.ShowCategoryLabel = new System.Windows.Forms.Label();
            this.LabelSelectedCategoryNote = new System.Windows.Forms.Label();
            this.LabelNoteName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxNoteText = new System.Windows.Forms.RichTextBox();
            this.NoteDateCreate = new System.Windows.Forms.DateTimePicker();
            this.NoteDateModify = new System.Windows.Forms.DateTimePicker();
            this.ModifiedLabel = new System.Windows.Forms.Label();
            this.CreatedLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editNoteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRandomObjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.splitContainer1.Panel1.Controls.Add(this.DeleteNoteButton);
            this.splitContainer1.Panel1.Controls.Add(this.NotesListBox);
            this.splitContainer1.Panel1.Controls.Add(this.CategoryComboBox);
            this.splitContainer1.Panel1.Controls.Add(this.EditNoteButton);
            this.splitContainer1.Panel1.Controls.Add(this.NewNoteButton);
            this.splitContainer1.Panel1.Controls.Add(this.ShowCategoryLabel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.splitContainer1.Panel2.Controls.Add(this.LabelSelectedCategoryNote);
            this.splitContainer1.Panel2.Controls.Add(this.LabelNoteName);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.TextBoxNoteText);
            this.splitContainer1.Panel2.Controls.Add(this.NoteDateCreate);
            this.splitContainer1.Panel2.Controls.Add(this.NoteDateModify);
            this.splitContainer1.Panel2.Controls.Add(this.ModifiedLabel);
            this.splitContainer1.Panel2.Controls.Add(this.CreatedLabel);
            this.splitContainer1.Panel2.Controls.Add(this.CategoryLabel);
            this.splitContainer1.Size = new System.Drawing.Size(1020, 522);
            this.splitContainer1.SplitterDistance = 339;
            this.splitContainer1.TabIndex = 0;
            // 
            // DeleteNoteButton
            // 
            this.DeleteNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteNoteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeleteNoteButton.BackgroundImage")));
            this.DeleteNoteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteNoteButton.FlatAppearance.BorderSize = 0;
            this.DeleteNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteNoteButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DeleteNoteButton.Location = new System.Drawing.Point(113, 471);
            this.DeleteNoteButton.Name = "DeleteNoteButton";
            this.DeleteNoteButton.Size = new System.Drawing.Size(43, 44);
            this.DeleteNoteButton.TabIndex = 9;
            this.DeleteNoteButton.UseVisualStyleBackColor = true;
            this.DeleteNoteButton.Click += new System.EventHandler(this.DeleteNoteButton_Click);
            // 
            // NotesListBox
            // 
            this.NotesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NotesListBox.FormattingEnabled = true;
            this.NotesListBox.IntegralHeight = false;
            this.NotesListBox.ItemHeight = 16;
            this.NotesListBox.Location = new System.Drawing.Point(12, 38);
            this.NotesListBox.Name = "NotesListBox";
            this.NotesListBox.Size = new System.Drawing.Size(324, 427);
            this.NotesListBox.TabIndex = 8;
            this.NotesListBox.SelectedIndexChanged += new System.EventHandler(this.NotesListBox_SelectedIndexChanged);
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Items.AddRange(new object[] {
            "All",
            "Documents",
            "Finance",
            "Health and Sports",
            "Home",
            "People",
            "Work",
            "Miscellaneous"});
            this.CategoryComboBox.Location = new System.Drawing.Point(125, 8);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(211, 24);
            this.CategoryComboBox.TabIndex = 7;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // EditNoteButton
            // 
            this.EditNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditNoteButton.BackColor = System.Drawing.SystemColors.Menu;
            this.EditNoteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditNoteButton.BackgroundImage")));
            this.EditNoteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditNoteButton.FlatAppearance.BorderSize = 0;
            this.EditNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditNoteButton.Location = new System.Drawing.Point(62, 471);
            this.EditNoteButton.Name = "EditNoteButton";
            this.EditNoteButton.Size = new System.Drawing.Size(45, 46);
            this.EditNoteButton.TabIndex = 5;
            this.EditNoteButton.UseVisualStyleBackColor = false;
            this.EditNoteButton.Click += new System.EventHandler(this.EditNoteButton_Click);
            // 
            // NewNoteButton
            // 
            this.NewNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NewNoteButton.BackColor = System.Drawing.SystemColors.Menu;
            this.NewNoteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NewNoteButton.BackgroundImage")));
            this.NewNoteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NewNoteButton.FlatAppearance.BorderSize = 0;
            this.NewNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewNoteButton.Location = new System.Drawing.Point(12, 469);
            this.NewNoteButton.Name = "NewNoteButton";
            this.NewNoteButton.Size = new System.Drawing.Size(44, 46);
            this.NewNoteButton.TabIndex = 4;
            this.NewNoteButton.UseVisualStyleBackColor = false;
            this.NewNoteButton.Click += new System.EventHandler(this.NewNoteButton_Click);
            // 
            // ShowCategoryLabel
            // 
            this.ShowCategoryLabel.AutoSize = true;
            this.ShowCategoryLabel.Location = new System.Drawing.Point(12, 11);
            this.ShowCategoryLabel.Name = "ShowCategoryLabel";
            this.ShowCategoryLabel.Size = new System.Drawing.Size(107, 17);
            this.ShowCategoryLabel.TabIndex = 3;
            this.ShowCategoryLabel.Text = "Show Category:";
            // 
            // LabelSelectedCategoryNote
            // 
            this.LabelSelectedCategoryNote.AutoSize = true;
            this.LabelSelectedCategoryNote.Location = new System.Drawing.Point(85, 64);
            this.LabelSelectedCategoryNote.Name = "LabelSelectedCategoryNote";
            this.LabelSelectedCategoryNote.Size = new System.Drawing.Size(120, 17);
            this.LabelSelectedCategoryNote.TabIndex = 20;
            this.LabelSelectedCategoryNote.Text = "SelectedCategory";
            // 
            // LabelNoteName
            // 
            this.LabelNoteName.AutoSize = true;
            this.LabelNoteName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNoteName.Location = new System.Drawing.Point(6, 11);
            this.LabelNoteName.Name = "LabelNoteName";
            this.LabelNoteName.Size = new System.Drawing.Size(155, 38);
            this.LabelNoteName.TabIndex = 19;
            this.LabelNoteName.Text = "Заметка";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 38);
            this.label1.TabIndex = 18;
            // 
            // TextBoxNoteText
            // 
            this.TextBoxNoteText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxNoteText.Location = new System.Drawing.Point(13, 117);
            this.TextBoxNoteText.Name = "TextBoxNoteText";
            this.TextBoxNoteText.Size = new System.Drawing.Size(653, 393);
            this.TextBoxNoteText.TabIndex = 17;
            this.TextBoxNoteText.Text = "";
            // 
            // NoteDateCreate
            // 
            this.NoteDateCreate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.NoteDateCreate.Location = new System.Drawing.Point(78, 89);
            this.NoteDateCreate.Name = "NoteDateCreate";
            this.NoteDateCreate.Size = new System.Drawing.Size(127, 22);
            this.NoteDateCreate.TabIndex = 13;
            // 
            // NoteDateModify
            // 
            this.NoteDateModify.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.NoteDateModify.Location = new System.Drawing.Point(291, 89);
            this.NoteDateModify.Name = "NoteDateModify";
            this.NoteDateModify.Size = new System.Drawing.Size(127, 22);
            this.NoteDateModify.TabIndex = 12;
            // 
            // ModifiedLabel
            // 
            this.ModifiedLabel.AutoSize = true;
            this.ModifiedLabel.Location = new System.Drawing.Point(220, 91);
            this.ModifiedLabel.Name = "ModifiedLabel";
            this.ModifiedLabel.Size = new System.Drawing.Size(65, 17);
            this.ModifiedLabel.TabIndex = 11;
            this.ModifiedLabel.Text = "Modified:";
            // 
            // CreatedLabel
            // 
            this.CreatedLabel.AutoSize = true;
            this.CreatedLabel.Location = new System.Drawing.Point(10, 91);
            this.CreatedLabel.Name = "CreatedLabel";
            this.CreatedLabel.Size = new System.Drawing.Size(62, 17);
            this.CreatedLabel.TabIndex = 10;
            this.CreatedLabel.Text = "Created:";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(10, 64);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(69, 17);
            this.CategoryLabel.TabIndex = 9;
            this.CategoryLabel.Text = "Category:";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.editToolStripMenuItem1,
            this.helpToolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1020, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNoteToolStripMenuItem,
            this.editNoteToolStripMenuItem1,
            this.deleteNoteToolStripMenuItem,
            this.addRandomObjectToolStripMenuItem});
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem1.Text = "Edit";
            // 
            // addNoteToolStripMenuItem
            // 
            this.addNoteToolStripMenuItem.Name = "addNoteToolStripMenuItem";
            this.addNoteToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.addNoteToolStripMenuItem.Text = "Add Note";
            this.addNoteToolStripMenuItem.Click += new System.EventHandler(this.addNoteToolStripMenuItem_Click);
            // 
            // editNoteToolStripMenuItem1
            // 
            this.editNoteToolStripMenuItem1.Name = "editNoteToolStripMenuItem1";
            this.editNoteToolStripMenuItem1.Size = new System.Drawing.Size(228, 26);
            this.editNoteToolStripMenuItem1.Text = "Edit Note";
            this.editNoteToolStripMenuItem1.Click += new System.EventHandler(this.editNoteToolStripMenuItem_Click);
            // 
            // deleteNoteToolStripMenuItem
            // 
            this.deleteNoteToolStripMenuItem.Name = "deleteNoteToolStripMenuItem";
            this.deleteNoteToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.deleteNoteToolStripMenuItem.Text = "Delete Note";
            this.deleteNoteToolStripMenuItem.Click += new System.EventHandler(this.deleteNoteToolStripMenuItem_Click);
            // 
            // addRandomObjectToolStripMenuItem
            // 
            this.addRandomObjectToolStripMenuItem.Name = "addRandomObjectToolStripMenuItem";
            this.addRandomObjectToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.addRandomObjectToolStripMenuItem.Text = "Add Random Object";
            this.addRandomObjectToolStripMenuItem.Click += new System.EventHandler(this.addRandomObjectToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(133, 26);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 550);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "NoteApp";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label ShowCategoryLabel;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Button EditNoteButton;
        private System.Windows.Forms.Button NewNoteButton;
        private System.Windows.Forms.DateTimePicker NoteDateCreate;
        private System.Windows.Forms.DateTimePicker NoteDateModify;
        private System.Windows.Forms.Label ModifiedLabel;
        private System.Windows.Forms.Label CreatedLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.ListBox NotesListBox;
        private System.Windows.Forms.Button DeleteNoteButton;
        private System.Windows.Forms.RichTextBox TextBoxNoteText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelNoteName;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editNoteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRandomObjectToolStripMenuItem;
        private System.Windows.Forms.Label LabelSelectedCategoryNote;
    }
}

