using System.ComponentModel.DataAnnotations;

namespace WebUI.Dtos.ServiceDto
{
    public class UpdateServiceDto
    {
        public int ServiceId { get; set; }  

        [Required(ErrorMessage = "Enter Service icon link ")]
        public string ServiceIcon { get; set; }

        [Required(ErrorMessage = "Enter Service Title ")]
        [StringLength(100, ErrorMessage = "Service title can be  100 character")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Enter Service Descrption ")]
        [StringLength(500, ErrorMessage = "Description can be  500 character")]
        public string Description { get; set; }
    }
}
