D:

SET DOTNET_ROOT=D:\ICS4U\dotnetSDK

SET DOTNET_MULTILEVEL_LOOKUP=0

SET PATH=D:\ICS4U\dotnetSDK;%PATH%

@REM Temporary Solution--- Use CMD for the integrated terminal and run the above commands on it first, and it should work
@REM find a way to automatically do this each new terminal instance for ease of access
dotnet run

@REM Just type in the terminal -- dotnetsetup.bat -- and it should run this fine
@REM Open MGCB editor with... dotnet mgcb-editor