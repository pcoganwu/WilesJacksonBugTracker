using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WilesJacksonBugTracker.Repository.Domain
{
    public partial class Projects
    {
        public Projects()
        {
            Bugs = new HashSet<Bugs>();
            ProjectAccesses = new HashSet<ProjectAccesses>();
            Testers = new HashSet<Testers>();
            Users = new HashSet<Users>();
        }

        public int Id { get; set; }
        [Required(ErrorMessage = "This field is required"), DisplayName("Project Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "This field is required"), DisplayName("Description"), DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [DisplayName("Modified On"), DataType(DataType.Date)]
        public DateTime ModifiedOn { get; set; }

        public virtual ICollection<Bugs> Bugs { get; set; }
        public virtual ICollection<ProjectAccesses> ProjectAccesses { get; set; }
        public virtual ICollection<Testers> Testers { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}
