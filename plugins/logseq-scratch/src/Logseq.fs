// ts2fable 0.7.1
module rec Logseq
open System
open Fable.Core
open Fable.Core.JS
open Fable.Core.JsInterop

[<Import("*", "csstype")>]
module CSS = jsNative

type Array<'T> = System.Collections.Generic.IList<'T>


type LSPluginCaller = __LSPlugin_caller.LSPluginCaller
type LSPluginFileStorage = __modules_LSPlugin_Storage.LSPluginFileStorage
type LSPluginExperiments = __modules_LSPlugin_Experiments.LSPluginExperiments

type PluginLocalIdentity =
    string

type [<AllowNullLiteral>] ThemeOptions =
    abstract name: string with get, set
    abstract url: string with get, set
    abstract description: string option with get, set
    abstract mode: ThemeOptionsMode option with get, set
    [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> obj option with get, set

type StyleString =
    string

type [<AllowNullLiteral>] StyleOptions =
    abstract key: string option with get, set
    abstract style: StyleString with get, set

type [<AllowNullLiteral>] UIContainerAttrs =
    abstract draggable: bool with get, set
    abstract resizable: bool with get, set
    [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> obj option with get, set

type [<AllowNullLiteral>] UIBaseOptions =
    abstract key: string option with get, set
    abstract replace: bool option with get, set
    abstract template: string option with get, set
    abstract style: CSS.Properties option with get, set
    abstract attrs: Record<string, string> option with get, set
    abstract close: U2<string, string> option with get, set
    abstract reset: bool option with get, set

type [<AllowNullLiteral>] UIPathIdentity =
    /// DOM selector
    abstract path: string with get, set

type [<AllowNullLiteral>] UISlotIdentity =
    /// Slot key
    abstract slot: string with get, set

type [<AllowNullLiteral>] UISlotOptions =
    interface end

type [<AllowNullLiteral>] UIPathOptions =
    interface end

type UIOptions =
    U3<UIBaseOptions, UIPathOptions, UISlotOptions>

type [<AllowNullLiteral>] LSPluginPkgConfig =
    abstract id: PluginLocalIdentity with get, set
    abstract main: string with get, set
    abstract entry: string with get, set
    abstract title: string with get, set
    abstract mode: LSPluginPkgConfigMode with get, set
    abstract themes: Array<ThemeOptions> with get, set
    abstract icon: string with get, set
    [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> obj option with get, set

type [<AllowNullLiteral>] LSPluginBaseInfo =
    abstract id: string with get, set
    abstract mode: LSPluginPkgConfigMode with get, set
    abstract settings: LSPluginBaseInfoSettings with get, set
    [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> obj option with get, set

type [<AllowNullLiteral>] IHookEvent =
    [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> obj option with get, set

type [<AllowNullLiteral>] IUserOffHook =
    [<Emit "$0($1...)">] abstract Invoke: unit -> unit

type IUserHook<'R> =
    IUserHook<obj, 'R>

type IUserHook =
    IUserHook<obj, obj>

type [<AllowNullLiteral>] IUserHook<'E, 'R> =
    [<Emit "$0($1...)">] abstract Invoke: callback: (obj -> unit) -> IUserOffHook

type IUserSlotHook =
    IUserSlotHook<obj>

type [<AllowNullLiteral>] IUserSlotHook<'E> =
    [<Emit "$0($1...)">] abstract Invoke: callback: (obj -> unit) -> unit

type EntityID =
    float

type BlockUUID =
    string

type BlockUUIDTuple =
    string * BlockUUID

type [<AllowNullLiteral>] IEntityID =
    abstract id: EntityID with get, set
    [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> obj option with get, set

type [<AllowNullLiteral>] IBatchBlock =
    abstract content: string with get, set
    abstract properties: Record<string, obj option> option with get, set
    abstract children: Array<IBatchBlock> option with get, set

type IDatom =
    e * float * a * string * v * obj option * t * float * added * bool

type [<AllowNullLiteral>] IGitResult =
    abstract stdout: string with get, set
    abstract stderr: string with get, set
    abstract exitCode: float with get, set

type [<AllowNullLiteral>] AppUserInfo =
    [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> obj option with get, set

type [<AllowNullLiteral>] AppInfo =
    abstract version: string with get, set
    [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> obj option with get, set

/// User's app configurations
type [<AllowNullLiteral>] AppUserConfigs =
    abstract preferredThemeMode: ThemeOptionsMode with get, set
    abstract preferredFormat: AppUserConfigsPreferredFormat with get, set
    abstract preferredDateFormat: string with get, set
    abstract preferredStartOfWeek: string with get, set
    abstract preferredLanguage: string with get, set
    abstract preferredWorkflow: string with get, set
    abstract currentGraph: string with get, set
    abstract showBracket: bool with get, set
    [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> obj option with get, set

/// In Logseq, a graph represents a repository of connected pages and blocks
type [<AllowNullLiteral>] AppGraphInfo =
    abstract name: string with get, set
    abstract url: string with get, set
    abstract path: string with get, set
    [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> obj option with get, set

/// Block - Logseq's fundamental data structure.
type [<AllowNullLiteral>] BlockEntity =
    abstract id: EntityID with get, set
    abstract uuid: BlockUUID with get, set
    abstract left: IEntityID with get, set
    abstract format: AppUserConfigsPreferredFormat with get, set
    abstract parent: IEntityID with get, set
    abstract unordered: bool with get, set
    abstract content: string with get, set
    abstract page: IEntityID with get, set
    abstract anchor: string option with get, set
    abstract body: obj option with get, set
    abstract children: Array<U2<BlockEntity, BlockUUIDTuple>> option with get, set
    abstract container: string option with get, set
    abstract file: IEntityID option with get, set
    abstract level: float option with get, set
    abstract meta: BlockEntityMeta option with get, set
    abstract title: Array<obj option> option with get, set
    [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> obj option with get, set

/// Page is just a block with some specific properties.
type [<AllowNullLiteral>] PageEntity =
    abstract id: EntityID with get, set
    abstract uuid: BlockUUID with get, set
    abstract name: string with get, set
    abstract originalName: string with get, set
    abstract ``journal?``: bool with get, set
    abstract file: IEntityID option with get, set
    abstract ``namespace``: IEntityID option with get, set
    abstract children: Array<PageEntity> option with get, set
    abstract format: AppUserConfigsPreferredFormat option with get, set
    abstract journalDay: float option with get, set

type BlockIdentity =
    U2<BlockUUID, obj>

type BlockPageName =
    string

type PageIdentity =
    U2<BlockPageName, BlockIdentity>

type [<StringEnum>] [<RequireQualifiedAccess>] SlashCommandActionCmd =
    | [<CompiledName "editor/input">] ``Editor/input``
    | [<CompiledName "editor/hook">] ``Editor/hook``
    | [<CompiledName "editor/clear-current-slash">] ``Editor/clearCurrentSlash``
    | [<CompiledName "editor/restore-saved-cursor">] ``Editor/restoreSavedCursor``

type SlashCommandAction =
    cmd * SlashCommandActionCmd * obj * obj option

type [<AllowNullLiteral>] SimpleCommandCallback =
    [<Emit "$0($1...)">] abstract Invoke: e: IHookEvent -> unit

type [<AllowNullLiteral>] BlockCommandCallback =
    [<Emit "$0($1...)">] abstract Invoke: e: obj -> Promise<unit>

type [<AllowNullLiteral>] BlockCursorPosition =
    abstract left: float with get, set
    abstract top: float with get, set
    abstract height: float with get, set
    abstract pos: float with get, set
    abstract rect: DOMRect with get, set

type [<AllowNullLiteral>] SimpleCommandKeybinding =
    abstract mode: SimpleCommandKeybindingMode option with get, set
    abstract binding: string with get, set
    abstract mac: string option with get, set

type [<AllowNullLiteral>] SettingSchemaDesc =
    abstract key: string with get, set
    abstract ``type``: SettingSchemaDescType with get, set
    abstract ``default``: U5<string, float, bool, Array<obj option>, obj> option with get, set
    abstract title: string with get, set
    abstract description: string with get, set
    abstract inputAs: SettingSchemaDescInputAs option with get, set
    abstract enumChoices: Array<string> option with get, set
    abstract enumPicker: SettingSchemaDescEnumPicker option with get, set

type [<StringEnum>] [<RequireQualifiedAccess>] ExternalCommandType =
    | [<CompiledName "logseq.command/run">] ``Logseq_command/run``
    | [<CompiledName "logseq.editor/cycle-todo">] ``Logseq_editor/cycleTodo``
    | [<CompiledName "logseq.editor/down">] ``Logseq_editor/down``
    | [<CompiledName "logseq.editor/up">] ``Logseq_editor/up``
    | [<CompiledName "logseq.editor/expand-block-children">] ``Logseq_editor/expandBlockChildren``
    | [<CompiledName "logseq.editor/collapse-block-children">] ``Logseq_editor/collapseBlockChildren``
    | [<CompiledName "logseq.editor/open-file-in-default-app">] ``Logseq_editor/openFileInDefaultApp``
    | [<CompiledName "logseq.editor/open-file-in-directory">] ``Logseq_editor/openFileInDirectory``
    | [<CompiledName "logseq.editor/select-all-blocks">] ``Logseq_editor/selectAllBlocks``
    | [<CompiledName "logseq.editor/toggle-open-blocks">] ``Logseq_editor/toggleOpenBlocks``
    | [<CompiledName "logseq.editor/zoom-in">] ``Logseq_editor/zoomIn``
    | [<CompiledName "logseq.editor/zoom-out">] ``Logseq_editor/zoomOut``
    | [<CompiledName "logseq.editor/indent">] ``Logseq_editor/indent``
    | [<CompiledName "logseq.editor/outdent">] ``Logseq_editor/outdent``
    | [<CompiledName "logseq.editor/copy">] ``Logseq_editor/copy``
    | [<CompiledName "logseq.editor/cut">] ``Logseq_editor/cut``
    | [<CompiledName "logseq.go/home">] ``Logseq_go/home``
    | [<CompiledName "logseq.go/journals">] ``Logseq_go/journals``
    | [<CompiledName "logseq.go/keyboard-shortcuts">] ``Logseq_go/keyboardShortcuts``
    | [<CompiledName "logseq.go/next-journal">] ``Logseq_go/nextJournal``
    | [<CompiledName "logseq.go/prev-journal">] ``Logseq_go/prevJournal``
    | [<CompiledName "logseq.go/search">] ``Logseq_go/search``
    | [<CompiledName "logseq.go/search-in-page">] ``Logseq_go/searchInPage``
    | [<CompiledName "logseq.go/tomorrow">] ``Logseq_go/tomorrow``
    | [<CompiledName "logseq.go/backward">] ``Logseq_go/backward``
    | [<CompiledName "logseq.go/forward">] ``Logseq_go/forward``
    | [<CompiledName "logseq.search/re-index">] ``Logseq_search/reIndex``
    | [<CompiledName "logseq.sidebar/clear">] ``Logseq_sidebar/clear``
    | [<CompiledName "logseq.sidebar/open-today-page">] ``Logseq_sidebar/openTodayPage``
    | [<CompiledName "logseq.ui/goto-plugins">] ``Logseq_ui/gotoPlugins``
    | [<CompiledName "logseq.ui/select-theme-color">] ``Logseq_ui/selectThemeColor``
    | [<CompiledName "logseq.ui/toggle-brackets">] ``Logseq_ui/toggleBrackets``
    | [<CompiledName "logseq.ui/toggle-cards">] ``Logseq_ui/toggleCards``
    | [<CompiledName "logseq.ui/toggle-contents">] ``Logseq_ui/toggleContents``
    | [<CompiledName "logseq.ui/toggle-document-mode">] ``Logseq_ui/toggleDocumentMode``
    | [<CompiledName "logseq.ui/toggle-help">] ``Logseq_ui/toggleHelp``
    | [<CompiledName "logseq.ui/toggle-left-sidebar">] ``Logseq_ui/toggleLeftSidebar``
    | [<CompiledName "logseq.ui/toggle-right-sidebar">] ``Logseq_ui/toggleRightSidebar``
    | [<CompiledName "logseq.ui/toggle-settings">] ``Logseq_ui/toggleSettings``
    | [<CompiledName "logseq.ui/toggle-theme">] ``Logseq_ui/toggleTheme``
    | [<CompiledName "logseq.ui/toggle-wide-mode">] ``Logseq_ui/toggleWideMode``
    | [<CompiledName "logseq.command-palette/toggle">] ``Logseq_commandPalette/toggle``

type [<StringEnum>] [<RequireQualifiedAccess>] UserProxyTags =
    | App
    | Editor
    | Db
    | Git
    | Ui
    | Assets

/// App level APIs
type [<AllowNullLiteral>] IAppProxy =
    abstract getInfo: (AppInfo -> Promise<U2<AppInfo, obj option>>) with get, set
    abstract getUserInfo: (unit -> Promise<AppUserInfo option>) with get, set
    abstract getUserConfigs: (unit -> Promise<AppUserConfigs>) with get, set
    abstract registerCommand: (string -> IAppProxyRegisterCommand -> SimpleCommandCallback -> unit) with get, set
    abstract registerCommandPalette: (IAppProxyRegisterCommandPalette -> SimpleCommandCallback -> unit) with get, set
    abstract registerCommandShortcut: (SimpleCommandKeybinding -> SimpleCommandCallback -> unit) with get, set
    abstract invokeExternalCommand: (ExternalCommandType -> Array<obj option> -> Promise<unit>) with get, set
    /// Get state from app store
    /// valid state is here
    /// https://github.com/logseq/logseq/blob/master/src/main/frontend/state.cljs#L27
    abstract getStateFromStore: (U2<string, Array<string>> -> Promise<'T>) with get, set
    abstract relaunch: (unit -> Promise<unit>) with get, set
    abstract quit: (unit -> Promise<unit>) with get, set
    abstract openExternalLink: (string -> Promise<unit>) with get, set
    abstract execGitCommand: (ResizeArray<string> -> Promise<string>) with get, set
    abstract getCurrentGraph: (unit -> Promise<AppGraphInfo option>) with get, set
    abstract pushState: (string -> Record<string, obj option> -> Record<string, obj option> -> unit) with get, set
    abstract replaceState: (string -> Record<string, obj option> -> Record<string, obj option> -> unit) with get, set
    abstract queryElementById: (string -> Promise<U2<string, bool>>) with get, set
    abstract queryElementRect: (string -> Promise<DOMRectReadOnly option>) with get, set
    abstract showMsg: (string -> U2<string, string> -> unit) with get, set
    abstract setZoomFactor: (float -> unit) with get, set
    abstract setFullScreen: (U2<bool, string> -> unit) with get, set
    abstract setLeftSidebarVisible: (U2<bool, string> -> unit) with get, set
    abstract setRightSidebarVisible: (U2<bool, string> -> unit) with get, set
    abstract registerUIItem: (IAppProxyRegisterUIItem -> IAppProxyRegisterUIItem2 -> unit) with get, set
    abstract registerPageMenuItem: (string -> (obj -> unit) -> unit) with get, set
    abstract onCurrentGraphChanged: IUserHook with get, set
    abstract onThemeModeChanged: IUserHook<IAppProxyOnThemeModeChangedIUserHook> with get, set
    abstract onBlockRendererSlotted: IUserSlotHook<IAppProxyOnBlockRendererSlottedIUserSlotHook> with get, set
    /// provide ui slot to block `renderer` macro for `{{renderer arg1, arg2}}`
    abstract onMacroRendererSlotted: IUserSlotHook<IAppProxyOnMacroRendererSlottedIUserSlotHook> with get, set
    abstract onPageHeadActionsSlotted: IUserSlotHook with get, set
    abstract onRouteChanged: IUserHook<IAppProxyOnRouteChangedIUserHook> with get, set
    abstract onSidebarVisibleChanged: IUserHook<IAppProxyOnSidebarVisibleChangedIUserHook> with get, set
    abstract _installPluginHook: (string -> string -> unit) with get, set
    abstract _uninstallPluginHook: (string -> U2<string, bool> -> unit) with get, set

/// Editor related APIs
type [<AllowNullLiteral>] IEditorProxy =
    inherit Record<string, obj option>
    /// register a custom command which will be added to the Logseq slash command list
    abstract registerSlashCommand: (string -> U2<BlockCommandCallback, Array<SlashCommandAction>> -> obj) with get, set
    /// register a custom command in the block context menu (triggered by right clicking the block dot)
    abstract registerBlockContextMenuItem: (string -> BlockCommandCallback -> obj) with get, set
    abstract checkEditing: (unit -> Promise<U2<BlockUUID, bool>>) with get, set
    abstract insertAtEditingCursor: (string -> Promise<unit>) with get, set
    abstract restoreEditingCursor: (unit -> Promise<unit>) with get, set
    abstract exitEditingMode: (bool -> Promise<unit>) with get, set
    abstract getEditingCursorPosition: (unit -> Promise<BlockCursorPosition option>) with get, set
    abstract getEditingBlockContent: (unit -> Promise<string>) with get, set
    abstract getCurrentPage: (unit -> Promise<U2<PageEntity, BlockEntity> option>) with get, set
    abstract getCurrentBlock: (unit -> Promise<BlockEntity option>) with get, set
    abstract getSelectedBlocks: (unit -> Promise<Array<BlockEntity> option>) with get, set
    /// get all blocks of the current page as a tree structure
    abstract getCurrentPageBlocksTree: (unit -> Promise<Array<BlockEntity>>) with get, set
    /// get all blocks for the specified page
    abstract getPageBlocksTree: (PageIdentity -> Promise<Array<BlockEntity>>) with get, set
    /// get all page/block linked references
    abstract getPageLinkedReferences: (PageIdentity -> Promise<Array<page>>) with get, set
    abstract PageEntity: obj with get, set
    abstract blocks: Array<BlockEntity> with get, set

/// Datascript related APIs
type [<AllowNullLiteral>] IDBProxy =
    /// Run a DSL query
    abstract q: (string -> Promise<Array<'T> option>) with get, set
    /// Run a datascript query
    abstract datascriptQuery: (string -> Array<obj option> -> Promise<'T>) with get, set
    /// Hook all transaction data of DB
    abstract onChanged: IUserHook<IDBProxyOnChangedIUserHook> with get, set
    /// Subscribe a specific block changed event
    abstract onBlockChanged: uuid: BlockUUID * callback: (BlockEntity -> Array<IDatom> -> IDBProxyOnChangedIUserHookTxMeta -> unit) -> IUserOffHook

/// Git related APIS
type [<AllowNullLiteral>] IGitProxy =
    abstract execCommand: (ResizeArray<string> -> Promise<IGitResult>) with get, set
    abstract loadIgnoreFile: (unit -> Promise<string>) with get, set
    abstract saveIgnoreFile: (string -> Promise<unit>) with get, set

type [<AllowNullLiteral>] UIMsgOptions =
    abstract key: string with get, set
    abstract timeout: float with get, set

type UIMsgKey =
    UIMsgOptions

type [<AllowNullLiteral>] IUIProxy =
    abstract showMsg: (string -> U2<string, string> -> obj -> Promise<UIMsgKey>) with get, set
    abstract closeMsg: (UIMsgKey -> unit) with get, set

/// Assets related APIs
type [<AllowNullLiteral>] IAssetsProxy =
    abstract listFilesOfCurrentGraph: exts: U2<string, ResizeArray<string>> -> Promise<IAssetsProxyListFilesOfCurrentGraphPromise>

type [<AllowNullLiteral>] ILSPluginThemeManager =
    inherit EventEmitter
    abstract themes: Map<PluginLocalIdentity, Array<ThemeOptions>> with get, set
    abstract registerTheme: id: PluginLocalIdentity * opt: ThemeOptions -> Promise<unit>
    abstract unregisterTheme: id: PluginLocalIdentity -> Promise<unit>
    abstract selectTheme: ?opt: ThemeOptions -> Promise<unit>

type [<StringEnum>] [<RequireQualifiedAccess>] LSPluginUserEvents =
    | [<CompiledName "ui:visible:changed">] ``Ui:visible:changed``
    | [<CompiledName "settings:changed">] ``Settings:changed``

type [<AllowNullLiteral>] ILSPluginUser =
    inherit EventEmitter<LSPluginUserEvents>
    /// Connection status with the main app
    abstract connected: bool with get, set
    /// Duplex message caller
    abstract caller: LSPluginCaller with get, set
    /// The plugin configurations from package.json
    abstract baseInfo: LSPluginBaseInfo with get, set
    /// The plugin user settings
    abstract settings: LSPluginBaseInfo option with get, set
    /// <summary>The main Logseq app is ready to run the plugin</summary>
    /// <param name="model">- same as the model in `provideModel`</param>
    abstract ready: ?model: Record<string, obj option> -> Promise<obj option>
    /// <param name="callback">- a function to run when the main Logseq app is ready</param>
    abstract ready: ?callback: (obj option -> U2<unit, ILSPluginUserReady>) -> Promise<obj option>
    abstract ready: ?model: Record<string, obj option> * ?callback: (obj option -> U2<unit, ILSPluginUserReady>) -> Promise<obj option>
    abstract beforeunload: ((unit -> Promise<unit>) -> unit) with get, set
    /// Create a object to hold the methods referenced in `provideUI`
    abstract provideModel: model: Record<string, obj option> -> ILSPluginUser
    /// Set the theme for the main Logseq app
    abstract provideTheme: theme: ThemeOptions -> ILSPluginUser
    /// Inject custom css for the main Logseq app
    abstract provideStyle: style: U2<StyleString, StyleOptions> -> ILSPluginUser
    /// Inject custom UI at specific DOM node.
    /// Event handlers can not be passed by string, so you need to create them in `provideModel`
    abstract provideUI: ui: UIOptions -> ILSPluginUser
    abstract useSettingsSchema: schemas: Array<SettingSchemaDesc> -> ILSPluginUser
    abstract updateSettings: attrs: Record<string, obj option> -> unit
    abstract onSettingsChanged: cb: ('T -> 'T -> unit) -> IUserOffHook
    abstract showSettingsUI: unit -> unit
    abstract hideSettingsUI: unit -> unit
    abstract setMainUIAttrs: attrs: Record<string, obj option> -> unit
    /// Set the style for the plugin's UI
    abstract setMainUIInlineStyle: style: CSS.Properties -> unit
    /// show the plugin's UI
    abstract showMainUI: ?opts: ILSPluginUserShowMainUIOpts -> unit
    /// hide the plugin's UI
    abstract hideMainUI: ?opts: ILSPluginUserHideMainUIOpts -> unit
    /// toggle the plugin's UI
    abstract toggleMainUI: unit -> unit
    abstract isMainUIVisible: bool with get, set
    abstract resolveResourceFullUrl: filePath: string -> string
    abstract App: obj with get, set
    abstract Editor: obj with get, set
    abstract DB: IDBProxy with get, set
    abstract Git: IGitProxy with get, set
    abstract UI: IUIProxy with get, set
    abstract FileStorage: LSPluginFileStorage with get, set
    abstract Experiments: LSPluginExperiments with get, set

type [<AllowNullLiteral>] ILSPluginUserShowMainUIOpts =
    abstract autoFocus: bool with get, set

type [<AllowNullLiteral>] ILSPluginUserHideMainUIOpts =
    abstract restoreEditingCursor: bool with get, set

type [<StringEnum>] [<RequireQualifiedAccess>] ThemeOptionsMode =
    | Dark
    | Light

type [<StringEnum>] [<RequireQualifiedAccess>] LSPluginPkgConfigMode =
    | Shadow
    | Iframe

type [<AllowNullLiteral>] LSPluginBaseInfoSettings =
    abstract disabled: bool with get, set
    [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> obj option with get, set

type [<StringEnum>] [<RequireQualifiedAccess>] AppUserConfigsPreferredFormat =
    | Markdown
    | Org

type [<AllowNullLiteral>] BlockEntityMeta =
    abstract timestamps: obj option with get, set
    abstract properties: obj option with get, set
    abstract startPos: float with get, set
    abstract endPos: float with get, set

type [<StringEnum>] [<RequireQualifiedAccess>] SimpleCommandKeybindingMode =
    | Global
    | [<CompiledName "non-editing">] NonEditing
    | Editing

type [<StringEnum>] [<RequireQualifiedAccess>] SettingSchemaDescType =
    | String
    | Number
    | Boolean
    | Enum
    | Object

type [<StringEnum>] [<RequireQualifiedAccess>] SettingSchemaDescInputAs =
    | Color
    | Date
    | [<CompiledName "datetime-local">] DatetimeLocal
    | Range

type [<StringEnum>] [<RequireQualifiedAccess>] SettingSchemaDescEnumPicker =
    | Select
    | Radio
    | Checkbox

type [<AllowNullLiteral>] IAppProxyRegisterCommand =
    abstract key: string with get, set
    abstract label: string with get, set
    abstract desc: string option with get, set
    abstract palette: bool option with get, set
    abstract keybinding: SimpleCommandKeybinding option with get, set

type [<AllowNullLiteral>] IAppProxyRegisterCommandPalette =
    abstract key: string with get, set
    abstract label: string with get, set
    abstract keybinding: SimpleCommandKeybinding option with get, set

type [<StringEnum>] [<RequireQualifiedAccess>] IAppProxyRegisterUIItem =
    | Toolbar
    | Pagebar

type [<AllowNullLiteral>] IAppProxyRegisterUIItem2 =
    abstract key: string with get, set
    abstract template: string with get, set

type [<AllowNullLiteral>] IAppProxyOnThemeModeChangedIUserHook =
    abstract mode: ThemeOptionsMode with get, set

type [<AllowNullLiteral>] IAppProxyOnBlockRendererSlottedIUserSlotHook =
    abstract uuid: BlockUUID with get, set

type [<AllowNullLiteral>] IAppProxyOnMacroRendererSlottedIUserSlotHookPayload =
    abstract arguments: Array<string> with get, set
    abstract uuid: string with get, set
    [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> obj option with get, set

type [<AllowNullLiteral>] IAppProxyOnMacroRendererSlottedIUserSlotHook =
    abstract payload: IAppProxyOnMacroRendererSlottedIUserSlotHookPayload with get, set

type [<AllowNullLiteral>] IAppProxyOnRouteChangedIUserHook =
    abstract path: string with get, set
    abstract template: string with get, set

type [<AllowNullLiteral>] IAppProxyOnSidebarVisibleChangedIUserHook =
    abstract visible: bool with get, set

type [<AllowNullLiteral>] IDBProxyOnChangedIUserHookTxMeta =
    abstract outlinerOp: string with get, set
    [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> obj option with get, set

type [<AllowNullLiteral>] IDBProxyOnChangedIUserHook =
    abstract blocks: Array<BlockEntity> with get, set
    abstract txData: Array<IDatom> with get, set
    abstract txMeta: IDBProxyOnChangedIUserHookTxMeta option with get, set

type [<AllowNullLiteral>] IAssetsProxyListFilesOfCurrentGraphPromise =
    abstract path: string with get, set
    abstract size: float with get, set
    abstract accessTime: float with get, set
    abstract modifiedTime: float with get, set
    abstract changeTime: float with get, set
    abstract birthTime: float with get, set

type [<AllowNullLiteral>] ILSPluginUserReady =
    interface end
