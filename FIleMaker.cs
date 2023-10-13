using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MathProblems
{
    public static class FileMaker {
        public static void CreateResponse(string fileName, string content)
        {
            string filePath = "solutions/"+fileName+".txt";
            File.WriteAllText(filePath,content);
        }
        
    }
}