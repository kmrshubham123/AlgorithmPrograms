using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class TwoStringFunction
    {
        public static bool CheckEquality(String[] strOne, String[] strTwo)
        {
            if(strOne==strTwo)
            {
                return true;
            }
            if(strOne==null || strTwo==null)
            {
                return false;
            }
            int len = strOne.Length;
            if (len != strTwo.Length)
            {
                return false;
            }
            for(int i=0; i<len; i++)
            {
                if (!strOne[i].Equals(strTwo[i])) 
                {
                    return false;
                }
            }return true;
        }
    }
}
