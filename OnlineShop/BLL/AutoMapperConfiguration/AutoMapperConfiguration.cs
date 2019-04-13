using AutoMapper;
using BLL.DTO;
using DAL.DataEntities;

namespace BLL.AutoMapperConfiguration
{
    public static class AutoMapperConfiguration 
    {
        public static void Initialize()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<CategoryDescription, CategoryDescriptionDto>()
                    .ForMember(destination => destination.Id, opt => opt.MapFrom(source => source.Id))
                    .ForMember(destination => destination.Description, opt => opt.MapFrom(source => source.Description))
                    .ReverseMap();

                cfg.CreateMap<Order, OrderDto>()
                    .ForMember(destination => destination.Id, opt => opt.MapFrom(source => source.Id))
                    .ForMember(destination => destination.DateOfCreation,opt => opt.MapFrom(source => source.DateOfCreation))
                    .ForMember(destination => destination.ProductId, opt => opt.MapFrom(source => source.Product.Id)).MaxDepth(1)
                    .ForMember(destination => destination.StageId, opt => opt.MapFrom(source => source.Stage.Id)).MaxDepth(1)
                    .ForMember(destination => destination.Amount, opt => opt.MapFrom(source => source.Amount))
                    .ForMember(destination => destination.ProductPrice, opt => opt.MapFrom(source => source.ProductPrice))
                    .ReverseMap();

                cfg.CreateMap<Product, ProductDto>()
                    .ForMember(destination => destination.Id, opt => opt.MapFrom(source => source.Id))
                    .ForMember(destination => destination.Caption, opt => opt.MapFrom(source => source.Caption))
                    .ForMember(destination => destination.ImgPath, opt => opt.MapFrom(source => source.ImgPath))
                    .ForMember(destination => destination.CategoryId, opt => opt.MapFrom(source => source.Category.Id)).MaxDepth(1)
                    .ReverseMap();

                cfg.CreateMap<ProductCategory, ProductCategoryDto>()
                    .ForMember(destination => destination.Id, opt => opt.MapFrom(source => source.Id))
                    .ForMember(destination => destination.Caption, opt => opt.MapFrom(source => source.Caption))
                    .ForMember(destination => destination.DescriptionId, opt => opt.MapFrom(source => source.Description.Id))
                    .ReverseMap();

                cfg.CreateMap<Stage, StageDto>()
                    .ForMember(destination => destination.Id, opt => opt.MapFrom(source => source.Id))
                    .ForMember(destination => destination.Caption, opt => opt.MapFrom(source => source.Caption))
                    .ReverseMap();
            });
        }
    }
}
