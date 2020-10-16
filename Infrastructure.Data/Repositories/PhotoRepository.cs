using Domain.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Microsoft.Extensions.Options;
using Infrastructure.Data.Persistance;

namespace Infrastructure.Data.Repositories
{
    public class PhotoRepository : IPhotoRepository
    { 
        private AlbumAPIConfig _photoURL;

        public PhotoRepository(IOptions<AlbumAPIConfig> _config)
        {
            _photoURL = _config.Value; 
        }

        public List<Photo> GetPhotos(int albumId)
        {
            string resourceUrl = _photoURL.Photos;
            var photos = ApiRestUtil.MyRequest<List<Photo>>(resourceUrl, albumId);
            return photos;
        } 
    }
}
