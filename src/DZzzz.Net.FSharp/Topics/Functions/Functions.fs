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

    // Function as an input value of another function
    let apply1 (transform: int -> int) y = transform y

    // Functions as an input (with multiple arguments)
    let apply2 (f: int -> int -> int) x y = f x y

    // Lambda expression is an unnamed function
    let resultApply1 = apply1 (fun x -> x + 1) 100
    let resultApply2 = apply2 (fun x y -> x * y ) 10 20

    // Function Composition
    let function1 x = x + 1
    let function2 x = x * 2
    let h = function1 >> function2
    let result5 = h 100

    // Function Composition with different argument count (???)
    let function1Dif x = x + 1
    let function2Dif x y = x * y
    let hDif = function1Dif >> function2Dif
    let resultDifFunction = h 100

    // Function Pipelining
    let result = 100 |> function1 |> function2

    // Function composition in different order
    let addOne x = x + 1
    let timesTwo x = 2 * x
    
    let Compose2 = addOne >> timesTwo // Composition operator: ( >> ) : ('T1 -> 'T2) -> ('T2 -> 'T3) -> 'T1 -> 'T3
    let Compose1 = addOne << timesTwo // Backward composition operator: ( << ) : ('T2 -> 'T3) -> ('T1 -> 'T2) -> 'T1 -> 'T3
    
    let result1 = Compose1 2 // Result is 5
    let result2 = Compose2 2 // Result is 6

    // Pipelining in different order
    let Pipeline2 x = addOne x |> timesTwo // Pipeline operator: ( |> ) : 'T1 -> ('T1 -> 'U) -> 'U
    let Pipeline1 x = addOne <| timesTwo x // Backward pipeline operator: ( <| ) : ('T -> 'U) -> 'T -> 'U
    
    let result3 = Pipeline1 2 // Result is 5
    let result4 = Pipeline2 2 // Result is 6
