using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Input;


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
        Texture2D wijk2901;
        Texture2D wijk2902;
        Texture2D wijk2906;
        Texture2D wijk2907;
        Texture2D wijk2909;
        Texture2D wijk2987;
        Texture2D wijk3012_2011;
        Texture2D wijk3013_3033_3032;
        Texture2D wijk3014_3015;
        Texture2D wijk3016;
        Texture2D wijk3021;
        Texture2D wijk3022;
        Texture2D wijk3023;
        Texture2D wijk3024;
        Texture2D wijk3025;
        Texture2D wijk3026;
        Texture2D wijk3027;
        Texture2D wijk3028;
        Texture2D wijk3029;
        Texture2D wijk3031;
        Texture2D wijk3034;
        Texture2D wijk3036_3035;
        Texture2D wijk3038_3037;
        Texture2D wijk3039;
        Texture2D wijk3042_3041;
        Texture2D wijk3043;
        Texture2D wijk3044;
        Texture2D wijk3045;
        Texture2D wijk3051;
        Texture2D wijk3052_3053;
        Texture2D wijk3054;
        Texture2D wijk3055;
        Texture2D wijk3056;
        Texture2D wijk3061;
        Texture2D wijk3062;
        Texture2D wijk3063;
        Texture2D wijk3064;
        Texture2D wijk3065;
        Texture2D wijk3066;
        Texture2D wijk3067;
        Texture2D wijk3068;
        Texture2D wijk3069;
        Texture2D wijk3071;
        Texture2D wijk3072;
        Texture2D wijk3073;
        Texture2D wijk3074;
        Texture2D wijk3075;
        Texture2D wijk3076;
        Texture2D wijk3077;
        Texture2D wijk3078;
        Texture2D wijk3079;
        Texture2D wijk3081;
        Texture2D wijk3082;
        Texture2D wijk3083;
        Texture2D wijk3084;
        Texture2D wijk3085;
        Texture2D wijk3086;
        Texture2D wijk3089_3087_3088;
        Texture2D wijk3111;
        Texture2D wijk3112;
        Texture2D wijk3113;
        Texture2D wijk3114;
        Texture2D wijk3115;
        Texture2D wijk3115_2;
        Texture2D wijk3116;
        Texture2D wijk3117;
        Texture2D wijk3118;
        Texture2D wijk3119;
        Texture2D wijk3122_3121;
        Texture2D wijk3124_3123;
        Texture2D wijk3129;
        Texture2D wijk3134;
        Texture2D wijk3135;
        Texture2D wijk3136;
        Texture2D wijk3137;

        // List<object> List_Locations = new List<object>();
        List <Texture2D> List_wijk_images = new List <Texture2D> ();



        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            graphics.IsFullScreen = false;
            graphics.PreferredBackBufferWidth = Convert.ToInt32(GraphicsDevice.DisplayMode.Width * 0.9f);
            graphics.PreferredBackBufferHeight = Convert.ToInt32(GraphicsDevice.DisplayMode.Height * 0.9f);
            graphics.ApplyChanges();
            Window.AllowUserResizing = true;
            this.IsMouseVisible = true;
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
            List_wijk_images.Add(this.Content.Load<Texture2D>("3115-2")); //63
            List_wijk_images.Add(this.Content.Load<Texture2D>("3116")); //64
            List_wijk_images.Add(this.Content.Load<Texture2D>("3117")); //65
            List_wijk_images.Add(this.Content.Load<Texture2D>("3118")); //66
            List_wijk_images.Add(this.Content.Load<Texture2D>("3119")); //67
            List_wijk_images.Add(this.Content.Load<Texture2D>("3122 en 3121")); //68
            List_wijk_images.Add(this.Content.Load<Texture2D>("3124 en 3123")); //69
            List_wijk_images.Add(this.Content.Load<Texture2D>("3129")); //70
            List_wijk_images.Add(this.Content.Load<Texture2D>("3134")); //71
            List_wijk_images.Add(this.Content.Load<Texture2D>("3135")); //72
            List_wijk_images.Add(this.Content.Load<Texture2D>("3136")); //73
            List_wijk_images.Add(this.Content.Load<Texture2D>("3137")); //74


            //List_wijk_images.Add(wijk2901);
            app = new BaseApp(basemap, List_wijk_images,100);
            
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
            app.Update((float) gameTime.ElapsedGameTime.TotalSeconds);
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.AntiqueWhite);
            spriteBatch.Begin();
            // TODO: Add your drawing code here
            app.Draw(spriteBatch);
            base.Draw(gameTime);
            spriteBatch.End();
        }
    }
}
