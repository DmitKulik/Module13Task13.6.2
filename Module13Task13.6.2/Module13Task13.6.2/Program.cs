namespace Module13Task1362
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;

    class Program{
        static void Main(string[] args){

            string _testText = File.ReadAllText(@"C:\Users\uites\OneDrive\Документы\ListVSLinkedList.txt");
            var _noPunctuationText = new string(_testText.Where(c => !char.IsPunctuation(c)).ToArray());

            Dictionary<string, int> _tenPrivateWords = new Dictionary<string, int>();
            string[] _words = _noPunctuationText.Split();

            foreach (string word in _words){
                if (_tenPrivateWords.ContainsKey(word))
                    _tenPrivateWords[word]++;

                else
                    _tenPrivateWords.Add(word, 1);
            }

            int z = 0;
            foreach (KeyValuePair<string, int> v in _tenPrivateWords.OrderByDescending(x => x.Value)){
                z++;
                Console.WriteLine($"Слово {v.Key} = {v.Value} раз в тексте");
                if (z == 10) break;
            }
        }
    }
}