﻿using Konet.Application.Slices.Content.Dtos;
using Konet.Application.Slices.Shared.Dtos;
using Konet.Domain.Content;
using Mapster;

namespace Konet.Infrastructure.Mapping;

public class MapsterSettings
{
    public static void Configure()
    {
        // here we will define the type conversion / Custom-mapping
        // More details at https://github.com/MapsterMapper/Mapster/wiki/Custom-mapping

        // This one is actually not necessary as it's mapped by convention
        // TypeAdapterConfig<Product, ProductDto>.NewConfig().Map(dest => dest.BrandName, src => src.Brand.Name);
        #region VideoMapping

        TypeAdapterConfig<VideoEntity, VideoDto>.NewConfig()
            .Map(dest => dest.OwnerId, src => src.UserId)
            .Map(dest => dest.Title, src => src.Title)
            .Map(dest => dest.Url, src => src.Url)
            .Map(dest => dest.Id, src => src.Id)
            .Map(dest => dest.Thumbnail, src => src.Thumbnail);

        #endregion
    }
}