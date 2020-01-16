(*
    Type 	                                                            Type syntax 	                                            Examples
    primitive type 	                                                    type-name 	                                                int, float, string
    aggregate type 
    (class, structure, union, record, enum, and so on) 	                type-name 	                                                System.DateTime, Color
    type abbreviation 	                                                type-abbreviation-name 	                                    bigint
    fully qualified type 	                                            namespaces.type-name or
                                                                        modules.type-name or
                                                                        namespaces.modules.type-name 	                            System.IO.StreamWriter
    array 	                                                            type-name[] or
                                                                        type-name array 	                                        int[], array<int>, int array
    two-dimensional array 	                                            type-name[,] 	                                            int[,], float[,]
    three-dimensional array 	                                        type-name[,,] 	                                            float[,,]
    tuple 	                                                            type-name1 * type-name2 ... 	                            For example, (1,'b',3) has type int * char * int
    generic type 	                                                    type-parameter generic-type-name or
                                                                        generic-type-name<type-parameter-list> 	                    'a list, list<'a>, Dictionary<'key, 'value>
    constructed type 
    (a generic type that has a specific type argument supplied) 	    type-argument generic-type-name or                          int option, string list, int ref, option<int>
                                                                        generic-type-name<type-argument-list> 	                    list<string>, ref<int>, Dictionary<int, string>
    function type that has a single parameter 	                        parameter-type1 -> return-type 	                            A function that takes an int and returns 
                                                                                                                                    a string has type int -> string
    function type that has multiple parameters 	                        parameter-type1 -> parameter-type2 -> ... -> return-type 	A function that takes an int and a float and returns 
                                                                                                                                    a string has type int -> float -> string
    higher order function as a parameter 	                            (function-type) 	                                        List.map has type ('a -> 'b) -> 'a list -> 'b list
    delegate 	                                                        delegate of function-type 	                                delegate of unit -> int
    flexible type 	                                                    #type-name 	                                                #System.Windows.Forms.Control
                                                                                                                                    #seq<int>
*)

module TypesCommon
// Unit Type (the absence of a specific value)
// Every F# expression must evaluate to a value. For expressions that do not generate a value that is of interest, the value of type unit is used
()

// 
let function1 x y = x + y
function1 10 20 // a compiler warning (module expects unit type as a result)
function1 10 20 |> ignore // do this if you want not to use the result


