(*

    Active patterns enable you to define named partitions that subdivide input data, 
    so that you can use these names in a pattern matching expression just as you would for a discriminated union. 
    You can use active patterns to decompose data in a customized manner for each partition.

    // Active pattern of one choice.
    let (|identifier|) [arguments] valueToMatch= expression

    // Active Pattern with multiple choices.
    // Uses a FSharp.Core.Choice<_,...,_> based on the number of case names. In F#, the limitation n <= 7 applies.
    let (|identifer1|identifier2|...|) valueToMatch = expression

    // Partial active pattern definition.
    // Uses a FSharp.Core.option<_> to represent if the type is satisfied at the call site.
    let (|identifier|_|) [arguments ] valueToMatch = expression

    The identifiers are names for partitions of the input data that is represented by arguments, or, in other words, 
    names for subsets of the set of all values of the arguments. 
    There can be up to seven partitions in an active pattern definition. 
    The expression describes the form into which to decompose the data. You can use an active pattern definition to 
    define the rules for determining which of the named partitions the values given as arguments belong to.

*)

module ActivePatterns

let (|Even|Odd|) input = if input % 2 = 0 then Even else Odd // val ( |Even|Odd| ) : input:int -> Choice<unit,unit>