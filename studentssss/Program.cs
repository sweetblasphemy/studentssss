using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace studentssss
{
    internal class Program
    {
        static void Main(string[] args)
        {

            student s1 = new student ("Niko", 15, 4492347, 4, 6, 5, 6, 5);
            student s2 = new student("Finn", 15, 4207549, 5, 6, 2, 4, 6);
            student s3 = new student("Ru", 15, 4874294, 5, 5, 6, 4, 6);
            student s4 = new student("Luna", 15, 4871873, 5, 4, 3, 6, 6);

            s1.print();
            s2 .print();
            s3 .print();
            s4 .print();

            av_result.print();

            
        }
    }
}