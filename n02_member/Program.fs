type Rect =
    class
        val height: float
        val width: float
        new(h, w) = { height = h; width = w }
        member x.Area = x.height * x.width
    end

let RectObj (x: float) (y: float) =
    let rect = Rect(x, y)
    printfn "Rect object rect:"
    printfn "height = %f" x
    printfn "width = %f" y
    printfn "area = %f" rect.Area


RectObj 3.0 2.5


type Rect2 =
    class
        val height: float
        val width: float

        new(h, w) as this =
            { height = h; width = w }
            then
                printfn "React obj rect"
                printfn "height = %f" this.height
                printfn "width = %f" this.width
                printfn "area = %f" this.Area

        member this.Area = this.height * this.width
    end

let rect2 = Rect2(2.0, 3.0)
