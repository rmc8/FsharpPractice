type IArea =
 interface
 abstract Area : unit -> float
end
type Rect = class
  val height : float
  val width : float
  new (h,w) =
       {height = h; width = w;}
  interface IArea with 
    member x.Area() = 
      x.height * x.width
end
type Circle = class
  val radius : float
  new (r) = 
       {radius = r;}
  interface IArea with 
    member x.Area() = 
      x.radius * x.radius * 3.141592
end;;
let RectObj (x : float) (y : float) = 
   let rect = new Rect(x, y)
   let ra = (rect :> IArea).Area()
   printfn "Rect object rect:"
   printfn "height = %f" x
   printfn "width = %f" y
   printfn "area = %f" ra;;
let CircObj (x : float)  = 
   let circ = new Circle(x)
   let ca = (circ :> IArea).Area()
   printfn "Circle object circ:"
   printfn "radius = %f" x
   printfn "area = %f" ca;;