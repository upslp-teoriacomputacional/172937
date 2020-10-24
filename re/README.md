## Programación expresiones regulares 
### Importancia de los lenguajes regulares.
  <li>
    La existencia y formalización de los lenguajes regulares (LR) y su vinculación con otros artefactos lingüísticos-matemáticos ya bien formalizados, estudiados e incluso llevados a la práctica ha sido de vital importancia en el ulterior desarrollo de los mecanismos de procesamiento de lenguajes de computadora, fundamentalmente en los analizadores lexicográficos gracias a la posibilidad de derivar el reconocimiento de los LR mediante autómatas finitos que son fáciles de implementar computacionalmente con mecanismos simples y rápidos, óptimos en la obtención de parsers veloces y robustos que a su vez le ofrecen a los desarrolladores información detallada de los errores léxicos, sintácticos e incluso advierten sobre errores semánticos.
    Lo mismo sucede por ejemplo con las expresiones regulares implementadas ya en muchos Lenguaje de programación de propósito general modernos que permiten a los desarrolladores de lenguajes mecanismos muy eficientes para la obtención intuitiva de partes de compiladores que reconocen los tókenes o partículas lexicales del código fuente como fase del proceso completo de interpretación o compilado, según sea el caso.
    A manera de ilustración en el caso del ejemplo anterior vemos la siguiente función Python que a partir de cualquiera de los elementos formalizadores del LR correspondiente permite decidir si un texto w es una variable PROLOG:  
</li>
  
<p> </p>
    Varias funciones de esa naturaleza componen los analizadores lexicográficos para discriminar la función de cada token del lenguaje en cuestión: constante númerica, literal de cadena de texto, identificador, separador, etc.; según sea el caso.      
    Y también puede verse que existe una estrecha relación en cómo implementar las funciones reconocedoras de LR y la expresión o la gramática regulares o el autómata finito correspondiente, al punto que desde hace más de 3 décadas existen aplicaciones generadoras de analizadores lexicográficos como el Flex o el Bisonte.
    Pero el alcance de los LR no se queda en el mundo de la compilación de lenguajes de ordenador como se ve en el siguiente ejemplo.
<p> </p>

## Programación generadora gramática regular

<p> </p>

<ol>
    Analizador léxico simple
    Ejemplo#
    En este ejemplo, te mostraré cómo hacer un lexer básico que creará los tokens para una declaración de variable.
    ¿Qué hace el analizador léxico?
    El propósito de un lexer (analizador léxico) es escanear el código fuente y dividir cada palabra en un elemento de la lista. Una vez hecho esto, toma estas palabras y crea un par de tipo y valor que se parece a esto ['INTEGER', '178'] para formar un token.
    Estos tokens se crean para identificar la sintaxis de su idioma, por lo que todo el objetivo del lexer es crear la sintaxis de su idioma, ya que todo depende de cómo desee identificar e interpretar los diferentes elementos.
</ol>