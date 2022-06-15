module App

open Fable.Core
open Logseq

let main() =
    logseq.UI.showMsg("test") |> ignore

let consoleError o =
    JS.console.error o
    o

printfn "[logseq-scratch] logseq object: %A" logseq
printfn "[logseq-scratch] ready func: %A" logseq.ready

let mainPromise = logseq.ready(main)
printfn "[logseq-fable] mainPromise = %A" mainPromise
mainPromise.catch(consoleError) |> ignore