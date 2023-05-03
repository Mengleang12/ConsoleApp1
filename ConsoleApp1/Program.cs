using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string ipv4;
            while (1 == 1)
            {
                Console.Write("Enter IPv4  addresses: ");
                ipv4 = Console.ReadLine();
                bool x = IsValidIPV4(ipv4);
                Console.WriteLine(x);
            }
        }
        private static bool IsValidIPV4(string ipv4)
        {
            string[] octets = ipv4.Split('.');
            if (octets.Length != 4) // IPv4 must 4 octets
            {
                return false;
            }
            foreach (string octet in octets)
            {
                if (string.IsNullOrWhiteSpace(octet))
                {
                    return false; // each octet can not be blank
                }
                else if (octet.StartsWith("0") && octet.Length != 1) // each octet not allow 0 leading
                {
                    return false;
                }
                else if (octet.Length > 3) // each octet allow only 3 digits
                {
                    return false;
                }
                else
                {
                    int ipRange = int.Parse(octet);
                    // each octet must in range 0 - 255
                    if (ipRange < 0 || ipRange > 255) return false;
                }
            }
            return true;
        }
    }
}
