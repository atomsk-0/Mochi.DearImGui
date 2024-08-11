cmake_minimum_required(VERSION 3.16)
project(Mochi.DearImGui.Native)

set(IMGUI_SOURCE_DIRECTORY "../external/imgui/")

#TODO: Add support for ARM64
#TODO: Consider using the determine-rid.(cmd|sh) script for this
if("${CMAKE_SYSTEM_NAME}" STREQUAL "Windows")
    set(DOTNET_RID "win-x64")
elseif("${CMAKE_SYSTEM_NAME}" STREQUAL "Linux")
    set(DOTNET_RID "linux-x64")
elseif("${CMAKE_SYSTEM_NAME}" STREQUAL "Darwin")
    set(DOTNET_RID "osx-x64")
else()
    message(FATAL_ERROR "Unsupported target platform '${CMAKE_SYSTEM_NAME}'")
endif()

# Link GLFW library
if (WIN32)
    set(GLFW_LIB "C:/Users/Mikael/projects/Mochi.DearImGui/external/imgui/glfw3.lib")
else()
    set(GLFW_LIB ${IMGUI_SOURCE_DIRECTORY}libglfw3.a)
endif()

# Set output directories
set(OUTPUT_DIRECTORY "${CMAKE_CURRENT_SOURCE_DIR}/../bin/Mochi.DearImGui.Native/${DOTNET_RID}/")

if(NOT GENERATOR_IS_MULTI_CONFIG)
    # Make sure configuration is appended to output directory for single-configuration generators
    set(OUTPUT_DIRECTORY "${OUTPUT_DIRECTORY}${CMAKE_BUILD_TYPE}/")
endif()

set(CMAKE_RUNTIME_OUTPUT_DIRECTORY "${OUTPUT_DIRECTORY}")
set(CMAKE_LIBRARY_OUTPUT_DIRECTORY "${OUTPUT_DIRECTORY}")
set(CMAKE_ARCHIVE_OUTPUT_DIRECTORY "${OUTPUT_DIRECTORY}")

file(GLOB IMGUI_SOURCES "${IMGUI_SOURCE_DIRECTORY}*.cpp")
link_libraries(${GLFW_LIB})

if (WIN32)
   link_libraries(legacy_stdio_definitions)
endif()

add_library(Mochi.DearImGui.Native SHARED ${IMGUI_SOURCES} InlineExportHelper.gen.cpp)
include_directories("${IMGUI_SOURCE_DIRECTORY}" ".")
add_compile_definitions(IMGUI_USER_CONFIG="DearImGuiConfig.h")