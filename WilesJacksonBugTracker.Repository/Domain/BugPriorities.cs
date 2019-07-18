using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WilesJacksonBugTracker.Repository.Domain
{
    public partial class BugPriorities
    {
        public BugPriorities()
        {
            Bugs = new HashSet<Bugs>();
        }

        public int Id { get; set; }
        [Required(ErrorMessage = "This field is required"), DisplayName("Priority")]
        public string BugPriorityType { get; set; }

        public virtual ICollection<Bugs> Bugs { get; set; }
    }
}
