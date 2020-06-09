using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Codenation.Challenge.Models
{
    public class Submission
    {
        public int User_Id { get; set; }
        public int  Challenge_id { get; set; }
        public decimal  Score { get; set; }
        public DateTime Created_At { get; set; }
        public virtual User Users { get; set; }
        public virtual Challenge Challenges { get; set; }
    }
}