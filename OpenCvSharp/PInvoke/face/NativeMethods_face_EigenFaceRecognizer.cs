﻿
using System;
using System.Runtime.InteropServices;

#pragma warning disable 1591

namespace OpenCvSharp
{
    // ReSharper disable InconsistentNaming

    static partial class NativeMethods
    {
        [DllImport(DllExtern)]
        public static extern IntPtr face_EigenFaceRecognizer_create(int numComponents, double threshold);

        [DllImport(DllExtern)]
        public static extern IntPtr face_Ptr_EigenFaceRecognizer_get(IntPtr obj);

        [DllImport(DllExtern)]
        public static extern void face_Ptr_EigenFaceRecognizer_delete(IntPtr obj);
    }
}