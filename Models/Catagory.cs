using System.ComponentModel.DataAnnotations;

namespace Ntwalo_APPR6312.Models
{
    public class Catagory
    {
        [Key]
        public int CatagoryId { get; set; }
        public string? CatagoryName { get; set; }
    }
}
