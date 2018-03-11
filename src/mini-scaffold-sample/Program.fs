module MiniScaffoldSample

module Say =
    let hello name =
        sprintf "Hello %s" name

[<EntryPoint>]
let main _ =
    printfn "%s from Mini Scaffold!" <| Say.hello "World"
    0 // return an integer exit code
