module Let
(*Let is a scope*)

(*Single line let definition
let nestedName = [some expression] in [some other expression involving nestedName]*)

let powerOfFour n =
    let nSquared = n * n in nSquared * nSquared // mean, nSquared = n * n, and then return from function nSquared * nSquared

let f () = 
    let x = 1 in   
        let y = 2 in x + y     

printfn "Power Of Foor: %d" (f ())
printfn "Power Of Foor: %d" (powerOfFour 3)

(*outscoped variables*)
//Outscoping a value doesn’t change the original value; 

let powerOfFourPlusTwo n =
    let n = n * n // n is a new variable in this scope, previous n value isn`t changed
    let n = n * n
    let n = n + 2
    n

printfn "Power Of Foor Plus 2: %d" (powerOfFourPlusTwo 5)
