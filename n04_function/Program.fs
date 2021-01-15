// let funcname arg-1 ... arg-n : type = def
let add x y: float = x + y
let x = 2.0
let y = 3.0
printfn "x + y = %f" (add x y)

// fun (arg-1 : type-1) ... (arg-n : type-n) -> expr

let add_fun = fun (x: float) (y: float) -> x + y
printfn "x + y = %f" (add_fun x y)

// --- Recursive function ---
//
let rec fact x = if x = 0 then 1 else x * (fact (x - 1))


for i = 1 to 10 do
    printfn "%d" (fact i)

// --- Composite function ---
let f x: float = 2.0 * x
let g x: float = x * x
printfn "f x = 2 * x"
printfn "g x = x * x"
printfn "f(g x) = %f" ((f >> g) x) // f(g(x))
printfn "g(f x) = %f" ((g >> f) x) // g(f(x))
