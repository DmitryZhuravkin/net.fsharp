(*

The option type in F# is used when an actual value might not exist for a named value or variable. 
An option has an underlying type and can hold a value of that type, or it might not have a value.

*)

module Options

let noneOption = None

let someOption = Some "some options value" // val someOption : string option = Some "some options value"
let someOptionWithTupple = Some("Some1", "Some2", "Some3", "Some4") //val someOptionWithTupple : (string * string * string * string) option

// Options are commonly used when a search does not return a matching result, as shown in the following code.
let rec tryFindMatch pred list =
    match list with
    | head :: tail -> if pred(head)
                        then Some(head)
                        else tryFindMatch pred tail
    | [] -> None

//Options can also be useful when a value might not exist, for example if it is possible that an exception will be thrown when you try to construct a value.
let result1 = tryFindMatch (fun elem -> elem = 100) [ 200; 100; 50; 25 ]
let result2 = tryFindMatch (fun elem -> elem = 26) [ 200; 100; 50; 25 ]

printfn "%A" (Option.toArray result1)
printfn "%A" (Option.toArray result2)