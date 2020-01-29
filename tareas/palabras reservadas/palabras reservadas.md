# PALABRAS  RESERVADAS PARA C#

#### Abtract:*
El modificador abstract indica que el elemento objeto de la modificación tiene una implementación incompleta
 o que le falta una implementación. .El modificador abstract se puede usar con clases,
 métodos, propiedades, indizadores y eventos*

#### Base:*

La palabra clave base se utiliza para obtener acceso a los miembros de la clase base desde una clase derivada*

#### As:*

Puede utilizar el operador de as para realizar algunos tipos de conversiones entre los tipos de referencia
 compatibles o tipos que aceptan valores NULL.*

#### Bool:*

La palabra clave bool es un alias de System.Boolean.Se utiliza para declarar variables que almacenan los valores
booleanos, true y false.*

#### Break:*

La instrucción break permite terminar el bucle envolvente más cercano o la instrucción switch en la cual aparece. 
El control se transfiere a la instrucción que sigue a la instrucción terminada, si existe alguna.*

#### Byte:*

La palabra clave byte denota un tipo entero que almacena valores.*

#### Switch:*

La instrucción switch es una instrucción de control que selecciona una sección switch para ejecutarla desde
una lista de candidatos.*

#### Try-Catch:*

La instrucción try-catch consta de un bloque try seguido de una o más cláusulas catch que especifican controladores
para diferentes excepciones.*

#### Char:*

La palabra clave de char se utiliza para declarar una instancia de la estructura de System.Char que .NET Framework
 utiliza para representar un carácter Unicode.El valor de un objeto de Char es un valor (ordinal) numérico de 16 bits.*

#### Cheked:*

La palabra clave checked se usa con el fin de habilitar explícitamente la comprobación de desbordamiento para operaciones
aritméticas y conversiones de tipo integral.*

#### Class:

Las clases se declaran mediante la palabra clave class.*

####Const:*

La palabra clave const se usa para declarar un campo constante o una local constante.Los campos y locales constantes
 no son variables y no se pueden modificar.Las constantes pueden ser números, valores booleanos, cadenas o una 
referencia nula.No cree una constante para representar información que esperas que cambie en algún momento.*

#### Continue:*

La instrucción de continue pasa el control a la siguiente iteración de mientras que agrega, de haga, de para,
o la instrucción de foreach en la que aparece.*
#### Decimal:*

La palabra clave decimal indica un tipo de datos de 128 bits.Comparado con los tipos de punto flotante,
el tipo decimal tiene una mayor precisión y un intervalo más reducido, lo que lo hace adecuado para los
cálculos financieros y monetario.*

#### Defaul:*

La palabra clave default se puede utilizar en la instrucción switch o en código genérico.*

#### Do:*

La instrucción do ejecuta una instrucción o un bloque de instrucciones repetidamente hasta
 que una determinada expresión se evalúa como false.El cuerpo del bucle se debe incluir 
entre llaves, {}, a menos que esté compuesto por una sola instrucción.En ese caso, las llaves son opcionales.*

#### Double:*

La palabra clave double denota un tipo simple que almacena valores de punto flotante de 64 bits.La siguiente tabla
muestra la precisión y el intervalo de valores aproximado para el tipo double.*

#### If-Else:*

Una instrucción if identifica que sentencia se tiene que ejecutar en función del valor de una expresión Boolean.
En el ejemplo siguiente, la variable Booleanresult se establece en true y, a continuación, se comprueba en la
instrucción if.La salida es The condition is true.*

#### Enum:*

La palabra clave enum se utiliza para declarar una enumeración, un tipo distinto que consiste en un conjunto 
de constantes con nombre denominado lista de enumeradores.*

#### Event:*

La palabra clave event se utiliza para declarar un evento en una clase de editor.*

#### Explicit:*

La palabra clave explicit declara un operador de conversión de tipos definido por el usuario que se debe 
invocar con una conversión de tipos. Por ejemplo, este operador convierte una clase denominada Fahrenheit
en una clase denominada Celsius.*

#### Extern:*

El modificador extern se usa para declarar un método que se implementa externamente. Un uso común del 
modificador extern es con el atributo DllImport al usar servicios de interoperabilidad para llamar a código
 no administrado. En este caso, el método se debe declarar también como static.*

#### Try-Finally:*

Utilizando un bloque finally, puede limpiar los recursos que se asignan en un bloque try, y puede ejecutar
código incluso si se produce una excepción en el bloque try.Normalmente, las instrucciones de un bloque 
finally se ejecuta cuando el control sale de una instrucción try.La transferencia del control puede producirse 
como resultado de la ejecución normal, de la ejecución de la instrucción break, continue, goto o return,
o de la propagación de una excepción fuera de la instrucción try.*

#### Fixed:*

