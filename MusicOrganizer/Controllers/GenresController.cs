using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using MusicOrganizer.Models;

namespace MusicOrganizer.Controllers
{
  public class GenresController : Controller
  {
    [HttpGet("/genres")]
    public ActionResult Index()
    {
      List<Genre> allGenres = Genre.GetAll();
      return View(allGenres);
    }

    [HttpGet("/genres/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/genres")]
    public ActionResult Create(string type)
    {
      Genre newGenre = new Genre(type);
      return RedirectToAction("Index");
    }

    [HttpGet("/genres/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Genre selectedGenre = Genre.Find(id);
      List<Record> genreRecords = selectedGenre.Records;
      model.Add("genre", selectedGenre);
      model.Add("records", genreRecords);
      return View(model);
    }

  }
}