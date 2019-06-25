namespace UsGov.Federal.Executive

open Akka.FSharp

module President =

    (*
        Head in State - Foreign affairs, veto bills, signing pardons, providing summary of progress
        Commander in Chief - military
    *)


    let handleMessage (mailbox: Actor<'a>) msg =
        match msg with
        | Some x -> printf "%A" x
        | None -> ()

    let president = spawn system "_President_" 
                    (fun mailbox ->
                        let rec loop() = actor {
                            let! message = mailbox.Receive()
                            // handle an incoming message
                            return! loop()
                        }
                        loop())