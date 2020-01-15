module FunctionsValues

(*Anonymous function value (fun n -> n * n * n)*)
let mapResult = List.map (fun n -> (n ** 3.0)) [1.0; 5.0; 6.0; 2.0; 8.0]
printfn "mapResult: %A" mapResult

(*Tail recursive functions*)

