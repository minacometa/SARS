using Microsoft.AspNetCore.Mvc;
using SARS.Commands;
using SARS.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SARS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivityController : ControllerBase
    {
        private readonly IActivityCommands _activityCommands;       
        private ActivityLogContext _context;

        public ActivityController(IActivityCommands activityCommands, ActivityLogContext activityLogContext)
        {
            _activityCommands = activityCommands;
            _context = activityLogContext;
        }

        [HttpGet("{key}/total")]
        public int Get(string key)
        {
            return _activityCommands.GetTotal(key, ref _context);
        }
        
        [HttpPost("{key}")]
        public void Post(string key, [FromBody] int value)
        {
            try
            {
               
                _activityCommands.AddValue(key, value, ref _context);
            }
            catch
            {
                throw;
            }
        }       
    }
}
