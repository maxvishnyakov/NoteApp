using NoteApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteApp.View
{
    public partial class MainForm : Form
    {
        private Project _project = new Project();

        String[] NotesName = {"Основы ЯП", "Рецепт мяса", "Деловая встреча",
            "Запись к врачу","Поход в кино"};

        String[] NotesText = {"Текст 1", "Текст 2" , "Текст 3" ,
            "Текст 4"  , "Текст 5" };
 
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обновляет список заметок в ListBox.
        /// </summary>
        private void UpdatedListBox()
        {
            NotesListBox.Items.Clear();
            for(int i = 0; i < _project.Notes.Count(); ++i)
            {
                NotesListBox.Items.Add(_project.Notes[i].Name);
            }
        }

        /// <summary>
        /// Добавляет новую заметку в список.
        /// </summary>
        private void AddNote()
        {
            Random random = new Random();
            int number = random.Next(0, 4);
            Note tmpNote = new Note(NotesName[number], NoteCategory.Miscellaneous, NotesText[number]);
            _project.Notes.Add(tmpNote);
        }

        /// <summary>
        /// Удаляет заметку из ListBox и _project.
        /// </summary>
        private void RemoveNote(int index)
        {
            if (index > -1)
            {
                var result = MessageBox.Show("Do you really want to remove " + "\"" + NotesListBox.SelectedItem.ToString() 
                    + "\"" + "?", "Deleting a note", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, 
                    MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                if (result == DialogResult.OK)
                {
                    NotesListBox.Items.RemoveAt(index);
                    _project.Notes.RemoveAt(index);
                }
            }
        }

        /// <summary>
        /// Метод для заполнения RichTextBox.
        /// </summary>
        private void UpdateSelectedObject(int index)
        {
            NoteRichTextBox.Text = _project.Notes[index].Text;
            NoteRichTextBox.Show();
        }

        /// <summary>
        /// Метод для очистки RichTextBox.
        /// </summary>
        private void ClearSelectedObject()
        {
            NoteRichTextBox.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Метод для обновления RichTextBox.
        /// </summary>
        private void NotesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NotesListBox.SelectedIndex == -1)
            {
                ClearSelectedObject();
            }
            else
            {
                UpdateSelectedObject(NotesListBox.SelectedIndex);
            }
        }

        private void NoteRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewNoteButton_Click(object sender, EventArgs e)
        {
            AddNote();
            UpdatedListBox();
        }

        private void EditNoteButton_Click(object sender, EventArgs e)
        {
            NoteForm noteForm = new NoteForm();
            noteForm.ShowDialog();
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void fileToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Обработчик кнопки "Exit" главного меню.
        /// </summary>
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you really want exit ?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void addNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNote();
            UpdatedListBox();

            //NoteForm noteForm = new NoteForm();
            //noteForm.ShowDialog();
        }

        private void editNoteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NoteForm noteForm = new NoteForm();
            noteForm.ShowDialog();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void DeleteNoteButton_Click(object sender, EventArgs e)
        {
            RemoveNote(NotesListBox.SelectedIndex);
            UpdatedListBox();
        }

        private void deleteNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveNote(NotesListBox.SelectedIndex);
            UpdatedListBox();
        }
    }
}
