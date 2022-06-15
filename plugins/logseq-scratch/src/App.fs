module App

open Fable.Core
open Fable.Core.JsInterop

[<Import("ILSPluginUser", "@logseq/libs")>]
let Logseq : Logseq.ILSPluginUser = jsNative

Logseq.UI.showMsg "test" null null