# WinUI-MAUI-Sample
.NET 6 MAUI Preview 3 Sample  :rocket::rocket::rocket:

------

## Get Started with Project Reunion

> :warning: **Note**
>
> If you created a project with an earlier preview or release version of Project Reunion or WinUI 3, you can [update the project to use the latest release](https://docs.microsoft.com/en-us/windows/apps/project-reunion/update-existing-projects-to-the-latest-release).

## .NET SDK references

In order to receive all of the fixes from the latest stable release of Project Reunion 0.5 in C# .NET 5 projects, you'll need to explicitly set your .NET SDK to the latest version. To do this, add the following item group to your .csproj file, then save your project. These lines can be removed from your project file after .NET 5.0.6 is available in May 2021.

```xml
<ItemGroup>
    <FrameworkReference Update="Microsoft.Windows.SDK.NET.Ref" RuntimeFrameworkVersion="10.0.18362.16" />
    <FrameworkReference Update="Microsoft.Windows.SDK.NET.Ref" TargetingPackVersion="10.0.18362.16" />
</ItemGroup>
```

## Set up your development environment

1. Ensure that your development computer has Windows 10, version 1809 (build 17763), or a later OS version installed.

2. Install [Visual Studio 2019, version 16.9](https://visualstudio.microsoft.com/vs/) if you haven't done so already.

   > :warning: **Note**
   >
   > Visual Studio 2019, version 16.9 does not currently support all WinUI 3 tooling features. To access the full suite of WinUI 3 tooling features, please use [Visual Studio 16.10 Preview](https://visualstudio.microsoft.com/vs/preview/). For more information about WinUI 3 tooling support, see [Windows UI Library 3 - Project Reunion 0.5](https://docs.microsoft.com/en-us/windows/apps/winui/winui3/#visual-studio-support).

   You must include the following components when installing Visual Studio:

   - On the **Workloads** tab of the installation dialog, make sure **Universal Windows Platform development** is selected.
   - On the **Individual components** tab of the installation dialog, make sure **Windows 10 SDK (10.0.19041.0)** is selected in the **SDKs, libraries, and frameworks** section.

   To build .NET apps, you must also include the following components:

   - On the **Workloads** tab of the installation dialog, make sure **.NET Desktop Development** is selected.

   To build C++ apps, you must also include the following components:

   - On the **Workloads** tab of the installation dialog, make sure **Desktop development with C++** is selected.
   - In the **Installation details** pane on the right side of the installation dialog, make sure the **C++ (v142) Universal Windows Platform tools** optional component is selected in the **Universal Windows Platform development** section.
3. If you previously installed the [WinUI 3 Preview extension for Visual Studio](https://marketplace.visualstudio.com/items?itemName=Microsoft-WinUI.WinUIProjectTemplates), uninstall the extension. For more information about how to uninstall an extension, see [Manage extensions for Visual Studio](https://docs.microsoft.com/en-us/visualstudio/ide/finding-and-using-visual-studio-extensions).

4. Make sure your system has a NuGet package source enabled for the official NuGet service index at `https://api.nuget.org/v3/index.json`.

      1. In Visual Studio, select **Tools** -> **NuGet Package Manager** -> **Package Manager Settings** to open the **Options** dialog.
      2. In the left pane of the **Options** dialog, select the **Package Sources** tab, and make sure there is a package source for **nuget.org** that points to `https://api.nuget.org/v3/index.json` as the source URL. For more information, see [Common NuGet configurations](https://docs.microsoft.com/en-us/nuget/consume-packages/configuring-nuget-behavior).

5. Download and install the Project Reunion 0.5 extension for Visual Studio. There are two versions of the extension: one for desktop (C#/.NET 5 or C++/WinRT) apps and one for UWP apps.

      To use Project Reunion in desktop (C#/.NET 5 or C++/WinRT) apps:

      - In Visual Studio 2019, click **Extensions** > **Manage Extensions**, search for **Project Reunion**, and install the **Project Reunion** extension.
      - Alternatively, you can download and install the [Project Reunion 0.5 extension](https://marketplace.visualstudio.com/items?itemName=ProjectReunion.MicrosoftProjectReunion) directly from the Visual Studio Marketplace.

      To use Project Reunion in UWP apps, you must install a preview version of the extension that is not supported for production environments:

      - Uninstall any existing versions of the Project Reunion VSIX.
      - In Visual Studio 2019, click **Extensions** > **Manage Extensions**, and click **Change your settings for Extensions** in the bottom left corner. Turn off automatic updates for packages installed for all users before installing the older version.
      - Download and install the [Project Reunion 0.5 Preview extension](https://download.microsoft.com/download/9/9/8/9981a84b-8fd8-4645-9dce-c62761601f17/ProjectReunion.Extension.vsix).
      
      For instructions about how to add the VSIX package to Visual Studio, see [Manage extensions for Visual Studio](https://docs.microsoft.com/en-us/visualstudio/ide/finding-and-using-visual-studio-extensions).

![Screenshot of Project Reunion extension being installed](https://gitee.com/jeremywuiot/img-res-all/raw/master/src/iie_shop/reunion-extension-install.png)

6. To use WinUI 3 tooling such as Live Visual Tree, Hot Reload, and Live Property Explorer in Visual Studio 2019 16.10 Preview, you must enable WinUI 3 tooling with Visual Studio Preview Features. For instructions, see [How to Enable UI Tooling for WinUI 3](https://github.com/microsoft/microsoft-ui-xaml/issues/4140).



## Create a new project that uses Project Reunion

The Project Reunion 0.5 extensions for Visual Studio 2019 (including the extension for desktop apps and the preview extension for UWP apps) provide project templates that generate projects with a WinUI 3-based UI layer and provide access to all other Project Reunion APIs. For more information about the available project templates, see [WinUI 3 project templates in Visual Studio](https://docs.microsoft.com/en-us/windows/apps/winui/winui3/winui-project-templates-in-visual-studio).

> :warning:**Note**
>
> The desktop (C#/.NET 5 and C++/WinRT) project templates are supported for use in production environments. The UWP project templates are available as a developer preview only, and cannot be used to build apps for production environments.
>
> If you create a C#/.NET 5 project, make sure that your project's .NET SDK references are up to date using [these instructions](https://docs.microsoft.com/en-us/windows/apps/project-reunion/#net-sdk-references).

To create a new project that uses Project Reunion 0.5:

1. In Visual Studio 2019, select **File** -> **New** -> **Project**.
2. In the project drop-down filters, select **C#**, **Windows**, and **WinUI**, respectively. 
3. Selected the **Blank App, Packaged (WinUI 3 in Desktop)** project type and click **Next**.

![image-20210507153824489](https://gitee.com/jeremywuiot/img-res-all/raw/master/src/iie_shop/image-20210507153824489.png)

4. Enter a project name, choose any other options as desired, and click **Create**.
5. In the following dialog box, set the **Target version** to Windows 10, version 2004 (build 19041) and **Minimum version** to Windows 10, version 1809 (build 17763) and then click **OK**.

![image-20210507153903333](https://gitee.com/jeremywuiot/img-res-all/raw/master/src/iie_shop/image-20210507153903333.png)

6. At this point, Visual Studio generates two projects:

   - ***Project name\* (Desktop)**: This project contains your app's code. The **App.xaml** file and **App.xaml.cs** code-behind file define an `Application` class that represents your app instance. The **MainWindow.xaml** file and **MainWindow.xaml.cs** code-behind file define a `MainWindow` class that represents the main window displayed by your app. These classes derive from types in the **Microsoft.UI.Xaml** namespace provided by WinUI.

     ![image-20210507153431742](https://gitee.com/jeremywuiot/img-res-all/raw/master/src/iie_shop/image-20210507153431742.png)

   - ***Project name\* (Package)**: This is a [Windows Application Packaging Project](https://docs.microsoft.com/en-us/windows/msix/desktop/desktop-to-uwp-packaging-dot-net) that is configured to build the app into an [MSIX package](https://docs.microsoft.com/en-us/windows/msix/overview). This provides a modern deployment experience, the ability to integrate with Windows 10 features via package extensions, and much more. This project contains the [package manifest](https://docs.microsoft.com/en-us/uwp/schemas/appxpackage/uapmanifestschema/schema-root) for your app, and it is the startup project for your solution by default.

     ![image-20210507153542827](https://gitee.com/jeremywuiot/img-res-all/raw/master/src/iie_shop/image-20210507153542827.png)

7. In order to receive all of the fixes from the latest stable release of Project Reunion 0.5, you'll need to update your app's project file to explicitly set your .NET SDK to the latest version. For more information, see [.NET SDK references](https://docs.microsoft.com/en-us/windows/apps/project-reunion/#net-sdk-references).
8. To add a new item to your app project, right-click the ***Project name\* (Desktop)** project node in **Solution Explorer** and select **Add** -> **New Item**. In the **Add New Item** dialog box, select the **WinUI** tab, choose the item you want to add, and then click **Add**. For more details about the available items, see [Item templates for WinUI 3](https://docs.microsoft.com/en-us/windows/apps/winui/winui3/winui-project-templates-in-visual-studio#item-templates-for-winui-3).

![image-20210507153633273](https://gitee.com/jeremywuiot/img-res-all/raw/master/src/iie_shop/image-20210507153633273.png)

9. Build and run your solution to confirm that the app runs without errors.

   > :warning: **Note**
   >
   > You should add below code to `WinUI-Sample.csproj` file to fix the .NET SDK version's errors if there is.
   >
   > ```xml
   >   <ItemGroup>            
   >     <FrameworkReference Update="Microsoft.Windows.SDK.NET.Ref" RuntimeFrameworkVersion="10.0.18362.16" />
   >     <FrameworkReference Update="Microsoft.Windows.SDK.NET.Ref" TargetingPackVersion="10.0.18362.16" />
   >   </ItemGroup>
   > ```

## See the sample status

![image-20210507154500805](https://gitee.com/jeremywuiot/img-res-all/raw/master/src/iie_shop/image-20210507154500805.png)

## License

<p>
<a href="LICENSE">MIT License</a>
</p>
