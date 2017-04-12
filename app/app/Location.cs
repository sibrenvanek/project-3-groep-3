using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class Location
{
    string Name, Postcode;
    int WOZ=100;
    Texture2D Image;
    Color Color;
    Vector2 Position;
    int budget;
    public Location(string name, string postcode, Texture2D image, int budget)
    {
        this.Name = name;
        this.Postcode = postcode;
        this.Image = image;
        this.Color = Color.White;
        this.Position = new Vector2(0, 0);
        this.budget = budget;
        //this.WOZ = getWOZ();
    }/*
    public int getWOZ()
    {
        SELECT woz_waarde
        FROM Wijk
        WHERE post_code = this.Postcode;
    }*/
    public void Draw(SpriteBatch spritebatch)
    {
        spritebatch.Draw(this.Image, this.Position, this.Color);
    }
    public void Update(float dt)
    {
        int A;
        A = (budget/WOZ)*100;

        if (A>80 & A<=120 )
        {
            // groen
            this.Color = Color.Red;
        }
        else if ( A>60 & A<=80 || A>120 & A<=140 )
        {
            // geelgroen
            this.Color = Color.YellowGreen;
        }
        else if (A>40 & A<=60 || A>140 & A<=160)
        {
            //geel
            this.Color = Color.Yellow;
        }
        else if (A>20 & A <=40 || A>160 & A <=180)
        {
            //oranje
            this.Color = Color.Orange;
        }
        else if (A<=20 || A<180)
        {
            //red
            this.Color = Color.Red;
        }

    }
}
