using System;
using System.Collections.Generic;
using System.Text;

namespace This_end_base
{
    class Baba
    {
        public int zozo(params int[]arg)
        {
            int result = arg[0];
            for (int i = 0; i < arg[0]; i++)
            {
                if (result < arg[i])
                {
                    result = arg[i];
                }
            }
            return result;
        }
        public string zozo(string a, string b)
        {
            return a.Length > b.Length ? a : b;
        }
    }
    class Boba : Baba
    {
        
    }
}
