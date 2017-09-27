using Contrucks.model.ViewModels;
using Contrucks.Service.Interfaces;
using System;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Contrucks.Controllers
{
    [EnableCors(origins:"*",headers: "*",methods: "*")]
    public class ContractorDashboardController : ApiController
    {
        IRecentJobPostService recentPostService;
        public ContractorDashboardController()
        {

        }
        public ContractorDashboardController(IRecentJobPostService rec)
        {
            recentPostService = rec;
        }

        // GET: /Details/
        [Route("api/ContractorDashboard/GetAllData")]
        public IHttpActionResult GetAllData()
        {
            try
            {
                var authors = recentPostService.GetAll();
                return Ok(authors);
            }
            catch (Exception)   
            {
                throw;
            }
        }

        //Get: Load type details
        [Route("api/ContractorDashboard/GetLoadType")]
        public IHttpActionResult GetLoadType()
        {
            try
            {
                var loadtype = recentPostService.GetLoadType();
                return Ok(loadtype);
            }
            catch (Exception)   
            {
                throw;
            }
        }

        //Get: Load type details
        [Route("api/ContractorDashboard/GetTruckType")]
        public IHttpActionResult GetTruckType()
        {
            try
            {
                var trucktype = recentPostService.GetTruckType();
                return Ok(trucktype);
            }
            catch (Exception)   
            {
                throw;
            }
        }

        //Post: New JobPost Data
        [Route("api/ContractorDashboard/SetData")]
        public IHttpActionResult SetData(RecentpostViewmodel recentVM)
        {
            try
            {
                recentPostService.AddData(recentVM);
                return Ok();

            }
            catch (Exception)   
            {
                throw;
            }
        }

    }


}


