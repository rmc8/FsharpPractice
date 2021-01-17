// FS39.fs: ポリモフィズム
[<AbstractClass>]
type Shape =
    class
        new() = {  }
        abstract Area: unit -> float
    end

type Rect =
    class
        inherit Shape
        val height: float
        val width: float
        new(h, w) = { height = h; width = w }
        override x.Area() = x.height * x.width
    end

type Circle =
    class
        inherit Shape
        val radius: float
        new(r) = { radius = r }
        override x.Area() = x.radius * x.radius * 3.141592
    end

let RectObj (x: float) (y: float) =
    let rect = Rect(x, y)
    let ra = rect.Area()
    printfn "Rect object rect:"
    printfn "height = %f" x
    printfn "width = %f" y
    printfn "area = %f" ra

let CircObj (x: float) =
    let circ = Circle(x)
    let ca = circ.Area()
    printfn "Circle object circ:"
    printfn "radius = %f" x
    printfn "area = %f" ca


RectObj 3.0 1.5
CircObj 1.0