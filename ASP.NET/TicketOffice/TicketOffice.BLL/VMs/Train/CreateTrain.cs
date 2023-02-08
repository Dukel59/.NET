﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TicketOffice.BLL.VMs.Train
{
    public class CreateTrain
    {
        public string TrainNumber { get; set; }
        public string Destination { get; set; }
        public DateTime Departs { get; set; }
        public int Track { get; set; }

        public CreateTrain() { }

        public CreateTrain(TicketOffice.Models.Train train)
        {
            TrainNumber = train.TrainNumber;
            Destination = train.Destination;
            Departs = train.Departs;
            Track = train.Track;
        }
    }
}
