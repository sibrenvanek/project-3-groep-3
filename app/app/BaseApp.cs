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
        public BaseApp(Texture2D background)
        {
            this.Background = background;
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(this.Background, new Vector2(0, 0), Color.White);
        }
    }
}
