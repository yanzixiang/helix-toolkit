﻿/*
The MIT License (MIT)
Copyright (c) 2018 Helix Toolkit contributors
*/
using SharpDX;
using System.Numerics;
using Matrix = System.Numerics.Matrix4x4;

#if NETFX_CORE
namespace HelixToolkit.UWP
#else
namespace HelixToolkit.Wpf.SharpDX
#endif
{
    public static class DataStreamExtension
    {
        public static int ReadInt(this DataStream ds)
        {
            return ds.Read<int>();
        }

        public static float ReadFloat(this DataStream ds)
        {
            return ds.Read<float>();
        }

        public static Vector4 ReadVector4(this DataStream ds)
        {
            return ds.Read<Vector4>();
        }

        public static Matrix ReadMatrix(this DataStream ds)
        {
            return ds.Read<Matrix>();
        }
    }
}
