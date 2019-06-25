namespace UsGov.Federal.SC

open Akka.FSharp

module SupremeCourt =

    let handleMessage (mailbox: Actor<'a>) msg =
        match msg with
        | Some x -> printf "%A" x
        | None -> ()

    let justice = spawn system "_SupremeCourt_"
                    (fun mailbox ->
                        let rec loop() = actor {
                            let! message = mailbox.Receive()
                            // handle an incoming message
                            return! loop()
                        }
                        loop())