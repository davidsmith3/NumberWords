using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberWords.Domain {
    public class Generator {

        private Dictionary<string, string> ntol = new Dictionary<string, string>()
        {
            {"1", "A"},
            {"2", "B"},
            {"3", "C"},
            {"4", "D"},
            {"5", "E"},
            {"6", "F"},
            {"7", "G"},
            {"8", "H"},
            {"9", "I"},
            {"10", "J"},
            {"11", "K"},
            {"12", "L"},
            {"13", "M"},
            {"14", "N"},
            {"15", "O"},
            {"16", "P"},
            {"17", "Q"},
            {"18", "R"},
            {"19", "S"},
            {"20", "T"},
            {"21", "U"},
            {"22", "V"},
            {"23", "W"},
            {"24", "X"},
            {"25", "Y"},
            {"26", "Z"}
        };

        public List<string> GetWords(int num) {
            return GetWords(num.ToString());
        }

        private List<string> GetWords(string s) {
            List<string> words = new List<string>();
            if (s.Length == 1) {
                if (ntol.ContainsKey(s)) {
                    words.Add(ntol[s]);
                }
            } else if (s.Length == 2) {
                if (ntol.ContainsKey(s)) {
                    words.Add(ntol[s]);
                }
                string prefix = s.Substring(0, 1);
                string suffix = s.Substring(1);
                if (ntol.ContainsKey(prefix) && ntol.ContainsKey(suffix)) {
                    words.Add(ntol[prefix] + ntol[suffix]);
                }
            } else {
                string prefix1 = ntol[s.Substring(0, 1)];
                List<string> suffix1list = GetWords(s.Substring(1));
                foreach (var suffix1 in suffix1list) {
                    words.Add(prefix1 + suffix1);
                }

                string prefix2 = s.Substring(0, 2);
                if (ntol.ContainsKey(prefix2)) {
                    prefix2 = ntol[prefix2];
                    List<string> suffix2list = GetWords(s.Substring(2));
                    foreach (var suffix2 in suffix2list) {
                        words.Add(prefix2 + suffix2);
                    }
                    
                }
            }
            return words;
        }
    }
}
