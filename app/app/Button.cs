using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using app;
using Microsoft.Xna.Framework.Input;
using Microsoft.VisualBasic;


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
        //Color Color;
        int WOZ;
        int budget;
        float A;

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
            //this.Color = Color.Purple;

            

           

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
        public void Draw(SpriteBatch spriteBatch,Color Color)
        {


            spriteBatch.Draw(this.Texture, this.Position, Color);
            spriteBatch.DrawString(this.font, this.Name, this.Position, Color.Black);
            

        }
        public int budget_function()
        {
            int value =Convert.ToInt32(Interaction.InputBox("test"));
            return value;
        }
    }
}