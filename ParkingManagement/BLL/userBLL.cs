using ParkingManagement.DAL.Repositories;
using ParkingManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ParkingManagement.BLL
{
    class userBLL
    {
        private readonly userRepository repository = new userRepository();

        public (List<allUserModel>, int) GetUsersByPage(
            int page,
            int pageSize,
            bool? status = null,
            string roleName = null,
            string areaName = null,
            string searchColumn = null,
            string searchValue = null
            )
        {
            return repository.GetUsersByPage(page, pageSize, status, roleName, areaName, searchColumn, searchValue);
        }

        public void AddUser(createUser user)
        {
            repository.AddUser(user);
        }

        public bool DeleteUserByCode(string userCode)
        {
            return repository.DeleteUserByCode(userCode);
        }

        public bool UpdateUser(createUser user)
        {
            return repository.UpdateUser(user);
        }

        public createUser Login(string code, string password)
        {
            return repository.LoginUser(code, password);
        }
    }
}
