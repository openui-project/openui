<!-- <p align="center">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://raw.githubusercontent.com/openui-project/openui/main/assets/pygdk_logo_dark.png">
    <source media="(prefers-color-scheme: light)" srcset="https://raw.githubusercontent.com/openui-project/openui/main/assets/pygdk_logo_light.png">
    <img src="https://raw.githubusercontent.com/openui-project/openui/main/assets/pygdk_logo_light.png">
  </picture>
</p> -->

# OpenUI

**OpenUI** is a lightweight C# library for building modern, interactive graphical user interfaces with simplicity and flexibility.

<!-- ## Installation  -->

## Getting Started

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
> [!TIP]
> Check out the **[official documentation](https://github.com/openui-project/openui/wiki)** for detailed usage, examples, and more.
