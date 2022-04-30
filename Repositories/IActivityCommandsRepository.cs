using SARS.Models;

namespace SARS.Repositories
{
    public interface IActivityCommandsRepository
    {
        void AddValue(string key, int value, ref ActivityLogContext activityLog);
        int GetTotal(string key, ref ActivityLogContext activityLogs);
    }
}
