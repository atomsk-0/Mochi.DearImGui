// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using System.Runtime.InteropServices;

namespace InfectedImGui.Internal
{
    [StructLayout(LayoutKind.Explicit, Size = 304)]
    public unsafe partial struct ImGuiWindowTempData
    {
        [FieldOffset(0)] public ImVec2 CursorPos;

        [FieldOffset(8)] public ImVec2 CursorPosPrevLine;

        [FieldOffset(16)] public ImVec2 CursorStartPos;

        [FieldOffset(24)] public ImVec2 CursorMaxPos;

        [FieldOffset(32)] public ImVec2 IdealMaxPos;

        [FieldOffset(40)] public ImVec2 CurrLineSize;

        [FieldOffset(48)] public ImVec2 PrevLineSize;

        [FieldOffset(56)] public float CurrLineTextBaseOffset;

        [FieldOffset(60)] public float PrevLineTextBaseOffset;

        [FieldOffset(64)] public ImVec1 Indent;

        [FieldOffset(68)] public ImVec1 ColumnsOffset;

        [FieldOffset(72)] public ImVec1 GroupOffset;

        [FieldOffset(76)] public uint LastItemId;

        [FieldOffset(80)] public ImGuiItemStatusFlags LastItemStatusFlags;

        [FieldOffset(84)] public ImRect LastItemRect;

        [FieldOffset(100)] public ImRect LastItemDisplayRect;

        [FieldOffset(116)] public ImGuiNavLayer NavLayerCurrent;

        [FieldOffset(120)] public int NavLayerActiveMask;

        [FieldOffset(124)] public int NavLayerActiveMaskNext;

        [FieldOffset(128)] public uint NavFocusScopeIdCurrent;

        [FieldOffset(132)] [MarshalAs(UnmanagedType.I1)] public bool NavHideHighlightOneFrame;

        [FieldOffset(133)] [MarshalAs(UnmanagedType.I1)] public bool NavHasScroll;

        [FieldOffset(134)] [MarshalAs(UnmanagedType.I1)] public bool MenuBarAppending;

        [FieldOffset(136)] public ImVec2 MenuBarOffset;

        [FieldOffset(144)] public ImGuiMenuColumns MenuColumns;

        [FieldOffset(180)] public int TreeDepth;

        [FieldOffset(184)] public uint TreeJumpToParentOnPopMask;

        [FieldOffset(192)] public ImGuiWindowVector ChildWindows;

        [FieldOffset(208)] public ImGuiStorage* StateStorage;

        [FieldOffset(216)] public ImGuiOldColumns* CurrentColumns;

        [FieldOffset(224)] public int CurrentTableIdx;

        [FieldOffset(228)] public ImGuiLayoutType LayoutType;

        [FieldOffset(232)] public ImGuiLayoutType ParentLayoutType;

        [FieldOffset(236)] public int FocusCounterRegular;

        [FieldOffset(240)] public int FocusCounterTabStop;

        [FieldOffset(244)] public ImGuiItemFlags ItemFlags;

        [FieldOffset(248)] public float ItemWidth;

        [FieldOffset(252)] public float TextWrapPos;

        [FieldOffset(256)] public ImVector<float> ItemWidthStack;

        [FieldOffset(272)] public ImVector<float> TextWrapPosStack;

        [FieldOffset(288)] public ImGuiStackSizes StackSizesOnBegin;
    }
}