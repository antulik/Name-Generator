/******************************************************/
/*          NULLFX FREE SOFTWARE LICENSE              */
/******************************************************/
/*  GetKeyState Utility                               */
/*  by: Steve Whitley                                 */
/*  © 2005 NullFX Software                            */
/*                                                    */
/* NULLFX SOFTWARE DISCLAIMS ALL WARRANTIES,          */
/* RESPONSIBILITIES, AND LIABILITIES ASSOCIATED WITH  */
/* USE OF THIS CODE IN ANY WAY, SHAPE, OR FORM        */
/* REGARDLESS HOW IMPLICIT, EXPLICIT, OR OBSCURE IT   */
/* IS. IF THERE IS ANYTHING QUESTIONABLE WITH REGARDS */
/* TO THIS SOFTWARE BREAKING AND YOU GAIN A LOSS OF   */
/* ANY NATURE, WE ARE NOT THE RESPONSIBLE PARTY. USE  */
/* OF THIS SOFTWARE CREATES ACCEPTANCE OF THESE TERMS */
/*                                                    */
/* USE OF THIS CODE MUST RETAIN ALL COPYRIGHT NOTICES */
/* AND LICENSES (MEANING THIS TEXT).                  */
/*                                                    */
/******************************************************/

namespace NullFX.Win32
{
    using System;
    using System.Windows.Forms;
    using System.Runtime.InteropServices;
    public class KeyboardInfo
    {
        private KeyboardInfo() { }
        [DllImport("user32")]
        private static extern short GetKeyState(int vKey);
        public static KeyStateInfo GetKeyState(Keys key)
        {
            short keyState = GetKeyState((int)key);
            byte[] bits = BitConverter.GetBytes(keyState);
            bool toggled = bits[0] > 0, pressed = bits[1] > 0;
            return new KeyStateInfo(key, pressed, toggled);
        }
    }


    public struct KeyStateInfo
    {
        Keys _key;
        bool _isPressed,
            _isToggled;
        public KeyStateInfo(Keys key,
                        bool ispressed,
                        bool istoggled)
        {
            _key = key;
            _isPressed = ispressed;
            _isToggled = istoggled;
        }
        public static KeyStateInfo Default
        {
            get
            {
                return new KeyStateInfo(Keys.None,
                                            false,
                                            false);
            }
        }
        public Keys Key
        {
            get { return _key; }
        }
        public bool IsPressed
        {
            get { return _isPressed; }
        }
        public bool IsToggled
        {
            get { return _isToggled; }
        }
    }
}