La instrucción fixed evita que el recolector de elementos no utilizados vuelva a ubicar una variable móvil.
La instrucción fixed solo se permite en un contexto no seguro. Fixed también se puede utilizar para crear 
búferes de tamaño fijo.*

#### Float:*

La palabra clave float denota un tipo simple que almacena valores de punto flotante de 32 bits. La siguiente
tabla muestra la precisión y el intervalo de valores aproximado para el tipo float.*

#### In:*

En los parámetros de tipo genérico, la palabra clave in especifica que el parámetro 
de tipo es contravariante.Puede usar la palabra clave in en delegados e interfaces genéricos.*

#### For:*

Mediante un bucle for , puede ejecutar una instrucción o un bloque de instrucciones varias veces hasta que
una expresión especificada se evalúe con false.Esta clase de bucle es útil para recorrer en iteración las
matrices y para otras aplicaciones en las que se sabe de antemano cuántas veces se desea el bucle para recorrer.*

#### Foreach:*

La instrucción foreach repite un grupo de instrucciones incrustadas para cada elemento de una matriz o colección
de objetos que implementa la interfaz System.Collections.IEnumerable o System.Collections.Generic.IEnumerable<T>.
La instrucción foreach se utiliza para recorrer la colección en iteración y obtener la información deseada, pero no
se puede utilizar para agregar o quitar elementos de la colección de origen, ya que se pueden producir efectos
secundarios imprevisibles.Si necesita agregar o quitar elementos de la colección de origen, utilice un bucle for.*

#### Goto:*

La instrucción goto transfiere el control del programa directamente a una instrucción identificada por una etiqueta.
Un uso habitual de goto consiste en transferir el control a una etiqueta switch-case específica o a la etiqueta 
predeterminada de una instrucción switch.*

#### Impiclit:*

La palabra clave implicit se utiliza para declarar un operador de conversión de tipo implícito definido por el
usuario.Utilícela para permitir conversiones implícitas entre un tipo definido por el usuario y otro tipo, si
existen garantías de que la conversión no provocará la pérdida de datos.*

#### Int:*

La palabra clave int denota un tipo entero que almacena valores según el tamaño.*

### Interface:*

Una interfaz sólo contiene las declaraciones de métodos, propiedades, eventos o indizadores. Una clase o struct 
que implemente la interfaz debe implementar los miembros de la interfaz que se especifican en la definición de 
interfaz.En el ejemplo siguiente, la clase ImplementationClass debe implementar un método denominado SampleMethod
que no tiene ningún parámetro y devuelve void.*

#### Internal:*

La palabra clave internal es modificador de acceso para los tipos y miembros de tipo.Los tipos o miembros internos
sólo son accesibles dentro de los archivos del mismo ensamblado.*

#### Is:*

Comprueba si un objeto es compatible con un tipo determinado.Por ejemplo, el código siguiente puede determinar si
un objeto es una instancia del tipo MyObject o un tipo que se deriva de MyObject.*

#### Lock:*

La palabra clave lock marca un bloque de instrucciones como una sección crucial, para lo cual utiliza el bloqueo 
de exclusión mutua de un objeto, la ejecución de una instrucción y, posteriormente, la liberación del bloqueo.*

#### Long:*

La palabra clave long denota un tipo entero que almacena valores según el tamaño.*

#### Namespace:
La palabra clave namespace se utiliza para declarar un ámbito que contiene un conjunto de objetos relacionados.
Puede utilizar un espacio de nombres para organizar elementos de código y crear tipos globales únicos.*

#### New:*

En C#, la palabra clave new se puede utilizar como operador, modificador o restricción.*

#### Null:*

La palabra clave null es un literal que representa una referencia nula, es decir, que no apunta a ningún objeto.
null es el valor predeterminado de variables de tipo referencia.Los tipos de valor normales no pueden ser null.
Sin embargo, en C# 2.0 se introdujeron los tipos de valor que aceptan valores NULL.*

#### Object:*

El tipo object es un alias de Object en .NET Framework.En el sistema de tipos unificado de C#, todos los tipos
(tipos de valor y de referencia predefinidos y definidos por el usuario) se heredan directa o indirectamente de Object.*

#### Operator:*

Utilice la palabra clave operator para sobrecargar un operador integrado o proporcionar una conversión definida por
 el usuario en una declaración de clase o struct.*

#### Out:*

Puede utilizar la palabra clave contextual out en dos contextos (cada uno es un vínculo a información detallada),
como un modificador de parámetro o en las declaraciones de parámetro de tipo genérico en interfaces y delegados.*

#### Override:*

El modificador override es necesario para ampliar o modificar la implementación abstracta o virtual de un método,
propiedad, indizador o evento heredado.*

#### Params:*

Usando la palabra clave params, puede especificar un parámetro de método que acepta un número variable de argumentos.*

