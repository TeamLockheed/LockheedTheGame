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

            Level newLevel = Level.GenerateSingleLevel();    
            Character glava = new Warrior("glava");

            glava.CurrentSkill = new ProjectileSkill("fireball", 10, 10, 10, Tier.Beginner, 5, "weapons/projectiles/fireBall.png");
            

            EntityManager.CurrentLevel = newLevel;
            EntityManager.Character = glava;

            


            //Map map = Map.generateMap();
            DateTime lastTick = DateTime.Now;
            float dt = 0;
            while (window.IsOpen())
            {                
                dt = (float)(DateTime.Now - lastTick).TotalMilliseconds;
                lastTick = DateTime.Now;
 
                window.DispatchEvents();
 
                while (dt > 0)
                {
                   
                    EntityManager.Update();   
                    dt -= MAX_TIMESTEP;
                  
                }
                window.Clear(Color.Black);
 
                EntityManager.Draw(window);

                window.Display();
            }
        }
            
        }

    }


