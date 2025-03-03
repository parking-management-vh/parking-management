using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ParkingManagement.Models
{
    class allUserModel
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string FullName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string AreaName { get; set; }
        public string RoleName { get; set; }
        public bool Status { get; set; }

        public allUserModel() { }
        public allUserModel(string code, string fullName, DateTime? dateOfBirth, string gender,
                  string phoneNumber, string email, string address, string areaName, Guid id, string roleName, bool status)
        {
            Code = code;
            FullName = fullName;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            PhoneNumber = phoneNumber;
            Email = email;
            Address = address;
            AreaName = areaName;
            Id = id;
            RoleName = roleName;
            Status = status;
        }
    }
}
