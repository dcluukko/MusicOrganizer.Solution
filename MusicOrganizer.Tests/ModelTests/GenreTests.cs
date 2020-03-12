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
  }
}