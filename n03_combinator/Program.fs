// --- conbinator ---
let IF x y z = x y z
let TRUE x y = x
let FALSE x y = y
let K x y = x
let I x = x

let zero_test =
    function
    | 0 -> TRUE
    | otherwise -> FALSE

printfn "%A" (IF (zero_test 0) "x is 0" "x is not zero")
printfn "%A" (IF (zero_test 50) "x is 0" "x is not zero")

// --- fixpoint combinator ---

let Yfact n =
    let rec Y F x = F (Y F) x
    Y (fun fact x -> if x = 0 then 1 else x * fact (x - 1)) n

printfn "%A" (Yfact 0)
printfn "%A" (Yfact 1)
printfn "%A" (Yfact 5)