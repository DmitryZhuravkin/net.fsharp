(*

    F# function values, methods, properties, and aggregate types such as classes, records, and discriminated unions can be generic. 
    Generic constructs contain at least one type parameter, which is usually supplied by the user of the generic construct. 
    Generic functions and types enable you to write code that works with a variety of types without repeating the code for each type.

    // Explicitly generic function.
    let function-name<type-parameters> parameter-list =
    function-body

    // Explicitly generic method.
    [ static ] member object-identifer.method-name<type-parameters> parameter-list [ return-type ] =
    method-body

    // Explicitly generic class, record, interface, structure,
    // or discriminated union.
    type type-name<type-parameters> type-definition

*)

module Generics

// Implicitly Generic Constructs
let makeList a b = [a; b] // val makeList : a:'a -> b:'a -> 'a list

let function1 (x: 'a) (y: 'a) =
    printfn "%A %A" x y


let function2<'T when 'T : null> x y =
    printfn "%A, %A" x y