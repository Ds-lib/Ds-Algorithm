using System;

public class Solution
{
    public int solution(int a, int b, int n)
    {
        int answer = 0;

        while (n >= a)
        {
            int temp = n;
            n /= a;
            n *= b;
            answer += n;
            n += temp % a;
        }

        return answer;
    }
}