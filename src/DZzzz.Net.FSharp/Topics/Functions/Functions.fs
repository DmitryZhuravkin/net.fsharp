namespace DZzzz.Net.FSharp.Topics.Functions

(*
    Non-recursive function definition.
    let [inline] function-name parameter-list [ : return-type ] = function-body
    Recursive function definition.
    let rec function-name parameter-list = recursive-function-body
*)

module FunctionsModule = 
    // Function with implicit parameter type
    let fImplParam (x: int) = x + 1

    // Function with implicit parameter types and return type
    let fImplParamAndType (x: float) (y: float) : float = x + y

    // Function without parameters
    let fWithoutArgs () = 17 + 3
    
    // Function with tuple as return value
    let fWithTupleReturn x = (x, x)
        
    // Partial application of arguments, refered to curring
    let smallPipeRadius = 2.0
    let bigPipeRadius = 3.0

    let cylinderVolume radius length : float =
        let pi = 3.14159
        length * pi * radius * radius

    let smallPipeVolume = cylinderVolume smallPipeRadius
    let bigPipeVolume = cylinderVolume bigPipeRadius

    // Recursive functions
    let rec factorial n = 
        if n <= 1 then 1 
        else n * factorial (n-1)

    let rec factorialMatch n =
        match n with
        | _ when n<=1   -> 1
        | _             -> n * factorialMatch (n-1)

    printfn "factorial: %d" (factorial 5)
    printfn "factorialMatch: %d" (factorialMatch 5)

    // Tail recursive functions
    let rec factorialTailAcc n acc = 
        match n with
        | _ when n<=1   -> 1
        | _             -> factorialTailAcc (n-1) acc * n

    let factorialTail n = factorialTailAcc n 1

    printfn "factorialTail: %d" (factorialTail 5)

    // Mutually recursive functions
    let rec even n = (n = 0u) || odd(n-1u)
    and     odd n = (n <> 0u) && even(n-1u)

    // Function as an input value of another function
    let apply1 (transform: int -> int) y = transform y

    // Functions as an input (with multiple arguments)
    let apply2 (f: int -> int -> int) x y = f x y

    // Lambda expression is an unnamed function
    let result3 = apply1 (fun x -> x + 1) 100
    let result4 = apply2 (fun x y -> x * y ) 10 20

    // Function Composition
    let function1 x = x + 1
    let function2 x = x * 2
    let h = function1 >> function2
    let result5 = h 100

    // Function Composition with different argument count (TODO)
    let function1Dif x = x + 1
    let function2Dif x y = x * y
    let hDif = function1Dif >> function2Dif
    let resultDifFunction = h 100
    
    // Function Pipelining
    let result = 100 |> function1 |> function2

    // Function Piplelining in different orders (TODO)
