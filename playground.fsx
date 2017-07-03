#r "./packages/Argu/lib/net40/Argu.dll"
#r "./packages/Expecto/lib/net461/Expecto.dll"

open Expecto

[<Tests>]
let exampleTest = 
  testCase "Sample" <| fun _ -> Expect.isFalse true "Should have been false"

let tests = 
  [ exampleTest ]
  |> testList "Tests"

runTests defaultConfig tests