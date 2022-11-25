# Remote Desktop Connection List Manager
Remote Desktop Connection List Manager (RDCLM) is a program that allows you to modify the computer list present in Remote Desktop Connection. The program supports Windows only.

* [Download the installer](https://github.com/BrandonXLF/remote-desktop-connection-list-manager/releases/latest/download/RDCLM_Installer.exe)
* [Download portable version](https://github.com/BrandonXLF/remote-desktop-connection-list-manager/releases/latest/download/RDCLM_Portable.exe)

## Building
RDCLM is built using Visual Studio with .NET as well as NSIS. To produce a publishable version of the app, publish the main project in Visual Studio. Note this will automatically run `makensis NSIS.nsi` to create the installer.
