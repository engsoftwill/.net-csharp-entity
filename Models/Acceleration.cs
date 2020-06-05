using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Codenation.Challenge.Models
{
    [Table("acceleration")]
    public class Acceleration
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        public string   name { get; set; }
        public string slug { get; set; }
        public int challenge_id { get; set; }
        public DateTime created_at { get; set; }
    }
}