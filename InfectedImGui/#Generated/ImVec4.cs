// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Size = 16)]
public unsafe partial struct ImVec4
{
    [FieldOffset(0)] public float x;

    [FieldOffset(4)] public float y;

    [FieldOffset(8)] public float z;

    [FieldOffset(12)] public float w;

    [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "__InlineHelper2", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(ImVec4* @this);

    [DebuggerStepThrough, DebuggerHidden]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Constructor()
    {
        fixed (ImVec4* @this = &this)
        { Constructor_PInvoke(@this); }
    }

    [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "__InlineHelper3", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(ImVec4* @this, float _x, float _y, float _z, float _w);

    [DebuggerStepThrough, DebuggerHidden]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Constructor(float _x, float _y, float _z, float _w)
    {
        fixed (ImVec4* @this = &this)
        { Constructor_PInvoke(@this, _x, _y, _z, _w); }
    }
}
