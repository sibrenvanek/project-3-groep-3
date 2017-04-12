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
        
        Location New_wijk2901;

        List<object> List_Locations = new List<object> ();

        public BaseApp(Texture2D background , Texture2D wijk2901)
        {
            this.Background = background;

            List_Locations.Add(new Location("wijk2901", "2901", wijk2901, 130));

           // New_wijk2901 = new Location("wijk2901", "2901",wijk2901, 100);
            
            

        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(this.Background, new Vector2(0, 0), Color.White);
            //New_wijk2901.Draw(spriteBatch);
            foreach (Location loc in List_Locations)
            {
                loc.Draw(spriteBatch);
            }

        }
        public void Update(float dt)
        {
            
            foreach(Location loc in List_Locations)
            {
                loc.Update(dt);
            }
        }
    }
}
