﻿namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("FCor")>]
[<assembly: AssemblyProductAttribute("FCor")>]
[<assembly: AssemblyDescriptionAttribute("F# numerical library")>]
[<assembly: AssemblyVersionAttribute("1.0.2")>]
[<assembly: AssemblyFileVersionAttribute("1.0.2")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0.2"
