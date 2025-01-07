namespace LazarB_MiniChallenge_TwoToFourEndpoints.Services
{
    public class GreaterLessServices
    {

        public string GreaterOrLess(int num1, int num2)
        {
            if (num1 > num2)
            {
                return $"{num1} is greater than {num2}. {num2} is less than {num1}.";
            }
            else if (num1 < num2)
            {
                return $"{num1} is less than {num2}. {num2} is greater than {num1}.";

            }
            else
            {
                return $"{num1} is equal to {num2}. {num2} is equal to {num1}.";

            }
        }
    }
}