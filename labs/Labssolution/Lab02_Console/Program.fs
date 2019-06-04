// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

// TODO: import the System namespace


[<EntryPoint>]
let main argv = 
    printfn "%A" argv

    //----------------------------------------------------------------------------------------------------------------------------
    // Task 1: creating functions using lambda expressions
    //----------------------------------------------------------------------------------------------------------------------------

    // TODO: create a function that checks wether or not a number is odd using a lambda expression

    // TODO: create a function that elevate a number to its square using a lambda expression

    // TODO: create a function that adds one to a number using a lambda expression

    //----------------------------------------------------------------------------------------------------------------------------
    // Task 2: storing functions in a list
    //----------------------------------------------------------------------------------------------------------------------------

    // we can store elements of same type in a list
    let sampleDataList = [1; 2; 3; 4; 5; 6; 7]
    let stringList = ["hello"; "world"; "of"; "functional"; "programming"]

    // TODO: uncomment the comment line below and verify that you get a compile error. Comment it again after that.
    // let mixedList = ["hello"; "number"; 1]

    // TODO: create a list made of the three functions that you have defined above and verify that they compile correctly

    
    // Below is a functional definition of the kinetic energy
    let kineticEnergy m v = 0.5 * m * v * v

    // TODO: try to create a list made of the three function above and the kinetic energy function. What do you notice? What can you conclude?

    //----------------------------------------------------------------------------------------------------------------------------
    // Task 3: storing functions in a tuple
    //----------------------------------------------------------------------------------------------------------------------------

    // A tuple can contains values of same or of different types
    let numberTuple = (1, 2, 3, 4)
    let stringTuple = ("hello", "world")
    let mixedTuple = ("hello", "world", "of", 6, "continents")

    // TODO: create a tuple and add in the three functions you create below as well as kinetic energy function 


    //----------------------------------------------------------------------------------------------------------------------------
    // Task 4: extracting and applying functions stored in a data structure
    //----------------------------------------------------------------------------------------------------------------------------

    let cube = fun x -> x*x*x
    let number = 19

    // TODO: create a tuple made of the cube function and the number value
    //       To extract the first element of the tuple use: fst TUPLE_NAME
    //       To extract the second element of the tuple use: snd TUPLE_NAME
    
    // TODO: use the fst and snd operators to apply the function to the number and compute the cube of 19
    // let computedCube = ...

    // TODO: verify that you can obtain the same result of this task using the cube lambda expression directly instead
    //       of associating it to the cube identifier


    //----------------------------------------------------------------------------------------------------------------------------
    // Task 5: Passing a function as parameter to another function
    //----------------------------------------------------------------------------------------------------------------------------

    // The following examples shows how to pass values to a function

    let sumofSquares = fun x y -> x*x + y*y 
    let tupleList = [(1,2); (3,4); (5,6)]

    let doSum values =
        values
        |> List.map (fun tuple -> sumofSquares (fst tuple) (snd tuple))
    
    printfn "The sum of the square for each tuple of the list produces: %A" (doSum tupleList)

    // The same can be done also with a function passed as value 
    // TODO: create a function called executeIt which takes two parameters, the first being a function and the
    //       second being an integer. ExecuteIt executes the passed function giving it the second parameter as argument
    //       use lambda expressions to do that

    // The following function will extract odd numbers from a list
    let numbersList = [1; 2; 3; 4; 5; 6; 7; 8; 9; 10]
    let oddNumbers = List.filter (fun number -> number % 2 <> 0) numbersList

    printfn "The list of odd numbers processed from %A is %A" numbersList oddNumbers

    //----------------------------------------------------------------------------------------------------------------------------
    // Task 6: returning a function as a result of calling another function
    //----------------------------------------------------------------------------------------------------------------------------

    // The following code snippet demonstrate how to return a function as the result of a call to another function
    let generateLinearFunction a b =
        let generatedFunction = fun x ->
            a*x + b
        generatedFunction
    
    let function1 = generateLinearFunction 1 10
    let identity = generateLinearFunction 1 0
    let constant = generateLinearFunction 0 10

    let points = [1; 2; 3; 4; 5; 6; 7]

    let applyFunction1ToList values =
        values
        |> List.map function1
    
    let applyIdentityToList values =
        values
        |> List.map identity

    let applyConstantToList values =
        values
        |> List.map constant
    

    printfn "The images of %A by the generated function1 are %A" points (applyFunction1ToList points)

    printfn "The images of %A by the generated identity function are %A" points (applyIdentityToList points)

    printfn "The images of %A by the generated constant function are %A" points (applyConstantToList points)

    // TODO: write a function that takes an integer as argument (that we will call item) and whose call returns another function. 
    //       The returned function takes a list as argument an return true or false depending on wether item is found in the list
    //       or not

    //----------------------------------------------------------------------------------------------------------------------------
    // Task 7: returning a composition of functions
    //----------------------------------------------------------------------------------------------------------------------------

    // The following code snippet demonstrate function composition

    let fog = fun f g ->
        fun n -> f (g n)
    
    let expXSquare = fog (fun x -> exp x) (fun x -> x*x)

    let x1 = 1.0
    let x2 = 0.0
    let x3 = 3.0

    printfn "\n-------------------------------"

    printfn "exp (0*0) is %f" (expXSquare x2)

    printfn "exp (1*1) is %f" (expXSquare x1)

    printfn "exp (3*3) is %f" (expXSquare x3)


    // TODO: create a function such that for an argument named x given to the function, it returns the sum
    //       of all the values (from 1 to x) of 1/(x*x). Use function composition and lmabdas

    System.Console.ReadLine()

    0 // return an integer exit code
