using CodeQuality.NetStandard;
using System;

namespace CodeQuality.CoreConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Treating Collection Of Objects As An Object
            TreatingCollectionOfObjectsAsAnObject treatingCollectionOfObjectsAsAnObject
               = new TreatingCollectionOfObjectsAsAnObject();
            treatingCollectionOfObjectsAsAnObject.Run();

            Console.ReadLine();
        }
    }
}
