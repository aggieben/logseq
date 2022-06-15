module Logseq

open System
open Fable.Core
open Fable.Core.JsInterop

type UIMsgOptions = {
    key: string option
    timeout: double option
}
type UIMessageStatus = Success | Warning | Error | Other of string
type UIMsgKey = string

type UI() =

    // import? emit?
    static member showMsg(content:string, ?status:UIMessageStatus, ?opts:UIMsgOptions) : JS.Promise<UIMsgKey> = jsNative


