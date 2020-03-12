using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicOrganizer.Models;
using System.Collections.Generic;
using System;

namespace MusicOrganizer.TestTools
{
  [TestClass]
  public class GenreTest : IDisposable
  {
    public void Dispose()
    {
      Genre.ClearAll();
    }
    [TestMethod]
    public void GenreConstructor_CreatesInstanceOfGenre_Genre()
    {
      Genre newGenre = new Genre("Test");

      Assert.AreEqual(typeof(Genre), newGenre.GetType());
    }
    [TestMethod]
    public void GetType_ReturnsType_String()
    {
      //Arrange
      string type = "Rock";
      Genre newGenre = new Genre(type);

      //Act
      string result = newGenre.Type;

      //Assert 
      Assert.AreEqual(type, result);   
    }
    [TestMethod]
    public void GetId_ReturnId_Int()
    {
      //Arrange
      Genre newGenre = new Genre("Test");
      //Act 
      int result = newGenre.Id;
      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllGenreObjects_GenreList()
    {
      //Arrange
      Genre newGenre1 = new Genre("string1");
      Genre newGenre2 = new Genre("string2");
      
      List<Genre> newList = new List<Genre> { newGenre1, newGenre2 };

      //Act
      List<Genre> result = Genre.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void Find_ReturnsCorrectGenre_Genre()
    {
    //Arrange 
    Genre newGenre1 = new Genre("string1");
    Genre newGenre2 = new Genre("string2");
    
    //Act
    Genre result = Genre.Find(1);

    //Assert
    Assert.AreEqual(newGenre1, result);
    }
    [TestMethod]
    public void AddRecord_AssociatesRecordWithGenre_RecordList()
    {
      //Arrange
      Record newRecord = new Record("title", "artist");
      List<Record> newList = new List<Record> { newRecord };
      Genre newGenre = new Genre("title");
      newGenre.AddRecord(newRecord);
      //Act

      List<Record> result = newGenre.Records;

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
  }
}