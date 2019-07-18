using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WilesJacksonBugTracker.Repository.Domain
{
    public partial class Bugs
    {
        private DateTime _date1 = DateTime.MinValue;

        public int Id { get; set; }
        [DisplayName("Project Name")]
        public int ProjectId { get; set; }
        [DisplayName("Priority")]
        public int BugPriorityId { get; set; }
        [DisplayName("Status")]
        public int BugStatusId { get; set; }
        [Required(ErrorMessage = "This is a required field"), DisplayName("Created By")]
        public string BugCreatedBy { get; set; }
        [DisplayName("Created On"), DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime BugCreatedOn { get; set; }
        [DisplayName("Close By")]
        public string BugClosedBy { get; set; }
        [DisplayName("Close On"), DataType(DataType.Date)]
        public DateTime BugClosedOn { get; set; }
        [DisplayName("Summary"), StringLength(500), DataType(DataType.MultilineText)]
        public string BugResolutionSummary { get; set; }
        [DisplayName("Priority")]
        public virtual BugPriorities BugPriority { get; set; }
        [DisplayName("Status")]
        public virtual BugStatuses BugStatus { get; set; }
        [DisplayName("Project")]
        public virtual Projects Project { get; set; }
    }
}
