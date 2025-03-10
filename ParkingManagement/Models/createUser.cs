using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagement.Models
{
    public class createUser
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string FullName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Gender { get; set; } 
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public Guid? RoleId { get; set; }
        public Guid? AreaId { get; set; }
        public string AreaName { get; set; }
        public string Role { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool Status { get; set; }

        public createUser() { }

        public createUser(string code, string fullName, DateTime? dateOfBirth, string gender,
                    string phoneNumber, string email, string address, Guid id, Guid roleId, Guid areaId, bool status)
        {
            Code = code;
            FullName = fullName;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            PhoneNumber = phoneNumber;
            Email = email;
            Address = address;
            Id = id;
            Status = status;
            AreaId = areaId;
            RoleId = roleId;
        }
    }
}
