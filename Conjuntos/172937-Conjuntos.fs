 //* ------------------------------------------------ ----------------------
 //* Universidad Politécnica de San Luis Potosí
 //* Ingeniería en Tecnologías de Información
 
 //* Materia: Teoría Computacional
 //* Profesor: Juan Carlos González Ibarra
 //* Nombre: Sergio Owsaldo Lopez Ledezma
 //* Matrícula: 172937
   
 //* Escrito: 12/11/2020
 //* Ultima actualización: 14/09/2020
 //* ------------------------------------------------- --------------------- 

//Define three sets
let A = Set  [1,2,3,4,5] 
let B = Set [3,4,5,6,7] 
let C = Set.empty

printfn "The set is: %O" A
printfn "The set is: %O" B
printfn "The set is: %O" C

//Convertir a un conjunto
let TransformarConj() =
   let ConjuntoA = Set.ofList [1,2,3]
   printfn "The set is: %O" ConjuntoA
   let ConjuntoB = Set.ofList [1,2,3,4,5]
   printfn "The set B is: %O" ConjuntoB

    
//Quitar elementos del conjunto 
let Quitar() = 
    let A = Set [0,1,2,3,4,5,6]
    let A = A.Remove(2)
    printfn "The set after to delete: %O" A
  
//Quitar todos los elementos de un conjunto 
let ClearSet() =
    let A = Set [0,1,2,3,4,5]
    let A = Set.empty
    printfn "The set clear: %O" A

//Copiar conjuntos
let Copiar() =
    let A = Set [1,2,3,4,5]
    let B = A 
    printfn "Set A = %O" A
    printfn "compare set B = %O" B

//Agregar un elementos 
let Agregar() =
    let A = A.Add(987)
    printfn "The new set B = %O" A

//-----------------------Set Operaciones-----------------------------

//Union
let Union() =
    let A = Set [1,2,3,4,5]
    let B = Set [3,4,5,6,7]
    let C = (Set.union A B)
    let D = (A + B)
    printfn "The union Set.union = %O" C
    printfn "The union A + B = %O" D

//Interseccion
let Interseccion() =
    let A = Set [1,2,3,4,5]
    let B = Set [3,4,5,6,7]
    let C = (Set.intersect A B)
    printfn "The intersection = %O" C

//Diferencia
let Diferencia() =
    let A = Set [1,2,3,4,5]
    let B = Set [3,4,5,6,7]
    let C = (Set.difference A B)
    let D = ( A - B )
    printfn "The diference = %O" C
    printfn "The diference = %O" D

//Diferencia Simetrica
let Simetrica() =
    let A = Set [1,2,3,4,5]
    let B = Set [3,4,5,6,7]
    let C = Set.empty
    printfn "Set A: %O" A
    printfn "Set B: %O" B
    printfn "Set C: %O" C
    let D = ((A - B) + (B - A))
    let E = ((B - A) + (A - B))
    let F = ((A - C) + (C - A))
    let G = ((B - C) + (C - B))
    printfn "The symmetric_difference = %O" D
    printfn "The symmetric_difference = %O" E
    printfn "The symmetric_difference = %O" F
    printfn "The symmetric_difference = %O" G

//SubConjuntos
let SubConjuntos() =
    let A = Set [0,1,2,3,4,5,6,7,8,9]
    let B = Set [1,2,3,4,5]
    let C = (B.IsSubsetOf A)
    let D = (A.IsSubsetOf B)
    printfn "The subset = %O" C
    printfn "The subset = %O" D

//SuperConjuntos
let SuperConjuntos() =
    let A = Set [0,1,2,3,4,5,6,7,8,9]
    let B = Set [1,2,3,4,5]
    let C = (B.IsSupersetOf A)
    let D = (A.IsSupersetOf B)
    printfn "The subset = %O" C
    printfn "The subset = %O" D