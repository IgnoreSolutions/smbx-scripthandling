using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmbxScripting
{
    public class ScriptHandling
    {
        /// <summary>
        /// Displays a message prompt for the user
        /// </summary>
        /// <param name="message">The message to be shown</param>
        /// <param name="type">The type of message to show
        /// 0=OK Only Message
        /// 1=Yes or No message</param>
        public void userPrompt(string message, int type)
        {
            if (type == 0)
            {
                MessageBox.Show(message, "Script", MessageBoxButtons.OK);
            }
            else if (type == 1)
            {
                MessageBox.Show(message, "Script", MessageBoxButtons.YesNo);
            }
        }

        public void copyFile(string source, string dest)
        {

        }
    }
}
