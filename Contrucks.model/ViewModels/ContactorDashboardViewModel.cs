namespace Contrucks.model.ViewModels
{
    public class ContactorDashboardViewModel
    {
        public string ContractorName { get; set; }
        public int ContractorPhone { get; set; }
        public string UserEmail { get; set; }
        public RecentpostViewmodel recentpostVM { get; set; }
        public fulfilledpostViewmodel fulfilledpostVM { get; set; }
        public TopTruckersViewmodel topTruckersVM{ get; set; }
        public LoadunitsgraphViewmodel LoadUnitsGraphVM { get; set; }
        public LoaddistancegraphViewmodel loadDistanceGraphVM { get; set; }
        public TransportexpenditureViewModel transportExpenditureVM { get; set; }
    }
}
