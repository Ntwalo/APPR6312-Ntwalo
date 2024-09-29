using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ntwalo_APPR6312.Models
{
    public class DonationItem
    {
        [Key]
        public int ItemDonationId { get; set; }

        [ForeignKey("Catagory")]
        public int CatagoryID { get; set; }
        public Catagory? Catagory { get; set; }

        public string? Description { get; set; }
        public int numItems { get; set; }
        public DateTime DonationDate { get; set; }
        public string? Donor { get; set; }

        [ForeignKey("Disaster")]
        public int DisasterId { get; set; }
        public Disaster? Disaster { get; set; }
    }
}
