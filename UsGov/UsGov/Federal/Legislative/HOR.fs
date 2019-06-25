namespace UsGov.Federal.Legislative

open Akka.FSharp

module HouseOfRepresentatives =

    let handleMessage (mailbox: Actor<'a>) msg =
        match msg with
        | Some x -> printf "%A" x
        | None -> ()

    let representative = spawn system "_HouseOfRepresenatives_"
                            (fun mailbox ->
                                let rec loop() = actor {
                                    let! message = mailbox.Receive()
                                    // handle an incoming message
                                    return! loop()
                                }
                                loop())