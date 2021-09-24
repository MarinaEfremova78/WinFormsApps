using GeniyIdiot.Common;
using System;
using System.Collections.Generic;


namespace GeniyIdiotConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите фамилию, имя, отчество");

                var currentUser = new User(CheckcurrentUserName());

                if (currentUser.Name == "Админ")
                {
                    GetAdminRights();
                    break;
                }

                var game = new Game(currentUser);

                while (!game.End())
                {
                    var currentQuestion = game.PopRandomQuestion();
                    Console.WriteLine(game.GetQuestionNumberInfo());                  

                    Console.WriteLine(currentQuestion.Text);

                    int userAnswerNumber = GetUserAnswer();

                    game.AcceptAnswer(userAnswerNumber);
                }
               
                UserResultsStorage.Append(currentUser);

                Console.WriteLine("Количество правильных ответов: " + currentUser.CountRightAnswers);
                Console.WriteLine(game.CalculateDiagnose());

                Console.WriteLine("Показать результаты других пользователей (Y/N)?");
                var yes = GetYesorNoUserAnswer();
                Console.WriteLine();
                if (yes == true)
                {
                    var allUsers = UserResultsStorage.GetAll();
                    ShowAllUsersResults(allUsers);
                }
                Console.WriteLine("Пройти тест ещё раз (Y/N)?");
                var anotherTry = GetYesorNoUserAnswer();
                Console.WriteLine();
                if (anotherTry == false)
                {
                    break;
                }
            }
        }
        static void AddNewQuestion()
        {
            Console.WriteLine("Введите новый вопрос");
            var newQuestion = CheckNewQuestion();
            Console.WriteLine("Введите правильный ответ на новый вопрос");
            var newAnswer = GetUserAnswer();
            Question question = new Question(newQuestion, newAnswer);
            QuestionsStorage.Append(question);
        }

        static int GetUserAnswer()
        {
            while (true)
            {
                try
                {
                    return Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Пожалуйста, введите число!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Пожалуйста, введите число меньше 10^9");
                }
            }
        }

        static string CheckcurrentUserName()
        {
            while (true)
            {
                var nameSurname = Console.ReadLine();
                var output = User.CheckName(nameSurname);
                if (output != nameSurname)
                {
                    Console.WriteLine(output);
                }
                else
                {
                    return nameSurname;
                }
            }
        }
        static string CheckNewQuestion()
        {
            while (true)
            {
                var adminInput = Console.ReadLine();
                if (String.IsNullOrEmpty(adminInput) || (adminInput == " ") == true)
                {
                    Console.WriteLine("Пожалуйста, введите Ваш текст");
                }
                else
                {
                    return adminInput;
                }
            }
        }
        static bool GetYesorNoUserAnswer()
        {
            var useryesNoAnswer = Console.ReadKey();
            while (useryesNoAnswer.Key != ConsoleKey.Y && useryesNoAnswer.Key != ConsoleKey.N)
            {
                Console.WriteLine("Выберите клавишу Y или N");
                useryesNoAnswer = Console.ReadKey();
            }
            if (useryesNoAnswer.Key == ConsoleKey.Y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void ShowAllUsersResults(List<User> allUsers)
        {
            Console.WriteLine("{0,-30}{1,-50}{2,-50}", "Фамилия, Имя, Отчество", "Кол-во правильных ответов", "Диагноз");
            foreach (var user in allUsers)
            {
                Console.WriteLine("{0,-40}{1,-40}{2,-40}", user.Name, user.CountRightAnswers, user.Diagnosis);
            }
        }
        static void GetAdminRights()
        {
            while (true)
            {
                Console.WriteLine("Вы хотите добавить новый вопрос? (Y/N)");
                var adminYesAnswer = GetYesorNoUserAnswer();
                Console.WriteLine();
                if (adminYesAnswer == true)
                {
                    AddNewQuestion();
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("Вы хотите посмотреть результаты всех пользователей? (Y/N)");
            var adminSecondYesAnwer = GetYesorNoUserAnswer();
            Console.WriteLine();
            if (adminSecondYesAnwer == true)
            {
                var allUsers = UserResultsStorage.GetAll();
                ShowAllUsersResults(allUsers);
            }
        }
    }
}


