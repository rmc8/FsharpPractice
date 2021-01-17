type Rect =
    class
        val height: float
        val width: float
        new(h, w) = { height = h; width = w }
        member x.Area = x.height * x.width
    end

type Square =
    class
        inherit Rect
        new(h, w) = { inherit Rect(h, w) }
    end

let RectObj (x: float) (y: float) =
    let rect = Rect(x, y)
    printfn "Rect object rect:"
    printfn "Height = %f" x
    printfn "width = %f" y
    printfn "area = %f" rect.Area

let SqObj (x: float) =
    let sq = Square(x, x)
    printfn "Square object sq:"
    printfn "height = width = %f" x
    printfn "area = %f" sq.Area


RectObj 3.0 4.0
SqObj 5.0

type Rect2 =
    class
        val height: float
        val width: float

        new(h, w) as this =
            { height = h; width = w }
            then
                printfn "height = %f" this.height
                printfn "width = %f" this.width
                printfn "area = %f" this.Area

        member this.Area = this.height * this.width
    end

type Square2 =
    class
        inherit Rect2
        new(h, w) = { inherit Rect2(h, w) }
    end

let RectObj2 (x: float) (y: float) =
    printfn "Rect object rect:"
    Rect2(x, y)

let SqObj2 (x: float) =
    printfn "Square object sq:"
    Square2(x, x)

RectObj2 3.0 4.0
SqObj2 5.0
