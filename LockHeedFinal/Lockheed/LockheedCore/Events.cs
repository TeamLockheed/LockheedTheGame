using System;

using SFML.Graphics;
using SFML.Window;
namespace LockHeedCore
{
    public static class Events
    {
        public static bool keyArrowLeft = false;
        public static bool keyArrowUp = false;
        public static bool keyArrowDown = false;
        public static bool keyArrowRight = false;

        public static void OnClose(object sender, EventArgs e)
        {
            RenderWindow window = (RenderWindow)sender;
            window.Close();
        }



        public static void OnKeyPressed(object sender, KeyEventArgs e)
        {
            RenderWindow window = (RenderWindow)sender;
            if (e.Code == Keyboard.Key.Left)
            {
                keyArrowLeft = true;
            }
            else if (e.Code == Keyboard.Key.Right)
            {
                keyArrowRight = true;
            }
            if (e.Code == Keyboard.Key.Up)
            {
                keyArrowUp = true;
            }
            else if (e.Code == Keyboard.Key.Down)
            {
                keyArrowDown = true;
            }

        }
        public static void OnKeyReleased(object sender, KeyEventArgs e)
        {
            RenderWindow window = (RenderWindow)sender;
            if (e.Code == Keyboard.Key.Left)
            {
                keyArrowLeft = false;
            }
            else if (e.Code == Keyboard.Key.Right)
            {
                keyArrowRight = false;
            }
            if (e.Code == Keyboard.Key.Up)
            {
                keyArrowUp = false;
            }
            else if (e.Code == Keyboard.Key.Down)
            {
                keyArrowDown = false;
            }

        }
        public static void OnMouseButtonPressed(object sender, MouseButtonEventArgs e)
        {
            if (e.Button == Mouse.Button.Right)
            {
                EntityManager.Character.CurrentSkill.Cast(EntityManager.Character, e.X, e.Y);
            }

        }


    }
}
