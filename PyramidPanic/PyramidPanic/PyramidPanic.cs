// Met using kan je een xna codebibliotheek toevoegen
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
    public class PyramidPanic : Microsoft.Xna.Framework.Game
    {
        //Fields 
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        //Dit is de constructor.Heeft altijd dezelfde naam als de classe
        public PyramidPanic()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            //Verander de tietel
            Window.Title = "Pyramid Panic";

            //Maak de muis zichtbaar
            IsMouseVisible = true;

            //Verander de breedte van het canvas
            this.graphics.PreferredBackBufferWidth = 640;
            
            //Verander de hoogte van het canvas
            this.graphics.PreferredBackBufferHeight = 480;

            //Past de nieuwe hoogte en breedte toe
            this.graphics.ApplyChanges();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            //spriteBatch is nodig voor het tekens
            spriteBatch = new SpriteBatch(GraphicsDevice);
        }

        protected override void UnloadContent()
        {
        }

        protected override void Update(GameTime gameTime)
        {
            //Zorgt dat het spel stopt wanneer je op de gamepad button Back indrukt
            if ((GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed) || 
                (Keyboard.GetState().IsKeyDown(Keys.Escape)))
                this.Exit();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            //Geeft de achter groond color
            GraphicsDevice.Clear(Color.Pink);

            base.Draw(gameTime);
        }
    }
}
