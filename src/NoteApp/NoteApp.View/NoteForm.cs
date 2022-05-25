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
        /// Конструктор формы.
        /// </summary>
        public NoteForm()
        {
            InitializeComponent();
            CategoryComboBox.DataSource = Enum.GetValues(typeof(NoteCategory));
            UpdateForm();
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
            }
        }

        /// <summary>
        /// Метод обновления формы.
        /// </summary>
        private void UpdateForm()
        {
            NameTextBox.Text = _note.Name;
            CategoryComboBox.SelectedItem = _note.Category.ToString();
            NoteRichTextBox.Text = _note.Text;
        }

        /// <summary>
        /// Метод обновления заметки.
        /// </summary>
        private void UpdateObject()
        {
            _note.Name = NameTextBox.Text;
            _note.Category = (NoteCategory)Enum.Parse(typeof(NoteCategory),
                CategoryComboBox.SelectedValue.ToString());
            _note.Text = NoteRichTextBox.Text;
        }

        /// <summary>
        /// Метод обработки и валидации названия заметки.
        /// </summary>
        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _note.Name = NameTextBox.Text;
                NameTextBox.BackColor = _correctColor;
                _noteError = "";
            }
            catch(ArgumentException exception)
            {
                NameTextBox.BackColor = _errorColor;
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
            CheckFormOnErrors();
            UpdateObject();
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
