# Patrones de diseño
Los patrones de diseño son unas técnicas para resolver problemas comunes en el desarrollo de software y otros ámbitos referentes al diseño de interacción o interfaces.

Un patrón de diseño resulta ser una solución a un problema de diseño. Para que una solución sea considerada un patrón debe poseer ciertas características. Una de ellas es que debe haber comprobado su efectividad resolviendo problemas similares en ocasiones anteriores. Otra es que debe ser reutilizable, lo que significa que es aplicable a diferentes problemas de diseño en distintas circunstancias.

### Objetivos de los patrones
Los patrones de diseño pretenden:

- Proporcionar catálogos de elementos reusables en el diseño de sistemas de software.
- Evitar la reiteración en la búsqueda de soluciones a problemas ya conocidos y solucionados anteriormente.
- Formalizar un vocabulario común entre diseñadores.
- Estandarizar el modo en que se realiza el diseño.
- Facilitar el aprendizaje a las nuevas generaciones de diseñadores condensando conocimiento ya existente.

Asimismo, no pretenden:
- Imponer ciertas alternativas de diseño frente a otras.
- Eliminar la creatividad inherente al proceso de diseño.

No es obligatorio utilizar los patrones, solo es aconsejable en el caso de tener el mismo problema o similar que soluciona el patrón, siempre teniendo en cuenta que en un caso particular puede no ser aplicable. "Abusar o forzar el uso de los patrones puede ser un error".

### Categorias de patrones 
##### Patrones de comportamiento
Se definen como patrones de diseño software que ofrecen soluciones respecto a la interacción y responsabilidades entre clases y objetos, así como los algoritmos que encapsulan.

##### Patrones creacionales
Corresponden a patrones de diseño de software que solucionan problemas de creación de instancias. Nos ayudan a encapsular y abstraer dicha creación.

##### Patrones estructurales
Son los patrones de diseño software que solucionan problemas de composición (agregación) de clases y objetos.

### Objetivos del proyecto
El código de este repositorio intenta dar una breve explicación del uso de los prinicipales patrones de diseños y un ejemplo para cada uno desarrollado en el lenguaje C#.

#### Estructura del repositorio
El repositorio esta dividido por tipo comportamiento, creacion y estructural.

- [Comportamiento](https://github.com/fercala/Design-patterns/tree/master/Behavioral)
    - Chain of Responsibility (Cadena de responsabilidad)
    - Command (Orden)
    - Interpreter (Intérprete)
    - Iterator (Iterador)
    - Mediator (Mediador)
    - Memento (Recuerdo)
    - Observer (Observador)
    - State (Estado)
    - [Strategy (Estrategia)](https://github.com/fercala/Design-patterns/tree/master/Behavioral/Strategy)
    - Template Method (Método plantilla)
    - Visitor (Visitante)
- [Creación](https://github.com/fercala/Design-patterns/tree/master/Creational)
    - Object Pool (no pertenece a los patrones especificados por GoF)
    - Abstract Factory (fábrica abstracta)
    - Builder (constructor virtual)
    - Factory Method (método de fabricación)
- [Estrucuturales](https://github.com/fercala/Design-patterns/tree/master/Structural)
    - Adapter o Wrapper (Adaptador o Envoltorio)
    - Bridge (Puente)
    - Composite (Objeto compuesto)
    - [Decorator (Decorador)](https://github.com/fercala/Design-patterns/tree/master/Structural/Decorator) 
    - Facade (Fachada)
    - Flyweight (Peso ligero)
    - [Proxy](https://github.com/fercala/Design-patterns/tree/master/Structural/Proxy)
    - Module

