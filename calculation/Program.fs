// Boolean
printfn "%b" (4 = 2 * 2)
printfn "%b" (true && true) // and
printfn "%b" (true && false)
printfn "%b" (false || false) // or
printfn "%b" (false || true)
printfn "%b" (5 <> 4)
printfn "%b" (5 = 4)
printfn "%b" (not (5 <> 4)) // Enclose the expression in parentheses

// Calc
printfn "%i" (5 * 3)

// string
let s = "hogehoge"
printfn "%s" s

// Calc
let x = 2.4
let y = 3.0
let z = 16
let u = 7
printfn "%f" (x + y) // float
printfn "%f" (x - y)
printfn "%f" (x * y)
printfn "%f" (x / y)
printfn "%i" (z % u)