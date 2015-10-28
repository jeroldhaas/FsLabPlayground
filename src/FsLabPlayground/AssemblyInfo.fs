namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("FsLabPlayground")>]
[<assembly: AssemblyProductAttribute("FsLabPlayground")>]
[<assembly: AssemblyDescriptionAttribute("FsLab Playground")>]
[<assembly: AssemblyVersionAttribute("1.0")>]
[<assembly: AssemblyFileVersionAttribute("1.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0"
