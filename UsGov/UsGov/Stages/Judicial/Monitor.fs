namespace UsGov.Stages.Judicial

open Akka.FSharp
open Play

module Monitor =

    (*
        This actor will be used to monitor activities of services.
        This differs from a Watcher, which looks at social trends and collects information.

        Monitors will be used to ensure that all services are following workflows accordingly.
        Meaning all evidence of a transaction between services must be submitted and reported.


        This actor replaces the supreme court
    
    *)

    let analyzer = spawn system "_Analyzer_"  <| fun mailbox ->
        let rec loop() = actor {
            let! msg = mailbox.Receive()

            printf msg

            // handle an incoming message
            return! loop()
        }
        loop()