//An ordered, immutable series of elements of the same type. Implemented as a linked list.

module Lists

// Simple definition
let emptyList = []
let emptyList2 : float list = List.Empty
let emptyList3 = List.empty

let listValues = [1; 2; 4;]
let listValues2 = [ // multiline
    1 
    2
    4 ]
let listValues3: float list = [1.0; 2.0; 4.0;]

let rangeList = [1 .. 99]

let consElementToList = 15 :: listValues // add element to head of list
let concatinatedList = listValues @ [5] // concat two lists
let tempList = 45 :: listValues @ rangeList

// Init list from sequence expression
let listOfSquares = [ for i in 1 .. 10 -> i*i ]

// List pattern matching
let primes = 15 :: [1 .. 17]

let printFirst primes =
    match primes with
    | h :: _ -> printfn "The first prime in the list is %d" h
    | [] -> printfn "No primes found in the list"

printFirst primes

// List properties
let list1 = [15 .. 32]

printfn "list1.IsEmpty is %b" (list1.IsEmpty)
printfn "list1.Length is %d" (list1.Length)
printfn "list1.Head is %d" (list1.Head)
printfn "list1.Tail.Head is %d" (list1.Tail.Head)
printfn "list1.Tail.Tail.Head is %d" (list1.Tail.Tail.Head)
printfn "list1.Item(1) is %d" (list1.Item(1))

// List recursion
let sum list =
   let rec loop list acc =
       match list with
       | head :: tail -> loop tail (acc + head)
       | [] -> acc
   loop list 0

printfn "list1 sum: %d" (sum list1)

// List functions 
// TODO
