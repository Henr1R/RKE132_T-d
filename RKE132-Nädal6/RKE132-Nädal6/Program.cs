using System;

namespace RKE132_Nädal6
{
	internal class Program
	{
		static void Main(string[] args)
		{


			string tervitus = "me oleme tsempionid";

			int stringLength = tervitus.Length;

			tervitus = tervitus.Trim();

			char esimeneTaht = tervitus[0];
			Console.WriteLine(esimeneTaht);

			tervitus = tervitus.Replace(tervitus[0], char.ToUpper(tervitus[0])).Replace('?', '!');

			esimeneTaht = tervitus[0];
			Console.WriteLine(esimeneTaht);

			Console.WriteLine(tervitus);
		}
	}
}
