// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

open System

[<EntryPoint>]
let main argv = 
    printfn "Hello world"

    let name = "Thomas"
    let specificGreeting = "Hello " + name + "!"

    printfn "%s" specificGreeting

    Console.ReadLine() |> ignore
    0
