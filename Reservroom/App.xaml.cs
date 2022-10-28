﻿using Reservroom.Exceptions;
using Reservroom.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Reservroom
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            
                Hotel hotel = new Hotel("Wadad's Haven");

              try
               {
                hotel.MakeReservation(new Reservation(
                 new RoomID(2, 4),
                 "Wadad",
                 new DateTime(2022, 1, 1),
                 new DateTime(2022, 1, 3)
                    ));

                hotel.MakeReservation(new Reservation(
                    new RoomID(2, 4),
                    "Wadad",
                    new DateTime(2022, 1, 1),
                    new DateTime(2022, 1, 5)
                    ));
            }
       
            catch (ReservationConflictExeption ex)
            {

            }
            IEnumerable<Reservation> reservations=  hotel.GetAllReservations();

            base.OnStartup(e);
        }
    }
}
