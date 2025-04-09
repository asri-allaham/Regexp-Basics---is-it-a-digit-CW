using System;
using System.Text;
using System.Text.RegularExpressions;

public static class Kata
{
    public static bool Digit(this string s)
    {
        /*
        Implement String#digit? (in Java StringUtils.isDigit(String)), 
        which should return true if given object is a single digit (0-9), false otherwise.
        */
      
        if (s.Length==0 || s.Length>1 ){return false;}
      
        int num = (int)char.GetNumericValue(s[0]);
      
            if( num!=-1 ){
                  return true;
              }
      
        return false;
    }
}