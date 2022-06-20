module App

open System
open Fable.Core
open Fable.Core.JsInterop
open Logseq
open Logseq.Settings
open Node.Api
open Node.Buffer

let registerSettings() =
    [|
        { key = "bible-api"
          ``type`` = SettingSchemaType.Enum
          ``default`` = (!^ [|"Biblia.com"|]) |> Some
          title = "Bible API"
          description = "API used to retrieve bible passages"
          inputAs = None
          enumChoices = [|"biblia.com";"bible.org"|] |> Some
          enumPicker = SettingSchemaEnumPickerType.Select |> Some }

        { key = "bible-translation"
          ``type`` = SettingSchemaType.Enum
          ``default`` = (!^ [|"ESV"|]) |> Some
          title = "Bible Translation"
          description = "Translation of scripture to request"
          inputAs = None
          enumChoices = [|"ESV";"KVJ";"LSB";"NIV"|] |> Some
          enumPicker = SettingSchemaEnumPickerType.Select |> Some }
    |] |> logseq.useSettingsSchema

let dumpUmdJson() =
  let umdText = fs.readFileSync("umd.jsonc")
  printfn "%A" umdText

let main() =
    registerSettings() |> ignore
    dumpUmdJson() |> ignore


logseq.ready(main)
      .catch(fun o -> JS.console.error o; o)
|> ignore