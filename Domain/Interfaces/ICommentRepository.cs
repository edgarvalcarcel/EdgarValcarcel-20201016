using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface ICommentRepository
    {
        List<Comment> GetCommentByPhoto(int photoId); 
    }
}
