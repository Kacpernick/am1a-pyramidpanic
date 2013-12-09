using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace PyramidPanic
{
    public class Image
    {
        //Fields
        private Texture2D texture;
        //Maak een Rectangle
        private Rectangle rectangle;

        private PyramidPanic game;

        //Constructor
        public Image(PyramidPanic game , String pathnaamAsset, Vector2 position)
        {
            this.texture = game.Content.Load<Texture2D>(pathnaamAsset);
            this.rectangle = new Rectangle((int)position.X,
                                            (int)position.Y,
                                            this.texture.Width,
                                            this.texture.Height);
        }

        //Update

        //Draw
        public void Draw(GameTime gameTime)
        {
            this.game.Spritebatch.Draw(this.texture, this.rectangle, Color.Black);
        }
        //Helper
    }
}
