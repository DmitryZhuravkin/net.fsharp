(*
    (element, ... , element)
    struct(element, ... ,element)
*)

module Tuples

let a = 1
let b = 50

let tuple = (1, 2)
let tupleTriple = ("one", "two", "three")
let tupleMixed = ("one", 1, 2.0)

let tupleExpressions = (a + 1, b + 1)

// Struct Tuple of floats
let structTuple = struct (1.025f, 1.5f) // val structTuple : struct (float32 * float32)

// Pattern matching with tuple #1
let print tuple1 =
   match tuple1 with
    | (a, b) -> printfn "Pair %A %A" a b

// Pattern matching with tuple #2
let print2 tuple1 =
   match tuple1 with
    | a, b -> printfn "Pair %A %A" a b

// Deconstruct tuple
let (a1, b1) = (1, 2)
let struct (c, d) = struct (1, 2)
let (a2, _) = (1, 2) // deconstruction only for one element


// Functions to work with tuples
let cF = fst (1, 2) // cF = 1
let dF = snd (1, 2) // dF = 2 

// Tuple usage to avoid functions curring
let sumNoCurry (a, b) = a + b

// Converting between Reference Tuples and Struct Tuples (only one way to do this)
let (aT, bT) = (1, 2)                   // Pattern match on the result.
let struct (cT, dT) = struct (aT, bT)   // Construct a new tuple from the parts you pattern matched on.
