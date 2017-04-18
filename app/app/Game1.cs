using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Linq;
using System;
using System.Collections;
using System.Collections.Generic;

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
        Texture2D rect;
        Texture2D rect_info;
        Texture2D rectback1;
        Texture2D rectback2;
        Texture2D rectback3;
        Texture2D rectback4;
        Texture2D rectback5;
        Texture2D rectback6;
        Texture2D rectback7;
        DBConnect DBConnection;
        SpriteFont Font;
        // List<object> List_Locations = new List<object>();
        List<Texture2D> List_wijk_images = new List<Texture2D>();
        //List<object> List_Buttons = new List<object>(); put in Locations
        List<Button> List_Buttons = new List<Button>();
        List<string> List_Postcodes = new List<string>();

        protected override void Initialize()
        {
            //Add your initialization logic here
            graphics.IsFullScreen = false;
            graphics.PreferredBackBufferWidth = Convert.ToInt32(GraphicsDevice.DisplayMode.Width * 0.9f);
            graphics.PreferredBackBufferHeight = Convert.ToInt32(GraphicsDevice.DisplayMode.Height * 0.9f);
            graphics.ApplyChanges();
            Window.AllowUserResizing = true;
            this.IsMouseVisible = true;
            DBConnection = new DBConnect();
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
            basemap = this.Content.Load<Texture2D>("mapje2");
            List_wijk_images.Add(this.Content.Load<Texture2D>("2901")); //0
            List_wijk_images.Add(this.Content.Load<Texture2D>("2902")); //1
            List_wijk_images.Add(Content.Load<Texture2D>("2906"));      //2
            List_wijk_images.Add(this.Content.Load<Texture2D>("2907")); //3
            List_wijk_images.Add(this.Content.Load<Texture2D>("2909")); //4
            List_wijk_images.Add(this.Content.Load<Texture2D>("2987")); //5
            List_wijk_images.Add(this.Content.Load<Texture2D>("3012 en 2011")); //6
            List_wijk_images.Add(this.Content.Load<Texture2D>("3013 en 3033 en 3032")); //7
            List_wijk_images.Add(this.Content.Load<Texture2D>("3014 en 3015")); //8
            List_wijk_images.Add(this.Content.Load<Texture2D>("3016")); //9
            List_wijk_images.Add(this.Content.Load<Texture2D>("3021")); //10
            List_wijk_images.Add(this.Content.Load<Texture2D>("3022")); //11
            List_wijk_images.Add(this.Content.Load<Texture2D>("3023")); //12
            List_wijk_images.Add(this.Content.Load<Texture2D>("3024")); //13
            List_wijk_images.Add(this.Content.Load<Texture2D>("3025")); //14
            List_wijk_images.Add(this.Content.Load<Texture2D>("3026")); //15
            List_wijk_images.Add(this.Content.Load<Texture2D>("3027")); //16
            List_wijk_images.Add(this.Content.Load<Texture2D>("3028")); //17
            List_wijk_images.Add(this.Content.Load<Texture2D>("3029")); //18
            List_wijk_images.Add(this.Content.Load<Texture2D>("3031")); //19
            List_wijk_images.Add(this.Content.Load<Texture2D>("3034")); //20
            List_wijk_images.Add(this.Content.Load<Texture2D>("3036 en 3035")); //21
            List_wijk_images.Add(this.Content.Load<Texture2D>("3038 en 3037")); //22
            List_wijk_images.Add(this.Content.Load<Texture2D>("3039")); //23
            List_wijk_images.Add(this.Content.Load<Texture2D>("3042 en 3041")); //24
            List_wijk_images.Add(this.Content.Load<Texture2D>("3043")); //25
            List_wijk_images.Add(this.Content.Load<Texture2D>("3044")); //26
            List_wijk_images.Add(this.Content.Load<Texture2D>("3045")); //27
            List_wijk_images.Add(this.Content.Load<Texture2D>("3051")); //28
            List_wijk_images.Add(this.Content.Load<Texture2D>("3052 en 3053")); //29
            List_wijk_images.Add(this.Content.Load<Texture2D>("3054")); //30
            List_wijk_images.Add(this.Content.Load<Texture2D>("3055")); //31
            List_wijk_images.Add(this.Content.Load<Texture2D>("3056")); //32
            List_wijk_images.Add(this.Content.Load<Texture2D>("3061")); //33
            List_wijk_images.Add(this.Content.Load<Texture2D>("3062")); //34
            List_wijk_images.Add(this.Content.Load<Texture2D>("3063")); //35
            List_wijk_images.Add(this.Content.Load<Texture2D>("3064")); //36
            List_wijk_images.Add(this.Content.Load<Texture2D>("3065")); //37
            List_wijk_images.Add(this.Content.Load<Texture2D>("3066")); //38
            List_wijk_images.Add(this.Content.Load<Texture2D>("3067")); //39
            List_wijk_images.Add(this.Content.Load<Texture2D>("3068")); //40
            List_wijk_images.Add(this.Content.Load<Texture2D>("3069")); //41
            List_wijk_images.Add(this.Content.Load<Texture2D>("3071")); //42
            List_wijk_images.Add(this.Content.Load<Texture2D>("3072")); //43
            List_wijk_images.Add(this.Content.Load<Texture2D>("3073")); //44
            List_wijk_images.Add(this.Content.Load<Texture2D>("3074")); //45
            List_wijk_images.Add(this.Content.Load<Texture2D>("3075")); //46
            List_wijk_images.Add(this.Content.Load<Texture2D>("3076")); //47
            List_wijk_images.Add(this.Content.Load<Texture2D>("3077")); //48
            List_wijk_images.Add(this.Content.Load<Texture2D>("3078")); //49
            List_wijk_images.Add(this.Content.Load<Texture2D>("3079")); //50
            List_wijk_images.Add(this.Content.Load<Texture2D>("3081")); //51
            List_wijk_images.Add(this.Content.Load<Texture2D>("3082")); //52
            List_wijk_images.Add(this.Content.Load<Texture2D>("3083")); //53
            List_wijk_images.Add(this.Content.Load<Texture2D>("3084")); //54
            List_wijk_images.Add(this.Content.Load<Texture2D>("3085")); //55
            List_wijk_images.Add(this.Content.Load<Texture2D>("3086")); //56
            List_wijk_images.Add(this.Content.Load<Texture2D>("3089 en 3087 en 3088")); //57
            List_wijk_images.Add(this.Content.Load<Texture2D>("3111")); //58
            List_wijk_images.Add(this.Content.Load<Texture2D>("3112")); //59
            List_wijk_images.Add(this.Content.Load<Texture2D>("3113")); //60
            List_wijk_images.Add(this.Content.Load<Texture2D>("3114")); //61
            List_wijk_images.Add(this.Content.Load<Texture2D>("3115")); //62
            List_wijk_images.Add(this.Content.Load<Texture2D>("3116")); //63
            List_wijk_images.Add(this.Content.Load<Texture2D>("3117")); //64
            List_wijk_images.Add(this.Content.Load<Texture2D>("3118")); //65
            List_wijk_images.Add(this.Content.Load<Texture2D>("3119")); //66
            List_wijk_images.Add(this.Content.Load<Texture2D>("3122 en 3121")); //67
            List_wijk_images.Add(this.Content.Load<Texture2D>("3124 en 3123")); //68
            List_wijk_images.Add(this.Content.Load<Texture2D>("3129")); //69
            List_wijk_images.Add(this.Content.Load<Texture2D>("3134")); //70
            List_wijk_images.Add(this.Content.Load<Texture2D>("3135")); //71
            List_wijk_images.Add(this.Content.Load<Texture2D>("3136")); //72
            List_wijk_images.Add(this.Content.Load<Texture2D>("3137")); //73

            List_Postcodes.Add("2901"); //0
            List_Postcodes.Add("2902"); //1
            List_Postcodes.Add("2906"); //2
            List_Postcodes.Add("2907"); //3
            List_Postcodes.Add("2909"); //4
            List_Postcodes.Add("2987"); //5
            List_Postcodes.Add("3012 en 2011"); //6
            List_Postcodes.Add("3013 en 3033 en 3032"); //7
            List_Postcodes.Add("3014 en 3015"); //8
            List_Postcodes.Add("3016"); //9
            List_Postcodes.Add("3021"); //10
            List_Postcodes.Add("3022"); //11
            List_Postcodes.Add("3023"); //12
            List_Postcodes.Add("3024"); //13
            List_Postcodes.Add("3025"); //14
            List_Postcodes.Add("3026"); //15
            List_Postcodes.Add("3027"); //16
            List_Postcodes.Add("3028"); //17
            List_Postcodes.Add("3029"); //18
            List_Postcodes.Add("3031"); //19
            List_Postcodes.Add("3034"); //20
            List_Postcodes.Add("3036 en 3035"); //21
            List_Postcodes.Add("3038 en 3037"); //22
            List_Postcodes.Add("3039"); //23
            List_Postcodes.Add("3042 en 3041"); //24
            List_Postcodes.Add("3043"); //25
            List_Postcodes.Add("3044"); //26
            List_Postcodes.Add("3045"); //27
            List_Postcodes.Add("3051"); //28
            List_Postcodes.Add("3052 en 3053"); //29
            List_Postcodes.Add("3054"); //30
            List_Postcodes.Add("3055"); //31
            List_Postcodes.Add("3056"); //32
            List_Postcodes.Add("3061"); //33
            List_Postcodes.Add("3062"); //34
            List_Postcodes.Add("3063"); //35
            List_Postcodes.Add("3064"); //3
            List_Postcodes.Add("3065"); //37
            List_Postcodes.Add("3066"); //38
            List_Postcodes.Add("3067"); //39
            List_Postcodes.Add("3068"); //40
            List_Postcodes.Add("3069"); //41
            List_Postcodes.Add("3071"); //42
            List_Postcodes.Add("3072"); //43
            List_Postcodes.Add("3073"); //44
            List_Postcodes.Add("3074"); //45
            List_Postcodes.Add("3075"); //46
            List_Postcodes.Add("3076"); //47
            List_Postcodes.Add("3077"); //48
            List_Postcodes.Add("3078"); //49
            List_Postcodes.Add("3079"); //50
            List_Postcodes.Add("3081"); //51
            List_Postcodes.Add("3082"); //52
            List_Postcodes.Add("3083"); //53
            List_Postcodes.Add("3084"); //54
            List_Postcodes.Add("3085"); //55
            List_Postcodes.Add("3086"); //56
            List_Postcodes.Add("3089 en 3087 en 3088"); //57
            List_Postcodes.Add("3111"); //58
            List_Postcodes.Add("3112"); //59
            List_Postcodes.Add("3113"); //60
            List_Postcodes.Add("3114"); //61
            List_Postcodes.Add("3115"); //62
            List_Postcodes.Add("3116"); //63
            List_Postcodes.Add("3117"); //64
            List_Postcodes.Add("3118"); //65
            List_Postcodes.Add("3119"); //66
            List_Postcodes.Add("3122 en 3121"); //67
            List_Postcodes.Add("3124 en 3123"); //68
            List_Postcodes.Add("3129"); //69
            List_Postcodes.Add("3134"); //70
            List_Postcodes.Add("3135"); //71
            List_Postcodes.Add("3136"); //72
            List_Postcodes.Add("3137"); //73

            rect = new Texture2D(graphics.GraphicsDevice, 100, 30);
            Color[] data = new Color[100 * 30];
            for (int i = 0; i < data.Length; ++i) data[i] = Color.White;
            rect.SetData(data);
            rect_info = new Texture2D(graphics.GraphicsDevice, 278, 500);
            Color[] data_info = new Color[278 * 500];
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
            //List_Buttons.Add(new Button("button 1", rect, 1000, 30));
            //List_Buttons.Add(new Button("button 2", rect, 1200, 30));


            //string name_button = "button1";
            //int counter = 0;
            //int counter2 = 0;
            //int X_pos = 900;
            //int Y_pos = 20;


            //while (counter <= 75)
            //{

            //    X_pos = X_pos + 100;
            //    Y_pos = 20;
            //    counter = counter + 1;
            //    counter2 = 0;

            //    while (counter2 <= 19)
            //    {
            //        List_Buttons.Add(new Button(name_button, rect, X_pos, Y_pos,Font));
            //        counter2 = counter2 + 1;
            //        Y_pos = Y_pos + 50;

            //    }

            //}


            Font = Content.Load<SpriteFont>("File");
            app = new BaseApp(basemap, List_wijk_images, Font, rect, 100, rect_info, List_Postcodes);

            //Texture2D button1texture = this.Content.Load<Texture2D>("button 1");
            //Texture2D button2texture = this.Content.Load<Texture2D>("button 2");
            //DBConnection.Insert();
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
