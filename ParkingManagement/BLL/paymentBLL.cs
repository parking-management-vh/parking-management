using ParkingManagement.DAL.Repositories;
using ParkingManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagement.BLL
{
    class paymentBLL
    {
        private readonly paymentRepository repository = new paymentRepository();

        public List<paymentModel> GetAllPayments(string filterType = null, string filterValue = null, string paymentMethodFilter = null, DateTime? paymentDate = null)
        {
            return repository.GetAllPayments(filterType, filterValue, paymentMethodFilter, paymentDate);
        }

        public List<paymentModel> GetAllPaymentsByStaffCode(string staffCode, string filterType, string filterValue, string paymentMethodFilter, DateTime? paymentDate = null)
        {
            return repository.GetAllPaymentsByStaffCode(staffCode, filterType, filterValue, paymentMethodFilter, paymentDate);
        }

        public bool CreatePayment(string licensePlate, string staffCode, string paymentMethod)
        {
            return repository.CreatePayment(licensePlate, staffCode, paymentMethod);
        }
        public bool DeletePayment(int paymentId)
        {
            return repository.DeletePayment(paymentId);
        }

    }
}
