module Strings

(*Strings are immutable*)
let exampleString1 = "Humpty Dumpty"                // String, Type: string
let exampleString2 = "c:\\Program Files"            // String, Type: string
let exampleString3 = @"c:\Program Files"            // Verbatim string, Type: string
let exampleString4 = "xyZy3d2"B                     // Literal byte array, Type: byte[]
let exampleString5 = 'c'                            // Character, Type: char
let exampleString6 = "\"Hello\""
let exampleString7 = @"He""ll""o"                   // Using a verbatim string
let exampleString8 = """He"ll"o"""

let str1 = "abc\
    xyz" //abcxyz"

let str2 = "abc
    xyz" //abc\nxyz"


let stringWithTrippleQuates = """
<?xml version="1.0"?>
<catalog>
   <book id="book">
  <author>Author</author>
  <title>F#</title>
  <genre>Computer</genre>
  <price>44.95</price>
  <publish_date>2012-10-01</publish_date>
  <description>An in-depth look at creating applications in F#</description>
   </book>
</catalog>
"""

// Access to character
printfn "%c" str1.[1]
// Subsctings
printfn "%s" str1.[3..5]

// "abc" interpreted as a Unicode string.
let strUnicode : string = "abc"
// "abc" interpreted as an ASCII byte array.
let byteArray = "abc"B // val byteArray : byte [] = [|97uy; 98uy; 99uy|]

// concatination
let sAgain  = "Couldn't put Humpty" + " " + "together again" // by using the + operator or by using the ^ operator
let sAgain1  = "Couldn't put Humpty" ^ "together again" // by using the ^ operator, warning is displayed

(*String functions/properties*)
let s = "Couldn't put Humpty"
printfn "s Length: %d" s.Length