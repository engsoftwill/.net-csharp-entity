using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Codenation.Challenge.Models
{
    public class Candidate
    {
        public int User_Id { get; set; }
        public int   Acceleration_Id { get; set; }
        public int Company_Id { get; set; }
        public int Status { get; set; }
        public DateTime Created_At { get; set; }
        public virtual User Users { get; set; }
        public virtual Acceleration Accelerations { get; set; }
        public virtual Company Companies { get; set; }
    }
}
