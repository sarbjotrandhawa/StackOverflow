using Assignment3_N01392504.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment3_N01392504.DAL
{
    public class QuestionInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<QuestionContext>
    {

        protected override void Seed(QuestionContext context)
        {
            var categories = new List<Category>
            {
            new Category{CategoryId=1,CategoryName="HTML"},
            new Category{CategoryId=2,CategoryName="CSS"},
            new Category{CategoryId=3,CategoryName="JavaScript" }
            };

            categories.ForEach(s => context.Categories.Add(s));
            context.SaveChanges();

            var questions = new List<Question>
            {
            new Question{QuestionId=1, name="jashan@gmail.com", views=0,QuestionName="document.getElementById() is not working",QuestionDateAndTime=DateTime.Parse("2021-04-04 11:00:00"),CategoryId=3},
            new Question{QuestionId=2, name="karan@gmail.com", views=0,QuestionName="How to set background image in CSS",QuestionDateAndTime=DateTime.Parse("2021-04-04 10:00:00"),CategoryId=2},
            new Question{QuestionId=3, name="gurman@gmail.com",views=0,QuestionName="How to display icon the browser title bar using HTML",QuestionDateAndTime=DateTime.Parse("2021-04-04 10:15:00"),CategoryId=1}
            };

            questions.ForEach(s => context.Questions.Add(s));
            context.SaveChanges();



            var answers = new List<Answer>
            {
            new Answer{AnswerId=1,QuestionId=1,AnswerText="Set Id",name="jashan@gmail.com",AnswerDateAndTime=DateTime.Parse("2021-04-04 10:00:00")}
            };

            answers.ForEach(s => context.Answers.Add(s));
            context.SaveChanges();
        }

    }
}