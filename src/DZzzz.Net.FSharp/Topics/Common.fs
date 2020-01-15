module Common
#light

(* This option allows you to write code that looks and feels simpler by omitting recurring F#
tokens such as in, done, ; (semicolon), ;; (double semicolon), begin, and end. The option instructs
the F# compiler and F# Interactive to use the indentation of F# code to determine where constructs
start and finish.*)


(*Data structures are generally divided between mutable and immutable
Immutable data structures are sometimes called persistent or simply functional. 
Here are some of the immutable data structures commonly used with F#:
• Tuple values and option values: These are immutable and are basic workhorses of F# programming.
• Immutable linked lists of type 'a list: 
    These are cheap to access from the left end. They are inefficient for random access lookup because the list must be traversed from the left for each lookup, 
    that is, random access lookup is O(n) where n is the number of elements in the collection. The full name of this type is Microsoft.FSharp.Collections.List<'a>.
• Immutable sets based on balanced trees: An implementation is provided via the type Set<'a> in the F# library namespace Microsoft.FSharp.Collections. 
    These are cheap to add, access, and union, with O(log(n)) access times, where n is the number of elements in the collection. 
    Because the type is immutable, internal nodes can be shared between different sets.
• Immutable maps based on balanced trees: These are similar to immutable sets but associate keys with
    values (that is, they are immutable dictionaries). One implementation of these is provided via the F#
    library type Map<'key,'value> in Microsoft.FSharp.Collections. As with sets, these have O(log(n)) access times.*)


(* Some Important Types, Type Constructors, and Their Corresponding Values
int                     int 32-bit integers.                For example: -3, 0, 127.
type option             int option, option<int>             A value of the given type or the special value None. For example: Some 3, Some "3", None.
type list               int list, list<int>                 An immutable linked list of values of the given type. All elements of the list must 
                                                            have the same type. For example: [], [3;2;1].
type1 -> type2          int -> string                       A function type, representing a value that will accept values of the first type and
                                                            compute results of the second type. For example: (fun x -> x+1).
type1 * ... * typeN     int * string                        A tuple type, such as a pair, triple, or larger combination of types. For example: (1,"3"), (3,2,1).
type []                 int[]                               An array type, indicating a flat, fixed-size mutable collection of values of type type.
unit                    unit                                A type containing a single value (), akin to void in many imperative languages.
'a, 'b                  'a, 'b, 'Key, 'Value                A variable type, used in generic code.*)

