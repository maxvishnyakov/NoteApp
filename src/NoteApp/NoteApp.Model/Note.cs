using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp.Model
{
	/// <summary>
	/// Описывает заметку.
	/// </summary>
	public class Note : ICloneable
	{
		/// <summary>
		/// Название заметки.
		/// </summary>
		private string _name = "Без названия";

		/// <summary>
		/// Категория заметки.
		/// </summary>
		private NoteCategory _category;

		/// <summary>
		/// Текст заметки.
		/// </summary>
		private string _text;

		/// <summary>
		/// Дата создания заметки.
		/// </summary>
		private DateTime _creationDate = DateTime.Now;

		/// <summary>
		/// Время последнего изменения заметки.
		/// </summary>
		private DateTime _lastModifiedTime;

		/// <summary>
		/// Задает и возвращает имя заметки.
		/// </summary>
		public string Name
		{
			get
			{
				return _name;
			}
			set
			{
				if (value.Length > 50)
				{
					throw new ArgumentException(
						$"The number of letters in the title must be less than 50"
						+ $" But was {value.Length}");
				}
				_name = value;
				_lastModifiedTime = DateTime.Now;
			}
		}

		/// <summary>
		/// Задает и возвращает категорию заметки.
		/// </summary>
		public NoteCategory Category
		{
			get
			{
				return _category;
			}
			set
			{
				_category = value;
				_lastModifiedTime = DateTime.Now;
			}
		}

		/// <summary>
		/// Задает и возвращает текст заметки.
		/// </summary>
		public string Text
		{
			get
			{
				return _text;

			}
			set
			{
				_text = value;
				_lastModifiedTime = DateTime.Now;
			}
		}

		/// <summary>
		/// Возвращает дату создания заметки.
		/// </summary>
		public DateTime CreationDate
		{
			get
			{
				return _creationDate;
			}
		}

		/// <summary>
		/// Возвращает время послденего изменения заметки.
		/// </summary>
		/// <returns></returns>
		public DateTime LastModifiedTime
		{
			get
			{
				return _lastModifiedTime;
			}
		}

		/// <summary>
		/// Создает экземпляр заметки.
		/// </summary>
		public Note(string name, NoteCategory category, string text)
		{
			Name = name;
			Category = category;
			Text = text;
		}

        public Note()
        {
        }

        /// <summary>
        /// Метод копирования.
        /// </summary>
        /// <returns></returns>
        public object Clone()
		{
			return new Note(Name, Category, Text);
		}
	}
}
