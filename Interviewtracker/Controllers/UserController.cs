using InterviewTracker.BusinessLayer.Interfaces;
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
    public class UserController : ApiController
    {
        /// <summary>
        /// Injecting IUserInterviewTrackerServices into constructor
        /// </summary>
        private readonly IUserInterviewTrackerServices _trackerServices;

        public UserController(IUserInterviewTrackerServices trackerServices)
        {
            _trackerServices = trackerServices;
        }
        /// <summary>
        /// Get all user
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IEnumerable<ApplicationUser>> GetAllUser()
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Register new user
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/User/Register")]
        public async Task<IHttpActionResult> RegisterUser([FromBody] RegisterViewModel model)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Delete User
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("api/User/DeleteUser/{UserId}")]
        public async Task<IHttpActionResult> DeleteUser(int UserId)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Update User
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("api/User/Updateuser")]
        public async Task<IHttpActionResult> Updateuser([FromBody] ApplicationUser user)
        {
            //Do code here
            throw new NotImplementedException();
        }
    }
}
