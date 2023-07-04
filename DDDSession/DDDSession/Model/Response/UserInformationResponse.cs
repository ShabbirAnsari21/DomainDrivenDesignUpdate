using System.ComponentModel.DataAnnotations;

namespace DDDSession.API.Model.Response
{
    public record UserInformationResponse
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public int PinCode { get; private set; }
        public string PhoneNumber { get; private set; }
    }
}
