using AutoMapper;
using CleanArchitecture.Application.Entities;
using CleanArchitecture.Application.Models.Authors.Commands.UpdateAuthor;
using CleanArchitecture.Application.Models.Authors.CreateAuthor.Commands;
using CleanArchitecture.Application.Models.Authors.GetAllAuthors.Queries;
using System;

namespace CleanArchitecture.Application.Configurations
{
    public static class Mapping
    {
        private static readonly Lazy<IMapper> Lazy = new Lazy<IMapper>(() =>
        {
            var config = new MapperConfiguration(cfg =>
            {
                // This line ensures that internal properties are also mapped over.
                cfg.ShouldMapProperty = p => p.GetMethod.IsPublic || p.GetMethod.IsAssembly;
                cfg.AddProfile<MappingProfile>();
            });
            var mapper = config.CreateMapper();

            return mapper;
        });

        public static IMapper Mapper => Lazy.Value;
    }

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AuthorDal, GetAllAuthorsModel>().ReverseMap();
            CreateMap<AuthorDal, CreateAuthorCommand>().ReverseMap();
            CreateMap<AuthorDal, UpdateAuthorCommand>().ReverseMap();
        }
        
    }
}
