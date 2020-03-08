# Arreglos Multidimensionales.

#### ¿Qué son?

En pocas palabras podríamos decir que estos no son “arreglos de arreglos”, sino que en realidad son matrices dado que no es posible declarar arreglos dentro de ellos 
como con los escalonados.

#### ¿cómo se declaran?

Como con todos los tipos por referencia podemos usar la palabra reservada "new" para instanciar estos arreglos, aunque esta vez es necesario incluír una coma
" , " para separar las dimensiones en lugar de los corchetes cuadrados de manera consecutiva, es decir si queremos declarar
un arreglo de 2 dimensiones en lugar de usar "[][]" debemos escribirlo de esta manera "[,]" la separacion por coma
indica es nivel 2 o bidimensional y con 3 es tridimensional, asi sucesivamente:

- tipodedato [,] nombrearreglo = new tipodato[,];
ejemplo: 
-int [,] arreglo1 = new arreglo [1,4];

Para este tipo de arreglos siempre es necesario precisar el tamaño de todas las dimensiones, ya que el espacio es asignado durante la asignación.


#### Ejemplo:

supongamos que tenemos un edificio especial de parking de autos, en ese parking de autos guardamos autos de todo tipo hasta colores
para poder identificar exactamente que auto está en cual nivel y en que numero de espacio está ocupando podemos crear un arreglo
multidimensional para acceder a los niveles y ala posicion de dicho auto.
int [,,,] parking = new parking[12,3,14];

#### ejemplo 2: 
Para terminar en cuanto a multidimensionalidad, veamos casos de declaraciones con más de dos dimensiones. 
Para ello supongamos que estamos realizando un “conteo de coches”, es decir, que estamos contando los coches 
que pasan por un determinado lugar en un periodo de tiempo que puede ser un día, varios días, varios meses, etc. 
La forma de declarar esos arrays podría ser la siguiente:
en c 
int[][][]  nc = new  int[24][31][12];
implementar en c#
int [,,,] conteo = new conteo[24,31,12];


