﻿// Decompiled with JetBrains decompiler
// Type: SAM.API.Wrappers.SteamUtils005
// Assembly: SAM.API, Version=6.3.0.804, Culture=neutral, PublicKeyToken=null
// MVID: 7DF108F6-41E2-4750-9029-3DA2C808D0A1
// Assembly location: E:\Dropbox\SPARA\Develop\TimeEnhancer\TimeEnhancer\TimeEnhancer\SAM.API.dll

using TimeEnhancer.API.Interfaces;
using System;
using System.Runtime.InteropServices;

namespace TimeEnhancer.API.Wrappers
{
  public class SteamUtils005 : NativeWrapper<ISteamUtils005>
  {
    public int GetConnectedUniverse()
    {
        return this.Call<int, SteamUtils005.NativeGetConnectedUniverse>(this.Functions.GetConnectedUniverse, new object[1]
        {
            (object) this.ObjectAddress
        });
    }

    public string GetIPCountry()
    {
        return this.Call<string, SteamUtils005.NativeGetIPCountry>(this.Functions.GetIPCountry, new object[1]
        {
            (object) this.ObjectAddress
        });
    }

    [return: MarshalAs(UnmanagedType.I1)]
    public bool GetImageSize(int index, ref int width, ref int height)
    {
        return this.GetFunction<SteamUtils005.NativeGetImageSize>(this.Functions.GetImageSize)(this.ObjectAddress, index, ref width, ref height);
    }

    public bool GetImageRGBA(int index, byte[] data)
    {
        return this.GetFunction<SteamUtils005.NativeGetImageRGBA>(this.Functions.GetImageRGBA)(this.ObjectAddress, index, data, data.Length);
    }

    public uint GetAppID()
    {
        return this.Call<uint, SteamUtils005.NativeGetAppID>(this.Functions.GetAppID, new object[1]
        {
            (object) this.ObjectAddress
        });
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
    private delegate int NativeGetConnectedUniverse(IntPtr thisObject);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
    private delegate string NativeGetIPCountry(IntPtr thisObject);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
    private delegate bool NativeGetImageSize(IntPtr thisObject, int iImage, ref int pnWidth, ref int pnHeight);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
    [return: MarshalAs(UnmanagedType.I1)]
    private delegate bool NativeGetImageRGBA(IntPtr thisObject, int iImage, byte[] pubDest, int nDestBufferSize);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
    private delegate uint NativeGetAppID(IntPtr thisObject);
  }
}
