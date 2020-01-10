using Gym1._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gym1._0.Core.Models
{
    public class ApplicationUserGymClass
    {
        public int Id { get; set; }
        public string ApplicationUserId { get; set; }
        public GymClass GymClass     { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public string GymClassId { get; set; }

    }
}
