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
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;

        //Maak een variab le aan van het type StartScene
        private StartScene startScene;

        //Maak een variab le aan van het type PlayScene
        private PlayScene playScene;

        //Maak een variab le aan van het type HelpScene
        private HelpScene helpScene;

        //Maak een variab le aan van het type GameOverScene
        private GameOverScene gameOverScene;

        //Maak een variab le aan van het type IState
        private IState iState;

        #region Propeties
        //Prpeties
        public IState IState
        {
            get { return this.iState; }
            set { this.iState = value; }
        }
        //Maak fields bechikbaar buiten

        public StartScene StartScene
        {
            get { return this.startScene; }
        }
        //Maak fields bechikbaar buiten
        public PlayScene PlayScene
        {
            get { return this.playScene; }
        }
        //Maak fields bechikbaar buiten
        public HelpScene HelpScene
        {
            get { return this.helpScene; }
        }
        //Maak fields bechikbaar buiten
        public GameOverScene GameOverScene
        {
            get { return this.gameOverScene; }
        } 
        public SpriteBatch SpriteBatch
        {
            get {return this.spriteBatch;}
        }
        #endregion
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

            //We maken nu het object
            //de constructor aan te roepen
            this.startScene = new StartScene(this);
            this.playScene = new PlayScene(this);
            this.helpScene = new HelpScene(this);
            this.gameOverScene = new GameOverScene(this);
            this.iState = this.startScene;
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
            //class input word aangeropen
            Input.Update();

            //Roep de update aan
            this.iState.Update(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            //Geeft de achter groond color
            GraphicsDevice.Clear(Color.Pink);

            //Roep de Draw aan
            this.spriteBatch.Begin();

            //Roep de Draw aan van StartScene class
            this.iState.Draw(gameTime);
            //End van de methode
            this.spriteBatch.End();



            base.Draw(gameTime);
        }
    }
}
