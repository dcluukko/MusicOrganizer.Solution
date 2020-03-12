using System.Collections.Generic;
using System;

namespace MusicOrganizer.Models
{
  public class Genre 
  {
    private static List<Genre> _genres = new List<Genre> { };
    public string Type { get; set;}
    public int Id { get; }
    public List<Record> Records { get; set; }

  public Genre(string genreType)
  {
    Type = genreType;
    _genres.Add(this);
    Id = _genres.Count;
    Records = new List<Record> { };
  }
  public static void ClearAll()
  {
    _genres.Clear();
  }
  }
}