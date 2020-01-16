namespace DZzzz.Net.FSharp.Topics.Values

open System

(*
    
*)

module ValuesModule = 
    let a = 1 // infered 
    let b = 100u // unsigned int
    let f x = x + 1 // A function value binding.

    // Mutable values
    let mutable x = 1 // values marked mutable may be automatically promoted to 'a ref if captured by a closure
    x <- x + 1

    // Nullable values (null keyword is a valid keyword in the F# language)
    //  
    let ParseDateTime (str: string) =
        let (success, res) = DateTime.TryParse(str, null, System.Globalization.DateTimeStyles.AssumeUniversal)
    
        if success then
            Some(res)
        else
            None
    
    
    let value = null

    match (box value) with // box is a function 
        | null -> printfn "The value is null."
        | _ -> printfn "The value is not null."

