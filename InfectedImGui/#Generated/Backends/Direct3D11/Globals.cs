// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using System.Runtime.InteropServices;

namespace InfectedImGui.Backends.Direct3D11
{
    public unsafe static partial class Globals
    {
        [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool ImGui_ImplDX11_Init(ID3D11Device* device, ID3D11DeviceContext* device_context);

        [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGui_ImplDX11_Shutdown();

        [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGui_ImplDX11_NewFrame();

        [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGui_ImplDX11_RenderDrawData(ImDrawData* draw_data);

        [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImGui_ImplDX11_InvalidateDeviceObjects();

        [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool ImGui_ImplDX11_CreateDeviceObjects();
    }
}