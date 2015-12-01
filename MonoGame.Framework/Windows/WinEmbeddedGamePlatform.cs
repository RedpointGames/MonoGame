#if WINDOWS && DIRECTX

using System;
using Microsoft.Xna.Framework;

namespace MonoGame.Framework
{
	internal class WinEmbeddedGamePlatform : GamePlatform
	{
		private IEmbedContext _embedContext;

		public WinEmbeddedGamePlatform(Game game, IEmbedContext context) : base(game)
		{
			_embedContext = context;

		    Window = new WinEmbeddedGameWindow(this, _embedContext);
		}

		public override GameRunBehavior DefaultRunBehavior
		{
			get {
				return GameRunBehavior.Synchronous;
			}
		}

        public override void Exit()
        {
        }

        public override void RunLoop()
        {
        }

        public override void StartRunLoop()
        {
        }

        public override bool BeforeUpdate(GameTime gameTime)
        {
            return true;
        }

        public override bool BeforeDraw(GameTime gameTime)
        {
            return true;
        }

	    public override void EnterFullScreen()
        {
        }

        public override void ExitFullScreen()
        {
        }

        public override void BeginScreenDeviceChange(bool willBeFullScreen)
        {
        }

        public override void EndScreenDeviceChange(string screenDeviceName, int clientWidth, int clientHeight)
        {
        }

        public override void Present()
        {
            var device = Game.GraphicsDevice;
            if (device != null)
                device.Present();
        }
    }
}

#endif