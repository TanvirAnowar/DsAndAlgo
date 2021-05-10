namespace Rough
{
    public class PrimeNumber
    {
        public static bool IsPrime(int number)
        {
            if (number == 1)
                return false;
            if (number == 2)
                return true;

            for (int i = 2; i <= number / 2; i++)
            {
                var result = number % i;

                if (result == 0)
                    return false;
            }

            return true;
        }
    }
}