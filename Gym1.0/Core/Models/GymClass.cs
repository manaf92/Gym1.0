using System;
using System.Collections.Generic;
using Gym1._0.Core.Models;


namespace Gym1._0.Models
{
    public class GymClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public TimeSpan Duration { get; set; }
       // public DateTime EndTime { get; set; }
        public string Desciption { get; set; }
        public DateTime EndTime => StartTime + Duration;
        public ICollection<ApplicationUserGymClass> MyProperty { get; set; }
    }
}
