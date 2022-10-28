﻿using Reservroom.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservroom.Models
{
    public class ReservationBook
    {
        private readonly List<Reservation> _reservations;

        public ReservationBook()
        {
                _reservations= new List<Reservation>();              
        }

        public IEnumerable<Reservation> GetAllReservations()
        {
            return _reservations;
        }

        public void AddReservation(Reservation reservation)
        {
            foreach(Reservation existingReservation in _reservations)
            {
                if (existingReservation.Conflicts(reservation)){

                    throw new ReservationConflictExeption(existingReservation, reservation);

                }
            }
            _reservations.Add(reservation); 
        }
    }
}
