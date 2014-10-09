using System;
using SFML.System;
using SFML.Audio;
using SFML.Window;
using SFML.Graphics;

namespace Example
{
    class Program
    {
        const double Ratio = 16.0 / 9.0;
        const int WindowWidth = 800;
        const int WindowHeight = (int)(WindowWidth / Ratio);

        static void Main(string[] args)
        {
            //create renderer window
            var resolution = new VideoMode(WindowWidth, WindowHeight, 16);
            var windowSettings = new ContextSettings(32, 0, 4);
            var window = new RenderWindow(resolution, "Lockheed the Game", Styles.Close, windowSettings);
            window.Closed += new EventHandler(OnClose);
            window.SetActive();

            //create player sprite
            var player = new CircleShape(64, 6);
            player.Origin = new Vector2f(player.Radius, player.Radius);
            player.Position = new Vector2f(window.Size.X / 2f, window.Size.Y / 2f);
            player.Rotation = 0.3f;
            player.FillColor = Color.Yellow;

            Clock clock = new Clock();
            float dt; //delta time
            float et = clock.ElapsedTime.AsMilliseconds();
            
            //game loop
            while (window.IsOpen)
            {
                //input
                window.DispatchEvents(); //process input and events
                //clear screen
                window.Clear(); //clear the screen and buffer
#if DEBUG
                Console.Clear();
#endif
                //update
                dt = clock.ElapsedTime.AsSeconds() - et;
                et = clock.ElapsedTime.AsSeconds();
                player.Rotation = et * 90;//our game engine Update() logic will go here
#if DEBUG
                Console.WriteLine("et: {0}; dt: {1}; rotation: {2};", et, dt, player.Rotation);
#endif
                //draw
                window.Draw(player); //here we will pass our renderer class that will be IDrawable
                //render
                window.Display(); //call this to draw everything in the buffer
            }
        }

        //this is the event when you press the X of the window
        static void OnClose(object sender, EventArgs e)
        {
            RenderWindow window = (RenderWindow)sender;
            window.Close();
        }
    }
}