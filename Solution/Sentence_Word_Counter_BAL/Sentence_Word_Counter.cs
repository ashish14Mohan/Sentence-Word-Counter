using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentence_Word_Counter_BAL
{
   public static class Sentence_Word_Counter
    {
        /// <summary>
        /// This function is used to returned a distinct list of words in the sentence
        /// and the number of times they have occurred
        /// </summary>
        /// <param name="senetence">This is good to see you , and good to know you.</param>
        /// <returns></returns>

        public static string SentenceWordWithCount(string senetence)
        {
            string txtOutputwrdcount = " ";
            try
            {
                if (string.IsNullOrEmpty(senetence) || string.IsNullOrWhiteSpace(senetence))
                {
                    //txtOutputwrdcount = "INPUT value in blank or null";
                    txtOutputwrdcount = string.Empty;
                }
                else
                {
                    //Convert string into array and removing extra spaces and special chars
                    string[] breakSenetceToWord = ReturnValidString(senetence).ToLower().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                    var wordCounts = breakSenetceToWord.GroupBy(x => x).Select(x => new { Name = x.Key, Count = x.Count() }).ToList();                  
                    for (int i = 0; i < wordCounts.Count; i++)                    
                    {
                        if (string.IsNullOrEmpty(txtOutputwrdcount))
                        {
                            txtOutputwrdcount = wordCounts[i].Name + "-" + wordCounts[i].Count;//Seprating by colon(-)
                        }
                        else
                        {
                            txtOutputwrdcount += "\n" + wordCounts[i].Name + "-" + wordCounts[i].Count;//Seprating by \n for new line 
                        }
                    }

                }

            }
            catch { throw; }
            return txtOutputwrdcount;

        }

        /// <summary>
        /// This function is used to Remove the Special 
        /// Character with blank Space
        /// </summary>
        /// <param name="str">This is good to see you , good to know you.</param>
        /// <returns></returns>
        private static string ReturnValidString(string str)
        {
            var characters = str.Select(c =>
            {
                if (!char.IsLetter(c)) return ' ';
                return c;
            }).ToArray();

            return new string(characters);
        }
    }
}
