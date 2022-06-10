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
    public partial class NoteForm : Form
    {
        /// <summary>
        /// Переменная заметки.
        /// </summary>
        private Note _note = new Note();

        /// <summary>
        /// Переменная заметки.
        /// </summary>
        private Note _noteCopy = new Note();

        /// <summary>
        /// Строка для вывода ошибки.
        /// </summary>
        private string _noteError;

        /// <summary>
        /// Константа для корректного цвета. 
        /// </summary>
        private readonly Color _correctColor = Color.White;

        /// <summary>
        /// Константа для цвета ошибки.
        /// </summary>
        private readonly Color _errorColor = Color.LightPink;

        /// <summary>
        /// Переменная класса, представляющего из себя два словаря типа 
        /// <Enum, String> и <String, Enum> 
        /// </summary>
        private NoteCategoryTools _noteCategoryTools = new NoteCategoryTools();


        /// <summary>
        /// Конструктор формы.
        /// </summary>
        public NoteForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Задает и возвращает объект заметки.
        /// </summary>
        public Note Note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
                if (_note!=null)
                {
                    _noteCopy = (Note)_note.Clone();
                }
                else
                {
                    _noteCopy = new Note();
                }
                UpdateForm();
            }
        }

        /// <summary>
        /// Метод обновления формы.
        /// </summary>
        private void UpdateForm()
        {
            ComboBoxNoteCategory.SelectedItem = _noteCategoryTools.CategoriesByEnum[_noteCopy.Category];
            TextBoxNoteTitle.Text = _noteCopy.Name;
            NoteDateCreate.Value = _noteCopy.CreationDate;
            NoteDateModify.Value = _noteCopy.LastModifiedTime;
            TextBoxNoteText.Text = _noteCopy.Text;
        }

        /// <summary>
        /// Метод обновления заметки.
        /// </summary>
        private void UpdateObject()
        {
            _noteCopy.Category = _noteCategoryTools.CategoriesByString
                [ComboBoxNoteCategory.SelectedItem.ToString()];
            _noteCopy.Name = TextBoxNoteTitle.Text;
            _noteCopy.Text = TextBoxNoteText.Text;
        }

        /// <summary>
        /// Метод обработки и валидации названия заметки.
        /// </summary>
        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _noteCopy.Name = TextBoxNoteTitle.Text;
                TextBoxNoteTitle.BackColor = _correctColor;
                _noteError = "";
            }
            catch(ArgumentException exception)
            {
                TextBoxNoteTitle.BackColor = _errorColor;
                _noteError = exception.Message;
            }
        }

        /// <summary>
        /// Проверка на анличие ошибок в форме.
        /// </summary>
        private bool CheckFormOnErrors()
        {
            if(_noteError != "")
            {
                MessageBox.Show(_noteError);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (CheckFormOnErrors())
            {
                UpdateObject();
                _note = _noteCopy;
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
