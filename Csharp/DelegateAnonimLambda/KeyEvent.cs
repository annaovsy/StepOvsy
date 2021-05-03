using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAnonimLambda
{
    class KayeventArgs : EventArgs
    {
        public char Key { get; set; }
    }

    class KeyEvent
    {
        public event EventHandler<KayeventArgs> KeyPress;

        public void OnKeyPress(char key)
        {
            KeyPress?.Invoke(this, new KayeventArgs { Key = key });
        }

    }
}
