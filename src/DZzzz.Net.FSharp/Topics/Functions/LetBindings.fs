namespace DZzzz.Net.FSharp.Topics.Functions

(*
    Binding a value:
    let identifier-or-pattern [: type] =expressionbody-expression
    Binding a function value:
    let identifier parameter-list [: return-type ] =expressionbody-expression
*)

module LetBindingsModule = 
    // Simple definitions
    let i, j, k = (1, 2, 3) // tuple decomposition

    // With body expression
    let result =
        let i, j, k = (1, 2, 3) // these variables in the scope of 'result' binding
        i + 2*j + 3*k

    // Functions binding
    let function2 (a, b) = a + b // input parametrer is tuple, return type - int

    // Single-line let
    // let nestedName = [some expression] in [some other expression involving nestedName]
    let powerOfFour n =
        let nSquared = n * n in nSquared * nSquared // mean, nSquared = n * n, and then return from function nSquared * nSquared

    //Outscoping a value
    let powerOfFourPlusTwo n =
        let n = n * n // n is a new variable in this scope, previous n value isn`t changed
        let n = n * n
        let n = n + 2
        n

    // let bindings in classes (TODO:)