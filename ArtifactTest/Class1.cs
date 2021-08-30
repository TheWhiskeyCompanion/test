using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtifactTest
{
    public class Class1
    {
        public string Property1 { get; set; }
        public static string Function1()
        {
            // A comment
            for(int i=0; i<100;i++){
                Console.WriteLine("thursday 4 world");
            }
            // yet another comment
            string json = @"{
                'CPU': 'Intel',
                'PSU': '500W'
                }";
            JsonTextReader reader = new JsonTextReader(new StringReader(json));
            while (reader.Read())
            {
              if (reader.Value != null)
              {
                 Console.WriteLine("Token: {0}, Value: {1}", reader.TokenType, reader.Value);
              }
              else
              {
                 Console.WriteLine("Token: {0}", reader.TokenType);
              }
             }
            return "done";
        }
    }
}
