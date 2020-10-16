using Application.Interfaces;
using Application.ViewModels;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Application.Services
{
    public class PhotoServices : IPhotoServices
    {
        public IPhotoRepository _photoRepository;
        public PhotoServices(IPhotoRepository photoRepository)
        {
            _photoRepository = photoRepository;
        }
        public List<PhotoVM> GetPhotos(int AlbumId)
        { 
            var _photosResult = _photoRepository.GetPhotos(AlbumId);
            List<PhotoVM> Photos = _photosResult.Select(a => new PhotoVM() { id = a.Id, title = a.Title , url = a.Url, thumbnailUrl = a.ThumbnailUrl}).ToList();
            return Photos; 
        }
    }
}
