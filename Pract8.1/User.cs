using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract8._1
{
    public class User
    {
        public string UserName;
        public double WordsInMinute;
        public double WordsInSecond;
        public User(string UN, double WIM, double WIS)
        {
            UserName = UN;
            WordsInMinute = WIM;
            WordsInSecond = WIS;
        }
    }
}
