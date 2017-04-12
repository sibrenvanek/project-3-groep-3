using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    class BaseApp
    {
        Texture2D Background;

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

        public BaseApp(Texture2D background)
        {
            this.Background = background;

            Location New_wijk2901 = new Location("wijk2901", "2901",wijk2901, 100);

        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(this.Background, new Vector2(0, 0), Color.White);
        }
    }
}
