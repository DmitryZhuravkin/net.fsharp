// Learn more about F# at http://fsharp.org

open System
open Options

[<EntryPoint>]
let main argv =
    let list1 = [ 1; 5; 100; 450; 788 ]

    // Pattern matching by using the cons pattern and a list
    // pattern that tests for an empty list.
    let rec printList listx =
        match listx with
        | head :: tail -> 
            printf "%d " head 
            printList tail
        | [] -> printfn ""

    printList list1

    Console.ReadKey true
    0 // return an integer exit code
