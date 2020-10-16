using Application.Interfaces;
using Application.ViewModels;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Application.Services
{
    public class CommentServices : ICommentServices
    {
        public ICommentRepository _commentRepository;
        public CommentServices(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }
        public List<CommentVM> GetComments(int photoId)
        {
            var _commentsResult = _commentRepository.GetCommentByPhoto(photoId);
            List<CommentVM> comments = _commentsResult.Select(a => new CommentVM() { id = a.Id, postId=a.PostId, name=a.Name, email=a.Email, body = a.Body}).ToList();
            return comments; 
        }
    }
}


