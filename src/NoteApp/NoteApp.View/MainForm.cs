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

        /// <summary>
        /// Список отображаемых заметок на экране
        /// </summary>
        private List<Note> _currentNotes;

        /// <summary>
        /// Переменная класса, представляющего из себя два словаря типа 
        /// <Enum, String> и <String, Enum> 
        /// </summary>
        private NoteCategoryTools _noteCategoryTools = new NoteCategoryTools();

        /// <summary>
        /// Показывать все заметки без учета категории
        /// </summary>
        private const string _allCategory = "All";

        /// <summary>
        /// Экземпляр класс ProjectSerializer для сереализации.
        /// </summary>
        private ProjectSerializer _projectSerializer = new ProjectSerializer();


        public MainForm()
        {
            InitializeComponent();
            _project = _projectSerializer.LoadFromFile();
            CategoryComboBox.SelectedIndex = 0;
            ClearSelectedNote();
        }

        /// <summary>
        /// Поиск индекса в списке заметок по индексу заметки из текущей категории
        /// </summary>
        private int FindNoteIndex(int index)
        {
            int resultIndex = 0;
            for (int i = 0; i < _project.Notes.Count; i++)
            {
                if (_project.Notes[i] == _currentNotes[index])
                {
                    resultIndex = i;
                    break;
                }
            }
            return resultIndex;
        }

        /// <summary>
        /// Вывод на экран списка заметок по выбранной категории
        /// </summary>
        private void OutputByCategory()
        {
            if (CategoryComboBox.SelectedItem.ToString() != _allCategory)
            {
                NoteCategory noteCategory = _noteCategoryTools.CategoriesByString
                    [CategoryComboBox.SelectedItem.ToString()];
                _currentNotes = _project.SearchByCategory(_project.Notes, noteCategory);
            }
            else
            {
                _currentNotes = _project.SortByModificationTime(_project.Notes);
            }
        }

        /// <summary>
        /// Обновляет список заметок в ListBox.
        /// </summary>
        private void UpdatedListBox()
        {
            NotesListBox.Items.Clear();
            _currentNotes = _project.SortByModificationTime(_currentNotes);
            for (int i = 0; i < _currentNotes.Count; i++)
            {
                NotesListBox.Items.Add(_currentNotes[i].Name);
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
                _project.Notes.Add(noteForm.Note);
                OutputByCategory();
                UpdatedListBox();
                NotesListBox.SelectedIndex = -1;
                _projectSerializer.SaveToFile(_project);
            }
        }

        /// <summary>
        /// Редактирование существующей заметки.
        /// </summary>
        private void EditNote(int index)
        {
            if (index == -1)
            {
                return;
            }
            int currentIndex = index;
            Note note = _currentNotes[index];
            index = FindNoteIndex(index);
            NoteForm noteForm = new NoteForm();
            noteForm.Note = _project.Notes[index];
            noteForm.ShowDialog();
            _project.Notes[index] = noteForm.Note;
            if (noteForm.DialogResult == DialogResult.OK)
            {
                currentIndex = -1;
                OutputByCategory();
                UpdateSelectedNote(NotesListBox.SelectedIndex);
                UpdatedListBox();
                _projectSerializer.SaveToFile(_project);
            }
            if ((NotesListBox.Items.Count != 0) && (currentIndex < NotesListBox.Items.Count))
            {
                NotesListBox.SelectedIndex = currentIndex;
            }
        }

        /// <summary>
        /// Добавление тестовых заметок.
        /// </summary>
        private void AddRandomNotes()
        {
            string[] testNoteTitle = { "Test1", "Test2", "Test3", "Test4", "Test5" };
            string[] testNoteText = { "Hello", "Bye", "Good morning", "Good afternoon",
                                        "Good evening", "Good night" };
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                int enumIndex = random.Next(0, 7);
                int titleIndex = random.Next(0, testNoteTitle.Length - 1);
                int textIndex = random.Next(0, testNoteText.Length - 1);
                NoteCategory randomNoteCategoryEnum = (NoteCategory)enumIndex;
                string randomNoteTitle = testNoteTitle[titleIndex];
                string randomNoteText = testNoteText[textIndex];
                _project.Notes.Add(new Note(randomNoteTitle, randomNoteCategoryEnum,
                    randomNoteText, DateTime.Now, DateTime.Now));
            }
            _projectSerializer.SaveToFile(_project);
        }

        /// <summary>
        /// Удаляет заметку из ListBox и _project.
        /// </summary>
        private void RemoveNote(int index)
        {
            if(index == -1)
            {
                return;
            }
            int currentIndex = index;
            Note note = _project.Notes[index];
            index = FindNoteIndex(index);
            var result = MessageBox.Show("Do you really want to remove " + "\"" + NotesListBox.SelectedItem.ToString() 
                + "\"" + "?", "Deleting a note", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, 
                MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK)
            {
                _project.Notes.RemoveAt(index);
                ClearSelectedNote();
                OutputByCategory();
                UpdatedListBox();
                _projectSerializer.SaveToFile(_project);
            }
            if ((NotesListBox.Items.Count != 0) && (currentIndex < NotesListBox.Items.Count))
            {
                NotesListBox.SelectedIndex = currentIndex;
            }
        }

        /// <summary>
        /// Метод для заполнения RichTextBox.
        /// </summary>
        private void UpdateSelectedNote(int index)
        {
            if ((index == -1) || (_currentNotes.Count == 0) || (_currentNotes.Count <= index))
            {
                ClearSelectedNote();
                return;
            }
            Note note = _currentNotes[index];
            TextBoxNoteText.Text = note.Text;
            LabelSelectedCategoryNote.Text = _noteCategoryTools.CategoriesByEnum[note.Category];
            LabelNoteName.Text = note.Name;
            NoteDateCreate.Visible = true;
            NoteDateModify.Visible = true;
            NoteDateCreate.Value = note.CreationDate;
            NoteDateModify.Value = note.LastModifiedTime;
        }

        /// <summary>
        /// Метод для очистки RichTextBox.
        /// </summary>
        private void ClearSelectedNote()
        {
            LabelNoteName.Text = "";
            TextBoxNoteText.Text = "";
            LabelSelectedCategoryNote.Text = "";
            NoteDateCreate.Visible = false;
            NoteDateModify.Visible = false;
        }

        /// <summary>
        /// Метод для обновления RichTextBox.
        /// </summary>
        private void NotesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NotesListBox.SelectedIndex == -1)
            {
                ClearSelectedNote();
            }
            else
            {
                UpdateSelectedNote(NotesListBox.SelectedIndex);
            }
        }

        private void NewNoteButton_Click(object sender, EventArgs e)
        {
            AddNote();
            UpdatedListBox();
        }

        private void EditNoteButton_Click(object sender, EventArgs e)
        {
            EditNote(NotesListBox.SelectedIndex);
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
                MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void editNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditNote(NotesListBox.SelectedIndex);
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
            AddRandomNotes();
            OutputByCategory();
            UpdatedListBox();
        }

        /// <summary>
        /// Обновляет список заметок с учетом выбранной категории
        /// </summary>
        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearSelectedNote();
            OutputByCategory();
            UpdatedListBox();
        }
    }
}
