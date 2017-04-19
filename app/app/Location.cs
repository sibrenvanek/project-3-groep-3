using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace app
{
    public class Location
    {
        string Name, Postcode;
        float WOZ;
        Texture2D Image;
        Color Color;
        Vector2 Position;
        List<Button> List_Location_Buttons = new List<Button>();
        //SpriteBatch spriteBatch;
        Button button;
        bool clicked;
        public bool hasBeenClicked, isClickable;
        public int Budget;
        Form1 info = new Form1();
        Info InfoWindow;
        public Location(string name, string postcode, Texture2D image, Button Button, int budget, Texture2D rect_info, SpriteFont font, Texture2D small_rect)
        {
            this.Name = name;
            this.Postcode = postcode;
            this.Image = image;
            this.Color = Color.Blue;
            this.Position = new Vector2(0, 0);
            this.Budget = budget;
            this.WOZ = 100;
            this.button = Button;
            this.isClickable = true;
            this.InfoWindow = new Info(name, new Vector2(1300, 10), rect_info, font, small_rect);


            //this.WOZ = getWOZ();
        }
    /*
    public int getWOZ()
    {
        SELECT woz_waarde
        FROM Wijk
        WHERE post_code = this.Postcode;
    }*/

        public void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(this.Image, this.Position, this.Color);
            this.button.Draw(spritebatch);
            Vector2 infowindowpos = new Vector2(1300, 10);
            if (this.hasBeenClicked)
            {
                InfoWindow.Draw(spritebatch);
            }
        }
        public void Update(float dt)
        {
            this.button.Update(dt);
            float A;
            A = ((this.Budget / this.WOZ) * 100);
            if (A > 80 && A <= 120)
            {
                // groen
                if ((this.button.isHovered || this.hasBeenClicked) && isClickable)
                    this.Color = Color.LightGreen;
                else
                    this.Color = Color.Green;
            }
            else if (A > 60 & A <= 80 | A > 120 & A <= 140)
            {
                // geelgroen
                if ((this.button.isHovered || this.hasBeenClicked) && isClickable)
                    this.Color = Color.GreenYellow;
                else
                    this.Color = Color.YellowGreen;
            }
            else if (A > 40 & A <= 60 | A > 140 & A <= 160)
            {
                //geel
                if ((this.button.isHovered || this.hasBeenClicked) && isClickable)
                    this.Color = Color.LightYellow;
                else
                    this.Color = Color.Yellow;
            }
            else if (A > 20 & A <= 40 | A > 160 & A <= 180)
            {
                //oranje
                if ((this.button.isHovered || this.hasBeenClicked) && isClickable)
                    this.Color = Color.DarkOrange;
                else
                    this.Color = Color.Orange;
            }
            else if (A <= 20 | A > 180)
            {
                //red
                if ((this.button.isHovered || this.hasBeenClicked) && isClickable)
                    this.Color = Color.DarkRed;
                else
                    this.Color = Color.Red;
            }
            else
            {
                if ((this.button.isHovered || this.hasBeenClicked) && isClickable)
                    this.Color = Color.Violet;
                else
                    this.Color = Color.Purple;
            }
            this.button.isClickable = this.isClickable;
            this.button.color = this.Color;
            if (this.button.isClicked)
            {
                this.clicked = true;
            }
            else if (this.clicked)
            {
                if (!(this.hasBeenClicked))
                {
                    //info.Show();
                    this.hasBeenClicked = true;
                }
                else if (this.hasBeenClicked)
                {
                    //info.Hide();
                    this.hasBeenClicked = false;
                }
                this.clicked = false;
            }
            if (this.hasBeenClicked)
                this.InfoWindow.Update(dt);
        }
    }
}