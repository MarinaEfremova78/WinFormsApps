using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace GeniyIdiot.Common
{
    public class QuestionsStorage
    {
        public static string Path = @"Questions.json";

        public static void Append(Question question)
        {
            var existingQuestions = Get();
            existingQuestions.Add(question);
            Save(existingQuestions);
        }
        public static List<Question> Get()
        {
            RunByDefault();
            var fileData = FileProvider.Get(Path);
            var existingQuestions = JsonConvert.DeserializeObject<List<Question>>(fileData);
            return existingQuestions;
        }
        public static void RunByDefault()
        {
            if (!FileProvider.Exists(Path))
            {
                var questions = new List<Question>();
                questions.Add(new Question("Сколько будет два плюс два умноженное на два?", 6));
                questions.Add(new Question("Бревно нужно распилить на 10 частей, сколько надо сделать распилов?", 9));
                questions.Add(new Question("На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25));
                questions.Add(new Question("Укол делают каждые полчаса, сколько нужно минут для трех уколов?", 60));
                questions.Add(new Question("Пять свечей горело, две потухли. Сколько свечей осталось?", 2));

                Save(questions);
            }
        }

        private static void Save(List<Question> questions)
        {
            var jsonData = JsonConvert.SerializeObject(questions, Formatting.Indented);
            FileProvider.Replace(Path, jsonData);
        }
        
    }
}
