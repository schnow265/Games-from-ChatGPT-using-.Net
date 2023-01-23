using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Numerics;
using System;

namespace PingPongGame
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        // Spielobjekte
        Texture2D ballTexture;
        Microsoft.Xna.Framework.Vector2 ballPosition;
       Microsoft.Xna.Framework.Vector2 ballVelocity;

        Texture2D paddleTexture;
        Microsoft.Xna.Framework.Vector2 paddlePosition;

        Texture2D computerPaddleTexture;
        Microsoft.Xna.Framework.Vector2 computerPaddlePosition;

        int playerScore;
        int computerScore;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            // Setzte die Anfangspositionen der Objekte
            ballPosition = new Microsoft.Xna.Framework.Vector2(GraphicsDevice.Viewport.Width / 2, GraphicsDevice.Viewport.Height / 2);
            ballVelocity = new Microsoft.Xna.Framework.Vector2(5, 5);

            paddlePosition = new Microsoft.Xna.Framework.Vector2(20, GraphicsDevice.Viewport.Height / 2 - paddleTexture.Height / 2);

            computerPaddlePosition = new Microsoft.Xna.Framework.Vector2(GraphicsDevice.Viewport.Width - 20 - computerPaddleTexture.Width, GraphicsDevice.Viewport.Height / 2 - computerPaddleTexture.Height / 2);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            // Erstellt einen neuen SpriteBatch
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // Lädt die Texturen für die Objekte
            ballTexture = Content.Load<Texture2D>("ball");
            paddleTexture = Content.Load<Texture2D>("paddle");
            computerPaddleTexture = Content.Load<Texture2D>("computer_paddle");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // Bewegt den Spielball
            ballPosition += ballVelocity;

            // Prüft Kollisionen mit den Wänden
            if (ballPosition.Y <= 0 || ballPosition.Y + ballTexture.Height >= GraphicsDevice.Viewport.Height)
                ballVelocity.Y = -ballVelocity.Y;

            if (ballPosition.X <= 0);
        }
    }
}


