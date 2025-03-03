using ParkingManagement.DAL.Repositories;
using ParkingManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagement.BLL
{
    public class roleBLL
    {
        private readonly roleRepository repository = new roleRepository();

        public List<roleModel> GetAllRoleAreas()
        {
            return repository.GetAllRoleAreas();
        }

        public void CreateRole(roleModel role)
        {
            repository.InsertRole(role);
        }

        public void UpdateRole(roleModel role)
        {
            repository.UpdateRole(role);
        }

        public void DeleteRole(Guid roleId)
        {
            repository.DeleteRole(roleId);
        }
    }
}
