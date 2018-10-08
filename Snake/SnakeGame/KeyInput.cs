using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_Game
{
    internal class KeyInput
    {
        //list available keyboard buttons
        private static Hashtable keyTable = new Hashtable();

        //check if a particular key is pressed.
        public static bool KeyPressed(Keys key)
        {
            if (keyTable[key] == null)
            {
                return false;
            }
            return (bool)keyTable[key];
        }


        
        public static void ChangeState(Keys key, bool state)
        {
            //detects the pressed key
            keyTable[key] = state;
        }
    }
}
