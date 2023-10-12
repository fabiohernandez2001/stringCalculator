﻿using System.Data;

namespace StringCalculator
{
    public class stringCalculator
    {
        private char[] separators = {','};
        public stringCalculator()
        { }
        public void SetFormat(char[] new_sep)
        {
            separators = new_sep;
        }
        public string[] TakeArgs(string args)
        {
            string[] filtered = args.Split(separators);
            if (string.IsNullOrEmpty(filtered.First())) { filtered = filtered.Skip(1).ToArray(); }
            if (string.IsNullOrEmpty(filtered.Last())) { filtered = filtered.SkipLast(1).ToArray(); }
            return filtered;
        }
        public int add(string op)
        {
            if (string.IsNullOrEmpty(op)) { return 0; }
            int[] argvs = TakeArgs(op).Cast<int>().ToArray();
            return argvs.Sum();
        }
    }
}