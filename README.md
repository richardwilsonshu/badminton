# Badminton

A WindowsForms app to manage badminton sessions and generate fair games based on a matchmaking system using elo.

## Deployment:

https://www.hanselman.com/blog/how-to-make-a-winforms-app-with-net-5-entirely-from-the-command-line-and-publish-as-one-selfcontained-file

### Self-Contained EXE

#### Option 1 (Visual Studio)

Just right-click "Badminton" project -> Publish -> click "Publish" on "Standalone.pubxml"

Output: \bin\Release\net6.0-windows\publish\win-x64

#### Option 2 (Command Line)

```
dotnet publish -r win-x64 -c Release /p:PublishSingleFile=true /p:IncludeNativeLibrariesForSelfExtract=true --self-contained true
```

Output: \bin\Release\net6.0-windows\win-x64\publish

### Framework Dependent EXE (.Net already installed on target machine)

#### Option 1 (Visual Studio)

Just right-click "Badminton" project -> Publish -> click "Publish" on ".Net Already Installed.pubxml"

Output: \bin\Release\net6.0-windows\publish\win-x64

#### Option 2 (Command Line)

```
dotnet publish -r win-x64 -c Release /p:PublishSingleFile=true /p:IncludeNativeLibrariesForSelfExtract=true --self-contained false
```

Output: \bin\Release\net6.0-windows\win-x64\publish

## Data Storage

App data is stored in the same directory as the EXE, in "badminton.json".

Saving ocurrs:
- Match finished
- Session Started
- Session Ended
- Program Closed

In the event that the PC crashes or is lost etc, it's recommended to regularly backup the badminton.json file, 
or perhaps use DropBox or OneDrive.
Note - If using the standalone deployment where the EXE is ~155MB, it may be better to save to "Saves\badminton.json" and 
selectively sync only the "Saves" folder.