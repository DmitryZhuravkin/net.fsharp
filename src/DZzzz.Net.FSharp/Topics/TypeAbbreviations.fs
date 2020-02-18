(*

    A type abbreviation is an alias or alternate name for a type. Accessibility of type abbreviations defaults to public.
    
    type [accessibility-modifier] type-abbreviation = type-name
*)

module TypeAbbreviations

// Simple type abbreviation
type SizeType = uint32

// Generic type abbreviation
type Transform<'a> = 'a -> 'a


