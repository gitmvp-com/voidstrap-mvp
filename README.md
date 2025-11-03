# 🌌 Voidstrap MVP

**Voidstrap MVP** is a minimal version of [Voidstrap](https://github.com/voidstrap/Voidstrap), featuring a modern WPF UI framework with theming support.

![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?style=for-the-badge&logo=dotnet)
![WPF](https://img.shields.io/badge/WPF-Windows-0078D4?style=for-the-badge&logo=windows)
![License](https://img.shields.io/badge/License-MIT-green?style=for-the-badge)

## ✨ Features

- ⚡ **Modern WPF UI** - Built with WPF-UI library for a contemporary look
- 🌓 **Theme Support** - Dark and Light themes with system integration
- 🎨 **Mica Backdrop** - Windows 11 Mica material for beautiful window chrome
- 🏗️ **MVVM Architecture** - Clean architecture with CommunityToolkit.Mvvm
- 🎯 **Minimal & Fast** - Focused MVP with only essential features

## 🚀 Quick Start

### Prerequisites

- Windows 7 or later (Windows 11 recommended for Mica effects)
- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- Visual Studio 2022 (optional, for development)

### Building from Source

1. **Clone the repository:**
   ```bash
   git clone https://github.com/gitmvp-com/voidstrap-mvp.git
   cd voidstrap-mvp
   ```

2. **Restore dependencies:**
   ```bash
   dotnet restore
   ```

3. **Build the project:**
   ```bash
   dotnet build
   ```

4. **Run the application:**
   ```bash
   dotnet run --project VoidstrapMVP
   ```

### Using Visual Studio

1. Open `VoidstrapMVP.sln` in Visual Studio 2022
2. Press `F5` to build and run

## 📦 Dependencies

This MVP uses the following NuGet packages (same versions as parent repository):

- **CommunityToolkit.Mvvm** `8.4.0` - MVVM helpers and commands
- **WPF-UI** `3.0.5` - Modern Fluent UI controls for WPF

## 🎨 Theme Controls

The application includes built-in theme switching:

- **Dark Theme** - Modern dark color scheme (default)
- **Light Theme** - Clean light color scheme
- **System Theme** - Automatically follows Windows theme

## 📁 Project Structure

```
voidstrap-mvp/
├── VoidstrapMVP/
│   ├── Views/
│   │   ├── MainWindow.xaml          # Main application window
│   │   └── MainWindow.xaml.cs       # Window code-behind
│   ├── Resources/
│   │   └── Icon.ico                 # Application icon
│   ├── App.xaml                     # Application resources
│   ├── App.xaml.cs                  # Application entry point
│   └── VoidstrapMVP.csproj         # Project file
├── VoidstrapMVP.sln                # Solution file
└── README.md                        # This file
```

## 🛠️ Development

### Adding New Features

This MVP is designed to be extended. To add features from the parent Voidstrap:

1. Review the [parent repository](https://github.com/voidstrap/Voidstrap)
2. Add required NuGet packages matching parent versions
3. Implement features following MVVM pattern
4. Update UI in `MainWindow.xaml`

### Configuration

The project targets:
- **Framework:** .NET 8.0 Windows
- **Platform:** Windows 7.0+
- **Architecture:** WPF with XAML UI

## 📝 License

This project is based on [Voidstrap](https://github.com/voidstrap/Voidstrap). Please refer to the parent repository for licensing information.

## 🙌 Credits

### Original Project
- **Voidstrap** - [voidstrap/Voidstrap](https://github.com/voidstrap/Voidstrap)
- **Bloxstrap** - [bloxstraplabs/bloxstrap](https://github.com/bloxstraplabs/bloxstrap)

### MVP Version
- Created with [GitMVP](https://github.com/gitmvp-com)

## 🤝 Contributing

This is a minimal MVP version. For the full-featured application, please visit the [parent repository](https://github.com/voidstrap/Voidstrap).

---

**Note:** This MVP includes only the basic WPF UI framework feature. The parent repository contains many more features including Discord RPC, FastFlags editor, mod manager, music player, and more.
