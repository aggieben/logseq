module BibleReference

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


    // let abbreviateBookIdOsis = function
    //     | Genesis -> "Gen"
    //     | Exodus -> "Exod"
    //     | Deuteronomy -> "Deut"
    //     | Joshua -> "Josh"
    //     | Judges -> "Judg"
    //     | Samuel1 -> "1Sam"
    //     | Samuel2 -> "2Sam"
    //     | Kings1 -> "1Kgs"
    //     | Kings2 -> "2Kgs"
    //     | Chronicles1 -> "1Chr"
    //     | Chronicles2 -> "2Chr"
    //     | Esther -> "Esth"
    //     | Psalms -> "Ps"
    //     | Proverbs -> "Prov"
    //     | Ecclesiastes -> "Eccl"
    //     | SongOfSolomon -> "Song"
    //     | Ezekiel -> "Ezek"
    //     | Obadiah -> "Obad"
    //     | Jonah -> "Jonah"
    //     | Zephaniah -> "Zeph"
    //     | Zechariah -> "Zech"
    //     | Matthew -> "Matt"
    //     | Corinthians1 -> "1Cor"
    //     | Corinthians2 -> "2Cor"
    //     | Philippians -> "Phil"
    //     | Thessalonians1 -> "1Thess"
    //     | Thessalonians2 -> "2Thess"
    //     | Timothy1 -> "1Tim"
    //     | Timothy2 -> "2Tim"
    //     | Titus -> "Titus"
    //     | Philemon -> "Phlm"
    //     | Peter1 -> "1Pet"
    //     | Peter2 -> "2Pet"
    //     | John1 -> "1John"
    //     | John2 -> "2John"
    //     | John3 -> "3John"


    // with member this.ToString(?format:string) =
    //     match defaultArg format "osis" with
    //     | "osis" ->



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
    Name: string
    VerseMap: Map<int,int>
    Genres: BookGenre[] // first entry considered primary genre
    Author: Author
    Date: BookDate
}

let bibleMap : Map<BookId, Book> option = None

// TODO: pass in bible data as a parameter so as to have pure functions here
let initialize(bibleData:obj) =
    // use whatever bible data is passed to parse and construct the value for bibleMap
    ()

(*
    let parse format =
        // return something useful
*)