using System;

namespace Demo.AngularWeb.Models
{
    public class Reason
    {
        public long Id { get; set; }

        public string Description { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime ModifiedOn { get; set; }
    }
}
