open System

let (|IsMultipleOf|_|) divisor (num:int) = 
    if num % divisor = 0 then Some IsMultipleOf else None

let FizzBuzz num =
        match num with
        | IsMultipleOf 5 & IsMultipleOf 3 ->  "FizzBuzz" 
        | IsMultipleOf 3 ->  "Fizz"
        | IsMultipleOf 5 ->  "Buzz"
        | _ -> num.ToString()
        
let PrintFizzBuzz range =
    range |> List.iter (fun x -> printfn "%s" (FizzBuzz x)) 

[<EntryPoint>]
let main argv =
    PrintFizzBuzz [1..100]
    System.Console.ReadKey() |> ignore
    0 // return an integer exit code
    