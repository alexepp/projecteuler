let problem1 n =
    List.sum ( List.filter (fun x -> x % 3 = 0 || x % 5 = 0) [1..n] )

[<EntryPoint>]
let main argv = 
    printfn "%A" (problem1 1000)
    0