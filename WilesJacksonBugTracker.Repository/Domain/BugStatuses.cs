using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WilesJacksonBugTracker.Repository.Domain
{
    public partial class BugStatuses
    {
        public BugStatuses()
        {
            Bugs = new HashSet<Bugs>();
        }

        public int Id { get; set; }
        [Required(ErrorMessage = "This field is required"), DisplayName("Status")]
        public string BugStatusType { get; set; }

        public virtual ICollection<Bugs> Bugs { get; set; }
    }
}
