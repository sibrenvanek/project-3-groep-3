using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Configuration;

namespace app
{
    class BaseApp
    {
        Texture2D Background, Legenda;

        List<Location> List_Locations = new List<Location>();
        List<string> List_names = new List<string>();
        List<Button> List_Buttons = new List<Button>();
        //List<object> List_Buttons_Locations = new List<object>();
        Button Budget_input;
        int Budget;
        bool clicked;

        public BaseApp(Texture2D background, List<Texture2D> List_wijk_image, SpriteFont Font, Texture2D rect, int budget, Texture2D rect_info, List<string> list_names, Texture2D legenda, Texture2D small_rect)
        {

            List_names = list_names;
            int counter = 0;
            int counter2 = 0;
            int X_pos = 1000;
            int Y_pos = 10;
            Budget_input = new Button("Budget_input", rect, 10, 10, Font);
            while (counter < 10)
            {
                List_Buttons.Add(new Button(List_names[counter], rect, X_pos, Y_pos, Font));
                Y_pos = Y_pos + 40;
                counter++;
            }
            this.Background = background;
            this.Legenda = legenda;
            Random rnd = new Random();
            while(counter2 < 10)
            {
                budget = rnd.Next(1, 201);
                List_Locations.Add(new Location(List_names[counter2], List_names[counter2], List_wijk_image[counter2], List_Buttons[counter2], budget, rect_info, Font, small_rect));
                counter2++;
            }
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(this.Background, new Vector2(0, 0), Color.White);
            spriteBatch.Draw(this.Legenda, new Vector2(0, 406), Color.White);
            Budget_input.Draw(spriteBatch);
            foreach (Location loc in List_Locations)
            {
                loc.Draw(spriteBatch);
            }
        }
        private void checkClick()
        {
            foreach(Location loc in List_Locations)
            {
                if (loc.hasBeenClicked)
                {
                    foreach(Location loca in List_Locations)
                    {
                        loca.isClickable = false;
                    }
                    loc.isClickable = true;
                }
            }
        }
        private void clickReset()
        {
            foreach(Location loc in List_Locations)
            {
                loc.isClickable = true;
            }
        }
        private void Update_budget()
        {
            foreach (Location loc in List_Locations)
            {
                loc.Budget = Budget;
            }
        }
        public void Update(float dt)
        {
            Budget_input.Update(dt);
            if (Budget_input.isHovered)
                Budget_input.color = Color.LightGray;
            else
                Budget_input.color = Color.White;
            checkClick();
            foreach (Location loc in List_Locations)
            {
                loc.Update(dt);
            }
            if (this.Budget_input.isClicked)
            {
                this.clicked = true;
            }
            else if (this.clicked)
            {
                this.clicked = false;
                Budget = Budget_input.budget_input();
                Update_budget();
            }
            clickReset();
        }
    }
}
