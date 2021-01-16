// Input
let Input msg =
    printf msg
    float(System.Console.ReadLine())


let x = Input("x = ")
let y = Input("y = ")

printf "x + y = %.3f" (x + y)

// Output
// %[flags][width][.precision][type]

printfn "%b" true
printfn "%b" false
printfn "%05d" 123
printfn "%-5d" 123
printfn "%+5d" 123
printfn "%-+5d" 123
printfn "%.2f" 123.4567
printfn "%.4f" 123.4567
printfn "%.4e" 123.4567
printfn "%.4E" 123.4567
printfn "%s" "F#"
printfn "%A" "F#"
printfn "%A" 123.45