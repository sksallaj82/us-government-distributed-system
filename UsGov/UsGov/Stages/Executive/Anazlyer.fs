namespace UsGov.Stages.Executive

open Akka.FSharp
open Play

module Analyzer =

    (*
        Will analyze infomation, providing statistical correlations
        All information are categorized as a Concern.
    *)

    let analyzer = spawn system "_Analyzer_"  <| fun mailbox ->
        let rec loop() = actor {
            let! msg = mailbox.Receive()

            printf msg

            // handle an incoming message
            return! loop()
        }
        loop()