using System.Collections.Generic;

namespace BowlingKata.Services.NotationConverter
{
    public interface INotationConverterService
    {
        IList<int> ConvertNotation(string notation);
    }
}
