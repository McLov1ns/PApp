using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PApp
{
    public static class TestData
    {
        public static string GetTextFromFile(string path)
        {
            return File.ReadAllText(path);
        }
    }
}
