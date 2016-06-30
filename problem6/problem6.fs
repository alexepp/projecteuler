let problem6 n =
    let range = [1..n]
    let sum1 = 
        range
        |> List.reduce (+)
        |> fun x -> x * x
    let sum2 = 
        range 
        |> List.map (fun x -> x * x) 
        |> List.reduce (+)
    sum1 - sum2

[<EntryPoint>]
let main argv = 
    printfn "%A" (problem6 100)
    0
