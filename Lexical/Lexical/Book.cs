using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexical
{
    public class Book
    {
        public Book()
        {
            //constructor
        }

        #region public methods
        public string Concatenate(string w1, string w2)
        {
            return this.Format(w1) + " " + this.Format(w2);
        }
        #endregion public methods

        #region private methods
        private string Format(string wordToFormat)
        {
            return wordToFormat.Substring(0, 1).ToUpper() + wordToFormat.Substring(1);
        }
        #endregion private methods
    }
}
