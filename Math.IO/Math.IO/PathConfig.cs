﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math.IO
{
    public static class PathConfig
    {
        private static string _conceptFilePath = "Topics.json";

        private static string _problemFilePath = "Problems.json";

        private static string _instructionPath = "Instructions.json";

        private static string _dataFolderName = "MathProblem-Dataset";

        public static string RetrieveConceptPath()
        {
            string startupPath;
            try
            {
                startupPath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName,
                    _dataFolderName,
                    _conceptFilePath);
                return startupPath;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}