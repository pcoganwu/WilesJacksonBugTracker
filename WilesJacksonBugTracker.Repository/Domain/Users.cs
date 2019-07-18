using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WilesJacksonBugTracker.Repository.Domain
{
    public partial class Users
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "This field is required"), DisplayName("First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "This field is required"), DisplayName("Last Name")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "This field is required"), DisplayName("Phone"),
        RegularExpression("\\(?\\d{3}\\)?[-\\.]? *\\d{3}[-\\.]? *[-\\.]?\\d{4}", ErrorMessage = "Invalid Phone Number")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "This field is required"), DisplayName("Email"),
        RegularExpression("^[a-z0-9][-a-z0-9._]+@([-a-z0-9]+.)+[a-z]{2,5}$", ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        [DisplayName("Project Name")]
        public int ProjectId { get; set; }
      
        public virtual Projects Project { get; set; }
    }
}
