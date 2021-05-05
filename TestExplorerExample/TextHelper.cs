using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExplorerExample
{
    public class TextHelper
    {
        public string Reverse(string text)
        {
            var list = text.ToList();
            list.Reverse();
            return string.Join("", list.ToArray());
        }

        public string StartUpper(string text)
        {
            var lowerText = text.ToLower();
            return $"{lowerText[0]}{lowerText[1..]}";
        }

        public string ToUpper(string text) => text.ToUpper();

        public string ToLower(string text) => text.ToLower();

        public string MixUp(string text)
       {
            var rnd = new Random();
            return string.Join("",text.ToList().OrderBy(x => rnd.Next()).ToArray());

        }
    } 
}
