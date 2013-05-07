﻿using System;

namespace Vocaluxe.Base.Server
{
    public struct SLoginData
    {
        public byte[] SHA256;
    }

    public struct SAvatarPicture
    {
        public int Width;
        public int Height;
        public byte[] data;
    }
}