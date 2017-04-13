using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using app;
using Microsoft.Xna.Framework.Input;


namespace app
{
    
    public class Button :Game
    {
        int buttonX, buttonY;
        string Name;
        Texture2D Texture;
        bool isClicked;
        bool isHovered;
        Vector2 Position;
        SpriteFont font ;

        public int ButtonX
        {
            get
            {
                return buttonX;
            }
        }

        public int ButtonY
        {
            get
            {
                return buttonY;
            }
        }

        public Button(string name, Texture2D texture, int buttonX, int buttonY,SpriteFont Font)
        {
            this.Name = name;
            this.Texture = texture;
            this.buttonX = buttonX;
            this.buttonY = buttonY;
            this.Position = new Vector2(this.buttonX, this.buttonY);
            this.font = Font;

            //Content.RootDirectory = "Content";
            //Font = Content.Load<SpriteFont>("File");

        }

        public void Update(float dt)
        {
            var mouseState = Mouse.GetState();
            var mousePoint = new Point(mouseState.X, mouseState.Y);
            var rectangle = new Rectangle(mousePoint.X, mousePoint.Y, this.Texture.Width, this.Texture.Height);


            



            if (rectangle.Contains(mousePoint))
            {
                isHovered = true;
                isClicked = mouseState.LeftButton == ButtonState.Pressed;
            }
            else
            {
                isHovered = false;
                isClicked = false;
            }
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            //if (isHovered)
            //    spriteBatch.Draw(this.Texture, this.Position, Color.LightGray);
            //else
            //    spriteBatch.Draw(this.Texture, this.Position, Color.White);
            spriteBatch.Draw(this.Texture, this.Position, Color.White);
            spriteBatch.DrawString(this.font, this.Name, new Vector2(this.buttonX, this.buttonY), Color.Black);
        }
    }
}