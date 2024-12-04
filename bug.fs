let mutable x = 10
let mutable y = 20

let add x y = 
    x + y

let result = add x y
printf "%d" result // Output: 30

x <- 15
y <- 25

printf "%d" (add x y) //Output: 40

//Trying to change the value of x and y using the add function would cause an unexpected error, it will not change the original value of x and y, because it is passed by value.

//In order to change the value of x and y, it should be passed by reference.
let addByRef x y =
    x <- x + y
    y <- x - y
    x,y

let xRef, yRef = addByRef x y
printf "%d %d" xRef yRef //Output: 40 0