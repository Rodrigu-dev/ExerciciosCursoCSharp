﻿using System;
using System.Collections.Generic;
using System.Text;
using ExHotel.Entities.Exceptions;

namespace ExHotel.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; } 
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {

        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainException("checkout date must be after checkIn");
            }

            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays; //  Retorna em dias a diferença entre as duas datas.
        }
        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;

            if (checkIn < now || checkOut < now)
            {
                throw new DomainException("Reservation dates for update must be future dates");
            }
            if (checkOut <= checkIn)
            {
                throw new DomainException("checkout date must be after checkIn");
            }
            CheckIn = checkIn;
            CheckOut = checkOut;

            
        }

        public override string ToString()
        {
            return "Room "
                + RoomNumber
                + ", check-in: "
                + CheckIn.ToString("dd/MM/yyyy")
                + ", check-out: "
                + CheckOut.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                + " nights";
        }

    }
}