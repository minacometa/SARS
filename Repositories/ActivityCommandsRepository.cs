using SARS.Models;
using System;

namespace SARS.Repositories
{
    public class ActivityCommandsRepository : IActivityCommandsRepository
    {
        public void AddValue(string key, int value, ref ActivityLogContext activityLog)
        {
            activityLog.ActivityLogs.Add(new ActivityLog { Id = Guid.NewGuid(), Type = key, Value = value, Timestamp = DateTime.Now });
            activityLog.SaveChanges();
        }       

        public int GetTotal(string key, ref ActivityLogContext activityLogs)
        {
            int total = 0;
           
            foreach (ActivityLog activityLog in activityLogs.ActivityLogs)
            {
                if (activityLog.Timestamp < DateTime.Now.AddHours(-12))
                    activityLogs.ActivityLogs.Remove(activityLog);
            }

            activityLogs.SaveChanges();

            foreach (ActivityLog activityLog in activityLogs.ActivityLogs)
            {
                total += activityLog.Value;
            }

            return total;
        }
    }
}
