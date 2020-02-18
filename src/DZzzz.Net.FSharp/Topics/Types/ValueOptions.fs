(*

The Value Option type in F# is used when the following two circumstances hold:
1. A scenario is appropriate for an F# Option.
2. Using a struct provides a performance benefit in your scenario.

Not all performance-sensitive scenarios are "solved" by using structs. 
You must consider the additional cost of copying when using them instead of reference types. 
However, large F# programs commonly instantiate many optional types that flow through hot paths, and in such cases, 
structs can often yield better overall performance over the lifetime of a program.

*)

module ValueOptions

let tryParseDateTime (s: string) = // val tryParseDateTime : s:string -> System.DateTime voption
    match System.DateTime.TryParse(s) with
    | (true, dt) -> ValueSome dt
    | (false, _) -> ValueNone


let possibleDateString1 = "1990-12-25"
let possibleDateString2 = "This is not a date"

let result1 = tryParseDateTime possibleDateString1
let result2 = tryParseDateTime possibleDateString2

match (result1, result2) with
| ValueSome d1, ValueSome d2 -> printfn "Both are dates!"
| ValueSome d1, ValueNone -> printfn "Only the first is a date!"
| ValueNone, ValueSome d2 -> printfn "Only the second is a date!"
| ValueNone, ValueNone -> printfn "None of them are dates!"