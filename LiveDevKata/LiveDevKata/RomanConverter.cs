namespace LiveDevKata
{
    using System.Collections.Generic;

    public class RomanConverter
    {
        public string ConvertToRoman(int input)
        {
            string result = string.Empty;

            new List<KeyValuePair<int, string>>
            {
                new KeyValuePair<int, string>(5, "V"),
                new KeyValuePair<int, string>(4, "IV"),
                new KeyValuePair<int, string>(1, "I")
            }.ForEach(pair =>
            {
                while (input >= pair.Key)
                {
                    input -= pair.Key;
                    result += pair.Value;
                }
            });


            return result;
        }
    }
}
