using System;

namespace Palindrome.Domain
{
    public class PalindroneChecker
    {
        public int Middle(string x){
            int result;
            if (x.Length%2 == 0){
            result = (x.Length)/2;
            return result;
            }
            else{
            result = (x.Length/2)-1;
            return result;
            }

        }
        public bool Check(string x, int index,int lastIndex)//returns true if ture or false if false
        {
            if(index == Middle(x))
            {
                if(x.Length%2 == 0)
                {
                    if(x[index] == x[lastIndex])
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return true;
                }
            }

            if(x[index] == x[lastIndex]){
                Check(x,index+=1,lastIndex+=1);
            }
            else
            {
                return false;
            }
        }
    }
}
