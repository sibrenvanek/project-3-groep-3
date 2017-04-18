﻿using Microsoft.Xna.Framework;
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
    
    public class Button
    {
        int buttonX, buttonY, buttonWidth, buttonHeigth;
        string Name;
        Texture2D Texture;
        public bool isClicked;
        public bool isHovered;
        public bool isClickable;
        Vector2 Position;
        public Color color;
        SpriteFont font;

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

        public Button(string name, Texture2D texture, int buttonX, int buttonY, SpriteFont font)
        {
            this.Name = name;
            this.Texture = texture;
            this.buttonX = buttonX;
            this.buttonY = buttonY;
            this.buttonWidth = 100;
            this.buttonHeigth = 30;
            this.Position = new Vector2(this.buttonX, this.buttonY);
            this.font = font;
            this.isClickable = true;
        }

        public void Update(float dt)
        {
            var mouseState = Mouse.GetState();

            if (mouseState.X >= buttonX && mouseState.X < (buttonX + buttonWidth) && mouseState.Y >= buttonY && mouseState.Y < (buttonY + buttonHeigth))
            {
                isHovered = true;
                if(isClickable)
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
            if (isHovered)
                spriteBatch.Draw(this.Texture, this.Position, this.color);
            else
                spriteBatch.Draw(this.Texture, this.Position, this.color);
            spriteBatch.DrawString(this.font, this.Name, new Vector2(this.buttonX + 5, this.buttonY + 7), Color.Black);
        }
    }
}