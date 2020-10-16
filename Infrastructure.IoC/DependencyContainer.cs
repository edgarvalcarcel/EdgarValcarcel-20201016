using Application.Interfaces;
using Application.Services;
using Domain.Interfaces;
using Infrastructure.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IAlbumServices, AlbumServices>();
            services.AddScoped<IPhotoServices, PhotoServices>();
            services.AddScoped<ICommentServices, CommentServices>();
            //*-------------------------------------------------------*
            services.AddScoped<IAlbumRepository, AlbumRepository>();
            services.AddScoped<IPhotoRepository, PhotoRepository>();
            services.AddScoped<ICommentRepository, CommentRepository>();  
        }
    }
}
