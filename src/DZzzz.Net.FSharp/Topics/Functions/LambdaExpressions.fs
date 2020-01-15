namespace DZzzz.Net.FSharp.Topics.Functions

(*
    Fun parameter-list -> expression
*)

module LambdaExpressionsModule = 
    let apply1 (transform: int -> int) y = transform y // transfom is a function
    let apply2 (f: int -> int -> int) x y = f x y

    // Lambda expression is an unnamed function
    let result3 = apply1 (fun x -> x + 1) 100
    let result4 = apply2 (fun x y -> x * y ) 10 20

    // Lambda with List.map
    let list = List.map (fun i -> i + 1) [1; 2; 3]
    printfn "%A" list
