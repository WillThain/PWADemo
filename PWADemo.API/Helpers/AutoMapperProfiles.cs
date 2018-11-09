using System.Linq;
using AutoMapper;
using PWADemo.API.Dtos;
using PWADemo.API.Models;

namespace PWADemo.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles() 
        {
            CreateMap<User, UserForListDto>()
            .ForMember(dest => dest.PhotoUrl, opt => {
                opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url);
            })
            .ForMember(dest => dest.Age, opt => {
                opt.ResolveUsing(d => d.DateOfBirth.CalaculateAge());
            });
            CreateMap<User, UserForDetailedDto>()            
            .ForMember(dest => dest.PhotoUrl, opt => {
                opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url);
            })
            .ForMember(dest => dest.Age, opt => {
                opt.ResolveUsing(d => d.DateOfBirth.CalaculateAge());
            });
            CreateMap<Photo, PhotosForDetailedDto>();
        }
    }
}