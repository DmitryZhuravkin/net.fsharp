(*

    Enumerations, also known as enums, are integral types where labels are assigned to a subset of the values. 
    You can use them in place of literals to make code more readable and maintainable.

    type enum-name =
    | value1 = integer-literal1
    | value2 = integer-literal2

*)

module Enumerations

// Declaration of an enumeration.
type Color =
   | Red = 0
   | Green = 1
   | Blue = 2
// Use of an enumeration.
let col1 : Color = Color.Red
let col2 = Color.Green

// Conversion to an integral type.
let n = int col2