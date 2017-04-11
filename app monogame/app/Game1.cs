using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace app
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        BaseApp app;
        Texture2D basemap;
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            graphics.IsFullScreen = false;
            graphics.PreferredBackBufferWidth = Convert.ToInt32(GraphicsDevice.DisplayMode.Width * 0.9f);
            graphics.PreferredBackBufferHeight = Convert.ToInt32(GraphicsDevice.DisplayMode.Height * 0.9f);
            graphics.ApplyChanges();
            Window.AllowUserResizing = true;
            LoadContent();
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            basemap = this.Content.Load<Texture2D>("mapje2");
            app = new BaseApp(basemap);
        }
        
        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();
            // TODO: Add your drawing code here
            app.Draw(spriteBatch);
            base.Draw(gameTime);
            spriteBatch.End();
        }
    }
    public class Location : Game
        {
        //name , postcode , WOZ , income , image , image_location , image_color , budget

            string name , postcode;
            int WOZ , Budget ;
            Texture2D Image;
            

        
        private Location (Texture2D image)
            {

            }
}

}
