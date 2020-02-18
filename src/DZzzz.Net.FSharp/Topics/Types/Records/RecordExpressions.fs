(*

    A copy and update record expression is an expression that copies an existing record, updates specified fields, and returns the updated record.
    Records and anonymous records are immutable by default, so that there is no update to an existing record possible. 
    To create an updated record all the fields of a record would have to be specified again. To simplify this task a copy and update expression can be used.

    { record-name with
        updated-labels }

    {| anonymous-record-name with
        updated-labels |}

*)

module RecordExpressions

type MyRecord = { X: int; Y: int; Z: int; }

let myRecord2 = { MyRecord.X = 1; MyRecord.Y = 2; MyRecord.Z = 3 }
let myRecord3 = { myRecord2 with Y = 100; Z = 2 }