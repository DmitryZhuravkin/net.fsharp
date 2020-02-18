(*

In F#, a slice is a subset of any data type that has a GetSlice method in its definition or in an in-scope type extension. 
It is most commonly used with F# arrays and lists. This article explains how to take slices from existing F# types and how to define your own slices.
Slices are similar to indexers, but instead of yielding a single value from the underlying data structure, they yield multiple ones.
F# currently has intrinsic support for slicing strings, lists, arrays, and 2D arrays.

*)
module Slices

// Generate a list of 100 integers
let fullList = [ 1 .. 100 ]

// Create a slice from indices 1-5 (inclusive)
let smallSlice = fullList.[1..5] // val smallSlice : int list = [2; 3; 4; 5; 6]
printfn "Small slice: %A" smallSlice

// Create a slice from the beginning to index 5 (inclusive)
let unboundedBeginning = fullList.[..5]
printfn "Unbounded beginning slice: %A" unboundedBeginning

// Create a slice from an index to the end of the list
let unboundedEnd = fullList.[94..]
printfn "Unbounded end slice: %A" unboundedEnd


// Generate an array of 100 integers
let fullArray = [| 1 .. 100 |]

// Create a slice from indices 1-5 (inclusive)
let smallSliceArray = fullArray.[1..5]
printfn "Small slice: %A" smallSliceArray

// Create a slice from the beginning to index 5 (inclusive)
let unboundedBeginningArray = fullArray.[..5]
printfn "Unbounded beginning slice: %A" unboundedBeginningArray

// Create a slice from an index to the end of the list
let unboundedEndArray = fullArray.[94..]
printfn "Unbounded end slice: %A" unboundedEndArray


// Generate a 3x3 2D matrix
let A = array2D [[1;2;3];[4;5;6];[7;8;9]]
printfn "Full matrix:\n %A" A

// Take the first row
let row0 = A.[0,*]
printfn "Row 0: %A" row0

// Take the first column
let col0 = A.[*,0]
printfn "Column 0: %A" col0

// Take all rows but only two columns
let subA = A.[*,0..1]
printfn "%A" subA

// Take two rows and all columns
let subA' = A.[0..1,*]
printfn "%A" subA'

// Slice a 2x2 matrix out of the full 3x3 matrix
let twoByTwo = A.[0..1,0..1]
printfn "%A" twoByTwo


// All intrinsic slices in F# are end-inclusive; that is, the upper bound is included in the slice. 
// For a given slice with starting index x and ending index y, the resulting slice will include the yth value.

// Define a new list
let xs = [1 .. 10]

printfn "%A" xs.[2..5] // Includes the 5th index