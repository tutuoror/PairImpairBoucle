namespace PairImpairBoucle;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Consignes
         * Demandez à l'utilisateur un nombre
         * Dites à l'utilisateur si le nombre fourni est pair ou impair
         * Demandez à l'utilisateur s'il veut proposer un autre nombre
         *  On lui permet de le faire lorsqu'il entre "y". Dans les autres cas, on termine le programme
         */
        string answer2;
        do
        {
            int answer;

            Console.WriteLine("choisissez un nombre entier");
            answer = Convert.ToInt32(Console.ReadLine());
            if (answer % 2 == 0)
            {
                Console.WriteLine("ton nombre est pair");
            }
            else
            {
                Console.WriteLine("ton nombre est impair");
            }
            Console.WriteLine("voulez vous en choisir un autre ? (y/n) ");
            answer2 = Console.ReadLine();
        } while (answer2 != "n");
       

    }
}
