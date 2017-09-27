using System;

namespace Contrucks.model.ViewModels
{
    public class fulfilledpostViewmodel
    {
        //NEW JOB POSTS
        public string JobTitle { get; set; }
       
        public string JobDescription { get; set; }

       public string SourceAddress { get; set; }

        public string DestinationAddress { get; set; }

        public int LoadWeight { get; set; }

        public int Budget { get; set; }

        public string LoadType { get; set; }
        public string TruckType { get; set; }
        public int NoofTrucksRequired { get; set; }
        //JOB DURATION

        public DateTime JobStartTime { get; set; }

        public DateTime JobStopTime { get; set; }
    }
}
