using System.ComponentModel.DataAnnotations;

namespace DDDSession.API.Model.Request
{
    public class CreateCompanyRequest
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [MaxLength(6)]
        public int PinCode { get; set; }
        [Required]
        [MaxLength(10)]
        public string PhoneNumber { get; set; }
    }
}
