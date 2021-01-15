// --- if ---
// if expr-1 then expr-2 [else expr-3]
// if expr-1 then expr-2 elif expr-3 then expr-4

let a = 5
if a > 0 then printfn "a > 0" else printfn "a <= 0"

let b = -5
if b > 0 then printfn "b > 0" else printfn "b <= 0"

let c = 0

if c > 0 then printfn "c > 0"
elif c < 0 then printfn "c < 0"
else printfn "c = 0"


// mutable
let mutable d = 8
printfn "%i" d
d <- 19
printfn "%i" d

// --- for ---
// for var = expr-1 to expr-2 do
//     expr-3
let n = 10
let mutable sum = 0

for i = 1 to n do
    sum <- sum + i

printfn "sum = %d" sum

// --- while ---
// while expr-1 do
//   expr-2
// done
// COMENT: The 'done' is optional.


sum <- 0
let mutable i = 0
while (i <= n) do
    sum <- sum + i
    i <- i + 1
printfn "sum = %d" sum