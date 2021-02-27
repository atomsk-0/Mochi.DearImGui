// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using InfectedImGui.Infrastructure;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace InfectedImGui.Internal
{
    [StructLayout(LayoutKind.Explicit, Size = 312)]
    public unsafe partial struct ImGuiViewportP
    {
        [FieldOffset(0)] public ImGuiViewport Base;

        [FieldOffset(96)] public int Idx;

        [FieldOffset(100)] public int LastFrameActive;

        [FieldOffset(104)] public int LastFrontMostStampCount;

        [FieldOffset(108)] public uint LastNameHash;

        [FieldOffset(112)] public ImVec2 LastPos;

        [FieldOffset(120)] public float Alpha;

        [FieldOffset(124)] public float LastAlpha;

        [FieldOffset(128)] public short PlatformMonitor;

        [FieldOffset(130)] [MarshalAs(UnmanagedType.I1)] public bool PlatformWindowCreated;

        [FieldOffset(136)] public ImGuiWindow* Window;

        [FieldOffset(144)] public ConstantArray_int_2 DrawListsLastFrame;

        [FieldOffset(152)] public ConstantArray_ImDrawList__UNICODE_0020____UNICODE_002A___2 DrawLists;

        [FieldOffset(168)] public ImDrawData DrawDataP;

        [FieldOffset(224)] public ImDrawDataBuilder DrawDataBuilder;

        [FieldOffset(256)] public ImVec2 LastPlatformPos;

        [FieldOffset(264)] public ImVec2 LastPlatformSize;

        [FieldOffset(272)] public ImVec2 LastRendererSize;

        [FieldOffset(280)] public ImVec2 WorkOffsetMin;

        [FieldOffset(288)] public ImVec2 WorkOffsetMax;

        [FieldOffset(296)] public ImVec2 CurrWorkOffsetMin;

        [FieldOffset(304)] public ImVec2 CurrWorkOffsetMax;

        [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "__InlineHelper55", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(ImGuiViewportP* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Constructor()
        {
            fixed (ImGuiViewportP* @this = &this)
            { Constructor_PInvoke(@this); }
        }

        [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "__InlineHelper56", ExactSpelling = true)]
        private static extern void Destructor_PInvoke(ImGuiViewportP* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Destructor()
        {
            fixed (ImGuiViewportP* @this = &this)
            { Destructor_PInvoke(@this); }
        }

        [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?GetMainRect@ImGuiViewportP@@QEBA?AUImRect@@XZ", ExactSpelling = true)]
        private static extern ImRect* GetMainRect_PInvoke(ImGuiViewportP* @this, out ImRect __returnBuffer);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe ImRect GetMainRect()
        {
            fixed (ImGuiViewportP* @this = &this)
            {
                ImRect __returnBuffer;
                GetMainRect_PInvoke(@this, out __returnBuffer);
                return __returnBuffer;
            }
        }

        [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?GetWorkRect@ImGuiViewportP@@QEBA?AUImRect@@XZ", ExactSpelling = true)]
        private static extern ImRect* GetWorkRect_PInvoke(ImGuiViewportP* @this, out ImRect __returnBuffer);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe ImRect GetWorkRect()
        {
            fixed (ImGuiViewportP* @this = &this)
            {
                ImRect __returnBuffer;
                GetWorkRect_PInvoke(@this, out __returnBuffer);
                return __returnBuffer;
            }
        }

        [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?UpdateWorkRect@ImGuiViewportP@@QEAAXXZ", ExactSpelling = true)]
        private static extern void UpdateWorkRect_PInvoke(ImGuiViewportP* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void UpdateWorkRect()
        {
            fixed (ImGuiViewportP* @this = &this)
            { UpdateWorkRect_PInvoke(@this); }
        }

        [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?ClearRequestFlags@ImGuiViewportP@@QEAAXXZ", ExactSpelling = true)]
        private static extern void ClearRequestFlags_PInvoke(ImGuiViewportP* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void ClearRequestFlags()
        {
            fixed (ImGuiViewportP* @this = &this)
            { ClearRequestFlags_PInvoke(@this); }
        }
    }
}