using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Codenation.Challenge.Models
{
    public class Acceleration
    {
        public int Id { get; set; }
        public string   Name { get; set; }
        public string Slug { get; set; }
        public int Challenge_Id { get; set; }
        public DateTime Created_At { get; set; }
        public ICollection<Candidate> Candidates { get; set; }
        public virtual Challenge Challenges { get; set; }
    }
}
