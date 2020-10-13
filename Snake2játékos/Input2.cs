using System.Collections;
using System.Windows.Forms;

namespace Snake
{
    class Input2
    {
        private static Hashtable keyTable2 = new Hashtable();


        public static bool KeyPressed2(Keys key)
        {
            if (keyTable2[key] == null)
            {
                return false;
            }

            return (bool)keyTable2[key];
        }


        public static void ChangeState2(Keys key, bool state)
        {
            keyTable2[key] = state;
        }
    }
}
