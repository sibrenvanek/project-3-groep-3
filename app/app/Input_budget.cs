using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
using System.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


//namespace app
//{
//    class Input_budget
//    {
//        Keys[] LastPressedKeys = new Keys[1];


//        public Input_budget()
//        {
//            GetKeys();
//        }
//        private void GetKeys()
//        {
//            KeyboardState kbState = Keyboard.GetState();
//            GetKeys[] pressedKeys = kbState.GetPressedKeys();

//            foreach (Keys key in lastPressedKeys)
//            {
//                if (!pressedKeys.Contains(key))
//                    OnKeyDown(key);
//            }
//            lastPressedKeys = pressedKeys;
//        }
//        private void OnKeyDown(Keys key)
//        {
//            if (key == GetKeys.Back && name.Length > 0)
//            {
//                name = name.Remove(name.Length - 1);
//            }
//            else if (key == key.LeftShift || key == GetKeys.RightShift)
//            {
//                caps = true;
//            }
//            else if (!caps && name.Length < 16)
//            {
//                if (key == GetKeys.Space)
//                {
//                    name += " ";
//                }
//                else
//                {
//                    name += key.ToString().ToLower();
//                }
//            }
//            else if (name.Length < 16)
//            {
//                name += key.ToString();
//            }
//        }
//        private void OnKeyUp(Keys key)
//        {
//            if(key==GetKeys.LeftShift || key==GetKeys.RightShift)
//            {
//                caps = false;
//            }
//        }
//    }
//}
