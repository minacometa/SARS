using System;

namespace SARS.Models
{
    public class ActivityLog
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public int Value { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
