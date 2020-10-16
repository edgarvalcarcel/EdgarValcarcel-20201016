using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IPhotoRepository
    {
        List<Photo> GetPhotos(int AlbumId); 
    }
}
