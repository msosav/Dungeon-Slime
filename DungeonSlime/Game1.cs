using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using MonoGameLibrary;
using MonoGameLibrary.Graphics;

namespace DungeonSlime;

public class Game1 : Core
{
    private Texture2D _logo;

    private TextureRegion _slime;

    private TextureRegion _bat;

    public Game1() : base(title: "Dungeon Slime", width: 1280, height: 720, fullScreen: false)
    {
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here

        base.Initialize();
    }

    protected override void LoadContent()
    {
        // TODO: use this.Content to load your game content here
        TextureAtlas atlas = TextureAtlas.FromFile(Content, "Images/atlas-definition.xml");

        _slime = atlas.GetRegion("slime");
        _bat = atlas.GetRegion("bat");

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
        // Clear the back buffer.
        GraphicsDevice.Clear(Color.CornflowerBlue);

        // Begin the sprite batch to prepare for rendering.
        SpriteBatch.Begin(samplerState: SamplerState.PointClamp);

        _slime.Draw(SpriteBatch, Vector2.Zero, Color.White, 0.0f, Vector2.One, 4.0f, SpriteEffects.None, 0.0f);
        _bat.Draw(SpriteBatch, new Vector2(_slime.Width * 4.0f + 10, 0), Color.White, 0.0f, Vector2.One, 4.0f, SpriteEffects.None, 0.0f);

        // Always end the sprite batch when finished.
        SpriteBatch.End();

        base.Draw(gameTime);
    }

}
