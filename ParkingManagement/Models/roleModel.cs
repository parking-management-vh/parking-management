using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagement.Models
{
    public class roleModel
    {
        public Guid Id { get; set; }
        public string RoleName { get; set; }
        public string Description { get; set; }

        public roleModel() { }

        public roleModel(Guid id, string roleName, string description)
        {
            Id = id;
            RoleName = roleName;
            Description = description;
        }
    }
}
