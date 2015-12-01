// MonoGame - Copyright (C) The MonoGame Team
// This file is subject to the terms and conditions defined in
// file 'LICENSE.txt', which is part of this source code package.

using System;

#if WINRT
using Windows.UI.ViewManagement;
#endif

namespace Microsoft.Xna.Framework
{
    partial class GamePlatform
    {
        internal static GamePlatform PlatformCreate(Game game, IEmbedContext embedContext)
        {
#if MONOMAC
            return new MacGamePlatform(game);
#elif DESKTOPGL || ANGLE
            return new SdlGamePlatform(game, embedContext);
#elif WINDOWS && DIRECTX
            if (embedContext != null && embedContext.WindowHandle != IntPtr.Zero)
            {
                return new MonoGame.Framework.WinEmbeddedGamePlatform(game, embedContext);
            }
            else
            {
                return new MonoGame.Framework.WinFormsGamePlatform(game);
            }
#elif WINDOWS_UAP
            return new UAPGamePlatform(game);
#elif WINRT
            return new MetroGamePlatform(game);
#endif
        }

#if WINDOWS_STOREAPP
        public event EventHandler<ViewStateChangedEventArgs> ViewStateChanged;

        private ApplicationViewState _viewState;
        public ApplicationViewState ViewState
        {
            get { return _viewState; }
            set
            {
                if (_viewState == value)
                    return;

                Raise(ViewStateChanged, new ViewStateChangedEventArgs(value));

                _viewState = value;
            }
        }
#endif
    }
}
