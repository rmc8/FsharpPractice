// --- higher-order function ---
//  --- map ---
// map f x

let Lsquare (lnum: int list) =
    let square = (fun x -> x * x)
    let lsnum = List.map square lnum
    printfn "num^2 = %A" lsnum


let num = [ 1 .. 10 ]
Lsquare num

// --- fold ---

let fold_sum (num: int list) =
    let sum = List.fold (fun x y -> x + y) 0 num
    printfn "sum = %d" sum

fold_sum [ 1 .. 10 ]
