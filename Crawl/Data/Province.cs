using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crawl.Data
{
    [Table("provinces")]
    public class Province
    {
        [Key]
        public string? code { get; set; }
        public string? name { get; set; }
        public string? name_en { get; set; }
        public string? full_name { get; set; }
        public string? full_name_en { get; set; }
        public string? code_name { get; set; }

    }
}
