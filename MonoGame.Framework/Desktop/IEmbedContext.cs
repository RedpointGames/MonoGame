namespace Microsoft.Xna.Framework
{
    public interface IEmbedContext
    {
#if (WINDOWS && OPENGL) || LINUX || ANGLE
        OpenTK.Graphics.IGraphicsContext GraphicsContext { get; }

        OpenTK.Platform.IWindowInfo WindowInfo { get; }

        System.Drawing.Point PointToClient(System.Drawing.Point point);

        event System.EventHandler OnResize;
#elif WINDOWS && DIRECTX
		System.IntPtr WindowHandle { get; }
#endif

        Rectangle GetClientBounds();
    }
}

