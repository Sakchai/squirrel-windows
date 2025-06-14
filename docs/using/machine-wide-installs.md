| [docs](..)  / [using](.) / machine-wide-installs.md
|:---|


# Machine-wide Installs

Squirrel's Releasify command generates an MSI file suitable for installation via Group Policy. This MSI isn't a general-purpose installer, this means that once you run the MSI, users from now on will get the app installed, on next Login.

So, most normal users should continue to run the Setup.exe's generated by Releasify, but if you want to have an IT Admin Friendly version, you can hand off the MSI

## Common pitfalls

### Missing data in `.nuspec`

Most users of Squirrel won't have to do anything new to enable this behavior, though certain NuGet package IDs / names might cause problems with MSI. 

**Source:** See [issue #466](https://github.com/Squirrel/Squirrel.Windows/issues/466) for more details.

### Nothing happens on login

In cases where the end user has previously installed your application, the installer that runs on login will not re-install your application on every login. This can easily be the case if you as a developer is testing out both the EXE and the MSI.

Squirrel leaves behind an almost-empty `%LocalAppData%\MyApp` folder after an uninstall. Deleting this folder (the entire folder, not just the contents) will allow the installer that runs on login to install successfully.

**Source:**: See [issue #555](https://github.com/Squirrel/Squirrel.Windows/issues/555#issuecomment-253265130) for details.

## Disabling MSI Generation
Generating MSIs can be disabled via the --no-msi flag as shown below:

~~~powershell
PM> Squirrel --releasify MyApp.1.0.0.nupkg --no-msi
~~~ 

---
| Return: [Table of Contents](../readme.md) |
|----|
