namespace LazarB_MiniChallenge_TwoToFourEndpoints.Services
{
    public class AddNumbersServices
    {
        // public List<string> userRes = new();
        public string AddNumbers(int num1, int num2){
        return $"The sum of {num1} and {num2} is {num1 + num2}";
        }
    }
}