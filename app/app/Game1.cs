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
            wijk2901 = this.Content.Load<Texture2D>("2901");
            wijk2902 = this.Content.Load<Texture2D>("2902");
            wijk2906 = this.Content.Load<Texture2D>("2906");
            wijk2907 = this.Content.Load<Texture2D>("2907");
            wijk2909 = this.Content.Load<Texture2D>("2909");
            wijk2987 = this.Content.Load<Texture2D>("2987");
            wijk3012_2011 = this.Content.Load<Texture2D>("3012 en 2011");
            wijk3013_3033_3032 = this.Content.Load<Texture2D>("3013 en 3033 en 3032");
            wijk3014_3015 = this.Content.Load<Texture2D>("3014 en 3015");
            wijk3016 = this.Content.Load<Texture2D>("3016");
            wijk3021 = this.Content.Load<Texture2D>("3021");
            wijk3022 = this.Content.Load<Texture2D>("3022");
            wijk3023 = this.Content.Load<Texture2D>("3023");
            wijk3024 = this.Content.Load<Texture2D>("3024");
            wijk3025 = this.Content.Load<Texture2D>("3025");
            wijk3026 = this.Content.Load<Texture2D>("3026");
            wijk3027 = this.Content.Load<Texture2D>("3027");
            wijk3028 = this.Content.Load<Texture2D>("3028");
            wijk3029 = this.Content.Load<Texture2D>("3029");
            wijk3031 = this.Content.Load<Texture2D>("3031");
            wijk3034 = this.Content.Load<Texture2D>("3034");
            wijk3036_3035 = this.Content.Load<Texture2D>("3036 en 3035");
            wijk3038_3037 = this.Content.Load<Texture2D>("3038 en 3037");
            wijk3039 = this.Content.Load<Texture2D>("3039");
            wijk3042_3041 = this.Content.Load<Texture2D>("3042 en 3041");
            wijk3043 = this.Content.Load<Texture2D>("3043");
            wijk3044 = this.Content.Load<Texture2D>("3044");
            wijk3045 = this.Content.Load<Texture2D>("3045");
            wijk3051 = this.Content.Load<Texture2D>("3051");
            wijk3052_3053 = this.Content.Load<Texture2D>("3052 en 3053");
            wijk3054 = this.Content.Load<Texture2D>("3054");
            wijk3055 = this.Content.Load<Texture2D>("3055");
            wijk3056 = this.Content.Load<Texture2D>("3056");
            wijk3061 = this.Content.Load<Texture2D>("3061");
            wijk3062 = this.Content.Load<Texture2D>("3062");
            wijk3063 = this.Content.Load<Texture2D>("3063");
            wijk3064 = this.Content.Load<Texture2D>("3064");
            wijk3065 = this.Content.Load<Texture2D>("3065");
            wijk3066 = this.Content.Load<Texture2D>("3066");
            wijk3067 = this.Content.Load<Texture2D>("3067");
            wijk3068 = this.Content.Load<Texture2D>("3068");
            wijk3069 = this.Content.Load<Texture2D>("3069");
            wijk3071 = this.Content.Load<Texture2D>("3071");
            wijk3072 = this.Content.Load<Texture2D>("3072");
            wijk3073 = this.Content.Load<Texture2D>("3073");
            wijk3074 = this.Content.Load<Texture2D>("3074");
            wijk3075 = this.Content.Load<Texture2D>("3075");
            wijk3076 = this.Content.Load<Texture2D>("3076");
            wijk3077 = this.Content.Load<Texture2D>("3077");
            wijk3078 = this.Content.Load<Texture2D>("3078");
            wijk3079 = this.Content.Load<Texture2D>("3079");
            wijk3081 = this.Content.Load<Texture2D>("3081");
            wijk3082 = this.Content.Load<Texture2D>("3082");
            wijk3083 = this.Content.Load<Texture2D>("3083");
            wijk3084 = this.Content.Load<Texture2D>("3084");
            wijk3085 = this.Content.Load<Texture2D>("3085");
            wijk3086 = this.Content.Load<Texture2D>("3086");
            wijk3089_3087_3088 = this.Content.Load<Texture2D>("3089 en 3087 en 3088");
            wijk3111 = this.Content.Load<Texture2D>("3111");
            wijk3112 = this.Content.Load<Texture2D>("3112");
            wijk3113 = this.Content.Load<Texture2D>("3113");
            wijk3114 = this.Content.Load<Texture2D>("3114");
            wijk3115 = this.Content.Load<Texture2D>("3115");
            wijk3115_2 = this.Content.Load<Texture2D>("3115-2");
            wijk3116 = this.Content.Load<Texture2D>("3116");
            wijk3117 = this.Content.Load<Texture2D>("3117");
            wijk3118 = this.Content.Load<Texture2D>("3118");
            wijk3119 = this.Content.Load<Texture2D>("3119");
            wijk3122_3121 = this.Content.Load<Texture2D>("3122 en 3121");
            wijk3124_3123 = this.Content.Load<Texture2D>("3124 en 3123");
            wijk3129 = this.Content.Load<Texture2D>("3129");
            wijk3134 = this.Content.Load<Texture2D>("3134");
            wijk3135 = this.Content.Load<Texture2D>("3135");
            wijk3136 = this.Content.Load<Texture2D>("3136");
            wijk3137 = this.Content.Load<Texture2D>("3137");
            app = new BaseApp(basemap);
            Wijk2901 = new location
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
            GraphicsDevice.Clear(Color.AntiqueWhite);
            spriteBatch.Begin();
            // TODO: Add your drawing code here
            app.Draw(spriteBatch);
            base.Draw(gameTime);
            spriteBatch.End();
        }
    }
}
