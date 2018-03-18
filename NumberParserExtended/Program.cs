using NumberParserExtended.Common;
using NumberParserExtended.Common.Configurations;
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
                ContentField readField = buildContentField.Build(contentFile);

                Recognize recognize = new Recognize();
                if (recognize.DoRecognize<NumberOneConfiguration>(readField))
                {
                    Console.WriteLine("Recognized one");
                }
                if (recognize.DoRecognize<NumberTwoConfiguration>(readField))
                {
                    Console.WriteLine("Recognized two");
                }
                if (recognize.DoRecognize<NumberThreeConfiguration>(readField))
                {
                    Console.WriteLine("Recognized three");
                }
                if (recognize.DoRecognize<NumberFourConfiguration>(readField))
                {
                    Console.WriteLine("Recognized four");
                }
                if (recognize.DoRecognize<NumberFiveConfiguration>(readField))
                {
                    Console.WriteLine("Recognized five");
                }
                

            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.ReadLine();
        }
    }
}
