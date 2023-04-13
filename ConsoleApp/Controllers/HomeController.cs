using ConsoleApp.ConsoleRepository;
using ConsoleApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Dynamic;

namespace ConsoleApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly NameRepository _namerepository = null;
       
        public HomeController()
        {
            _namerepository = new NameRepository();
        }
                
        public ActionResult Index()
        {

            //dynamic data = new ExpandObject();

            //data.Id = 1;
            //data.Name = "Nice";
            //ViewBag.Data = data;
            ViewBag.Type = new ConsoleModel() { ArtistName = "Deepak", SongId = 2 };
            return View();
        }
        public ActionResult UploadSong()
        {
            return View();
        }
        public ActionResult AllSong()
        {
            var name = _namerepository.GetAllSong();
            return View(name);
        }
        public ViewResult SearchSong(string song)
        {
            var searchsong = _namerepository.SearchByName(song);
            return View(searchsong);
        }

        [Route("Song-Dtails/{id}",Name ="Song")]
        public ViewResult GetSong(int id)
        {
            var a = _namerepository.GetById(id);
            return View(a);
           
        }
        public ActionResult AboutUs()
        {
            return View();
        }
        public ActionResult ContactUs()
        {
            return View();
        }

       
    }
}

