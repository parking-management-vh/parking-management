using System.Collections.Generic;
using ParkingManagement.DAL.Repositories;
using ParkingManagement.Models;

namespace ParkingManagement.BLL
{
    public class TicketPriceBLL
    {
        private TicketPriceRepository ticketPriceRepository = new TicketPriceRepository();

        public List<TicketPrice> GetAllTicketPrices()
        {
            return ticketPriceRepository.GetAllTicketPrices();
        }

        public List<VehicleType> GetVehicleTypes()
        {
            return ticketPriceRepository.GetVehicleTypes();
        }
        public void AddTicketPrice(TicketPrice ticketPrice)
        {
            ticketPriceRepository.InsertTicketPrice(ticketPrice);
        }

        public void UpdateTicketPrice(string id, decimal price, TicketPrice ticketPrice)
        {
            ticketPriceRepository.UpdateTicketPrice(ticketPrice);
        }

        public void DeleteTicketPrice(string id)
        {
            ticketPriceRepository.DeleteTicketPrice(id);
        }
    }
}
