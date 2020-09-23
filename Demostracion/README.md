# TABLAS DE VERDAD F#
La variable x recorrerá la lista booleanos, tomando en la primera iteración el valor False y en la siguiente True. 
Pero, por cada iteración, aparece una nueva variable y que también recorrerá booleanos de izquierda a derecha. 
Así garantizamos que se alcanzan las cuatro combinaciones posibles de x e y.
En la impresión con print, hemos empleado el argumento sep = ‘t’ para que separe cada elemento mediante un tabulador, 
en lugar de usar un espacio en blanco, valor por omisión. Aprecia el uso de la expresión x or y para que muestre el resultado del or.
El resto de las tablas se calcula del mismo modo, simplemente teniendo en cuenta que hay que emplear, naturalmente, 
la expresión lógica adecuada.


## OPERADODES 
<p><li>Operador OR. Si alguno de los dos operandos es distinto de cero, la condición se vuelve verdadera.
<table>
<TR><TD><pre>
    (A || B)
</pre></td></tr>
</table>

<p><li>Operador NOT. Si una condición es verdadera, el operador NOT lógico la convertirá en falsa.
<table>
<TR><TD><pre>
     A (not A)
</pre></td></tr>
</table>

<p><li> Operador AND. Si ambos operandos son distintos de cero, la condición se vuelve verdadera.
<table>
<TR><TD><pre>
    (A && B)
</pre></td></tr>
</table>


## PROBLEMATICA
Para la creación del operador XOR, tuvo que ser necesario la creación de una operación para lograr el resultado correspondiente, en este caso se usaron los diferentes operadores usados anteriormente.  
<table>
<TR><TD><pre>
    A B ((A || B) && not (A && B))
</pre></td></tr>
</table>