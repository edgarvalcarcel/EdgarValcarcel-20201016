using Application.Interfaces;
using Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using System.Collections.Generic;
using System.Diagnostics;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAlbumServices _albumServices;
        private readonly IPhotoServices _photoServices;
        private readonly ICommentServices _commentServices;

        public HomeController(IAlbumServices albumServices, IPhotoServices photoServices, ICommentServices commentServices)
        {
            _albumServices = albumServices;
            _photoServices = photoServices;
            _commentServices = commentServices;
        }
        public IActionResult Index()
        {
            List<AlbumVM> model = _albumServices.GetAlbums();
            return View(model);
        }
        public IActionResult Modal()
        {
            return PartialView("_DeleteCategory");
        }

        [HttpGet]
        [Route("GetPhotos/{id}")]
        public IActionResult GetPhotos(int id)
        {
            List<PhotoVM> model = _photoServices.GetPhotos(id);
            return PartialView(model);
        }

        [HttpGet]
        [Route("GetCommentsbyPhoto/{id}")]
        public IActionResult GetCommentsbyPhoto(int id)
        {
            List<CommentVM> model = _commentServices.GetComments(id);
            return View("GetComments", model);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
