using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    class Button
    {
        public Button(x, y, width, height, function, color, hovercolor, text)
    }

    class Button :
    def __init__(self, x, y, width, height, function, color, hovercolor, text, constant=False, textsize=None, textcolor=(255,255,255)):
        self.X = x
        self.Y = y
        self.Width = width
        self.Height = height

        self.Function = function
        self.Color = color
        self.Color_hover = hovercolor
        self.Color_text = textcolor
        self.Text = text
        if textsize != None: self.Text_size = textsize
        else: self.Text_size = int(self.Height / 1.2)

        self.Constant = constant

        self.Pressing = False
        self.Pressed = False


    def Click(self): return pygame.mouse.get_pressed()[0]
    def Hover(self):
        if self.X<pygame.mouse.get_pos()[0] < self.X + self.Width:
            if self.Y<pygame.mouse.get_pos()[1] < self.Y + self.Height: return True
        return False

    def Draw(self):
        if self.Hover():
            pygame.draw.rect(game.Display, self.Color_hover, (self.X, self.Y, self.Width, self.Height))

            if self.Constant == True:
                if self.Click():
                    self.Pressing = True
                else:
                    if self.Pressing:
                        if self.Pressed:
                            self.Pressed = False
                        else:
                            self.Pressed = True
                        self.Pressing = False
            else:
                self.Pressing = self.Click()
                if self.Pressing:
                    self.Pressed = True
                    self.Pressing = False
                else:
                    if self.Pressed == True:
                        self.Function()
                        #PlaySound(Mouseclick)
                        self.Pressed = False

        else:
            pygame.draw.rect(game.Display, self.Color, (self.X, self.Y, self.Width, self.Height))
        text(self.Text, int(self.Text_size), self.X + 5, self.Y + self.Height / 5, self.Color_text)

        if self.Constant == True:
            if self.Pressed:
                self.Function()
}
