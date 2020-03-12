using System.Collections.Generic;

namespace MusicOrganizer.Models
{
  public class Record
  {
    public string Artist { get; set; }
    public string Title { get; set; }

    public Record( string artist, string title )
    {
      Artist = artist;
      Title = title;
    }
  }

}