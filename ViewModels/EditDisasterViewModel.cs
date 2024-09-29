namespace Ntwalo_APPR6312.ViewModels
{
    public class EditDisasterViewModel
    {
        public int DisasterId { get; set; }
        public string? Title { get; set; }  
        public string? Location { get; set; } 
        public string? Description { get; set; }   
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
