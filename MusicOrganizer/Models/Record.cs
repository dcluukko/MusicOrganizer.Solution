using System.Collections.Generic;

namespace MusicOrganizer.Models
{
  public class Record
  {
    public string Artist { get; set; }
    public string Title { get; set; }
    public int Id { get; }
    private static List<Record> _records = new List<Record> { };

    public Record( string artist, string title )
    {
      Artist = artist;
      Title = title;
      _records.Add(this);
      Id = _records.Count;
    }

    public static List<Record> GetAll()
    {
      return _records;
    }

    public static void ClearAll()
    {
      _records.Clear();
    }

    public static Record Find(int id)
    {
      return _records[id - 1];
    }
  }
}