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
    int WOZ;
    Texture2D Image;
    Color Color;
    Vector2 Position;
    public Location(string name, string postcode, Texture2D image)
    {
        this.Name = name;
        this.Postcode = postcode;
        this.Image = image;
        this.Color = Color.White;
        this.Position = new Vector2(0, 0);
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

    }
}
