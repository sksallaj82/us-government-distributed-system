module Play

open Akka.FSharp
let system = System.create "usgov" (Configuration.defaultConfig())
