(*
    A sequence is a logical series of elements all of one type. Sequences are particularly useful when you have a large, 
    ordered collection of data but do not necessarily expect to use all of the elements. 
    Individual sequence elements are computed only as required, so a sequence can provide better performance than 
    a list in situations in which not all the elements are used. 
    Sequences are represented by the seq<'T> type, which is an alias for IEnumerable<T>
     
*)

module Sequences

// Sequence Expressions
let seq1 = seq { 1 .. 5 }
let seq2 = seq { 0 .. 10 .. 100 } // 10 in the middle - an increment between first and last element
let seq3 = seq { for i in 1 .. 10 -> i * i }
let seq4 = seq { for i in 1 .. 10 do yield i * i }

// yield! is that it flattens an inner sequence and then includes that in the containing sequence.
let seq5 = // val seq5 : seq<int> !!!!
    seq {
        for _ in 1..10 do
            yield! seq { 1.. 5}
    }

Seq.iter (fun c -> printfn "%A" c ) seq5

// yield
let seq6 = // val seq6 : seq<int> !!!!
    seq {
        for x in 1..10 do
            yield x // inset a single number
            yield! seq { for i in 1..x -> i}
    }
Seq.iter (fun c -> printfn "%A" c ) seq6

// Sequence usage
let seqEmpty = Seq.empty
let seqOne = Seq.singleton 10
let seqFirst5MultiplesOf10 = Seq.init 5 (fun n -> n * 10)

// Sequence casting
let seqFromArray1 = [| 1 .. 10 |] :> seq<int>
let seqFromArray2 = [| 1 .. 10 |] |> Seq.ofArray

// Infinite sequence - infinite sequences are possible because of lazy evaluation; elements are created as needed by calling the function that you specify.

// Sequence usage
// TODO