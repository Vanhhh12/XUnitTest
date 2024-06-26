using Crawl.Data;
using Crawl.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Crawl.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CrawlController : ControllerBase
    {
        private readonly HttpClient _httpClient;
        private readonly ICrwalDataRepositories _repository;
        public CrawlController(ICrwalDataRepositories _repo)
        {
            _repository = _repo;
            _httpClient = new HttpClient();
        }

        [HttpGet]
        public async Task<IActionResult> CrawlData()
        {
            var apiURL = "https://open.oapi.vn/location/provinces?page=0&size=64&query=";
            HttpResponseMessage re = await _httpClient.GetAsync(apiURL);
            if (re.IsSuccessStatusCode) {
                return Ok(await re.Content.ReadAsStringAsync());    
            }
            else
            {
                return StatusCode((int)re.StatusCode);
            }
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllWard()
        {
            try { 
                return Ok(await _repository.GetAllAsync());
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
