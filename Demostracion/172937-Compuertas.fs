 //* ------------------------------------------------ ----------------------
 //* Universidad Politécnica de San Luis Potosí
 //* Ingeniería en Tecnologías de Información
 
 //* Materia: Teoría Computacional
 //* Profesor: Juan Carlos González Ibarra
 //* Nombre: Sergio Oswaldo Lopez Ledezma
 //* Matrícula: 172937
   
 //* Escrito: 22/11/2020
 //* 
 //* ------------------------------------------------- --------------------- 

open System

//Comenzamos creando una lista con los dos posibles valores booleanos, False y True
let booleanos = [false; true]

[<EntryPoint>]

let main argv =

      //TABLA DE VERDAD OR
printfn "   x\t |   y\t| x OR y |"  
printfn "****************************"
for x in booleanos do
    for y in booleanos do
        printfn "%A\t %A\t %A\t" x y (x or y)   //Para este caso en particular, 
printfn "-"                                     //se puede usar el operador "or" como "||"

        //TABLA DE VERDAD AND
printfn "   x\t |   y\t| x AND y |"
printfn "****************************"
for x in booleanos do
    for y in booleanos do
      printfn "%A\t %A\t %A\t" x y (x && y)
printfn "-"   

        //TABLA DE VERDAD NOT
printfn "   x\t |  NOT y |"
printfn "***************************"
for x in booleanos do
    for y in booleanos do
      printfn "%A\t %A\t " x (not x)
printfn "-"   

        //TABLA DE VERDAD ^ (XOR)
printfn "   x\t |   y\t| x XOR y |"
printfn "*****************************"
for x in booleanos do
    for y in booleanos do
      printfn "%A\t %A\t %A\t " x y ((x || y) && not (x && y)) //Para el caso de XOR se creo un operador
printfn "-"                                                    // en donde se realizo el uso de los demas operadores

0