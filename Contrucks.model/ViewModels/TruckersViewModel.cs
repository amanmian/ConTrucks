namespace Contrucks.model.ViewModels
{
    public class TruckersViewModel
    {
        //TRUCKERS
        public int UserId { get; set; }
        public string TruckerFirstName { get; set; }
        public string TruckerLastName { get; set; }
        public int TruckerAge { get; set; }
       
        public string TruckerLicensePlate { get; set; }
        public string TruckerPhone { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        //USER TABLES
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
    }
}
