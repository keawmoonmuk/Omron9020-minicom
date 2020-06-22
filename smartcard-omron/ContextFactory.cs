using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace smartcard_omron
{
    class ContextFactory
    {
        //private static void DisplayReaderStatus(ISCardContext context, IEnumerable<string> readerNames)
        //{
        //    foreach (var readerName in readerNames)
        //    {
        //        try
        //        {
        //            using (var reader = context.ConnectReader(readerName, SCardShareMode.Shared, SCardProtocol.Any))
        //            {
        //                PrintReaderStatus(reader);
        //                Console.WriteLine();
        //            }
        //        }
        //        catch (Exception exception)
        //        {
        //            Console.Error.WriteLine(
        //                "No card inserted or reader '{0}' is reserved exclusively by another application.", readerName);
        //            Console.Error.WriteLine("Error message: {0} ({1})\n", exception.Message, exception.GetType());
        //        }
        //    }
        //}
        public static object Instance { get; internal set; }
    }
}
