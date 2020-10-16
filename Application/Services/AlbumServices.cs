using Application.Interfaces;
using Application.ViewModels;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Application.Services
{
    public class AlbumServices : IAlbumServices
    {
        public IAlbumRepository _albumRepository;
        public AlbumServices(IAlbumRepository albumRepository)
        {
            _albumRepository = albumRepository;
        }
        public List<AlbumVM> GetAlbums()
        { 
            var _albumsResult = _albumRepository.GetAllAlbums();
            List<AlbumVM> Albums = _albumsResult.Select(a => new AlbumVM() { id = a.Id, title = a.Title }).ToList();
            return Albums; 
        }
    }
}
