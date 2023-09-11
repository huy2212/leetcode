using System;
using System.Collections.Generic;
public class Solution
{
    public bool IsValid(string s)
    {
        var st = new Stack<char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(' || s[i] == '{' || s[i] == '[')
            {
                st.Push(s[i]);
            }
            else
            {
                if (st.Count == 0)
                {
                    return false;
                }
                else
                {
                    if (isPair(st.Peek(), s[i]))
                    {
                        st.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
        return st.Count == 0 ? true : false;
    }

    public bool isPair(char top, char next)
    {
        switch (top)
        {
            case '(':
                if (next != ')') return false;
                else break;
            case '{':
                if (next != '}') return false;
                else break;
            case '[':
                if (next != ']') return false;
                else break;
        }
        return true;
    }
}