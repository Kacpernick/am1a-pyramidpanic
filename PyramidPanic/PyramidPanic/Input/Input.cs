using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace PyramidPanic
{
    public static class Input
    {
        //Fields
        //KeyboardSta
        private static KeyboardState ks, oks;

        private static MouseState ms ,oms;

        //Dit is een rectengle
        private static Rectangle mouseRect;

        //Constructor

        static Input()
        {
            ks = Keyboard.GetState();
            ms = Mouse.GetState();
            oks = ks;
            oms = ms;
            mouseRect = new Rectangle(ms.X, ms.Y, 1, 1);
        }

        //Update
        public static void Update()
        {
            oks = ks;
            oms = ms;
            ks = Keyboard.GetState();
            ms = Mouse.GetState();
        }

        //Dit is een edgedetector voor het indrukken
        public static bool EdgeDetectKeyDown(Keys key)
        {
            return (ks.IsKeyDown(key) && oks.IsKeyUp(key));
        }
        //Dit is een edgedetector voor het loslaten
        public static bool EdgeDetectKeyUp(Keys key)
        {
            return (ks.IsKeyUp(key) && oks.IsKeyDown(key));
        }


        public static bool EdgeDetectMousePressLeft()
        {
            return ((ms.LeftButton == ButtonState.Pressed) && (oms.LeftButton == ButtonState.Released));
        }
        //LevelDetector ingedrukt
        public static bool LevelDetectKeyDown(Keys key)
        {
            return (ks.IsKeyDown(key));
        }
        //LevelDetector losgelate
        public static bool LevelDetectKeyUp(Keys key)
        {
            return (ks.IsKeyUp(key));
        }
        public static Vector2 MousePosition()
        {
            return new Vector2(ms.X, ms.Y);
        }

        public static Rectangle MouseRect()
        {
            mouseRect.X = ms.X;
            mouseRect.Y = ms.Y;
            return mouseRect;
        }
    }
}
