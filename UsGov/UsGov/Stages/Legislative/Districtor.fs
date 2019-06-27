namespace UsGov.Stages.Legislative

open Akka.FSharp
open Play

module Districtor =

    (*

    Represents the accumulation of all votes of all individuals for each city
    *)

    let analyzer = spawn system "_Analyzer_"  <| fun mailbox ->
        let rec loop() = actor {
            let! msg = mailbox.Receive()

            printf msg

            // handle an incoming message
            return! loop()
        }
        loop()