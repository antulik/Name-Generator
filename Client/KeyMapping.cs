using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Client.Generators;
using System.Windows.Forms;
using System.Threading;

namespace Client
{
    class KeyMapping
    {
        public KeyMapping()
        {
            Hotkey.Pressed += delegate
            {
                OnPress();
            };
        }

        private Hotkey _hotkey = new Hotkey();

        public Hotkey Hotkey
        {
            get {
                return _hotkey;
            }
        }

        public INameGenerator Generator {get; set;}

        public String Name
        {
            get
            {
                if (Generator != null) {
                    return Generator.Name;
                }
                return "Unknown";
            }
        }

        public String Status {get;set;}

        private void OnPress()
        {
            while (NullFX.Win32.KeyboardInfo.GetKeyState(Keys.ControlKey).IsPressed ||
                    NullFX.Win32.KeyboardInfo.GetKeyState(Keys.ShiftKey).IsPressed ||
                    NullFX.Win32.KeyboardInfo.GetKeyState(Keys.Menu).IsPressed ||
                    NullFX.Win32.KeyboardInfo.GetKeyState(Keys.LWin).IsPressed ||
                    NullFX.Win32.KeyboardInfo.GetKeyState(Keys.RWin).IsPressed)
            {
                Thread.Sleep(50);
            }
            Console.WriteLine("pressed!");

            var name = Generator.Generate();
            SendKeys.Send(name);
        }

        public void UnRegister()
        {
            if (Hotkey.Registered)
            {
                Hotkey.Unregister();
                Status = "Unregistered";
                Console.WriteLine(Status);
            }
        }

        public void Register(Control windowControl)
        {
            if (!Hotkey.GetCanRegister(windowControl))
            {
                Status = "Cannot Register";
            }
            else
            {
                Hotkey.Register(windowControl);
                Status = "Registered";
                
            }
            Console.WriteLine(Status);
        }

        public bool Alt
        {
            get
            {
                return Hotkey.Alt;
            }
            set
            {
                Hotkey.Alt = value;
            }
        }

        public bool Control
        {
            get
            {
                return Hotkey.Control;
            }
            set
            {
                Hotkey.Control = value;
            }
        }

        public bool Shift
        {
            get
            {
                return Hotkey.Shift;
            }
            set
            {
                Hotkey.Shift = value;
            }
        }

        public bool Win
        {
            get
            {
                return Hotkey.Windows;
            }
            set
            {
                Hotkey.Windows = value;
            }
        }

        public string KeyCode
        {
            get
            {
                return Hotkey.KeyCode.ToString();

            }

            set
            {
                try
                {
                    Hotkey.KeyCode = (Keys)Enum.Parse(typeof(Keys), value);
                }
                catch (ArgumentException)
                {
                }
            }

        }

    }
}
