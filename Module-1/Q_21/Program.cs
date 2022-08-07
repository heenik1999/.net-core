using System;

namespace Q_21
{
    class RBI
    {
        public double rateofint_rbi = 6.5f;
        public double calculatebalanceRBI(int Amount, int Years)
        {
            return Amount + ((Amount * rateofint_rbi * Years) / 100);   
        }
    }
    class SBI : RBI
    {
        public double rateofint_sbi = 7f;
        public double calculatebalanceSBI(int Amount, int Years)
        {
            return Amount + ((Amount * rateofint_sbi * Years) / 100);
        }
    }
    class CANERA:SBI
    {
        public double rateofint_canera = 7.2f;
        public double calculatebalanceCANERA(int Amount, int Years)
        {
            return Amount + ((Amount * rateofint_canera * Years) / 100);
        }
        public void diasplay()
        {
            Console.Write("Enter the amount you want to invest?? : ");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.Write("for how many time you want to invest (in years)? : ");
            int years = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("\nYour amount according to canera bank policies after " + years + " years will be " + calculatebalanceCANERA(amount, years));
            Console.WriteLine("\nYour amount according to State bank of India policies after " + years + " years will be " + calculatebalanceSBI(amount, years));
            Console.WriteLine("\nYour amount according to Reserve bank of India policies after " + years + " years will be " + calculatebalanceRBI(amount, years));
        }
    }
    class Bank
    {
        static void Main(string[] args)
        {
            CANERA c = new CANERA();
                c.diasplay();

        }
    }
}
