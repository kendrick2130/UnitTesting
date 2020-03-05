using System;
using PrimeService;
using System.Text;


namespace PrimeService
{
    public class PrimeService
    {
        public bool IsPrime(int candidate)
        {
           for(int i = 2; i <= candidate/2; i++)
           {
                if(candidate % i == 0)
                {
                    return false;
                }
                if(candidate <= 0)
                {
                    return false;
                }
           }
           return true;

        }
    }
}
