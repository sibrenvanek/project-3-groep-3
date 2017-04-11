using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace app
{
    public class Location : Game
    {
        //name , postcode , WOZ , income , image , image_location , image_color , budget

        string name, postcode;
        int WOZ;
        int Budget;
        Texture2D Image;
        Vector2 image_location;
        Color image_color;



        private Location(Texture2D image)
        {
            // load in image , all other info  when initialising

        }
        private void Draw(SpriteBatch spritebatch)
        {
            // draw the class ( image ) 

        }
    }
}
