open System

let mutable simbolo = ""
let fin = None
let caracter (character:char) :int =
    simbolo <- ""  
    match character with 
    | '0'| '1'| '2'| '3'| '4'| '5'| '6'| '7'| '8'| '9' -> simbolo <- " Digito " ;0
    | '+'| '-'| '*'| '/'  -> simbolo <- "Operador";1
    | ' ' -> 2
    | _ -> 3 

let cuerpo () = 
    printfn "+--------------+---------+-----------+------------------+"

let encabezado () =
    printfn "|Estado Actual | Caracter|  Simbolo  |Estado Siguiente  |"
    cuerpo()

let contenido estadoSiguiente character simbolo estado =
    if estado = 4 then
        printfn "|     %O        |  %O      |%O   |      ERROR       |" estadoSiguiente character simbolo 
    else 
        printfn "|     %O        |  %O      |%O   |       %O          |" estadoSiguiente character simbolo estado

[<EntryPoint>]

let main argv =
    
    let tabla = [ [1;4;4];[4;2;4];[3;4;4];[4;4;5] ]
    
    let mutable estado = 0
    printfn "+-------------------------------------+"
    printfn "|    Ingrese una cadena a evaluar:    |"
    printfn "+-------------------------------------+"
    
    let cadena = Console.ReadLine()
    cuerpo()
    encabezado()
    
    for character in cadena do
        
        let estadoSiguiente = estado
       
        let charcaracter = caracter character
       
        if (charcaracter = 3) then
            printfn "Caracter invalido"
            exit 0
        
        estado <- tabla.[estado].[charcaracter]
       
        if (estado = 4) then
            contenido estadoSiguiente character simbolo estado
            cuerpo()
            printfn "|                Cadena No Valida :(                    |"
            printfn "+--------------+---------+-----------+------------------+"
            exit 0
        
        contenido estadoSiguiente character simbolo estado
        cuerpo()

    if (estado <> 3) then
        printfn "|                Cadena No Valida :(                    |"
        printfn "+--------------+---------+-----------+------------------+"
    
    if (estado = 3) then
        printfn "|     %O        |         |FindeCadena|                  |" estado
        cuerpo()
        printfn "|                    Cadena Valida                      |"
        printfn "+--------------+---------+-----------+------------------+"   
    0 