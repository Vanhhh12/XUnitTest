using AutoMapper;
using Crawl.Data;
using Crawl.Model;

namespace Crawl.Helper
{
    public class Mapper : Profile
    {
        public Mapper() {
            CreateMap<District, DistrictModel>().ReverseMap();
            CreateMap<Ward, WardModel>().ReverseMap();
            CreateMap<Province, ProvinceModel>().ReverseMap();
        }
    }
}
