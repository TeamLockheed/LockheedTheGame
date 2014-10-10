using System;
using System.Diagnostics;
//using SFML.System;
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
        const float MovementModifier = 0.45f;

        static float X = WindowWidth / 2f;
        static float Y = WindowHeight / 2f;
        static bool keyArrowLeft = false;
        static bool keyArrowUp = false;
        static bool keyArrowDown = false;
        static bool keyArrowRight = false;

        static void Main(string[] args)
        {
            //create renderer window
            var resolution = new VideoMode(WindowWidth, WindowHeight, 32);
            var windowSettings = new ContextSettings(32, 0, 4);
            var window = new RenderWindow(resolution, "Lockheed the Game", Styles.Close, windowSettings);
            window.Closed += new EventHandler(OnClose);
            window.KeyPressed += new EventHandler<KeyEventArgs>(OnKeyPressed);
            window.KeyReleased += new EventHandler<KeyEventArgs>(OnKeyReleased);
            window.SetActive();
          
            //create player sprite
            var player = new Sprite();
            player.Texture = new Texture("character.png");
            
            player.Position = new Vector2f(X, Y);
            //player.Origin = new Vector2f(30f, 30f);
           
            player.Origin = new Vector2f(player.GetGlobalBounds().Width / 2, player.GetGlobalBounds().Height / 2);


         

            //game loop
            while (window.IsOpen())
            {
                //input
                window.DispatchEvents(); //process input and events
                //clear screen
                window.Clear(); //clear the screen and buffer
                Console.Clear();

                ChangePosition();

              
                player.Position = new Vector2f(X, Y);
                Console.WriteLine("{0:0.00}|{1:0.00}", X, Y);
                Console.WriteLine("Width {0},Height {1}", WindowWidth, WindowHeight);

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

        static void ChangePosition() 
        {
            
            if (keyArrowDown)
            {
                if (Y <= WindowHeight-45)
                {
                    Y += MovementModifier;
                }
            }
            if (keyArrowUp) 
            {
                if (Y >= 45)
                {
                    Y -= MovementModifier;
                }              
            }
            if (keyArrowLeft) 
            {
                if (X >= 40)
                {
                    X -= MovementModifier;
                }    
               
            }
            if (keyArrowRight) 
            {
                if (X <= WindowWidth-40)
                {
                    X += MovementModifier;
                }   
            }
        }

        static void OnKeyPressed(object sender, KeyEventArgs e)
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
        static void OnKeyReleased(object sender, KeyEventArgs e)
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
        
    }
}

