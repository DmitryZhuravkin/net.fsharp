module Options

(*An option is simply either a value Some(v) or the absence of a value None.*)

let people = [ ("Adam", None); // list of tuples, where the first element - string, second - option field
    ("Eve" , None);
    ("Cain", Some ("Adam","Eve"));
    ("Abel", Some ("Adam","Eve")) ] // val people : (string * (string *string) option) list

let showParents (name,parents) =
    match parents with
    | Some(dad,mum) -> printfn "%s has father %s, mother %s" name dad mum
    | None -> printfn "%s has no parents!" name

let noneOption = None

let someOption = Some "some options value"
let someOptionWithTupple = Some("Some1", "Some2", "Some3", "Some4")

let run =
    showParents ("Adam",None)
    printfn "None option: %A" noneOption
    printfn "Some option: %A" someOption

    printfn "Option.get: %A" (Option.get someOption)
    printfn "Option.get: %A" (Option.get someOptionWithTupple)
