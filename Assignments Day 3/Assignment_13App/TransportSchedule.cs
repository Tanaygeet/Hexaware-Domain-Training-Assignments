﻿using System;

namespace Assignment_13App
{
    public class TransportSchedule
    {
        public string TransportType { get; set; } 
        public string Route { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public decimal Price { get; set; }
        public int SeatsAvailable { get; set; }
    }
}


