using System.Net.NetworkInformation;
using static System.Formats.Asn1.AsnWriter;
using MathGame;

namespace MathGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var name = Helpers.GetName();
            var date = DateTime.UtcNow;

            //var games = new List<string>();

            var menu = new Menu();

            while (true)
            {
                menu.ShowMenu(name, date);
            }
        }

    }
}
