using NumberParserExtended.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace NumberParserExtended
{
    class Program
    { 

        static async Task Main(string[] args)
        {
            try
            {
                var assembly = Assembly.GetExecutingAssembly();
                var resourceName = "NumberParserExtended.NumberParserExtended.txt";

                string contentFile = string.Empty;

                using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                using (StreamReader reader = new StreamReader(stream))
                {
                    contentFile = await reader.ReadToEndAsync();
                }

                BuildContentField buildContentField = new BuildContentField();
                buildContentField.Build(contentFile);

                Console.WriteLine("Hello World!");

            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.ReadLine();
        }
    }
}
