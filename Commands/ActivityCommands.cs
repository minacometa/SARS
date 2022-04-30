using SARS.Models;
using SARS.Repositories;

namespace SARS.Commands
{
    public class ActivityCommands : IActivityCommands
    {
        private readonly IActivityCommandsRepository _activityCommandsRepository;

        public ActivityCommands(IActivityCommandsRepository activityCommandsRepository)
        {
            _activityCommandsRepository = activityCommandsRepository;
        }
     
        public void AddValue(string key, int value, ref ActivityLogContext activityLog)
        {
            _activityCommandsRepository.AddValue(key, value, ref activityLog);
        }

        public int GetTotal(string key, ref ActivityLogContext _activityLogs)
        {
            return _activityCommandsRepository.GetTotal(key, ref _activityLogs);
        }
    }
}
