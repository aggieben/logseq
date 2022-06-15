namespace Logseq

[<AutoOpen>]
module Logseq =

    open System
    open Fable.Core
    open Fable.Core.JsInterop

    open Logseq.Settings

    type UIMsgOptions = {
        key: string option
        timeout: double option
    }
    type UIMessageStatus = Success | Warning | Error | Other of string
    type UIMsgKey = string

    type UI =
        abstract member showMsg: content:string * ?status:UIMessageStatus * ?opts:UIMsgOptions -> JS.Promise<UIMsgKey>
        abstract member closeMsg: key:UIMsgKey -> unit


    type Logseq =
        abstract member ready: callback:(unit->unit) -> JS.Promise<obj>
        abstract member useSettingsSchema: schemas:SettingSchemaDesc[] -> Logseq
        abstract member UI: UI with get

    [<Emit("window['logseq']")>]
    let logseq : Logseq = jsNative


