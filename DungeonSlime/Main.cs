using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGameLibrary;

namespace DungeonSlime;

public class Main : Core
{
    // The MonoGame logo texture
    private Texture2D _logo;

    public Main() : base("Dungeon Slime", 1280, 720, false) { }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here

        base.Initialize();
    }

    protected override void LoadContent()
    {
        // TODO: use this.Content to load your game content here
        
        _logo = Content.Load<Texture2D>("images/logo");

        base.LoadContent();
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        // TODO: Add your update logic here

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.Coral);

        // TODO: Add your drawing code here

        // Begin the sprite batch to prepare for rendering.
        SpriteBatch.Begin();

        // Draw the logo texture
        SpriteBatch.Draw(
            _logo,              // texture
            new Vector2(        // position
                Window.ClientBounds.Width * 0.5f,
                Window.ClientBounds.Height * 0.5f),
            null,               // sourceRectangle
            Color.White,        // color
            0.0f,               // rotation
            new Vector2(_logo.Width, _logo.Height) * 0.5f,       // origin
            1.0f,               // scale
            SpriteEffects.None, // effects
            0.0f                // layerDepth
    );

        // Always end the sprite batch when finished.
        SpriteBatch.End();

        base.Draw(gameTime);
    }
}