#### Puede enviar una lista separada por comas de argumentos del tipo especificado en la declaración de parámetro o en
una matriz de argumentos del tipo especificado. También puede no enviar ningún argumento. Si no se envía ningún argumento,
la longitud de la lista de params es cero.*

#### Private:*

La palabra clave private es un modificador de acceso de miembros. El acceso de tipo private corresponde al nivel
de acceso más restrictivo. Los miembros privados sólo son accesibles dentro del cuerpo de la clase o struct en 
los que se declaran.*

#### Protected:*

La palabra clave protected es un modificador de acceso a miembros. Un miembro protegido es accesible dentro de 
su clase y por instancias de clases derivadas. Encontrará una comparación de protected con los otros modificadores
de acceso en Niveles de accesibilidad.*

#### Public:*

La palabra clave public es un modificador de acceso para tipos y miembros de tipos. El acceso de tipo public corresponde
 al nivel de acceso menos restrictivo. No existen restricciones para obtener acceso a los miembros públicos.*

#### Readondly:*

La palabra clave readonly corresponde a un modificador que se puede utilizar en campos. Cuando una declaración 
de campo incluye un modificador readonly, las asignaciones a los campos que aparecen en la declaración sólo pueden
tener lugar en la propia declaración o en un constructor de la misma clase.*

#### Ref:*

La palabra clave ref hace que un argumento se pase por referencia, no por valor. El efecto de pasar por referencia
es que cualquier cambio del parámetro en el método llamado se refleja en el método de llamada.*

#### Return:*

La instrucción return termina la ejecución del método en el que aparece y devuelve el control al método que
realizó la llamada.También puede devolver un valor opcional. Si el método es del tipo void, la instrucción return
se puede omitir.*

#### Sealed:*

El modificador sealed, cuando se aplica a una clase, impide que otras clases se hereden de él. En el ejemplo 
siguiente, la clase B se hereda de la clase A, pero no es posible heredar ninguna clase de la clase B.*

#### Short:*

La palabra clave short denota un tipo de datos integral que almacena valores según el tamaño.*

#### Sizeof:*

Se usa para obtener el tamaño en bytes de un tipo no administrado.*

#### Stackalloc*

La palabra clave stackalloc se utiliza en un contexto de código no seguro para asignar un bloque de memoria en la pila.*

#### Static:*

Utilice el modificador static para declarar un miembro estático, que pertenece al propio tipo en vez de a un objeto
específico.*

#### String:*

El tipo string representa una secuencia de cero o más caracteres Unicode. string es un alias de String en .NET Framework.*

#### Struct:*

Un tipo struct es un tipo de valor que normalmente se usa para encapsular pequeños grupos de variables relacionadas,
como las coordenadas de un rectángulo o las características de un elemento en un inventario.*

#### This:*

La palabra clave this hace referencia a la instancia actual de la clase y también se utiliza como modificador del
primer parámetro de un método de extensión.*

#### Throw:*

La instrucción throw se usa para indicar una situación anómala (excepción) durante la ejecución del programa.*

#### Unsafe:*

La palabra clave unsafe denota un contexto no seguro, que es necesario para cualquier operación que involucre a punteros.*

#### Ushort:*

La palabra clave ushort indica un tipo de datos integral que almacena valores según el tamaño y el intervalo.*

#### Using:*

La palabra clave using tiene dos usos principales:*
Como directiva, cuando se utiliza para crear un alias para un espacio de nombres o para importar tipos definidos
en otros espacios de nombres.Vea Directiva using. Como instrucción, cuando define un ámbito al final del cual el
objeto se destruye.*

#### Virtual:*

La palabra clave virtual se utiliza para modificar un método, propiedad, indizador o declaración de evento y permite
invalidar cualquiera de estos elementos en una clase derivada. Por ejemplo, éste método puede ser sobrescrito por
cualquier clase que lo herede.*

#### Void:*

Cuando se utiliza como tipo de valor devuelto para un método, void especifica que el método no devuelve un valor.*
void no se permite en la lista de parámetros de un método. Un método que no utiliza parámetros y que no devuelve 
ningún valor.*

#### Volatile:*

La palabra clave volatile indica que varios subprocesos que se ejecutan a la vez podrían modificar un campo.
Los campos que se declaran como volatile no están sujetos a optimizaciones del compilador que suponen el acceso
por un subproceso único. Esto garantiza que el valor más actualizado está en todo momento presente en el campo.*
#### While:*

La instrucción while ejecuta una instrucción o un bloque de instrucciones repetidamente hasta que una expresión
especificada se evalúa como false.*

#### ¿QUE ES UNA SOLUCION?*

No se tiene una definicion especifica de solucion, pero podría definirse como un conjunto de programas utilizados para lanzar
un ejecutable en un programa, una solucion pude contener muchos programas y librerias.
