using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulationsInternal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("my second commit");
            Console.WriteLine("Please Enter the Username :");
            string userName = Console.ReadLine();
            string middleName = string.Empty;

            string[] namePartsWithoutSpaces = userName.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string firstName = namePartsWithoutSpaces[0].Trim();
            if (namePartsWithoutSpaces.Length > 1)
            {
                middleName = string.Join(" ", namePartsWithoutSpaces.Skip(1).ToArray());
            }

            Console.WriteLine(firstName);
            Console.WriteLine(middleName);
            Console.ReadLine();

        }
    }
}
