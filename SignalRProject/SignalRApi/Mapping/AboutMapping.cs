using AutoMapper;
using SignalR.DtoLayer.AboutDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping
{
    public class AboutMapping :Profile
    {//maplemek istediğimiz metodları çağırırız bu sınıfta
        public AboutMapping() 
        { 
         CreateMap< About, ResultAboutDto>().ReverseMap();
         CreateMap< About, CreateAboutDto>().ReverseMap();
         CreateMap< About, UpdateAboutDto>().ReverseMap();
         CreateMap< About, GetAboutDto>().ReverseMap();
        }
    }
}
