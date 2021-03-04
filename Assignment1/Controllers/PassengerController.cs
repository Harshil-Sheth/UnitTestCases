using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BusinessEntities;
using Business.Interface;

namespace Assignment1.Controllers
{
    public class PassengerController
    {
        // GET: Passenger
        private readonly IPassengerManager _passengerManager;

        public PassengerController(IPassengerManager passengerManager)
        {
            _passengerManager = passengerManager;
        }

        // GET: api/Passengers
        public List<PassengerView> GetPassengers()
        {
            return _passengerManager.GetAllPassengers();
        }

        // GET: api/Passengers/5
        public PassengerView GetPassenger(int id)
        {
            return _passengerManager.GetPassenger(id); ;
        }

        // PUT: api/Passengers/5
        public string PutPassenger(int id, PassengerView passenger)
        {
            return _passengerManager.UpdatePassenger(id, passenger);
        }

        // POST: api/Passengers
        public string PostPassenger(PassengerView passenger)
        {
            return _passengerManager.CreateNewPassenger(passenger);
        }

        // DELETE: api/Passengers/5
        public bool DeletePassenger(int id)
        {
            return _passengerManager.DeletePassenger(id);
        }
    }
}