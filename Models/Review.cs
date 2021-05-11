using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Assignment3_N01392504.Models
{
    public class Review
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        [DisplayName("Votes")]
        public bool vote { get; set; }

        [DisplayName("Question ID")]
        public int QuestionId { get; set; }

        public virtual Question Question { get; set; }
    }
}