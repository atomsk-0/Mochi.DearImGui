Fork of [MochiLibraries/Mochi.DearImGui](https://github.com/MochiLibraries/Mochi.DearImGui), Modified for my other projects, this fork removes the OpenTK backend and instead uses imgui provided backends by including them for source generation.

# Dear ImGui-flavored Mochi

[![MIT Licensed](https://img.shields.io/github/license/mochilibraries/mochi.dearimgui?style=flat-square)](LICENSE.txt)
[![Sponsor](https://img.shields.io/badge/sponsor_(original_author)-%E2%9D%A4-lightgrey?logo=github&style=flat-square)](https://github.com/sponsors/PathogenDavid)

This repo contains C# bindings for [Dear ImGui](https://github.com/ocornut/imgui/) as well as a [Biohazrd](https://github.com/MochiLibraries/Biohazrd)-powered generator for generating them.

In contrast to other C# bindings for Dear ImGui, this one interacts with the C++ API directly and is lower-level. If you need high-level bindings consider using the excellent [ImGui.NET](https://github.com/mellinoe/ImGui.NET) instead.

## License

This project is licensed under the MIT License. [See the license file for details](LICENSE.txt).

Additionally, this project has some third-party dependencies. [See the third-party notice listing for details](THIRD-PARTY-NOTICES.md).

## Building

### Windows Prerequisites

Windows 10 21H2 x64 is recommended.

Tool | Tested Version
-----|--------------------
[Visual Studio](https://visualstudio.microsoft.com/vs/) | 2022 (17.1.0p2)
[.NET 6.0 SDK](http://dot.net/) | 6.0.101
[CMake](https://cmake.org/) | 3.22.0

Visual Studio must have the "Desktop development with C++" workload installed.

### Linux Prerequisites

Ubuntu 20.04 Focal x64 is recommended, but most distros are expected to work. (Mochi.DearImGui itself should also work on Linux ARM64, but the OpenTK backend doesn't since OpenTK's GLFW redistributable doesn't.)

Package | Tested Version
--------|--------------------
`build-essential` | 12.8
`cmake` | 3.16.3
`dotnet-sdk-6.0` | 6.0.100

### Building Dear ImGui and generating the bindings

1. Ensure Git submodules are up-to-date with `git submodule update --init --recursive`
2. Build and run `generate.cmd` (Windows) or `generate.sh` (Linux) from the repository root

(Sample project is not included)
