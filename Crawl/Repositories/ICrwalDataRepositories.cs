using Crawl.Model;

namespace Crawl.Repositories
{
    public interface ICrwalDataRepositories
    {
        public Task<List<WardModel>> GetAllAsync();
        public Task<List<ProvinceModel>> GetAllProvinceAsync(); 
        public Task<List<DistrictModel>> GetAllDistrictAsync();
    }
}
