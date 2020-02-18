(*

Records represent simple aggregates of named values, optionally with members. They can either be structs or reference types. They are reference types by default.
    [ attributes ]
    type [accessibility-modifier] typename =
        { [ mutable ] label1 : type1;
          [ mutable ] label2 : type2;
          ... }
        [ member-list ]

Records are immutable by default;
*)

module Records

// Labels are separated by semicolons when defined on the same line.
type Point = { X: float; Y: float; Z: float; }

// You can define labels on their own line with a semicolon.
type Customer = 
    { First: string
      Last: string
      SSN: uint32
      AccountNumber: uint32; }

// A struct record.
[<Struct>]
type StructPoint = 
    { X: float
      Y: float
      Z: float }

// You can set values in expressions known as record expressions. 
// The compiler infers the type from the labels used (if the labels are sufficiently distinct from those of other record types). 
// Braces ({ }) enclose the record expression.
let mypoint1 = { X = 1.0; Y = 1.0; Z = -1.0; }
let mypoint2 = { Point.X = 1.0; Point.Y = 1.0; Point.Z = -1.0; }

// To copy an existing record, and possibly change some of the field values.
// This form of the record expression is called the copy and update record expression.
let mypoint3 = { mypoint2 with Y = 20.0; Z = 2.0; }


// Pattern Matching with Records
type Point3D = { X: float; Y: float; Z: float }
let evaluatePoint (point: Point3D) =
    match point with
    | { X = 0.0; Y = 0.0; Z = 0.0 } -> printfn "Point is at the origin."
    | { X = xVal; Y = 0.0; Z = 0.0 } -> printfn "Point is on the x-axis. Value is %f." xVal
    | { X = 0.0; Y = yVal; Z = 0.0 } -> printfn "Point is on the y-axis. Value is %f." yVal
    | { X = 0.0; Y = 0.0; Z = zVal } -> printfn "Point is on the z-axis. Value is %f." zVal
    | { X = xVal; Y = yVal; Z = zVal } -> printfn "Point is at (%f, %f, %f)." xVal yVal zVal

evaluatePoint { X = 0.0; Y = 0.0; Z = 0.0 }
evaluatePoint { X = 100.0; Y = 0.0; Z = 0.0 }
evaluatePoint { X = 10.0; Y = 0.0; Z = -1.0 }


// Record fields differ from classes in that they are automatically exposed as properties, and they are used in the creation and copying of records. 
// Record construction also differs from class construction. In a record type, you cannot define a constructor. 
// Instead, the construction syntax described in this topic applies. Classes have no direct relationship between constructor parameters, fields, and properties.
// Like union and structure types, records have structural equality semantics. Classes have reference equality semantics.