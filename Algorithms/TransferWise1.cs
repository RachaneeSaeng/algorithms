using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Algorithms
{
    public class TransferWise1
    {
        static void PrintOutput(string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
                textWriter.WriteLine(text);
                textWriter.Flush();
                textWriter.Close();
            }
        }

        public static int Method1()
        {
            return 0;
        }
    }
}
