module BibleReference

open FSharp.Reflection

type BookId =
    | Genesis
    | Exodus
    | Leviticus
    | Numbers
    | Deuteronomy
    | Joshua
    | Judges
    | Ruth
    | Samuel1
    | Samuel2
    | Kings1
    | Kings2
    | Chronicles1
    | Chronicles2
    | Ezra
    | Nehemiah
    | Esther
    | Job
    | Psalms
    | Proverbs
    | Ecclesiastes
    | SongOfSolomon
    | Isaiah
    | Jeremiah
    | Lamentations
    | Ezekiel
    | Daniel
    | Hosea
    | Joel
    | Amos
    | Obadiah
    | Jonah
    | Micah
    | Nahum
    | Habakkuk
    | Zephaniah
    | Haggai
    | Zechariah
    | Malachi
    | Matthew
    | Mark
    | Luke
    | John
    | Acts
    | Romans
    | Corinthians1
    | Corinthians2
    | Galatians
    | Ephesians
    | Philippians
    | Colossians
    | Thessalonians1
    | Thessalonians2
    | Timothy1
    | Timothy2
    | Titus
    | Philemon
    | Hebrews
    | James
    | Peter1
    | Peter2
    | John1
    | John2
    | John3
    | Jude
    | Revelation

let private abbreviateBookIdOsis = function
    | Genesis -> "Gen"
    | Exodus -> "Exod"
    | Leviticus -> "Lev"
    | Numbers -> "Num"
    | Deuteronomy -> "Deut"
    | Joshua -> "Josh"
    | Judges -> "Judg"
    | Ruth -> "Ruth"
    | Samuel1 -> "1Sam"
    | Samuel2 -> "2Sam"
    | Kings1 -> "1Kgs"
    | Kings2 -> "2Kgs"
    | Chronicles1 -> "1Chr"
    | Chronicles2 -> "2Chr"
    | Ezra -> "Ezra"
    | Nehemiah -> "Neh"
    | Esther -> "Esth"
    | Job -> "Job"
    | Psalms -> "Ps"
    | Proverbs -> "Prov"
    | Ecclesiastes -> "Eccl"
    | SongOfSolomon -> "Song"
    | Isaiah -> "Isa"
    | Jeremiah -> "Jer"
    | Lamentations -> "Lam"
    | Ezekiel -> "Ezek"
    | Daniel -> "Dan"
    | Hosea -> "Hos"
    | Joel -> "Joel"
    | Amos -> "Amos"
    | Obadiah -> "Obad"
    | Jonah -> "Jonah"
    | Micah -> "Mic"
    | Nahum -> "Nah"
    | Habakkuk -> "Hab"
    | Zephaniah -> "Zeph"
    | Haggai -> "Hag"
    | Zechariah -> "Zech"
    | Malachi -> "Mal"
    | Matthew -> "Matt"
    | Mark -> "Mark"
    | Luke -> "Luke"
    | John -> "John"
    | Acts -> "Acts"
    | Romans -> "Rom"
    | Corinthians1 -> "1Cor"
    | Corinthians2 -> "2Cor"
    | Galatians -> "Gal"
    | Ephesians -> "Eph"
    | Philippians -> "Phil"
    | Colossians -> "Col"
    | Thessalonians1 -> "1Thess"
    | Thessalonians2 -> "2Thess"
    | Timothy1 -> "1Tim"
    | Timothy2 -> "2Tim"
    | Titus -> "Titus"
    | Philemon -> "Phlm"
    | Hebrews -> "Heb"
    | James -> "Jam"
    | Peter1 -> "1Pet"
    | Peter2 -> "2Pet"
    | John1 -> "1John"
    | John2 -> "2John"
    | John3 -> "3John"
    | Jude -> "Jude"
    | Revelation -> "Rev"

