﻿using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;

using SadConsole.Consoles;
using Console = SadConsole.Consoles.Console;
using SadConsole.Input;

namespace StarterProject.CustomConsoles
{


    class CachedConsoleConsole : Console
    {
        CachedTextSurfaceRenderer cachedRenderer;
        ITextSurfaceRenderer oldRenderer;

        public CachedConsoleConsole()
            : base(80, 25)
        {
            IsVisible = false;
            FillWithRandomGarbage();

            cachedRenderer = new CachedTextSurfaceRenderer(TextSurface);
            oldRenderer = _renderer;
        }

        public override bool ProcessKeyboard(KeyboardInfo info)
        {
            if (info.IsKeyReleased(Keys.Space))
            {
                Renderer = _renderer == oldRenderer ? cachedRenderer : oldRenderer;
                TextSurface.Tint = _renderer == oldRenderer ? Color.Transparent : new Color(255, 255, 255, 70);
            }

            return false;
        }
    }
}
