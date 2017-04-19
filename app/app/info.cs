using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace app
{
    class Info
    {
        string Name;
        Vector2 Position;
        Texture2D Texture;
        SpriteFont Font;
        Button button2014, button2013, button2012, button2011, button2010, button2009;
        bool clicked2009, clicked2010, clicked2011, clicked2012, clicked2013, clicked2014;
        bool click2009, click2010, click2011, click2012, click2013, click2014;
        public Info(string name, Vector2 position, Texture2D texture, SpriteFont font, Texture2D small_rect)
        {
            this.Name = name;
            this.Position = position;
            this.Texture = texture;
            this.Font = font;
            this.button2014 = new Button("2014", small_rect, Convert.ToInt32(this.Position.X + 10), Convert.ToInt32(this.Position.Y + 420), Font);
            this.button2013 = new Button("2013", small_rect, Convert.ToInt32(this.Position.X + 120), Convert.ToInt32(this.Position.Y + 420), Font);
            this.button2012 = new Button("2012", small_rect, Convert.ToInt32(this.Position.X + 230), Convert.ToInt32(this.Position.Y + 420), Font);
            this.button2011 = new Button("2011", small_rect, Convert.ToInt32(this.Position.X + 10), Convert.ToInt32(this.Position.Y + 460), Font);
            this.button2010 = new Button("2010", small_rect, Convert.ToInt32(this.Position.X + 120), Convert.ToInt32(this.Position.Y + 460), Font);
            this.button2009 = new Button("2009", small_rect, Convert.ToInt32(this.Position.X + 230), Convert.ToInt32(this.Position.Y + 460), Font);
            this.button2009.color = Color.LightGray;
            this.button2010.color = Color.LightGray;
            this.button2011.color = Color.LightGray;
            this.button2012.color = Color.LightGray;
            this.button2013.color = Color.LightGray;
            this.button2014.color = Color.LightGray;
            this.button2009.isClickable = true;
            this.button2010.isClickable = true;
            this.button2011.isClickable = true;
            this.button2012.isClickable = true;
            this.button2013.isClickable = true;
            this.button2014.isClickable = true;
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(this.Texture, this.Position, Color.White);
            spriteBatch.DrawString(this.Font, this.Name, this.Position + new Vector2(10, 0), Color.Black);
            spriteBatch.DrawString(this.Font, "2015:", this.Position + new Vector2(10, 30), Color.Black);
            spriteBatch.DrawString(this.Font, "General real estate value:", this.Position + new Vector2(10, 60), Color.Black);
            spriteBatch.DrawString(this.Font, "General income:", this.Position + new Vector2(10, 80), Color.Black);
            spriteBatch.DrawString(this.Font, "average family size:", this.Position + new Vector2(10, 100), Color.Black);
            spriteBatch.DrawString(this.Font, "satisfaction rating:", this.Position + new Vector2(10, 120), Color.Black);
            spriteBatch.DrawString(this.Font, "show previous years:", this.Position + new Vector2(10, 400), Color.Black);

            if (this.clicked2009)
            {
                spriteBatch.DrawString(this.Font, "2009:", this.Position + new Vector2(10, 180), Color.Black);
                spriteBatch.DrawString(this.Font, "General real estate value:", this.Position + new Vector2(10, 210), Color.Black);
                spriteBatch.DrawString(this.Font, "General income:", this.Position + new Vector2(10, 230), Color.Black);
                spriteBatch.DrawString(this.Font, "average family size:", this.Position + new Vector2(10, 250), Color.Black);
                spriteBatch.DrawString(this.Font, "satisfaction rating:", this.Position + new Vector2(10, 270), Color.Black);
            }
            if (this.clicked2010)
            {
                spriteBatch.DrawString(this.Font, "2010:", this.Position + new Vector2(10, 180), Color.Black);
                spriteBatch.DrawString(this.Font, "General real estate value:", this.Position + new Vector2(10, 210), Color.Black);
                spriteBatch.DrawString(this.Font, "General income:", this.Position + new Vector2(10, 230), Color.Black);
                spriteBatch.DrawString(this.Font, "average family size:", this.Position + new Vector2(10, 250), Color.Black);
                spriteBatch.DrawString(this.Font, "satisfaction rating:", this.Position + new Vector2(10, 270), Color.Black);
            }
            if (this.clicked2011)
            {
                spriteBatch.DrawString(this.Font, "2011:", this.Position + new Vector2(10, 180), Color.Black);
                spriteBatch.DrawString(this.Font, "General real estate value:", this.Position + new Vector2(10, 210), Color.Black);
                spriteBatch.DrawString(this.Font, "General income:", this.Position + new Vector2(10, 230), Color.Black);
                spriteBatch.DrawString(this.Font, "average family size:", this.Position + new Vector2(10, 250), Color.Black);
                spriteBatch.DrawString(this.Font, "satisfaction rating:", this.Position + new Vector2(10, 270), Color.Black);
            }
            if (this.clicked2012)
            {
                spriteBatch.DrawString(this.Font, "2012:", this.Position + new Vector2(10, 180), Color.Black);
                spriteBatch.DrawString(this.Font, "General real estate value:", this.Position + new Vector2(10, 210), Color.Black);
                spriteBatch.DrawString(this.Font, "General income:", this.Position + new Vector2(10, 230), Color.Black);
                spriteBatch.DrawString(this.Font, "average family size:", this.Position + new Vector2(10, 250), Color.Black);
                spriteBatch.DrawString(this.Font, "satisfaction rating:", this.Position + new Vector2(10, 270), Color.Black);
            }
            if (this.clicked2013)
            {
                spriteBatch.DrawString(this.Font, "2013:", this.Position + new Vector2(10, 180), Color.Black);
                spriteBatch.DrawString(this.Font, "General real estate value:", this.Position + new Vector2(10, 210), Color.Black);
                spriteBatch.DrawString(this.Font, "General income:", this.Position + new Vector2(10, 230), Color.Black);
                spriteBatch.DrawString(this.Font, "average family size:", this.Position + new Vector2(10, 250), Color.Black);
                spriteBatch.DrawString(this.Font, "satisfaction rating:", this.Position + new Vector2(10, 270), Color.Black);
            }
            if (this.clicked2014)
            {
                spriteBatch.DrawString(this.Font, "2014:", this.Position + new Vector2(10, 180), Color.Black);
                spriteBatch.DrawString(this.Font, "General real estate value:", this.Position + new Vector2(10, 210), Color.Black);
                spriteBatch.DrawString(this.Font, "General income:", this.Position + new Vector2(10, 230), Color.Black);
                spriteBatch.DrawString(this.Font, "average family size:", this.Position + new Vector2(10, 250), Color.Black);
                spriteBatch.DrawString(this.Font, "satisfaction rating:", this.Position + new Vector2(10, 270), Color.Black);
            }
            this.button2009.Draw(spriteBatch);
            this.button2010.Draw(spriteBatch);
            this.button2011.Draw(spriteBatch);
            this.button2012.Draw(spriteBatch);
            this.button2013.Draw(spriteBatch);
            this.button2014.Draw(spriteBatch);
        }
        public void Update(float dt)
        {
            if (this.button2009.isHovered || this.clicked2009)
            {
                this.button2009.color = Color.Gray;
            }
            else
            {
                this.button2009.color = Color.LightGray;
            }
            if (this.button2010.isHovered || this.clicked2010)
            {
                this.button2010.color = Color.Gray;
            }
            else
            {
                this.button2010.color = Color.LightGray;
            }
            if (this.button2011.isHovered || this.clicked2011)
            {
                this.button2011.color = Color.Gray;
            }
            else
            {
                this.button2011.color = Color.LightGray;
            }
            if (this.button2012.isHovered || this.clicked2012)
            {
                this.button2012.color = Color.Gray;
            }
            else
            {
                this.button2012.color = Color.LightGray;
            }
            if (this.button2013.isHovered || this.clicked2013)
            {
                this.button2013.color = Color.Gray;
            }
            else
            {
                this.button2013.color = Color.LightGray;
            }
            if (this.button2014.isHovered || this.clicked2014)
            {
                this.button2014.color = Color.Gray;
            }
            else
            {
                this.button2014.color = Color.LightGray;
            }
            this.button2009.Update(dt);
            this.button2010.Update(dt);
            this.button2011.Update(dt);
            this.button2012.Update(dt);
            this.button2013.Update(dt);
            this.button2014.Update(dt);
            if (this.button2009.isClicked)
            {
                this.click2009 = true;
            }
            else if (this.click2009)
            {
                this.click2009 = false;
                if (this.clicked2009)
                {
                    this.clicked2009 = false;
                }
                else if (!(this.clicked2009))
                {
                    this.clicked2009 = true;
                    this.clicked2010 = false;
                    this.clicked2011 = false;
                    this.clicked2012 = false;
                    this.clicked2013 = false;
                    this.clicked2014 = false;
                }
            }
            if (this.button2010.isClicked)
            {
                this.click2010 = true;
            }
            else if (this.click2010)
            {
                this.click2010 = false;
                if (this.clicked2010)
                {
                    this.clicked2010 = false;
                }
                else if (!(this.clicked2010))
                {
                    this.clicked2010 = true;
                    this.clicked2009 = false;
                    this.clicked2011 = false;
                    this.clicked2012 = false;
                    this.clicked2013 = false;
                    this.clicked2014 = false;
                }
            }
            if (this.button2011.isClicked)
            {
                this.click2011 = true;
            }
            else if (this.click2011)
            {
                this.click2011 = false;
                if (this.clicked2011)
                {
                    this.clicked2011 = false;
                }
                else if (!(this.clicked2011))
                {
                    this.clicked2011 = true;
                    this.clicked2009 = false;
                    this.clicked2010 = false;
                    this.clicked2012 = false;
                    this.clicked2013 = false;
                    this.clicked2014 = false;
                }
            }
            if (this.button2012.isClicked)
            {
                this.click2012 = true;
            }
            else if (this.click2012)
            {
                this.click2012 = false;
                if (this.clicked2012)
                {
                    this.clicked2012 = false;
                }
                else if (!(this.clicked2012))
                {
                    this.clicked2012 = true;
                    this.clicked2009 = false;
                    this.clicked2010 = false;
                    this.clicked2011 = false;
                    this.clicked2013 = false;
                    this.clicked2014 = false;
                }
            }
            if (this.button2013.isClicked)
            {
                this.click2013 = true;
            }
            else if (this.click2013)
            {
                this.click2013 = false;
                if (this.clicked2013)
                {
                    this.clicked2013 = false;
                }
                else if (!(this.clicked2013))
                {
                    this.clicked2013 = true;
                    this.clicked2009 = false;
                    this.clicked2010 = false;
                    this.clicked2011 = false;
                    this.clicked2012 = false;
                    this.clicked2014 = false;
                }
            }
            if (this.button2014.isClicked)
            {
                this.click2014 = true;
            }
            else if (this.click2014)
            {
                this.click2014 = false;
                if (this.clicked2014)
                {
                    this.clicked2014 = false;
                }
                else if (!(this.clicked2014))
                {
                    this.clicked2014 = true;
                    this.clicked2009 = false;
                    this.clicked2010 = false;
                    this.clicked2011 = false;
                    this.clicked2012 = false;
                    this.clicked2013 = false;
                }
            }
        }
    }
}
