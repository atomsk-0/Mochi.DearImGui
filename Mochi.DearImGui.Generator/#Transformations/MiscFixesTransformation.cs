using Biohazrd;
using Biohazrd.CSharp;
using Biohazrd.Expressions;
using Biohazrd.Transformation;
using System;
using System.Diagnostics;
using System.Linq;

namespace Mochi.DearImGui.Generator
{
    internal sealed class MiscFixesTransformation : TransformationBase
    {
        protected override TransformationResult TransformTypedef(TransformationContext context, TranslatedTypedef declaration)
        {
            // ImWchar16 is defined as being ushort, but it makes more sense for it to be a C# char.
            if (declaration.Name is "ImWchar16")
            {
                Debug.Assert(declaration.UnderlyingType == CSharpBuiltinType.UShort);
                return declaration with
                {
                    UnderlyingType = CSharpBuiltinType.Char
                };
            }
            // ImWchar32 is defined as being uint, but it makes more sense for it to be a .NET System.Rune.
            // (In theory System.Rune is slightly different since it should only be used with valid unicode characters, but I think this is probably fine.)
            else if (declaration.Name is "ImWchar32")
            {
                Debug.Assert(declaration.UnderlyingType == CSharpBuiltinType.UInt);
                return declaration with
                {
                    UnderlyingType = new ExternallyDefinedTypeReference("System.Text", "Rune")
                };
            }
            else
            { return declaration; }
        }

        protected override TransformationResult TransformFunction(TransformationContext context, TranslatedFunction declaration)
        {
            if (declaration.Name.Contains("ImGui_Impl"))
            {
                string cleanedName = declaration.Name.Replace("ImGui_ImplWin32_", "")
                    .Replace("ImGui_ImplDX9_", "")
                    .Replace("ImGui_ImplDX10_", "")
                    .Replace("ImGui_ImplDX11_", "")
                    .Replace("ImGui_ImplDX12_", "")
                    .Replace("ImGui_ImplGlfw_", "")
                    .Replace("ImGui_ImplOpenGL3_", "");
                /*if (declaration.Namespace == null) return declaration;
                string lastPartNamespace = declaration.Namespace!.Split('.').Last();
                if (cleanedName.StartsWith(lastPartNamespace, StringComparison.InvariantCultureIgnoreCase))
                {
                    cleanedName = cleanedName[lastPartNamespace.Length..];
                }
                if (cleanedName.StartsWith("_", StringComparison.InvariantCultureIgnoreCase))
                {
                    cleanedName = cleanedName[1..];
                }*/
                return declaration with{ Name = cleanedName };
            }

            return declaration;
        }
    }
}
