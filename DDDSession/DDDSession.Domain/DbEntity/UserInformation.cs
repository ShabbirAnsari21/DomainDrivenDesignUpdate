using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDSession.Domain.DbEntity
{
    public class UserInformation
    {
        [Key]
        public int Id { get; private set; }
        [Required]
        public string Name { get; private set; }
        [Required]
        public string Email { get; private set; }
        [Required]
        public int PinCode { get; private set; }
        [Required]
        public string PhoneNumber { get; private set; }
        public UserInformation(string name, string email, int pinCode, string phoneNumber )
        {
            Name = ValidateName(name);
            Email = ValidateEmail(email);
            PinCode = pinCode;
            PhoneNumber = phoneNumber;
        }
        public static UserInformation Create(string name, string email, int pincode, string number)
        {
            return new UserInformation(
                                        name, 
                                        email, 
                                        pincode, 
                                        number 
                                      );
        }
        public string ValidateName(string name)
        {
            Name = name;
            return Name;
        }

        public string ValidateEmail(string email)
        {
            if(email.Contains("ariqt.com"))
                return email;

            throw new Exception("Email Not Valid");
        }
    }
}
