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
    public class AlbumRepository : IAlbumRepository
    { 
        private AlbumAPIConfig _albumURL;
        public AlbumRepository(IOptions<AlbumAPIConfig> _config)
        { 
            _albumURL = _config.Value; 
        }
        public List<Album> GetAllAlbums()
        { 
            string resourceUrl = _albumURL.Albums;
            var albums = ApiRestUtil.MyRequest<List<Album>>(resourceUrl,0);
            return albums;


        }
    }
}
