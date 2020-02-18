(*
    fixed-size, zero-based, mutable collections of consecutive data elements that are all of the same type.
*)

module Arrays

// Array definition
let array1 = [| 1; 2; 3 |] // val array1 : int []
// Multiline definition
let array2 =
    [|
        1
        2
        3
     |]

// Init using sequence expression
let array3 = [| for i in 1 .. 10 -> i * i |]

// Init array 
let array4 = [| [15..99] |] // this is an array with one element, element type - list

// 
let arrayOfTenZeroes : int array = Array.zeroCreate 10 // val arrayOfTenZeroes : int array = [|0; 0; 0; 0; 0; 0; 0; 0; 0; 0|]

// The same like previous example
let arrayOfTenZeroes2 : int [] = Array.zeroCreate 10

// Acessing elements
printfn "%d" array1.[0] // Array indexes start at 0.
printfn "%A" array1.[0..2] // Accesses elements from 0 to 2.
printfn "%A" array1.[..2] // Accesses elements from the beginning of the array to 2.
printfn "%A" array1.[2..] // Accesses elements from 2 to the end of the array.

// Array finctions 
// TODO