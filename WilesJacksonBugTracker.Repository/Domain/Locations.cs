using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WilesJacksonBugTracker.Repository.Domain
{
    public partial class Locations
    {
        public int Id { get; set; }
        [DisplayName("Tester")]
        public int TesterId { get; set; }
        [Required(ErrorMessage = "This field is required"), DisplayName("Location Name")]
        public string Name { get; set; }

        public virtual Testers Tester { get; set; }
    }
}
