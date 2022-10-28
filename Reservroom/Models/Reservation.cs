﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservroom.Models
{
    public class Reservation
    {
       
        public Reservation(RoomID roomID,string username, DateTime startTime, DateTime endTime)
        {
            RoomID = roomID;
            Username = username;
            StartTime = startTime;
            EndTime = endTime;
        

        }

        public RoomID RoomID { get; }
        public DateTime StartTime { get;}
        public DateTime EndTime { get; }
        public string Username { get; }
        public TimeSpan Length => EndTime.Subtract(StartTime);

        public bool Conflicts(Reservation reservation)
        {
            if (reservation.RoomID != RoomID)
                return false;

            return reservation.StartTime < EndTime && reservation.EndTime > StartTime;

        }

 
    }
}
