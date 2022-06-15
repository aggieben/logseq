module App

open Fable.Core
open Logseq

let main() =
    logseq.UI.showMsg("test") |> ignore

let consoleError o =
    JS.console.error o
    o

logseq.ready(main).catch(consoleError) |> ignore