namespace LazarB_MiniChallenge_TwoToFourEndpoints.Services
{
    public class AskQuestionsServices
    {

        public string AskingQuestions(string userName, string userTime){
            return $"Hello! Your name is {userName} and you woke up at {userTime}.";
        }
    }
}