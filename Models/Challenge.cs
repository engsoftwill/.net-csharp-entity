using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Codenation.Challenge.Models
{
    [Table("challenge")]
    public class Challenge
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        public string   name { get; set; }
        public string slug { get; set; }
        public DateTime created_at { get; set; }
    }
}