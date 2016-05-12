using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace SJsonTest
{
    class Program
    {
        static void Main( string[] args )
        {
            string outStr = null;
            object data   = null;
            string jsonStr = File.ReadAllText( "test.json" );

            try
            {
                data = JsonConvert.DeserializeObject( jsonStr );
            }
            catch( Exception ex )
            {
                Console.WriteLine( "Error parsing json file:" );
                Console.WriteLine( ex.Message );
                if( ex.InnerException != null )
                    Console.WriteLine( ex.InnerException.Message );
            }

            if( data != null )
                outStr = JsonConvert.SerializeObject( data );

            if( !string.IsNullOrEmpty(outStr) )
            {
                Console.WriteLine( outStr );
            }

            Console.ReadKey();
        }
    }
}
