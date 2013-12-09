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
    public class HelpScene : IState //De classe implementeert de interface
    {
        //Fields van de classe
        private PyramidPanic game;

        //Construstor van de StartScene
        public HelpScene(PyramidPanic game)
        {
            this.game = game;
        }

        //Geeft startward
        public void Initialize()
        {

        }

        //Deze methode maakt nieuwe objecten
        public void LoadContent()
        {

        }

        //Deze methode word normaal 60 maal per seconde aangeroepen.
        public void Update(GameTime gameTime)
        {
            {
                if (Input.EdgeDetectKeyDown(Keys.Right))
                {
                    this.game.IState = this.game.StartScene;
                }
            }
        }

        //Deze methode word normaal 60 maal per seconde aangeroepen en tekent de textures op het canvas.
        public void Draw(GameTime gameTime)
        {
            this.game.GraphicsDevice.Clear(Color.Navy);
        }
    }
}