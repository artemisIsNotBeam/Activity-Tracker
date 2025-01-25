using System.ComponentModel.DataAnnotations;

namespace Activity_Tracker.Models
{
    public class Activity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string desc { get; set; }
        public bool completed { get; set; }
    }
}
