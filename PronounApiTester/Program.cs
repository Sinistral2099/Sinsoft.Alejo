using Sinsoft.Alejo;
using System;

namespace PronounApiTester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PronounsApi pApi = new PronounsApi();

            Console.WriteLine("sinistral2099");
            Console.WriteLine(pApi.GetUserPronouns("sinistral2099").FriendlyName);
            Console.WriteLine("nintendesi");
            Console.WriteLine(pApi.GetUserPronouns("nintendesi").FriendlyName);
            Console.WriteLine("saberamesia");
            Console.WriteLine(pApi.GetUserPronouns("saberamesia").FriendlyName);
            Console.ReadKey();
        }
    }
}
