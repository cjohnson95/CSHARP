using System;


namespace StringLibrary {
    public static class StringLib 
    {
        // rotate the chars within a string
        // abcd => dabc => cdab => bcda=> abcd =>
        public static string RemoveVowels(string s) 
        {
            var vowels = new char[]
                  {'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'};
            var pos = s.IndexOfAny(vowels);
            while (pos > -1) 
            {
                s = s.Remove(pos, 1);
                pos = s.IndexOfAny(vowels);

            }
            return s;
        
        }

        public static object Rotate(string s) 
        {
            return s[s.Length - 1] +s.Substring(0, s.Length - 1);
        }

        public static string Reverse(string s) 
        {
            var charArr = s.ToCharArray();                                 // the orange dot is a breakpoint. You click it into the grey line behind the number lines. Once
            var reversedString = "abcd";
                                                                        // the breakpoint is set, you can run in debug mode, and the program will run in that mode to find the
            for (var idx = 0; idx < s.Length; idx++)
            {
                var idx2 = s.Length - idx - 1;
                reversedString += charArr[idx2];
            }
            return reversedString;                                                       //charArr looks like { 'a', 'b', 'c' } : charArr[0]// a == charArr[3] = 4 - 0 - 1 = 3
                                                                        // the error. HOWEVER, running in this mode makes the program run very slowly. Once 
                                                                                         // : charArr[1]// b == charArr[2] = 4 - 1 - 1 = 2
        }                                                                               // : charArr[2]// c == charArr[1] = 4 - 2 - 1 = 1
    }                                                                                     // : charArr[3]// d == charArr[0] = 4 - 3 - 1 = 0
}
