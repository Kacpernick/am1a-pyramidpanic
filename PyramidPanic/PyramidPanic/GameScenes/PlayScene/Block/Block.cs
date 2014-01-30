// Met using kan je een XNA codebibliotheek toevoegen en gebruiken in je class
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
    class Block : Image
    {
        //Fields
        private Texture2D texture;

        //Properties

        //Constructor
        public Block(PyramidPanic game, string pathNameAsset, Vector2 position) : base (game, pathNameAsset, position)
        {
            this.texture = game.Content.Load<Texture2D>(@"Scorpion\Scorpion");
        }

        //Update

        // Draw methode. Deze methode wordt normaal 60 maal per seconde aangeroepen en
        // tekent de textures op het canvas
        public void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
        }
    }
}
