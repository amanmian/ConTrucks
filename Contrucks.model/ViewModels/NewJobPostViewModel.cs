using System;

namespace Contrucks.model.ViewModels
{
    public   class NewJobPostViewModel
    {
        public string JobTitle { get; set; }
       
        public DateTime? JobStartDate { get; set; }
        public DateTime? JobEndDate { get; set; }
        public string JobDescription { get; set; }

        public DateTime? EstimatedTime { get; set; }
       
        public string SourceAddress { get; set; }
       
        public string DestinationAddress { get; set; }
       
        public int LoadWeight { get; set; }
       
        public int Budget { get; set; }

        public string LoadType { get; set; }
        public string TruckType { get; set; }
        public int NoofTrucksRequired { get; set; }

    }
}
