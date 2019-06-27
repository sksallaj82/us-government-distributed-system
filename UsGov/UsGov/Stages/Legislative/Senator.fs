namespace UsGov.Stages.Legislative

open Akka.FSharp
open Play

module Senator =

    (*
         Represents the accumulation of all votes of all individuals for each state

    *)

    let analyzer = spawn system "_Analyzer_"  <| fun mailbox ->
        let rec loop() = actor {
            let! msg = mailbox.Receive()

            printf msg

            // handle an incoming message
            return! loop()
        }
        loop()