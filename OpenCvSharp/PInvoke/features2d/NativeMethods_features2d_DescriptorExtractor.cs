﻿using System;
using System.Runtime.InteropServices;

#pragma warning disable 1591

namespace OpenCvHololens
{
    static partial class NativeMethods
    {
        // DescriptorExtractor
        [DllImport(DllExtern)]
        public static extern void features2d_DescriptorExtractor_delete(IntPtr obj);
        [DllImport(DllExtern)]
        public static extern void features2d_DescriptorExtractor_compute1(
            IntPtr obj, IntPtr image, IntPtr keypoint, IntPtr descriptors);
        [DllImport(DllExtern)]
        public static extern void features2d_DescriptorExtractor_compute2(
            IntPtr obj, IntPtr[] images, int imagesSize, IntPtr keypoints, 
            IntPtr[] descriptors, int descriptorsSize);
        [DllImport(DllExtern)]
        public static extern int features2d_DescriptorExtractor_descriptorSize(IntPtr obj);
        [DllImport(DllExtern)]
        public static extern int features2d_DescriptorExtractor_descriptorType(IntPtr obj);
        [DllImport(DllExtern)]
        public static extern int features2d_DescriptorExtractor_empty(IntPtr obj);
        [DllImport(DllExtern)]
        public static extern IntPtr features2d_DescriptorExtractor_info(IntPtr obj);
        [DllImport(DllExtern)]
        public static extern IntPtr features2d_DescriptorExtractor_create(
            [MarshalAs(UnmanagedType.LPStr)] string descriptorExtractorType);

        [DllImport(DllExtern)]
        public static extern IntPtr features2d_Ptr_DescriptorExtractor_get(IntPtr ptr);
        [DllImport(DllExtern)]
        public static extern void features2d_Ptr_DescriptorExtractor_delete(IntPtr ptr);
    }
}