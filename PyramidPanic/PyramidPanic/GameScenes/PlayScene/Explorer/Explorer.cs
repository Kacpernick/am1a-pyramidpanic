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
    public class Explorer : AnimatedSprite
    {
        //Fields

        private PyramidPanic game;
        private Texture2D texture;

        //Properties
        public PyramidPanic Game
        {
            get { return this.game; }
        }

        public Texture2D Texture
        {
            get { return this.texture; }
        }

        //Constructor

        public Explorer(PyramidPanic game): base(game)
        {
            this.game = game;
            this.texture = game.Content.Load<Texture2D>(@"Explorer\Explorer");
            this.destinationRectangle.X = 0;
            this.destinationRectangle.X = 300;
        }

        //Update

        public void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        //Draw

        public void Draw(GameTime gameTime)
        {
            base.Draw(gameTime, this.texture);
        }
    }
}
