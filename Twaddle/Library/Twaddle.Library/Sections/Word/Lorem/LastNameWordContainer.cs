using System.Collections.Generic;
using System.Linq;

namespace Codetreehouse.Twaddle.Containers.Lorem
{
    public class LastNameWordContainer : WordListContainer
    {
        public override List<string> GetWordList()
        {
            //Data from National Records of Scotland https://www.nrscotland.gov.uk/statistics-and-data/statistics/

            return "Smith,Brown,Wilson,Robertson,Campbell,Stewart,Thomson,Anderson,Scott,Macdonald,Reid,Murray,Clark,Taylor,Ross,Young,Paterson,Watson,Mitchell,Fraser,Walker,Henderson,Morrison".Split(',').ToList();
        }
    }
}