using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp.Model
{
	public class Project
	{
		/// <summary>
		/// Список заметок
		/// </summary>
		public List<Note> Notes { get; set; }

		/// <summary>
		/// Конструктор класса
		/// </summary>
		public Project()
		{
			Notes = new List<Note>();
		}

		/// <summary>
		/// Функция сортировки всех заметок по убыванию
		/// </summary>
		/// <param name="notes">Передаваемый список заметок</param>
		/// <returns></returns>
		public List<Note> SortByModificationTime(List<Note> notes)
		{
			notes = notes.OrderByDescending(note =>
				note.LastModifiedTime).ToList();
			return notes;
		}

		/// <summary>
		/// Функция выборки всех заметок по передаваемой категории
		/// </summary>
		/// <param name="notes">Передаваемый список заметок</param>
		/// <param name="noteCategory">Передаваемая категория заметки</param>
		/// <returns></returns>
		public List<Note> SearchByCategory(List<Note> notes, NoteCategory noteCategory)
		{
			notes = Notes.Where(note =>
				note.Category == noteCategory).ToList();
			return notes;
		}

	}

}
