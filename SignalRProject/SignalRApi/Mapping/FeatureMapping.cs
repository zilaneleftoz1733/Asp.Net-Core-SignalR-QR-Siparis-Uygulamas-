using AutoMapper;
using AutoMapper.Features;
using SignalR.DtoLayer.AboutDto;
using SignalR.DtoLayer.FeatureDto;
using SignalR.EntityLayer.Entities;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using SignalR.DtoLayer.FeatureDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping
{
    public class FeatureMapping:Profile
    {
        public FeatureMapping()
        {
            CreateMap<Feature, ResultFeatureDto>().ReverseMap();
            CreateMap<Feature, CreateFeatureDto> ().ReverseMap();
            CreateMap<Feature, UpdateFeatureDto> ().ReverseMap();
            CreateMap<Feature, GetFeatureDto> ().ReverseMap();
        }
    }
}
