namespace UsGov.Stages.Executive

open Akka.FSharp
open Play

module Watcher =

    (*
        Will be the eyes and ears of all information that flows in and out of the executive branch.
        All information are categorized as a Concern.


    *)

    let watcher = spawn system "_Watcher_"  <| fun mailbox ->
        let rec loop() = actor {
            let! msg = mailbox.Receive()

            printf msg

            // handle an incoming message
            return! loop()
        }
        loop()