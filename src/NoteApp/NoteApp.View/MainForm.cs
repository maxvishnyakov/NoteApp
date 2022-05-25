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
            var noteForm = new NoteForm();
            noteForm.ShowDialog();
            if (noteForm.DialogResult == DialogResult.OK)
            {
                var newData = noteForm.Note;
                _project.Notes.Add(newData);
            }
        }

        /// <summary>
        /// Редактирование существующей заметки.
        /// </summary>
        private void EditNote()
        {
            var selectedIndex = NotesListBox.SelectedIndex;
            Note selectedNote = _project.Notes[selectedIndex];
            Note clonedNote = (Note)selectedNote.Clone();
            var noteForm = new NoteForm();
            noteForm.Note = clonedNote;
            noteForm.ShowDialog();
            if (noteForm.DialogResult == DialogResult.OK)
            {
                var updatedNote = noteForm.Note;
                NotesListBox.Items.RemoveAt(selectedIndex);
                _project.Notes.RemoveAt(selectedIndex);
                _project.Notes.Insert(selectedIndex, updatedNote);
                NotesListBox.Items.Insert(selectedIndex, updatedNote);
            }
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
            label.Text = _project.Notes[index].Name;
            categoryTextBox.Text = _project.Notes[index].Category.ToString();
        }

        /// <summary>
        /// Метод для очистки RichTextBox.
        /// </summary>
        private void ClearSelectedObject()
        {
            NoteRichTextBox.Clear();
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

        private void NewNoteButton_Click(object sender, EventArgs e)
        {
            AddNote();
            UpdatedListBox();
        }

        private void EditNoteButton_Click(object sender, EventArgs e)
        {
            EditNote();
            UpdatedListBox(); ;
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

        private void addNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNote();
            UpdatedListBox();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you really want exit ?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void editNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditNote();
            UpdatedListBox();
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

        private void addRandomObjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int number = random.Next(0, 4);
            Note tmpNote = new Note(NotesName[number], NoteCategory.Miscellaneous, NotesText[number]);
            _project.Notes.Add(tmpNote);
            UpdatedListBox();
        }
    }
}
