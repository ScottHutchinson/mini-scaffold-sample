# MiniScaffold Example in an F# console application for dotnet core

This sample demonstrates how to use the MiniScaffold template to create an F# console application for dotnet core.

## Steps to re-create this project from scratch

1. Install the MiniScaffold template by running this CLI command:  
    &nbsp;&nbsp;&nbsp;&nbsp;```dotnet new -i "MiniScaffold::*"```  

2. Create a new project by running this CLI command:  
    &nbsp;&nbsp;&nbsp;&nbsp;```dotnet new mini-scaffold -lang f# -n mini-scaffold-sample --githubUsername ScottHutchinson```  

3. Add this line above the TargetFrameworks element in the .fsproj file:  
    &nbsp;&nbsp;&nbsp;&nbsp;```<OutputType>Exe</OutputType>```  

4. Rename the file Library.fs as Program.fs (not strictly necessary).

5. Change the namespace to a module instead.

6. Add this function:  
    &nbsp;&nbsp;&nbsp;&nbsp;```[<EntryPoint>]  
    let main argv =  
        printfn "Hello World from Mini Scaffold!"  
        0 // return an integer exit code```  
7. Change the target framework from multiple targets to a single target:  
    &nbsp;&nbsp;&nbsp;&nbsp;```<TargetFramework>netcoreapp2.0</TargetFramework>```  

8. Add this line to the top of the paket.dependencies file to specify a particular version of paket:  
    &nbsp;&nbsp;&nbsp;&nbsp;```version 5.148.0```  

## Related links  

https://fsprojects.github.io/Paket/bootstrapper.html#Magic-mode

