// --- pattern matching ---
// match expr with
// | pat-1 -> result-1
// | pat-2 -> result-2
// | pat-3 when expr -> result-3
// | ...
// | _ -> defaultResult

let rec fact x =
    match x with
    | 0
    | 1 -> 1
    | x -> x * (fact (x - 1))


let res = fact 5
printfn "%d" res

let mydiv (x: float) (y: float) =
    match y with
    | 0.0 -> None
    | _ -> Some(x / y) // Option type

printfn "%A" (mydiv 2.0 3.0)
printfn "%A" (mydiv 3.0 0.0)
