// ts2fable 0.7.1
module rec Logseq
open System
open Fable.Core
open Fable.Core.JS

type ILSPluginUser = __dist_LSPlugin.ILSPluginUser

type [<AllowNullLiteral>] IExports =
    abstract logseq: ILSPluginUser
