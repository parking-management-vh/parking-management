using ParkingManagement.DAL.Repositories;
using ParkingManagement.Models;
using System;
using System.Data;

namespace ParkingManagement.BLL
{
    public class PaymentReceiptBLL
    {
        private readonly PaymentReceiptDAL dal = new PaymentReceiptDAL();

        public DataTable GetAllReceipts()
        {
            return dal.GetAllReceipts();
        }

        public bool AddReceipt(PaymentReceipt receipt)
        {
            if (receipt.TotalPrice <= 0)
                throw new Exception("Tổng tiền không hợp lệ!");
            if (string.IsNullOrEmpty(receipt.VehicleId))
                throw new Exception("Chưa chọn xe!");
            if (string.IsNullOrEmpty(receipt.StaffCode))
                throw new Exception("Chưa chọn nhân viên!");
            if (string.IsNullOrEmpty(receipt.PaymentMethod))
                throw new Exception("Chưa chọn phương thức thanh toán!");

            return dal.InsertReceipt(receipt);
        }

        public bool UpdateReceipt(PaymentReceipt receipt)
        {
            if (string.IsNullOrEmpty(receipt.Id))
                throw new Exception("Mã hóa đơn không hợp lệ!");
            if (receipt.TotalPrice <= 0)
                throw new Exception("Tổng tiền không hợp lệ!");
            if (string.IsNullOrEmpty(receipt.VehicleId))
                throw new Exception("Chưa chọn xe!");
            if (string.IsNullOrEmpty(receipt.StaffCode))
                throw new Exception("Chưa chọn nhân viên!");
            if (string.IsNullOrEmpty(receipt.PaymentMethod))
                throw new Exception("Chưa chọn phương thức thanh toán!");

            return dal.UpdateReceipt(receipt);
        }

        public bool DeleteReceipt(int id)
        {
            if (id <= 0)
                throw new Exception("Mã hóa đơn không hợp lệ!");
            return dal.DeleteReceipt(id);
        }
    }
}