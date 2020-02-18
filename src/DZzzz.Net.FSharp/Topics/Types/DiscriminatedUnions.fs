(*

    Discriminated unions provide support for values that can be one of a number of named cases, possibly each with different values and types. 
    Discriminated unions are useful for heterogeneous data; data that can have special cases, including valid and error cases; 
    data that varies in type from one instance to another; and as an alternative for small object hierarchies. 
    In addition, recursive discriminated unions are used to represent tree data structures.

    [ attributes ]
    type [accessibility-modifier] type-name =
        | case-identifier1 [of [ fieldname1 : ] type1 [ * [ fieldname2 : ] type2 ...]
        | case-identifier2 [of [fieldname3 : ]type3 [ * [ fieldname4 : ]type4 ...]

        [ member-list ]

*)

module DiscriminatedUnions

type Shape =
    | Rectangle of width : float * length : float
    | Circle of radius : float
    | Prism of width : float * float * height : float

let rect = Rectangle(length = 1.3, width = 10.0)
let circ = Circle (1.0)
let prism = Prism(5., 2.0, height = 3.0)

let getShapeWidth shape =
    match shape with
    | Rectangle(width = w) -> w
    | Circle(radius = r) -> 2. * r
    | Prism(width = w) -> w

printfn "%f" (getShapeWidth rect)
printfn "%f" (getShapeWidth circ)
printfn "%f" (getShapeWidth prism)

// Unwrapping Discriminated Unions
// In F# Discriminated Unions are often used in domain-modeling for wrapping a single type. 
// It's easy to extract the underlying value via pattern matching as well.

type ShaderProgram = | ShaderProgram of id:int

let someFunctionUsingShaderProgram1 shaderProgram =
    let (ShaderProgram id) = shaderProgram
    printfn "%d" id
    ()

let someFunctionUsingShaderProgram2 (ShaderProgram id) =
    printfn "%d" id
    ()

let shaderProgram = ShaderProgram(50)

// Struct Discriminated Unions
// 1. They are copied as value types and have value type semantics.
// 2. You cannot use a recursive type definition with a multicase struct Discriminated Union.
// 3. You must provide unique case names for a multicase struct Discriminated Union.

[<Struct>]
type SingleCase = Case of string

// Using Discriminated Unions Instead of Object Hierarchies
// TODO