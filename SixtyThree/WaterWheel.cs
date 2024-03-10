using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.IO;
using System.Text.Json;


namespace WaterWheel
{
	public class WaterWheel : Game
	{
		float GroundLevel;
		private GraphicsDeviceManager _graphics;
		private SpriteBatch _spriteBatch;




		public WaterWheel()
		{
			GameSettings.SettingsSet();
			string SettingsFile = "Settings.json";
			string JsonString = File.ReadAllText(SettingsFile);
			GameSettings settings = JsonSerializer.Deserialize<GameSettings>(JsonString)!;

			_graphics = new GraphicsDeviceManager(this);
			_graphics.PreferredBackBufferWidth = settings.DisplayWidth;
			_graphics.PreferredBackBufferHeight = settings.DisplayHeight;
			_graphics.IsFullScreen = settings.FullScreen;
			Content.RootDirectory = "Content";
			IsMouseVisible = false;
		}

		protected override void Initialize()
		{
			// TODO: Add your initialization logic here
			

			GroundLevel = _graphics.PreferredBackBufferHeight - (_graphics.PreferredBackBufferHeight / 3);
			



			base.Initialize();
		}

		protected override void LoadContent()
		{
			_spriteBatch = new SpriteBatch(GraphicsDevice);

			// TODO: use this.Content to load your game content here
			Texture2D IdleSheet = Content.Load<Texture2D>("IdleAnim");


		}

		protected override void Update(GameTime gameTime)
		{
			if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
				_graphics.IsFullScreen = false;

			// TODO: Add your update logic here

			var Kinput = Keyboard.GetState();


			if (Kinput.IsKeyDown(Keys.W))
			{
				
			}
			if (Kinput.IsKeyDown(Keys.A))
			{
			}
			if (Kinput.IsKeyDown(Keys.S))
			{
			}
			if (Kinput.IsKeyDown(Keys.D))
			{
			}			




			base.Update(gameTime);
		}

		protected override void Draw(GameTime gameTime)
		{
			GraphicsDevice.Clear(Color.CornflowerBlue);

			// TODO: Add your drawing code here
			_spriteBatch.Begin();


			_spriteBatch.End();
			
			
			

			base.Draw(gameTime);
		}
	}
}
