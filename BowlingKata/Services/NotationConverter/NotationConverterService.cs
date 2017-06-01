using System.Collections.Generic;

namespace BowlingKata.Services.NotationConverter
{
    public class NotationConverterService : INotationConverterService
    {
        public IList<int> ConvertNotation(string notation)
        {
            var pinsList = new List<int>();
            
            for (int i = 0; i < notation.Length; i++)
            {
                if (char.IsNumber(notation[i]))
                {
                    pinsList.Add((int)char.GetNumericValue(notation[i]));
                }
                else if (notation[i].ToString() == "X")
                {
                    pinsList.Add(10);
                }
                else if (notation[i].ToString() == "/")
                {
                    pinsList.Add(10 - (int)char.GetNumericValue(notation[i - 1]));
                }
                else if (notation[i].ToString() == "-")
                {
                    pinsList.Add(0);
                }
            }
            return pinsList;
        }
    }
}
