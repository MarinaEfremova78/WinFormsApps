using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeniyIdiot.Common
{
    public class Game
    {
        private List<Question> questions;
        private int allQuestionsCount;
        private User user;
        private Question currentQuestion;
        private int currentQuestionNumber;

        public Game(User user)
        {
            this.user = user;
            questions = QuestionsStorage.Get();
            allQuestionsCount = questions.Count;
        }

        public Question PopRandomQuestion()
        {
            var random = new Random();
            int randomIndex = random.Next(0, questions.Count);
            currentQuestion = questions[randomIndex];
            questions.RemoveAt(randomIndex);
            currentQuestionNumber++;
            return currentQuestion;
        }

        public void AcceptAnswer(int userAnswer)
        {
            var rightAnswer = currentQuestion.Answer;

            if (userAnswer == rightAnswer)
            {
                user.AcceptRightAnswer();
            }
        }

        public string CalculateDiagnose()
        {
            DiagnosisCalculator.Calculate(user, allQuestionsCount);
            return user.Name + ", Ваш диагноз: " + user.Diagnosis;
        }
       
        public bool End()
        {
            return questions.Count == 0;
        }

        public string GetQuestionNumberInfo()
        {
            return "Вопрос № " + currentQuestionNumber;
        }
    }
}
