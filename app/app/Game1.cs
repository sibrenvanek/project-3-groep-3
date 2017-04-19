using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Configuration;
using Microsoft.VisualBasic;

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
        Texture2D basemap, legenda;
        Texture2D rect;
        Texture2D small_rect;
        Texture2D rect_info;
        Texture2D rectback1;
        Texture2D rectback2;
        Texture2D rectback3;
        Texture2D rectback4;
        Texture2D rectback5;
        Texture2D rectback6;
        Texture2D rectback7;
        SpriteFont Font;
        // List<object> List_Locations = new List<object>();
        List<Texture2D> List_wijk_images = new List<Texture2D>();
        //List<object> List_Buttons = new List<object>(); put in Locations
        List<Button> List_Buttons = new List<Button>();
        List<string> List_Wijken = new List<string>();

        protected override void Initialize()
        {
            //Add your initialization logic here
            graphics.IsFullScreen = false;
            graphics.PreferredBackBufferWidth = Convert.ToInt32(GraphicsDevice.DisplayMode.Width * 0.9f);
            graphics.PreferredBackBufferHeight = Convert.ToInt32(GraphicsDevice.DisplayMode.Height * 0.9f);
            graphics.ApplyChanges();
            Window.AllowUserResizing = true;
            this.IsMouseVisible = true;
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

            //use this.Content to load your game content here
            basemap = this.Content.Load<Texture2D>("basemap");
            legenda = this.Content.Load<Texture2D>("Legenda");

            List_wijk_images.Add(this.Content.Load<Texture2D>("Centrum")); //0
            List_wijk_images.Add(this.Content.Load<Texture2D>("Charlois")); //1
            List_wijk_images.Add(this.Content.Load<Texture2D>("Delftshaven")); //2
            List_wijk_images.Add(this.Content.Load<Texture2D>("Feyenoord")); //3
            List_wijk_images.Add(this.Content.Load<Texture2D>("Hillegersberg-Schiebroek")); //4
            List_wijk_images.Add(this.Content.Load<Texture2D>("Ijsselmonde")); //5
            List_wijk_images.Add(this.Content.Load<Texture2D>("Kralingen-Crooswijk")); //6
            List_wijk_images.Add(this.Content.Load<Texture2D>("Noord")); //7
            List_wijk_images.Add(this.Content.Load<Texture2D>("Overschie")); //8
            List_wijk_images.Add(this.Content.Load<Texture2D>("Prins alexander")); //9

            List_Wijken.Add("Centrum"); //0
            List_Wijken.Add("Charlois"); //1
            List_Wijken.Add("Delftshaven"); //2
            List_Wijken.Add("Feyenoord"); //3
            List_Wijken.Add("Hillegersberg-Schiebroek"); //4
            List_Wijken.Add("Ijselmonde"); //5
            List_Wijken.Add("Kralingen-Crooswijk"); //6
            List_Wijken.Add("Noord"); //7
            List_Wijken.Add("Overschie"); //8
            List_Wijken.Add("Prins-Alexander"); //9

            rect = new Texture2D(graphics.GraphicsDevice, 200, 30);
            Color[] data = new Color[200 * 30];
            for (int i = 0; i < data.Length; ++i) data[i] = Color.White;
            rect.SetData(data);
            small_rect = new Texture2D(graphics.GraphicsDevice, 100, 30);
            Color[] small_data = new Color[100 * 30];
            for (int i = 0; i < small_data.Length; ++i) small_data[i] = Color.White;
            small_rect.SetData(small_data);
            rect_info = new Texture2D(graphics.GraphicsDevice, 400, 500);
            Color[] data_info = new Color[400 * 500];
            for (int i = 0; i < data_info.Length; ++i) data_info[i] = Color.White;
            rect_info.SetData(data_info);
            int height = graphics.PreferredBackBufferHeight / 7;
            Color[] databack = new Color[graphics.PreferredBackBufferWidth * height];
            rectback1 = new Texture2D(graphics.GraphicsDevice, graphics.PreferredBackBufferWidth, height);
            rectback2 = new Texture2D(graphics.GraphicsDevice, graphics.PreferredBackBufferWidth, height);
            rectback3 = new Texture2D(graphics.GraphicsDevice, graphics.PreferredBackBufferWidth, height);
            rectback4 = new Texture2D(graphics.GraphicsDevice, graphics.PreferredBackBufferWidth, height);
            rectback5 = new Texture2D(graphics.GraphicsDevice, graphics.PreferredBackBufferWidth, height);
            rectback6 = new Texture2D(graphics.GraphicsDevice, graphics.PreferredBackBufferWidth, height);
            rectback7 = new Texture2D(graphics.GraphicsDevice, graphics.PreferredBackBufferWidth, height);
            for (int i = 0; i < databack.Length; ++i) databack[i] = Color.Crimson;
            rectback1.SetData(databack);
            for (int i = 0; i < databack.Length; ++i) databack[i] = Color.OrangeRed;
            rectback2.SetData(databack);
            for (int i = 0; i < databack.Length; ++i) databack[i] = Color.Gold;
            rectback3.SetData(databack);
            for (int i = 0; i < databack.Length; ++i) databack[i] = Color.Lime;
            rectback4.SetData(databack);
            for (int i = 0; i < databack.Length; ++i) databack[i] = Color.Blue;
            rectback5.SetData(databack);
            for (int i = 0; i < databack.Length; ++i) databack[i] = Color.Indigo;
            rectback6.SetData(databack);
            for (int i = 0; i < databack.Length; ++i) databack[i] = Color.Violet;
            rectback7.SetData(databack);
            
            Font = Content.Load<SpriteFont>("File");
            app = new BaseApp(basemap, List_wijk_images, Font, rect, 100, rect_info, List_Wijken, legenda, small_rect);
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            //Unload any non ContentManager content here
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
            float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;
            //Add your update logic here
            app.Update(dt);
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.LightGray);
            spriteBatch.Begin();
            //Add your drawing code here
            /*spriteBatch.Draw(rectback1, new Vector2(0, 0), Color.White);
            spriteBatch.Draw(rectback2, new Vector2(0, 0 + (graphics.PreferredBackBufferHeight / 7)), Color.White);
            spriteBatch.Draw(rectback3, new Vector2(0, 0 + ((graphics.PreferredBackBufferHeight / 7) * 2)), Color.White);
            spriteBatch.Draw(rectback4, new Vector2(0, 0 + ((graphics.PreferredBackBufferHeight / 7) * 3)), Color.White);
            spriteBatch.Draw(rectback5, new Vector2(0, 0 + ((graphics.PreferredBackBufferHeight / 7) * 4)), Color.White);
            spriteBatch.Draw(rectback6, new Vector2(0, 0 + ((graphics.PreferredBackBufferHeight / 7) * 5)), Color.White);
            spriteBatch.Draw(rectback7, new Vector2(0, 0 + ((graphics.PreferredBackBufferHeight / 7) * 6)), Color.White);*/
            app.Draw(spriteBatch);
            base.Draw(gameTime);
            spriteBatch.End();
        }
    }
}
