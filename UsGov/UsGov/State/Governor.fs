namespace UsGov.State

open Akka.FSharp

module Governor =

    (*
        Head in State - Foreign affairs, veto bills, signing pardons, providing summary of progress
        Commander in Chief - military
    *)


    let handleMessage (mailbox: Actor<'a>) msg =
        match msg with
        | Some x -> printf "%A" x
        | None -> ()

    let governor = spawn system "_Governor_" 
                    (fun mailbox ->
                        let rec loop() = actor {
                            let! message = mailbox.Receive()
                            // handle an incoming message
                            return! loop()
                        }
                        loop())