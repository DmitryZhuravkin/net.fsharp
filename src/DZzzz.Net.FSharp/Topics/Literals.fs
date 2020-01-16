namespace DZzzz.Net.FSharp.Topics

(*
    sbyte 	            signed 8-bit integer 	                        y 	                86y, 0b00000101y
    byte 	            unsigned 8-bit natural number 	                uy 	                86uy, 0b00000101uy
    int16 	            signed 16-bit integer 	                        s 	                86s
    uint16 	            unsigned 16-bit natural number 	                us 	                86us
    int, int32 	        signed 32-bit integer 	                        l or none 	        86, 86l
    uint, uint32 	    unsigned 32-bit natural number 	                u or ul 	        86u, 86ul
    nativeint 	        native pointer to a signed natural number 	    n 	                123n
    unativeint 	        native pointer as an unsigned natural number 	un 	                0x00002D3Fun
    int64 	            signed 64-bit integer 	                        L 	                86L
    uint64 	            unsigned 64-bit natural number 	                UL 	                86UL
    single, float32 	32-bit floating point number 	                F or f 	            4.14F or 4.14f
		                                                                lf 	                0x00000000lf
    float; double 	    64-bit floating point number 	                none 	            4.14 or 2.3E+32 or 2.3e+32
		                                                                LF 	                0x0000000000000000LF
    bigint 	            integer not limited to 64-bit representation 	I 	                9999999999999999999999999999I
    decimal 	        fractional number represented as a fixed 
                        point or rational number 	                    M or m 	            0.7833M or 0.7833m


    char 	            Unicode character 	                            none 	            'a' or '\u0061'
    String 	            Unicode string 	                                none 	            "text\n"
                                                                                            @"c:\filename"
                                                                                            """<book title="Paradise Lost">"""
                                                                                            "string1" + "string2"
    byte 	            ASCII character 	                            B 	                'a'B
    byte[] 	            ASCII string 	                                B 	                "text"B
    String or byte[] 	verbatim string 	                            @ prefix 	        @"\\server\share" (Unicode)
                                                                                            @"\\server\share"B (ASCII)
*)


module LiteralsModule =
    // Named literals
    [<Literal>]
    let Literal1 = "a" + "b" // Values that are intended to be constants can be marked with the Literal attribute.

    // _ separator
    let value = 0xDEAD_BEEF
    let valueAsBits = 0b1101_1110_1010_1101_1011_1110_1110_1111
    let exampleSSN = 123_456_7890