let private _bookIdReverseMap = 
    [ "Genesis", Genesis; "Exodus", Exodus; "Leviticus", Leviticus; "Numbers", Numbers; "Deuteronomy", Deuteronomy; "Joshua", Joshua; "Judges", Judges
      "Ruth", Ruth; "1 Samuel", Samuel1; "2 Samuel", Samuel2; "1 Kings", Kings1; "2 Kings", Kings2; "1 Chronicles", Chronicles1; "2 Chronicles", Chronicles2
      "Ezra", Ezra; "Nehemiah", Nehemiah; "Esther", Esther; "Job", Job; "Psalms", Psalms; "Proverbs", Proverbs; "Ecclesiastes", Ecclesiastes
      "Song of Solomon", SongOfSolomon; "Isaiah", Isaiah; "Jeremiah", Jeremiah; "Lamentations", Lamentations; "Ezekiel", Ezekiel; "Daniel", Daniel
      "Hosea", Hosea; "Joel", Joel; "Amos", Amos; "Obadiah", Obadiah; "Jonah", Jonah; "Micah", Micah; "Nahum", Nahum; "Habakkuk", Habakkuk
      "Zephaniah", Zephaniah; "Haggai", Haggai; "Zechariah", Zechariah; "Malachi", Malachi; "Matthew", Matthew; "Mark", Mark
      "Luke", Luke; "John", John; "Acts", Acts; "Romans", Romans; "1 Corinthians", Corinthians1; "2 Corinthians", Corinthians2
      "Galatians", Galatians; "Ephesians", Ephesians; "Philippians", Philippians; "Colossians", Colossians; 
      "1 Thessalonians", Thessalonians1; "2 Thessalonians", Thessalonians2; "1 Timothy", Timothy1; "2 Timothy", Timothy2; "Titus", Titus
      "Philemon", Philemon; "Hebrews", Hebrews; "James", James; "1 Peter", Peter1; "2 Peter", Peter2; "1 John", John1; "2 John", John2
      "3 John", John3; "Jude", Jude; "Revelation", Revelation ]

type BookId
    with 
        member this.ToString(?format:string) =
            match defaultArg format "o" with
            | "o" -> abbreviateBookIdOsis this
            | _ -> nameof this

        static member TryParse(bookTag:string) =
            _bookIdReverseMap
            |> List.choose (fun (name,id) -> 
                                if name.StartsWith(bookTag, System.StringComparison.InvariantCultureIgnoreCase)
                                then Some id
                                else None)
            |> List.tryExactlyOne

type BookGenre =
    | Narrative
    | Law
    | Poetry
    | Wisdom
    | Prophecy
    | Gospel
    | Epistle
    | Apocalypse

type Provenance =
    | SelfIdentified
    | Historic
    | Tradition
    | Speculative
    | Unknown

type Author = {
    Name: string option
    Provenance: Provenance
}

type BookDate = {
    Year: int
    Provenance: Provenance
}

type Book = {
    Id: BookId
    Map: int[]
    // Genres: BookGenre[] // first entry considered primary genre
    // Author: Author
    // Date: BookDate
}

