// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Size = 12)]
public unsafe partial struct ImGuiTableColumnSortSpecs
{
    [FieldOffset(0)] public uint ColumnUserID;

    [FieldOffset(4)] public short ColumnIndex;

    [FieldOffset(6)] public short SortOrder;

    [FieldOffset(8)] private uint __SortDirection__backingField;
    public ImGuiSortDirection SortDirection
    {
        get => (ImGuiSortDirection)((__SortDirection__backingField >> 0) & 0xFFU);
        set
        {
            uint shiftedValue = (((uint)value) & 0xFFU) << 0;
            uint otherBits = __SortDirection__backingField & 0xFFFFFF00U;
            __SortDirection__backingField = otherBits | shiftedValue;
        }
    }

    [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "__InlineHelper6", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(ImGuiTableColumnSortSpecs* @this);

    [DebuggerStepThrough, DebuggerHidden]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Constructor()
    {
        fixed (ImGuiTableColumnSortSpecs* @this = &this)
        { Constructor_PInvoke(@this); }
    }
}
