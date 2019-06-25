namespace UsGov.Federal.Executive

open Akka.FSharp

module VicePresident =

    let handleMessage (mailbox: Actor<'a>) msg =
        match msg with
        | Some x -> printf "%A" x
        | None -> ()

    let president = spawn system "_VicePresident_" 
                    (fun mailbox ->
                        let rec loop() = actor {
                            let! message = mailbox.Receive()
                            // handle an incoming message
                            return! loop()
                        }
                        loop())