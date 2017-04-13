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
    class BaseApp
    {
        Texture2D Background;

        BaseApp app;
        Texture2D basemap;
        Texture2D array_wijk_image;
        Texture2D rect;
        SpriteFont Font;
        List<Location> List_Locations = new List<Location>();
        List<string> List_names = new List<string>();
        List<Button> List_Buttons = new List<Button>();
        //List<object> List_Buttons_Locations = new List<object>();
        


        public BaseApp(Texture2D background, List<Texture2D> List_wijk_image,SpriteFont Font,Texture2D rect,int budget)
        {

            List_names.Add("Blaak");
            List_names.Add("Beurs");

            string name_button = List_names[0];
            int counter = 0;
            int counter2 = 0;
            int X_pos = 900;
            int Y_pos = 20;


            while (counter <= 74)
            {

                X_pos = X_pos + 100;
                Y_pos = 20;
                counter = counter + 1;
                counter2 = 0;

                while (counter2 <= 19)
                {
                    List_Buttons.Add(new Button(name_button, rect, X_pos, Y_pos, Font));
                    counter2 = counter2 + 1;
                    Y_pos = Y_pos + 50;

                }

            }






            this.Background = background;
            
            List_Locations.Add(new Location(List_names[0], "2901", List_wijk_image[0],List_Buttons[0], budget));
            List_Locations.Add(new Location(List_names[0], "2902", List_wijk_image[1],List_Buttons[1], 80));
            List_Locations.Add(new Location(List_names[0], "2906", List_wijk_image[2], List_Buttons[2], 130));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[3], List_Buttons[3], 200));
            List_Locations.Add(new Location(List_names[0], "2987", List_wijk_image[4], List_Buttons[4], budget));
            List_Locations.Add(new Location(List_names[0], "3012 en 2011", List_wijk_image[5], List_Buttons[5], budget));
            List_Locations.Add(new Location(List_names[0], "3013 en 3033 en 3032", List_wijk_image[6], List_Buttons[6], budget));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[7], List_Buttons[7], budget));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[8], List_Buttons[8], budget));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[9], List_Buttons[9], budget));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[10], List_Buttons[10], budget));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[11], List_Buttons[11], budget));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[12], List_Buttons[12], budget));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[13], List_Buttons[13], budget));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[14], List_Buttons[14], budget));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[15], List_Buttons[15], budget));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[16], List_Buttons[16], budget));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[17], List_Buttons[17], budget));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[18], List_Buttons[18], budget));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[19], List_Buttons[19], budget));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[20], List_Buttons[20], budget));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[21], List_Buttons[21], budget));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[22], List_Buttons[22], budget));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[23], List_Buttons[23], budget));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[24], List_Buttons[24], budget));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[25], List_Buttons[25], budget));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[26], List_Buttons[26], budget));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[27], List_Buttons[27], budget));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[28], List_Buttons[28], budget));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[29], List_Buttons[29], budget));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[30], List_Buttons[30], budget));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[31], List_Buttons[31], budget));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[32], List_Buttons[32], budget));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[33], List_Buttons[33], budget));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[34], List_Buttons[34], budget));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[35], List_Buttons[35], budget));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[36], List_Buttons[36], budget));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[37], List_Buttons[37], budget));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[38], List_Buttons[38], budget));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[39], List_Buttons[39], budget));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[40], List_Buttons[40], budget));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[41], List_Buttons[41], budget));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[42], List_Buttons[42], budget));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[43], List_Buttons[43], budget));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[44], List_Buttons[44], budget));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[45], List_Buttons[45], budget));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[46], List_Buttons[46], budget));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[47], List_Buttons[47], budget));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[48], List_Buttons[48], budget));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[49], List_Buttons[49], budget));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[50], List_Buttons[50], budget));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[51], List_Buttons[51], budget));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[52], List_Buttons[52], budget));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[53], List_Buttons[53], budget));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[54], List_Buttons[54], budget));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[55], List_Buttons[55], budget));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[56], List_Buttons[56], budget));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[57], List_Buttons[57], budget));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[58], List_Buttons[58], budget));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[59], List_Buttons[59], budget));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[60], List_Buttons[60], budget));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[61], List_Buttons[61], budget));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[62], List_Buttons[62], budget));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[63], List_Buttons[63], budget));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[64], List_Buttons[64], budget));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[65], List_Buttons[65], budget));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[66], List_Buttons[66], budget));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[67], List_Buttons[67], budget));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[68], List_Buttons[68], budget));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[69], List_Buttons[69], budget));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[70], List_Buttons[70], budget));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[71], List_Buttons[71], budget));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[72], List_Buttons[72], budget));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[73], List_Buttons[73], budget));
            List_Locations.Add(new Location(List_names[0], "2907", List_wijk_image[74], List_Buttons[74], budget));

            // name_button == name wijk , replace both with a name_list


            
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(this.Background, new Vector2(0, 0), Color.White);
            //New_wijk2901.Draw(spriteBatch);
            foreach(Location loc in List_Locations)
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
