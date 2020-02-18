(*
    FOR F# 4.6


    Anonymous records are simple aggregates of named values that don't need to be declared before use. 
    You can declare them as either structs or reference types. They're reference types by default.

    // Construct an anonymous record
    let value-name = [struct] {| Label1: Type1; Label2: Type2; ...|}

    // Use an anonymous record as a type parameter
    let value-name = Type-Name<[struct] {| Label1: Type1; Label2: Type2; ...|}>

    // Define a parameter with an anonymous record as input
    let function-name (arg-name: [struct] {| Label1: Type1; Label2: Type2; ...|}) ...
*)

module AnonymousRecords

//open System

//let getCircleStats radius =
//    let d = radius * 2.0
//    let a = Math.PI * (radius ** 2.0)
//    let c = 2.0 * Math.PI * radius
//    {| Diameter = d; Area = a; Circumference = c |}

//let r = 2.0
//let stats = getCircleStats r
//printfn "Circle with radius: %f has diameter %f, area %f, and circumference %f" r stats.Diameter stats.Area stats.Circumference
