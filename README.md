<!-- <p align="center">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://raw.githubusercontent.com/openui-project/openui/main/assets/pygdk_logo_dark.png">
    <source media="(prefers-color-scheme: light)" srcset="https://raw.githubusercontent.com/openui-project/openui/main/assets/pygdk_logo_light.png">
    <img src="https://raw.githubusercontent.com/openui-project/openui/main/assets/pygdk_logo_light.png">
  </picture>
</p> -->

# OpenUI

**OpenUI** is a lightweight C# library for building modern, interactive graphical user interfaces with simplicity and flexibility.

## Installation - NuGet

The easiest way to get started is through NuGet.

1. Choose a folder where you’d like to start your OpenUI project. For example, "MyOpenUIProject".
2. Open a terminal (e.g., Visual Studio terminal) in the directory and execute the following commands. Make sure .NET is already installed:

```bat
dotnet new console
```

```bat
dotnet add package OpenUI
```

## Installation - Manual Setup

1. Clone the repository:

```bat
git clone https://github.com/openui-project/openui.git
```

2. Navigate to the `src` directory:
```bat
cd openui/src
```

3. Add all the `.csproj` files from the folders within the `src` directory to your project.

## Quick Start

Here's a quick example demonstrating how to create a window:

```cs
using OpenUI;

public static class Program
{
    public static void Main(string[] args)
    {
        var window = new GameWindow(800, 600, "Simpile Example");
        window.Show();
    }
}
```
