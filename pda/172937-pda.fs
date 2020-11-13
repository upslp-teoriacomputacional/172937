 //* ------------------------------------------------ ----------------------
 //* Universidad Politécnica de San Luis Potosí
 //* Ingeniería en Tecnologías de Información
 
 //* Materia: Teoría Computacional
 //* Profesor: Juan Carlos González Ibarra
 //* Nombre: Sergio Oswaldo Lopez Ledezma
 //* Matrícula: 172937
   
 //* Escrito: 12/11/2020
 //* 
 //* ------------------------------------------------- --------------------- 

open System
open System.Text.RegularExpressions
let mutable simbolo=""
let mutable FIN=""
let mutable cont=0
let caracter (character):int = 
    simbolo <- "" 
    FIN <- ""
    let mutable a = "a"
    let mutable b= "b"
   
   
    if Regex.IsMatch(character, a) then
        simbolo <- "a"
        0
    elif Regex.IsMatch(character, b) then
        simbolo <- "b"
        cont<-cont+1
        1
    elif character.Equals(FIN) then 
        2
    else 
      
        printfn "|                           Cadena No Valida  %A                                  |"character
        printfn "+---------------+------------+-----------+------------------+---------------------+"
        Environment.Exit 1     
        15
        
let body() = 
    printfn "+---------------+------------+-----------+------------------+---------------------+"

let encabezado() = 
    printfn "|  Edo. Actual  |  Caracter  |  Simbolo  |  Edo. Siguiente  |       Pila          |"
    body()

let contenido (estadosig, character, simbolo,estado,vector) =  
    printfn "|        %A      |     %A     |  %A    |        %A          |  %A   \t   | " estadosig character simbolo estado vector
    body()

        
[<EntryPoint>]
let main argv = 
    let tabla =    [[1;100;100;100];
                    [2;100;100;100];
                    [100;3;100;100];
                    [4;100;100;100];
                    [1;100;100;100];
                    [6;100;100;100];
                    [100;100;7;100];
                    [8;100;100;100];
                    [5;100;100;100];
                    [100;100;100;110];]

    let mutable auxa=0;
    let mutable auxb=0;
    let vector = ResizeArray<char>()
    let mutable estado = 0
    printfn """
     +-------------------------------------+
     |    Ingresa una cadena a evaluar     |
     +-------------------------------------+"""

    let cadena = System.Console.ReadLine() 
    body() 
    encabezado()
    let mutable size=cadena.Length;
    let mutable characte = 0 

    for character in cadena do
        let mutable estadosig = estado 
        characte <- caracter(string character)
        estado <- tabla.[estado].[characte]

        if cont.Equals(0)then
            if estadosig.Equals(1) && not(character.Equals("b")) then
                estado <- 0
            vector.Add(character)
            auxa<-auxa+1

        if estado.Equals(100)  then
            estado<-5               
            auxb<-auxb+1       
            if(auxa-auxb)<0 then
                estado<-100
            else                
                vector.RemoveAt(auxa-auxb)

        if size.Equals(1) then 
            estado<-110 

        if estado.Equals(100) && estadosig.Equals(5)then
            estado<-5
        
        if estado.Equals(6) && estadosig.Equals(5) && not(character.Equals("a")) then       
            printfn "|                              Cadena No Valida                                   |"
            printfn "+---------------+------------+-----------+------------------+---------------------+"
            Environment.Exit 1      
            
        if estado.Equals(110) &&    (character.Equals("a")) then           
            printfn "|                               Cadena No Valida                                  |"
            printfn "+---------------+------------+-----------+------------------+---------------------+"
            Environment.Exit 1   

        if characte < 15   then 
            if estado = 15 then 
                printfn "|        %A      |     %A    |  %A |        %A        |" estadosig character simbolo estado
                body()            
            contenido(estadosig, character, simbolo, estado,vector)     

        if size.Equals(100) || estadosig.Equals(100)  then
            printfn "|                             Cadena No Valida                                    |"
            printfn "+---------------+------------+-----------+------------------+---------------------+"
            if auxa.Equals(auxb)  then   
                printfn "|                             Cadena es valida                                    |"
                printfn "+---------------+------------+-----------+------------------+---------------------+"
            else            
                printfn "|                           Cadena no es valida                                   |"
                printfn "+---------------+------------+-----------+------------------+---------------------+"
            Environment.Exit 1     
        size<-size-1
        if size.Equals(0) || estado.Equals(110) then        
            printfn "|                              Fin de cadena                                      |"
            printfn "+---------------+------------+-----------+------------------+---------------------+"
            if auxa.Equals(auxb)  then
                printfn "|                             Cadena es valida                                    |"
                printfn "+---------------+------------+-----------+------------------+---------------------+"
            else       
                printfn "|                            Cadena no es valida                                  |"
                printfn "+---------------+------------+-----------+------------------+---------------------+"
            vector |> Seq.iter (fun x -> printf "%A;" x)
            Environment.Exit 1   
        
