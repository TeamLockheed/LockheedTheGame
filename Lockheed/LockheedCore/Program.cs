using System;
using System.Diagnostics;
using System.Collections.Generic;

using SFML.Audio;
using SFML.Window;
using SFML.Graphics;


namespace LockHeedCore
{
   
    public class Program
    {
        public const int FPS = 60;
        public const float RATIO = 16f / 9f;
        public const int WIDTH = 800;
        public const int HEIGHT = (int)(WIDTH / RATIO);
        public const float MAX_TIMESTEP = 1000f / FPS;
       
        public const float MovementModifier = 0.5f;

        static void Main(string[] args)
        {
            
             var resolution = new VideoMode(WIDTH, HEIGHT, 32);
            var windowSettings = new ContextSettings(32, 0, 4);
            var window = new RenderWindow(resolution, "Lockheed the Game", Styles.Close, windowSettings);

            window.Closed += new EventHandler(Events.OnClose);
            window.KeyPressed += new EventHandler<KeyEventArgs>(Events.OnKeyPressed);
            window.KeyReleased += new EventHandler<KeyEventArgs>(Events.OnKeyReleased);
            window.MouseButtonPressed += new EventHandler<MouseButtonEventArgs>(Events.OnMouseButtonPressed);
            window.SetActive();

            Map map = Map.generateMap();
           

            Character character = new Mage("glava");

            Console.WriteLine(map.Levels[10, 10].ToString());
            //Map map = Map.generateMap();
            DateTime lastTick = DateTime.Now;
            float dt = 0;
            while (window.IsOpen())
            {                
                dt = (float)(DateTime.Now - lastTick).TotalMilliseconds;
                lastTick = DateTime.Now;
 
                window.DispatchEvents();
 
                var t = 0;
                while (dt > 0)
                {
                    if (dt < MAX_TIMESTEP)
                    {
                        //EntityManager.Update(dt);
                        character.Update();
                        
                    }
                    else
                    {
                        
                        
                        //EntityManager.Update(MAX_TIMESTEP);
                    }
                    dt -= MAX_TIMESTEP;
                    t++;
                    if (t > 2)
                    {
                        Console.WriteLine(t);
                    }
                }
                window.Clear(Color.Black);
                map.Levels[10, 10].Draw(window);
                character.Draw(window);
                
                window.Display();
            }
        }
            
        }

    }


