using System;

namespace DemoTypeDonneesPredefinis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            // Un octet (8 bits de données)
            // 00000000
            // 00000001
            // 00000010
            // ........
            // 11111111
            // 2 puissance 8 = 256
            // Valeurs possibles : [-128, 127]
            sbyte bit = -127;
            
            //16 Bits > 2 puissance 16 possibilités
            short deuxOctet = 32000;

            int quatreOctet = 14877444;
            //000000000000000000000000000000000001
            long huitOctect = 151515115151515115L;
            double d = 5.1515151;
            float f = 5.181818181F;
            decimal decim = 5.15151M;

            float res = 100 / 200F * 5;
            Console.WriteLine(res);

            int reste = 10 % 3; // 10 MODULO 3
                                // -> le reste de la division entière
                                // de 10 par 3
            Console.WriteLine($"reste  {reste}");



        }
    }
}
