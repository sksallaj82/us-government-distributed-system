namespace UsGov.Stages.Executive

open Akka.FSharp
open Play

module Decider =

    (*
        In a distributed system, this the Decider will conclude and take actions on any problem that arises.
        It will make decisions on the market, economy, military, education, and legislation
        It will also help provide advice for citizens
        It will also act as a final decision for court

        Roles are limited to:
            Pardoning
            Appointing into a service
            Removing from a service
            Migration between services
            Handling diplomatic ties
            Handling military actions


        Since this is replacing a centralization of power, this actor will dissolve the following mapped roles:
            President
            Vice President
            Judge
            Governor
            Mayor

    *)

    let decider = spawn system "_Decider_"  <| fun mailbox ->
        let rec loop() = actor {
            let! msg = mailbox.Receive()

            printf msg

            // handle an incoming message
            return! loop()
        }
        loop() //starts the loop