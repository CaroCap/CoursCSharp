using System;

namespace PremiereApplicationConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			// Opérations de sortie (écriture dans la console)
				Console.WriteLine("Hello World!" + 15 + "deuxieme ...");
				string name = "Grégory";
				Console.WriteLine("Bonjour je m'appelle {0} {1}", name, "Ceuleers");
				Console.WriteLine($"Bonjour je m'appelle {name}");
				Console.Write(true);
				Console.Write(1);
				Console.Write('A');

				//Commenter la ligne avec CTRL + K + C
				//Decommenter la ligne avec CTRL + K + U
				/*    OU via CTRL + SHIFT + /   */


				// Opération d'entrée (lecture depuis la console)
				string donnee = Console.ReadLine();
				Console.WriteLine(donnee);
				// Raccourci clavier pour générer directement
				// un Console.WriteLine() : cw + TAB + TAB

				ConsoleKeyInfo input = Console.ReadKey();
				Console.WriteLine(input.Key);

				Console.Clear();

		}
	}
}
