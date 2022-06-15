module App

open System
open Fable.Core
open Fable.Core.JsInterop
open Logseq
open Logseq.Settings

let registerSettings() =
    [|
        { key = "test value"
          ``type`` = SettingSchemaType.String
          ``default`` = (!^ String.Empty) |> Some
          title = "Test Value"
          description = "a description"
          inputAs = None
          enumChoices = None
          enumPicker = None }
    |] |> logseq.useSettingsSchema

let main() =
    registerSettings() |> ignore
    logseq.UI.showMsg("Hello from Scratch!") |> ignore

let mainPromise =
    logseq.ready(main)
          .catch(fun o -> JS.console.error o; o)
    |> ignore