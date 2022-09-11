using System;
namespace RomanNumeralsService
{
	public class RomanNumerals
	{
		public RomanNumerals()
		{
		}

			Dictionary<int, string> RomanNumeralsValueKey = new Dictionary<int, string>
			{

				{1000, "M"},
				{900, "CM"},
				{500, "D"},
				{400, "CD"},
				{ 100, "C"},
				{ 90, "XC"},
                { 40, "XL"},
                { 10, "X"},
                { 9, "IX"},
                { 5, "V"},
                { 4, "IV"},
                { 1, "I" }
			};

			
        
		public string RomanNumeralsConverter(int num)

		{
			string result = "";
            if (num <= 0 || num > 4999)
            {
                result = "Only values ranging from 1-4999 can be converted using this application";

            }

            foreach (var item in RomanNumeralsValueKey)
			{

				while (num >= item.Key)
				{
					result += item.Value;
					num -= item.Key;
				}
			}
			return result;


        } 
	}
}

