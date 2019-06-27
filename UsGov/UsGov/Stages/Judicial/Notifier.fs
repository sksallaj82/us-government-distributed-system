namespace UsGov.Stages.Judicial

open Akka.FSharp
open Play

module Notifier =


    (*
        This actor will be used to send Notifications to you or your community, pertaining to any governmental
        procedures that you are involved in, as well as any governmental actions that have been taken that you
        are concerned with.

        Government procedures:
            Applying for a new state drivers license, applying for social security, court proceedings

        Government actions examples:
            New information about foreign policy, decisions on taxes and health care, etc.

        The notifier may also provide advice/resources/guidelines that you may use afterwards to help resolve, 
        or continue to next steps of the work flow.

    *)

    let analyzer = spawn system "_Analyzer_"  <| fun mailbox ->
        let rec loop() = actor {
            let! msg = mailbox.Receive()

            printf msg

            // handle an incoming message
            return! loop()
        }
        loop()