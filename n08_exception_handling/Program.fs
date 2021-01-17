// -- exception handling ---
// * System.ArithmeticException
// * System.ArrayTypeMismatchException
// * System.DivideByZeroException
// * System.OverFlowException
// * System.IndexOutOfRangeException
// --- try-catch ---
// try expr with rules
// --- Pattern rule ---
// :? System.FormatException -> value

let Input msg =
    printf msg

    try
        float (System.Console.ReadLine())
    with :? System.FormatException -> System.Double.NaN


let x = Input("x = ")
let y = Input("y = ")
printfn "%f + %f = %f" x y (x + y)


let mydiv (x: float) (y: float) =
    try
        x / y
    finally
        printfn "DivideByZero Exception if infinity"


mydiv 3.0 2.0
mydiv 3.0 0.0