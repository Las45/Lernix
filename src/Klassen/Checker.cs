using Quiz_show.src.Klassen;

public class Checker
{
    public int Quizzes_correct { get; set; }
    public int Quizzes_gesamt { get; set; }
    public int Quizzes_prozent { get; set; }

    public void Calculate(int neueFragen)
    {
        Quizzes_gesamt += neueFragen;

        if (Quizzes_gesamt <= 0)
        {
            Quizzes_prozent = 0;
            return;
        }

        Quizzes_prozent = Quizzes_correct * 100 / Quizzes_gesamt;
        Logging.logger.Debug($"Quiz result calculated: {Quizzes_prozent}% ({Quizzes_correct}/{Quizzes_gesamt})");
    }
}