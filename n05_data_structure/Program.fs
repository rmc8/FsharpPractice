// --- tuple ---
// (expr-1, ..., expr-n)
let t = (1.0, 2.0, 3.0)

let average (a, b, c) =
    let sum = a + b + c
    sum / 3.0

printfn "%f" (average t)

// --- list ---
// [expr-1; ... ; expr-n]

let x = 'a' :: 'b' :: 'c' :: []

let y = 'd' :: 'e' :: []
let z = x @ y

let append s t =
    let u = s @ t
    printfn "s @ t = %A" u


printfn "%A" z
printfn "%A" (append x y)

// --- array ---
// Array is a sequence of data of the same type
let asum (x: int array) =
    let mutable sum = 0
    let n = x.Length

    for i = 0 to n - 1 do
        sum <- sum + x.[i]

    printfn "sum = %d" sum

let a = [| 1; 2; 3 |]

asum a



let det (x: float [] []) =
    let d =
        x.[0].[0] * x.[1].[1] - x.[0].[1] * x.[1].[0]

    printfn "det(A) = %f" d


let A = [| [| 1.0; 2.0 |]; [| 3.0; 4.0 |] |]

det A

// --- record ---
// Record is a sequence of values of different data types. Each data can be given a name.
// type name  = {field_name-1: type1; ... ; field_name-n: type-n}
// var_name.field_name

type Person = { Name: string; Sex: string; Age: int }

let getName x = printfn "Name = %A" x.Name

let getSex x = printfn "Sex = %A" x.Sex

let getAge x = printfn "Age = %A" x.Age

let P1 = { Name = "Suzuki"; Sex = "M"; Age = 58 }
getName P1
getSex P1
getAge P1

let P2 = { Name = "Tanaka"; Sex = "F"; Age = 24 }
getName P2
getSex P2
getAge P2