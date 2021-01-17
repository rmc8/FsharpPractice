// -- currying ---
// add(x, y) = x + y
// λxλy(add(x, y) = λxλy(x + y)
// x = 2; y = 3
// λxλy(add(2, 3)) = λxλy(x + y)(2)(3) = λy(2 + y)(3) = 5
// --- anonymous function ---
// fun x y -> x + y

let c_add = (fun x -> (fun y -> x + y))

let uadd =
    (fun (x: float) -> (fun (y: float) -> (x + y: float)))


printfn "%f" (uadd 2.0 3.0)
printfn "%f" ((uadd 2.0) 3.0)
let uadd_2 = uadd 2.0
printfn "%f" (uadd_2 3.0)


// --- pipeline ---
// let inline (|>) x f = fx

let inline (|>) x f = f x

let three x = 3 * x
let add x y = x + y
let toString x = x.ToString()
let Pfunc x y = x |> three |> add y |> toString

printfn "%s" (Pfunc 2 4)
