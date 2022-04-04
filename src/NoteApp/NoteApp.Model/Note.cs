using System;

public class Note : ICloneable
{
	private string _name = "Без названия" { get; set; }

	private string _categoryNote { get; set; }

	private string _textNote { get; set; }

	private DateTime _creationDate { get; set; }

	private DateTime _lastModifiedTime { get; set; }

	public Note(string name, string categoryNote, string textNote, DateTime creationDate)
    {
		SetName(string name);
		SetCategoryNote(string categoryNote);
		SetTextNote(string textNote);
		_creationDate = creationDate;
	}

	public void SetName (string name, DateTime lastModifiedTime)
    {
		_name = name;
		_lastModifiedTime = lastModifiedTime;

	}

	public void SetCategoryNote(string categoryNote, DateTime lastModifiedTime)
	{
		_categoryNote = categoryNote;
		_lastModifiedTime = lastModifiedTime;
	}

	public void SetTextNote(string textNote, DateTime lastModifiedTime)
    {
		_textNote = textNote;
		_lastModifiedTime = lastModifiedTime;
	}

	public string GetName()
    {
		return _name;
    }

	public string GetCategoryNote()
	{
		return _categoryNote;
	}

	public string GetTextNote()
	{
		return _textNote;
	}

	public DateTime GetCreationDate()
    {
		return _creationDate;
    }

	public DateTime GetLastModifiedTime()
	{
		return _creationDate;
	}

	public object Clone()
    {
		return new Note(string name, string categoryNote, string textNote, 
			DateTime creationDate);
    }
}
