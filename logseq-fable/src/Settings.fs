module Logseq.Settings

open Fable.Core

type [<StringEnum>] SettingSchemaType =
    | String
    | Number
    | Boolean
    | Enum
    | Object

type [<StringEnum>] SettingSchemaInputType =
    | Color
    | Date
    | [<CompiledName("datetime-local")>] DatetimeLocal
    | Range

type [<StringEnum>] SettingSchemaEnumPickerType =
    | Select
    | Radio
    | Checkbox

type SettingSchemaDesc = {
    key : string
    ``type`` : SettingSchemaType
    ``default`` : U5<string, float, bool, obj option[], obj> option
    title : string
    description : string
    inputAs : SettingSchemaInputType option
    enumChoices : string[] option
    enumPicker: SettingSchemaEnumPickerType option
}