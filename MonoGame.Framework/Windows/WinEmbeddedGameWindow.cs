using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace MonoGame.Framework
{
    internal class WinEmbeddedGameWindow : GameWindow
    {
        private readonly WinEmbeddedGamePlatform _platform;
        private readonly IEmbedContext _embedContext;

        internal WinEmbeddedGameWindow(WinEmbeddedGamePlatform platform, IEmbedContext embedContext)
        {
            _platform = platform;
            _embedContext = embedContext;
        }

        public override bool AllowUserResizing { get; set; }

        public override Rectangle ClientBounds
        {
            get { return _embedContext.GetClientBounds(); }
        }

        public override Point Position { get; set; }

        public override DisplayOrientation CurrentOrientation
        {
            get { return DisplayOrientation.Default; }
        }

        public override IntPtr Handle
        {
            get { return _embedContext.WindowHandle; }
        }

        public override string ScreenDeviceName
        {
            get { return "Default"; }
        }

        public override void BeginScreenDeviceChange(bool willBeFullScreen)
        {
        }

        public override void EndScreenDeviceChange(string screenDeviceName, int clientWidth, int clientHeight)
        {
        }

        protected internal override void SetSupportedOrientations(DisplayOrientation orientations)
        {
        }

        protected override void SetTitle(string title)
        {
        }
    }
}
