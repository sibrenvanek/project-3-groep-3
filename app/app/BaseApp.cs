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
        Texture2D array_wijk_image;
        List<object> List_Locations = new List<object>();



        public BaseApp(Texture2D background, List<Texture2D> List_wijk_image, int budget)
        {
            this.Background = background;



            List_Locations.Add(new Location("wijk2901", "2901", List_wijk_image[0], budget));
            List_Locations.Add(new Location("wijk2901", "2902", List_wijk_image[1], budget));
            List_Locations.Add(new Location("wijk2901", "2906", List_wijk_image[2], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[3], 200));
            List_Locations.Add(new Location("wijk2901", "2987", List_wijk_image[4], budget));
            List_Locations.Add(new Location("wijk2901", "3012 en 2011", List_wijk_image[5], budget));
            List_Locations.Add(new Location("wijk2901", "3013 en 3033 en 3032", List_wijk_image[6], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[7], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[8], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[9], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[10], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[11], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[12], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[13], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[14], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[15], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[16], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[17], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[18], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[19], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[20], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[21], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[22], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[23], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[24], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[25], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[26], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[27], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[28], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[29], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[30], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[31], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[32], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[33], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[34], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[35], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[36], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[37], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[38], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[39], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[40], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[41], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[42], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[43], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[44], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[45], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[46], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[47], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[48], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[49], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[50], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[51], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[52], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[53], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[54], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[55], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[56], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[57], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[58], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[59], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[60], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[61], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[62], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[63], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[64], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[65], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[66], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[67], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[68], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[69], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[70], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[71], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[72], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[73], budget));
            List_Locations.Add(new Location("wijk2901", "2907", List_wijk_image[74], budget));
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

            foreach (Location loc in List_Locations)
            {
                loc.Update(dt);
            }
        }
    }
}
