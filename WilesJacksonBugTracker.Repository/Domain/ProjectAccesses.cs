using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WilesJacksonBugTracker.Repository.Domain
{
    public partial class ProjectAccesses
    {
        public int Id { get; set; }
        [DisplayName("Project Name")]
        public int ProjectId { get; set; }
        [Required(ErrorMessage = "This field is required"), DisplayName("First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "This field is required"), DisplayName("Last Name")]
        public string LastName { get; set; }
        [DisplayName("Project Name")]
        public virtual Projects Project { get; set; }
    }
}
