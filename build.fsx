#r "./packages/Fake/tools/FakeLib.dll"

#load "./paket-files/lawrencetaylor/83d214421c9c6abcbf9bbecb727b4a26/FsiSessionBuilder.fsx"

open Fake
open FsiSessionBuilder
open System


let fsi = createFsiSession defaultConfig

Target "Watch" (fun _ -> 
  let watcher = 
    !! "playground.fsx"
    |> WatchChanges (fun _ -> 
        let evaulationResult = 
          fsiEval {
            load "./playground.fsx"
          } |> execute fsi
        traceImportant "Hello" |> ignore)

  Console.ReadLine() |> ignore  

  watcher.Dispose()  
)

RunTargetOrDefault "Watch"