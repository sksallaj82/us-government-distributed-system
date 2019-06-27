namespace UsGov.Stages.Legislative

open Akka.FSharp
open Play

module Representor =

   (*
        Represents the accumulation of all votes of all individuals across the nation

        This is the human element that will be used to provide the government with public feedback

   *)

   let analyzer = spawn system "_Analyzer_"  <| fun mailbox ->
       let rec loop() = actor {
           let! msg = mailbox.Receive()

           printf msg

           // handle an incoming message
           return! loop()
       }
       loop()