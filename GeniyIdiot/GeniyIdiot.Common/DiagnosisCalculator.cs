namespace GeniyIdiot.Common
{
    public static class DiagnosisCalculator
    {
        public static void Calculate(User currentUser, int countQuestions)
        {
            var rateRightAnswers = (double)currentUser.CountRightAnswers / countQuestions;
            var diagnoses = GetDiagnoses();

            if (rateRightAnswers == 0)
            {
                currentUser.Diagnosis = diagnoses[0];
                return;
            }
            if (rateRightAnswers <= 0.2)
            {
                currentUser.Diagnosis = diagnoses[1];
                return;
            }
            if (rateRightAnswers <= 0.4)
            {
                currentUser.Diagnosis = diagnoses[2];
                return;
            }
            if (rateRightAnswers <= 0.6)
            {
                currentUser.Diagnosis = diagnoses[3];
                return;
            }
            if (rateRightAnswers <= 0.8)
            {
                currentUser.Diagnosis = diagnoses[4];
                return;
            }

            currentUser.Diagnosis = diagnoses[5];
        }
        static string[] GetDiagnoses()
        {
            var diagnoses = new string[6];
            diagnoses[0] = "Идиот";
            diagnoses[1] = "Кретин";
            diagnoses[2] = "Дурак";
            diagnoses[3] = "Нормальный";
            diagnoses[4] = "Талант";
            diagnoses[5] = "Гений";
            return diagnoses;
        }
    }
}
