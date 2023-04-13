using System.ComponentModel.DataAnnotations;

namespace WebUI.Dtos.ServiceDto
{
    public class CreateServiceDto
    {
        [Required(ErrorMessage ="Enter Service icon link ")]
        public string ServiceIcon { get; set; }

        [Required(ErrorMessage = "Enter Service Title ")]
        [StringLength(100,ErrorMessage ="Service title can be  100 character")]  
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
