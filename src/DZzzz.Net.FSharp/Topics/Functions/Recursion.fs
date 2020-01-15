namespace DZzzz.Net.FSharp.Topics.Functions

(*
    Recursive function:
    let rec function-nameparameter-list =
    function-body

    Mutually recursive functions:
    let rec function1-nameparameter-list =
    function1-body
    and function2-nameparameter-list =
    function2-body
*)

module RecursionModule = 

    // Recursive functions (not a good way, )
    let rec factorial n = 
        if n <= 1 then 1 
        else n * factorial (n-1)

    let rec factorialMatch n =
        match n with
        | _ when n<=1   -> 1
        | _             -> n * factorialMatch (n-1)

    printfn "factorial: %d" (factorial 5)
    printfn "factorialMatch: %d" (factorialMatch 5)

    // Tail recursive functions (use it in order to allow compilator to do recursion optimization)
    let rec factorialTailAcc n acc = 
        match n with
        | _ when n<=1   -> 1
        | _             -> factorialTailAcc (n-1) acc * n

    let factorialTail n = factorialTailAcc n 1

    printfn "factorialTail: %d" (factorialTail 5)

    // Mutually recursive functions
    let rec even n = (n = 0u) || odd(n-1u)
    and     odd n = (n <> 0u) && even(n-1u)

