using System;

public class Solution
{
	public int solution(string s)
	{
		int answer = 0;

		string[] check = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

		for (int i = 0; i < 10; i++)
		{
			s = s.Replace(check[i], $"{i}");
		}

		answer = int.Parse(s);

		return answer;
	}

}