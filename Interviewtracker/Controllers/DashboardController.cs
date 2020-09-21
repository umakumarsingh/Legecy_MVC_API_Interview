using InterviewTracker.BusinessLayer.Services;
using InterviewTracker.BusinessLayer.ViewModels;
using InterviewTracker.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Interviewtracker.Controllers
{
    public class DashboardController : ApiController
    {
        /// <summary>
        /// Injecting InterviewTrackerServices into constructor
        /// </summary>
        private readonly InterviewTrackerServices _interviewTS;

        public DashboardController(InterviewTrackerServices interviewTrackerServices)
        {
            _interviewTS = interviewTrackerServices;
        }
        /// <summary>
        /// Get all interview
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IEnumerable<Interview>> GetAllInterview()
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Add/Create new interview
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/Dashboard/Addinterview")]
        public async Task<IHttpActionResult> AddNewInterview([FromBody] AddInterviewViewModel model)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Delete interview
        /// </summary>
        /// <param name="InterviewId"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("api/Dashboard/DeleteInterview/{InterviewId}")]
        public async Task<IHttpActionResult> DeleteInterview(int InterviewId)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Update Interview
        /// </summary>
        /// <param name="interview"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("api/Dashboard/Updateinterview")]
        public async Task<IHttpActionResult> Updateinterview([FromBody] Interview interview)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Find a interview
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/Dashboard/Searchinterview/{Name}")]
        public async Task<IHttpActionResult> SearchInterview(string name)
        {
            //Do code here
            throw new NotImplementedException();
        }
       /// <summary>
       /// Get total number of interview
       /// </summary>
       /// <returns></returns>
        [HttpGet]
        [Route("api/Dashboard/TotalInterview")]
        public IHttpActionResult TotalInterview()
        {
            //Do code here
            throw new NotImplementedException();
        }
    }
}
