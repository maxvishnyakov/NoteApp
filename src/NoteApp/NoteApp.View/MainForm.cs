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
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NotesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NoteRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewNoteButton_Click(object sender, EventArgs e)
        {
            NoteForm noteForm = new NoteForm();
            noteForm.ShowDialog();
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
    }
}
