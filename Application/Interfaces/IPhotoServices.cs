using Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces
{
    public interface IPhotoServices
    {
        List<PhotoVM> GetPhotos(int AlbumId); 
    }
}