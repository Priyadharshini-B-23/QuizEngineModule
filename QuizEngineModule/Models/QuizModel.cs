namespace QuizEngineModule.Models
{
    public class QuizModel
    {
         
        public int QuestionNo { get; set; }  

        public string? QuestionText { get; set;}

        public string? Category { get;set;}

        public string? AnswerOne { get; set;}

        public string? AnswerTwo { get; set; }

        public string? AnswerThree { get; set;}

        public string? RightAnswer { get; set;}

    }
}
