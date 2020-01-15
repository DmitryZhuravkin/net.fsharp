namespace DZzzz.Net.FSharp.Topics.Functions

(*Non-recursive function definition.
let [inline] function-name parameter-list [ : return-type ] = function-body
Recursive function definition.
let rec function-name parameter-list = recursive-function-body*)

module FunctionsModule = 
    // function with implicit parameter type
    let fImplParam (x : int) = x + 1

    // function with implicit parameter types and return type
    let fImplParamAndType (x : float) (y : float) : float = x + y

    // function without parameters
    let fWithoutArgs () = 17 + 3
    
    // function with tuple as return value
    let fWithTupleReturn x = (x, x)

    



    (*Recursive functions*)
    let rec factorial n = 
        if n <= 1 then 1 
        else n * factorial (n-1)

    let rec factorialMatch n =
        match n with
        | _ when n<=1   -> 1
        | _             -> n * factorialMatch (n-1)

    printfn "factorial: %d" (factorial 5)
    printfn "factorialMatch: %d" (factorialMatch 5)

    (*Tail recursive functions*)
    let rec factorialTailAcc n acc = 
        match n with
        | _ when n<=1   -> 1
        | _             -> factorialTailAcc (n-1) acc * n

    let factorialTail n = factorialTailAcc n 1

    printfn "factorialTail: %d" (factorialTail 5)

    (*Mutually recursive functions*)
    let rec even n = (n = 0u) || odd(n-1u)
    and     odd n = (n <> 0u) && even(n-1u)

    (*Aggregate operations for functions*)
