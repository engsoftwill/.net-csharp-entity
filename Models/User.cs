using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Codenation.Challenge.Models
{
    [Table("user")]
    public class User
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        public string   full_name { get; set; }
        public string email { get; set; }
        public string nickname { get; set; }
        public string password { get; set; }
        public DateTime created_at { get; set; }
    }
}
