using System;

public class Solution
{
    public int solution(string[] babbling)
    {
        int answer = 0;
        string[] check = { "aya", "ye", "woo", "ma" };

        for (int i = 0; i < babbling.Length; i++)
        {
            for (int j = 0; j < check.Length; j++)
            {
                string temp = check[j] + check[j];
                babbling[i] = babbling[i].Replace(temp, "1");
                babbling[i] = babbling[i].Replace(check[j], " ");
            }

            if (babbling[i].Trim().Length == 0)
            {
                answer++;
            }
        }

        return answer;
    }
}