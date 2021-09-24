using System;

namespace GeniyIdiot.Common
{
    public class User
    {
        public string Name;
        public int CountRightAnswers;
        public string Diagnosis;

        public User(string name)
        {
            Name = name;
            CountRightAnswers = 0;
            Diagnosis = "Неизвестно";
        }

        public void AcceptRightAnswer()
        {
            CountRightAnswers++;
        }
        public static string CheckName(string name)
        {
            if (String.IsNullOrEmpty(name))
            {
                return "Пожалуйста, введите действительные фамилию, имя, отчество через пробел";
            }
            if (name == "Админ")
            {
                return name;
            }
            int count = 0;
            for (int i = 0; i < name.Length; i++)
            {
                if ((name[i] < 'А' || name[i] > 'я') && name[i] != 'Ё' && name[i] != 'ё' && name[i] != ' ')
                {
                    return "Пожалуйста, введите действительные фамилию, имя, отчество через пробел";
                }
                if (name[i] == ' ' && i > 0)
                {
                    count++;
                }
                if (i == name.Length - 1 && count < 1)
                {
                    return "Пожалуйста, введите действительные фамилию, имя, отчество через пробел";
                }
                else if (i == name.Length - 1 && count >= 1)
                {
                    return name;
                }
            }
            return "null";
        }
    }
}


