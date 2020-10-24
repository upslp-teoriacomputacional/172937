 //* ------------------------------------------------ ----------------------
 //* Universidad Politécnica de San Luis Potosí
 //* Ingeniería en Tecnologías de Información
 
 //* Materia: Teoría Computacional
 //* Profesor: Juan Carlos González Ibarra
 //* Nombre: Sergio Owsaldo Lopez Ledezma
 //* Matrícula: 172937
   
 //* Escrito: 22/10/2020
 //* 
 //* ------------------------------------------------- --------------------- 

open System
open System.Text.RegularExpressions

[<EntryPoint>]

    let main argv =

    let mutable tokens = []
    let source_code = "int result = 1;".Split(' ')

for word in source_code do
    if List.exists ((=)word) ["str"; "int"; "bool"] then 
        tokens <- List.append tokens [word]

    elif Regex.IsMatch(word, "[A-Za-z]") then 
        tokens <- List.append tokens [word]

    elif List.exists ((=)word) ["*";"-";"/";"+";"%";"="] then 
        tokens <- List.append tokens [word]

    elif Regex.IsMatch (word,"[0-9]") then 
        if word.[word.Length - 1] = ';' then
            tokens <- List.append tokens [word.[0..(word.Length-2)]]
            tokens <- List.append tokens [";"]
        else
            tokens <- List.append tokens [word]
printfn "%A" tokens 