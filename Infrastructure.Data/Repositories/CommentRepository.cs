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
    public class CommentRepository : ICommentRepository
    { 
        private AlbumAPIConfig _commentURL;
        public CommentRepository(IOptions<AlbumAPIConfig> _config)
        {
            _commentURL = _config.Value; 
        }
        public List<Comment> GetCommentByPhoto(int photoId)
        {
            string resourceUrl = _commentURL.Comments;
            var comments = ApiRestUtil.MyRequest<List<Comment>>(resourceUrl, photoId);
            return comments;
        }
    }
}
