// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Size = 56)]
public unsafe partial struct ImDrawCmd
{
    [FieldOffset(0)] public ImVec4 ClipRect;

    [FieldOffset(16)] public void* TextureId;

    [FieldOffset(24)] public uint VtxOffset;

    [FieldOffset(28)] public uint IdxOffset;

    [FieldOffset(32)] public uint ElemCount;

    [FieldOffset(40)] public delegate* unmanaged[Cdecl]<ImDrawList*, ImDrawCmd*, void> UserCallback;

    [FieldOffset(48)] public void* UserCallbackData;

    [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "__InlineHelper20", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(ImDrawCmd* @this);

    [DebuggerStepThrough, DebuggerHidden]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Constructor()
    {
        fixed (ImDrawCmd* @this = &this)
        { Constructor_PInvoke(@this); }
    }
}
