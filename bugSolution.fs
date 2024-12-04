let mutable x = 10
let mutable y = 20

// Pass by reference using tuples
let addByRef (x, y) =
    let newX = x + y
    let newY = newX - y
    newX, newY

let (x, y) = addByRef (x, y)
printf "%d %d" x y // Output: 30 10

//Alternatively, pass by reference using mutable references
let addByRefRef xRef yRef =
    xRef := !xRef + !yRef
    yRef := !xRef - !yRef

let xRef = ref x
let yRef = ref y

addByRefRef xRef yRef
printf "%d %d" !xRef !yRef // Output: 30 10