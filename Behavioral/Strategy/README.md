# Strategy 
El patrón Estrategia (Strategy) es un patrón de diseño para el desarrollo de software. Se clasifica como patrón de comportamiento porque determina cómo se debe realizar el intercambio de mensajes entre diferentes objetos para resolver una tarea. El patrón estrategia permite mantener un conjunto de algoritmos de entre los cuales el objeto cliente puede elegir aquel que le conviene e intercambiarlo dinámicamente según sus necesidades.

- Se forma con una familia de algoritmos que están encapsulados.
- Es el uso puro del polimorfismo de programación orientada a objetos.
- El cliente selecciona que algoritmo utilizar.
- El objetivo es hacer esos algoritmos intercambiables y el mejor para cada caso.
- Si tenemos un programa que provee una funcionalidad pero existen varias formas de llevarla a cabo, se puede usar strategy.
- Puede hacerse vía herencia o con implmentación de interfaz.

### Diagrama
El siguiente diagrama muestra como un cliente consume a travez de una interfaz, un algoritmo definido sin conocer la verdadera implmentación.

##### Partes importantes
- Contexto: Una clase que contiene la infromación de contexto del contexto sobre ela cual trabajaran los algoritmos.
- Interface: Define la interfaz común a todas las estrategias(algoritmos).
- Estrategia n: Implmentación de un algoritmo en particular.

![Strategy Diagram](https://github.com/fercala/Design-patterns/blob/master/Behavioral/Strategy/Strategy%20Diagram.png?raw=true)

Esto permite un desacoplameiento y de esta manera que sea mas facil de manter en el tiempo.
También permite que puedan realizarse distintas estrategias de algoritmos para distintas sitauaciones y con un simple cambio de instancia se cambie el comportamiento.

### Ejemplo de uso
Suponiendo un editor de textos con diferentes algoritmos para particionar un texto en líneas (justificado, alineado a la izquierda, etc.), se desea separar las clases clientes de los diferentes algoritmos de partición, por diversos motivos:

Incluir el código de los algoritmos en los clientes hace que estos sean demasiado grandes y complicados de mantener y/o extender.
El cliente no va a necesitar todos los algoritmos en todos los casos, de modo que no queremos que dicho cliente los almacene si no los va a usar.
Si existiesen clientes distintos que usasen los mismos algoritmos, habría que duplicar el código, por tanto, esta situación no favorece la reutilización.
La solución que el patrón estrategia supone para este escenario pasa por encapsular los distintos algoritmos en una jerarquía y que el cliente trabaje contra un objeto intermediario contexto. El cliente puede elegir el algoritmo que prefiera de entre los disponibles, o el mismo contexto puede ser el que elija el más apropiado para cada situación.

##### Otros ejempos
- Salvar un archivo en diferentes formatos.
- Compresión con difrentes algoritmos.
- Formas de presentar información.
