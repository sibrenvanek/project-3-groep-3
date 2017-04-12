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
        Texture2D Wijk2901;
        Texture2D Wijk2902;
        public bool W2901;
        public bool W2902;
        bool FPressed;
        bool FHasBeenPressed;
        public BaseApp(Texture2D background, Texture2D wijk2901, Texture2D wijk2902)
        {
            this.Background = background;
            this.Wijk2901 = wijk2901;
            this.Wijk2902 = wijk2902;
            this.W2901 = true;
            this.W2902 = true;
        }
        private void Switch2901()
        {
            if (W2901)
                W2901 = false;
            else if (!(W2901))
                W2901 = true;
        }
        private void Switch2902()
        {
            if (W2902)
                W2902 = false;
            else if (!(W2902))
                W2902 = true;
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            if(Microsoft.Xna.Framework.Input.Keyboard.GetState().IsKeyDown(Microsoft.Xna.Framework.Input.Keys.F))
            {
                FPressed = true;
            }
            if(FPressed)
            {
                FPressed = false;
                FHasBeenPressed = true;
            }
            else if (FHasBeenPressed)
            {
                Switch2901();
                Switch2902();
                FHasBeenPressed = false;
            }
            spriteBatch.Draw(this.Background, new Vector2(0, 0), Color.White);
            if (W2901)
                spriteBatch.Draw(this.Wijk2901, new Vector2(0, 0), Color.Green);
            else
                spriteBatch.Draw(this.Wijk2901, new Vector2(0, 0), Color.Red);
            if (W2902)
                spriteBatch.Draw(this.Wijk2902, new Vector2(0, 0), Color.Green);
            else
                spriteBatch.Draw(this.Wijk2902, new Vector2(0, 0), Color.Red);
        }
    }
}
