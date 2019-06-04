﻿using EvenCart.Data.Entity.MediaEntities;
using Microsoft.AspNetCore.Http;

namespace EvenCart.Infrastructure.MediaServices
{
    public interface IMediaAccountant
    {
        Media GetMediaInstance(IFormFile mediaFile, int userId);

        string GetPictureUrl(Media picture, int width = 0, int height = 0, bool returnDefaultIfNotFound = false);

        string GetPictureUrl(Media picture, string size, bool returnDefaultIfNotFound = false);

        string GetVideoUrl(Media media);

        string GetPictureUrl(int pictureId, int width = 0, int height = 0, bool returnDefaultIfNotFound = false);
    }
}