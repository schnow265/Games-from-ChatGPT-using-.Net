using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace PingPongGame
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        // Spielobjekte
        Texture2D ballTexture;
        Vector2 ballPosition;
        Vector2 ballVelocity;

        Texture2D paddleTexture;
        Vector2 paddlePosition;

        Texture2D computerPaddleTexture;
        Vector2 computerPaddlePosition;

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
            ballPosition = new Vector2(GraphicsDevice.Viewport.Width / 2, GraphicsDevice.Viewport.Height / 2);
            ballVelocity = new Vector2(5, 5);

            paddlePosition = new Vector2(20, GraphicsDevice.Viewport.Height / 2 - paddleTexture.Height / 2);

            computerPaddlePosition = new Vector2(GraphicsDevice.Viewport.Width - 20 - computerPaddleTexture.Width, GraphicsDevice.Viewport.Height / 2 - computerPaddleTexture.Height / 2);

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

