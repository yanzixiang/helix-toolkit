﻿/*
The MIT License (MIT)
Copyright (c) 2018 Helix Toolkit contributors
*/
using SharpDX.Direct3D11;
using System;

#if NETFX_CORE
namespace HelixToolkit.UWP.Render
#else
namespace HelixToolkit.Wpf.SharpDX.Render
#endif
{
    /// <summary>
    /// 
    /// </summary>
    public class SwapChainRenderHost : DefaultRenderHost
    {
        protected readonly IntPtr surface;
        /// <summary>
        /// Initializes a new instance of the <see cref="SwapChainRenderHost"/> class.
        /// </summary>
        /// <param name="surface">The window PTR.</param>
        public SwapChainRenderHost(IntPtr surface)
        {
            this.surface = surface;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SwapChainRenderHost"/> class.
        /// </summary>
        /// <param name="surface">The surface.</param>
        /// <param name="createRenderer">The create renderer.</param>
        public SwapChainRenderHost(IntPtr surface, Func<Device, IRenderer> createRenderer) : base(createRenderer)
        {
            this.surface = surface;
        }
        /// <summary>
        /// Creates the render buffer.
        /// </summary>
        /// <returns></returns>
        protected override IDX11RenderBufferProxy CreateRenderBuffer()
        {
            return new DX11SwapChainRenderBufferProxy(surface, EffectsManager);
        }
    }
}
