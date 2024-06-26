using AutoMapper;
using Crawl.Data;
using Crawl.Model;
using Microsoft.EntityFrameworkCore;

namespace Crawl.Repositories
{
    public class CrawlDataRepositories : ICrwalDataRepositories
    {
        private readonly AddressContext _addressContext;
        private readonly IMapper _mapper;
        public CrawlDataRepositories(AddressContext addressContext, IMapper mapper)
        {
            _addressContext = addressContext;
            _mapper = mapper;
        }

        public async Task<List<WardModel>> GetAllAsync()
        {
            var wards = await _addressContext.Ward!.ToArrayAsync();
            return _mapper.Map<List<WardModel>>(wards);
        }

        public async Task<List<DistrictModel>> GetAllDistrictAsync()
        {
            var districts = await _addressContext.District!.ToArrayAsync();
            return _mapper.Map<List<DistrictModel>>(districts);
        }

        public async Task<List<ProvinceModel>> GetAllProvinceAsync()
        {
            var provinces = await _addressContext.Province!.ToArrayAsync();
            return _mapper.Map<List<ProvinceModel>>(provinces); 
        }
    }
}
