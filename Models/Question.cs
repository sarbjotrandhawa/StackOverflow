using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Assignment3_N01392504.Models
{
    public class Question
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("Question ID")]
        public int QuestionId { get; set; }

        [DisplayName("Question")]
        public string QuestionName { get; set; }

        [DisplayName("Views")]
        public int views { get; set; }

        [DisplayName("Last Updated")]
        public DateTime QuestionDateAndTime { get; set; }

        [DisplayName("Category ID")]
        public int CategoryId { get; set; }

        [DisplayName("Posted By")]
        public String name { get; set; }

        public virtual Category Category { get; set; }

    }
}