let bibleMap : Map<BookId, Book> = 
    [
        (Genesis, { Id = Genesis
                    Map = [|31;25;24;26;32;22;24;22;29;32;32;20;18;24;21;16;27;33;38;18;34;24;20;67;34;35;46;22;35;43;55;32;20;31;29;43;36;30;23;23;57;38;34;34;28;34;31;22;33;26|] })
        (Exodus, { Id = Exodus
                   Map = [|22;25;22;31;23;30;25;32;35;29;10;51;22;31;27;36;16;27;25;26;36;31;33;18;40;37;21;43;46;38;18;35;23;35;35;38;29;31;43;38|]})
        (Leviticus, { Id = Leviticus
                      Map = [|17;16;17;35;19;30;38;36;24;20;47;8;59;57;33;34;16;30;37;27;24;33;44;23;55;46;34|]})
        (Numbers, { Id = Numbers
                    Map = [|54;34;51;49;31;27;89;26;23;36;35;16;33;45;41;50;13;32;22;29;35;41;30;25;18;65;23;31;40;16;54;42;56;29;34;13|]})
        (Deuteronomy, { Id = Deuteronomy
                        Map = [|46;37;29;49;33;25;26;20;29;22;32;32;18;29;23;22;20;22;21;20;23;30;25;22;19;19;26;68;29;20;30;52;29;12|]})
        (Joshua, { Id = Joshua
                   Map = [|18;24;17;24;15;27;26;35;27;43;23;24;33;15;63;10;18;28;51;9;45;34;16;33|]})
        (Judges, { Id = Judges
                   Map = [|36;23;31;24;31;40;25;35;57;18;40;15;25;20;20;31;13;31;30;48;25|]})
        (Ruth, { Id = Ruth
                 Map = [|22;23;18;22|]})
        (Samuel1, { Id = Samuel1
                    Map = [|28;36;21;22;12;21;17;22;27;27;15;25;23;52;35;23;58;30;24;42;15;23;29;22;44;25;12;25;11;31;13|]})
        (Samuel2, { Id = Samuel2
                    Map = [|27;32;39;12;25;23;29;18;13;19;27;31;39;33;37;23;29;33;43;26;22;51;39;25|]})
        (Kings1, { Id = Kings1
                   Map = [|53;46;28;34;18;38;51;66;28;29;43;33;34;31;34;34;24;46;21;43;29;53|]})
        (Kings2, { Id = Kings2
                   Map = [|18;25;27;44;27;33;20;29;37;36;21;21;25;29;38;20;41;37;37;21;26;20;37;20;30|]})
        (Chronicles1, { Id = Chronicles1
                        Map = [|54;55;24;43;26;81;40;40;44;14;47;40;14;17;29;43;27;17;19;8;30;19;32;31;31;32;34;21;30|]})
        (Chronicles2, { Id = Chronicles2
                        Map = [|17;18;17;22;14;42;22;18;31;19;23;16;22;15;19;14;19;34;11;37;20;12;21;27;28;23;9;27;36;27;21;33;25;33;27;23|]})
        (Ezra, { Id = Ezra
                 Map = [|11;70;13;24;17;22;28;36;15;44|]})
        (Nehemiah, { Id = Nehemiah
                     Map = [|11;20;32;23;19;19;73;18;38;39;36;47;31|]})
        (Esther, { Id = Esther
                   Map = [|22;23;15;17;14;14;10;17;32;3|]})
        (Job, { Id = Job
                Map = [|22;13;26;21;27;30;21;22;35;22;20;25;28;22;35;22;16;21;29;29;34;30;17;25;6;14;23;28;25;31;40;22;33;37;16;33;24;41;30;24;34;17|]})
        (Psalms, { Id = Psalms
                   Map = [|6;12;8;8;12;10;17;9;20;18;7;8;6;7;5;11;15;50;14;9;13;31;6;10;22;12;14;9;11;12;24;11;22;22;28;12;40;22;13;17;13;11;5;26;17;11;9;14;20;23;19;9;6;7;23;13;11;11;17;12;8;12;11;10;13;20;7;35;36;5;24;20;28;23;10;12;20;72;13;19;16;8;18;12;13;17;7;18;52;17;16;15;5;23;11;13;12;9;9;5;8;28;22;35;45;48;43;13;31;7;10;10;9;8;18;19;2;29;176;7;8;9;4;8;5;6;5;6;8;8;3;18;3;3;21;26;9;8;24;13;10;7;12;15;21;10;20;14;9;6|]})
        (Proverbs, { Id = Proverbs
                     Map = [|33;22;35;27;23;35;27;36;18;32;31;28;25;35;33;33;28;24;29;30;31;29;35;34;28;28;27;28;27;33;31|]})
        (Ecclesiastes, { Id = Ecclesiastes
                         Map = [|18;26;22;16;20;12;29;17;18;20;10;14|]})
        (SongOfSolomon, { Id = SongOfSolomon
                          Map = [|17;17;11;16;16;13;13;14|]})
        (Isaiah, { Id = Isaiah
                   Map = [|31;22;26;6;30;13;25;22;21;34;16;6;22;32;9;14;14;7;25;6;17;25;18;23;12;21;13;29;24;33;9;20;24;17;10;22;38;22;8;31;29;25;28;28;25;13;15;22;26;11;23;15;12;17;13;12;21;14;21;22;11;12;19;12;25;24|]} )
        (Jeremiah, { Id = Jeremiah
                     Map = [|19;37;25;31;31;30;34;22;26;25;23;17;27;22;21;21;27;23;15;18;14;30;40;10;38;24;22;17;32;24;40;44;26;22;19;32;21;28;18;16;18;22;13;30;5;28;7;47;39;46;64;34|]})
        (Lamentations, { Id = Lamentations
                         Map = [|22;22;66;22;22|]})
        (Ezekiel, { Id = Ezekiel
                    Map = [|28;10;27;17;17;14;27;18;11;22;25;28;23;23;8;63;24;32;14;49;32;31;49;27;17;21;36;26;21;26;18;32;33;31;15;38;28;23;29;49;26;20;27;31;25;24;23;35|]})
        (Daniel, { Id = Daniel
                   Map = [|21;49;30;37;31;28;28;27;27;21;45;13|]})
        (Hosea, { Id = Hosea
                  Map = [|11;23;5;19;15;11;16;14;17;15;12;14;16;9|]})
        (Joel, { Id = Joel
                 Map = [|20;32;21|]})
        (Amos, { Id = Amos
                 Map = [|15;16;15;13;27;14;17;14;15|]})
        (Obadiah, { Id = Obadiah
                    Map = [|21|]})
        (Jonah, { Id = Jonah
                  Map = [|17;10;10;11|]})
        (Micah, { Id = Micah
                  Map = [|16;13;12;13;15;16;20|]})
        (Nahum, { Id = Nahum
                  Map = [|15;13;19|]})
        (Habakkuk, { Id = Habakkuk
                     Map = [|17;20;19|]})
        (Zephaniah, { Id = Zephaniah
                      Map = [|18;15;20|]})
        (Haggai, { Id = Haggai
                   Map = [|15;23|]})
        (Zechariah, { Id = Zechariah
                      Map = [|21;13;10;14;11;15;14;23;17;12;17;14;9;21|]})
        (Malachi, { Id = Malachi
                    Map = [|14;17;18;6|]})
        (Matthew, { Id = Matthew
                    Map = [|25;23;17;25;48;34;29;34;38;42;30;50;58;36;39;28;27;35;30;34;46;46;39;51;46;75;66;20|]})
        (Mark, { Id = Mark
                 Map = [|45;28;35;41;43;56;37;38;50;52;33;44;37;72;47;20|]})
        (Luke, { Id = Luke
                 Map = [|80;52;38;44;39;49;50;56;62;42;54;59;35;35;32;31;37;43;48;47;38;71;56;53|]})
        (John, { Id = John
                 Map = [|51;25;36;54;47;71;53;59;41;42;57;50;38;31;27;33;26;40;42;31;25|]})
        (Acts, { Id = Acts
                 Map = [|26;47;26;37;42;15;60;40;43;48;30;25;52;28;41;40;34;28;41;38;40;30;35;27;27;32;44;31|]})
        (Romans, { Id = Romans
                   Map = [|32;29;31;25;21;23;25;39;33;21;36;21;14;23;33;27|]})
        (Corinthians1, { Id = Corinthians1
                         Map = [|31;16;23;21;13;20;40;13;27;33;34;31;13;40;58;24|]})
        (Corinthians2, { Id = Corinthians2
                         Map = [|24;17;18;18;21;18;16;24;15;18;33;21;14|]})
        (Galatians, { Id = Galatians
                      Map = [|24;21;29;31;26;18|]})
        (Ephesians, { Id = Ephesians
                      Map = [|23;22;21;32;33;24|]})
        (Philippians, { Id = Philippians
                        Map = [|30;30;21;23|]})
        (Colossians, { Id = Colossians
                       Map = [|29;23;25;18|]})
        (Thessalonians1, { Id = Thessalonians1
                           Map = [|10;20;13;18;28|]})
        (Thessalonians2, { Id = Thessalonians2
                           Map = [|12;17;18|]})
        (Timothy1, { Id = Timothy1
                     Map = [|20;15;16;16;25;21|]})
        (Timothy2, { Id = Timothy2
                     Map = [|18;26;17;22|]})
        (Titus, { Id = Titus
                  Map = [|16;15;15|]})
        (Philemon, { Id = Philemon
                     Map = [|25|]})
        (Hebrews, { Id = Hebrews
                    Map = [|14;18;19;16;14;20;28;13;28;39;40;29;25|]})
        (James, { Id = James
                  Map = [|27;26;18;17;20|]})
        (Peter1, { Id = Peter1
                   Map = [|25;25;22;19;14|]})
        (Peter2, { Id = Peter2
                   Map = [|21;22;18|]})
        (John1, { Id = John1
                  Map = [|10;29;24;21;21|]})
        (John2, { Id = John2
                  Map = [|13|]})
        (John3, { Id = John3
                  Map = [|14|]})
        (Jude, { Id = Jude
                 Map = [|25|]})
        (Revelation, { Id = Revelation
                       Map = [|20;29;22;11;14;17;17;13;21;11;19;17;18;20;8;21;18;24;21;15;27;21|]})
    ] 
    |> Map.ofList

open FSharp.Text.RegexProvider

type private SingleBookReferenceRx = Regex< @"(?'BookTag'[A-Za-z]+)(?'Chapter'[0-9]+)(?:[.:](?'StartVerse'[0-9]+)(?:-(?'EndVerse'[0-9]+))?)?" >
let parse reference =
    let rxMatch = SingleBookReferenceRx().TypedMatch(reference)
    let bookIdOpt = BookId.TryParse(rxMatch.BookTag.Value)
    match bookIdOpt with
    | None -> None
    | Some bookId ->
        Some ()

(*
    let parse format =
        // return something useful
*)