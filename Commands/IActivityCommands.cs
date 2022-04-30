using SARS.Models;

namespace SARS.Commands
{
    public interface IActivityCommands
    {
        void AddValue(string key, int value, ref ActivityLogContext activityLog);
        int GetTotal(string key, ref ActivityLogContext _activityLogs);
    }
}
