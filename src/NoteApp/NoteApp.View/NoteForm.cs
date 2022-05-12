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
        /// Конструктор формы.
        /// </summary>
        public NoteForm()
        {
            InitializeComponent();
            _note.Name = "TestHome";
            _note.Category = NoteCategory.Home;
            _note.Text = "TextHome";
            UpdateForm();
        }

        /// <summary>
        /// Метод обновления формы.
        /// </summary>
        private void UpdateForm()
        {
            TitleTextBox.Text = _note.Name;
            CategoryComboBox.Text = _note.Category.ToString();
            NoteRichTextBox.Text = _note.Text;
        }

        /// <summary>
        /// Метод обновления заметки.
        /// </summary>
        private void UpdateObject()
        {
            _note.Name = TitleTextBox.Text;
            _note.Category = (NoteCategory)CategoryComboBox.SelectedItem;
            _note.Text = NoteRichTextBox.Text;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Метод обработки и валидации названия заметки.
        /// </summary>
        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _note.Name = TitleTextBox.Text;
                TitleTextBox.BackColor = Color.White;
                _noteError = "";
            }
            catch(ArgumentException exception)
            {
                TitleTextBox.BackColor = Color.LightPink;
                _noteError = exception.Message;
            }
        }

        /// <summary>
        /// Проверка на анличие ошибок в форме.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Обработчик кнопки "Ok".
        /// </summary>
        private void OkButton_Click(object sender, EventArgs e)
        {
            CheckFormOnErrors();
            UpdateObject();
        }

        /// <summary>
        /// Обработчик кнопки "Cancel".
        /// </summary>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
