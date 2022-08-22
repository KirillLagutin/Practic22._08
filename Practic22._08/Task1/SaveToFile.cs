using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic22._08.Task1
{
    internal class SaveToFile : IDrinkToFile
    {
        public void SaveDrink(string text)
        {
            string path = "../../../App_Data/drink.txt";
            File.AppendAllText(path, text);
        }
    }
}
