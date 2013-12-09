﻿// Met using kan je een xna codebibliotheek toevoegen
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
   public class StartScene : IState //De classe implementeert de interface
    {
        //Fields van de classe
        private PyramidPanic game;
        private Image background , title;

        //Construstor van de StartScene
        public StartScene(PyramidPanic game)
        {
            this.game = game;
            this.Initialize();
        }

        //Geeft startward
        public void Initialize()
        {

        }

        //Deze methode maakt nieuwe objecten
        public void LoadContent()
        {
            this.background = new Image(this.game, @"", Vector2.Zero);
            this.title = new Image(this.game, @"", Vector2.Zero);
        }

        //Deze methode word normaal 60 maal per seconde aangeroepen.
        public void Update(GameTime gameTime)
        {
            if (Input.EdgeDetectKeyDown(Keys.Right) || Input.EdgeDetectMousePressLeft())
            {
                this.game.IState = this.game.PlayScene;
            }

            if (Input.EdgeDetectKeyDown(Keys.Right))
            {
                this.game.IState = this.game.PlayScene;
            }
        }

        //Deze methode word normaal 60 maal per seconde aangeroepen en tekent de textures op het canvas.
        public void Draw(GameTime gameTime)
        {
            this.game.GraphicsDevice.Clear(Color.Azure);
        }
    }
}
