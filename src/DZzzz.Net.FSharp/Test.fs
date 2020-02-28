module Test

//val x : int = 10
//val result : Lazy<int> = 30
//val it : unit = ()
let x = 10
let result = lazy(
        printfn "lazy call"
        x + 20
    )

printfn "%d" (result.Force())
printfn "%d" (result.Force())