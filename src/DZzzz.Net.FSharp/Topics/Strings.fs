module Strings

(*Strings are immutable*)
let exampleString1 = "Humpty Dumpty"                // String, Type: string
let exampleString2 = "c:\\Program Files"            // String, Type: string
let exampleString3 = @"c:\Program Files"            // Verbatim string, Type: string
let exampleString4 = "xyZy3d2"B                     // Literal byte array, Type: byte[]
let exampleString5 = 'c'                            // Character, Type: char
let exampleString6 = "\"Hello\""
let exampleString7 = @"He""ll""o"
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

printfn "%s" exampleString6
printfn "%s" exampleString7
printfn "%s" exampleString8

(*String functions/properties*)
let s = "Couldn't put Humpty"

printfn "s Length: %d" s.Length

(**)
let sAgain  = "Couldn't put Humpty" + " " + "together again"