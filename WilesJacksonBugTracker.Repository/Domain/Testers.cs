using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WilesJacksonBugTracker.Repository.Domain
{
    public partial class Testers
    {
        public Testers()
        {
            Locations = new HashSet<Locations>();
        }

        public int Id { get; set; }
        [DisplayName("Project Name")]
        public int ProjectId { get; set; }
        [Required(ErrorMessage = "This is a required field"), DisplayName("First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "This is a required field"), DisplayName("Last Name")]
        public string LastName { get; set; }
        public string FullName { get { return $"{FirstName} {LastName}"; } }
        [DisplayName("Project Name")]
        public virtual Projects Project { get; set; }
        public virtual ICollection<Locations> Locations { get; set; }
    }
}
