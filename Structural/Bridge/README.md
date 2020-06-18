# Bridge 
El patrón Decorator responde a la necesidad de añadir dinámicamente funcionalidad a un Objeto. Esto nos permite no tener que crear sucesivas clases que hereden de la primera incorporando la nueva funcionalidad, sino otras que la implementan y se asocian a la primera.

- Provee un mecanismo para colocar un nuevo comportamiento y/o estdo a un objeto de forma dinamica.
- El objeto no sabe que esta siendo decorado.
- Tiene una instancia de la clase original y tambien desciende de ella.
- No necesitamos una superclase con todas las caractierísticas.
- Cada decoración es independiente de las demás.
- Podemos colocarlas seguún las necesitemos.
- No depende de la herencia para adicionar nuevos comportamientos.
- Algunos recomiendan usr clases abstractas, en lo personal prefiero usar interfaces.

### Diagrama
El siguiente diagrama muestra como es la relacion para crear un decorador. Un cliente que utiliza una Clase por agregacion puede decurar un componente. En este punto es importante entender que el decorador debe poseer una instancia de IComponent para poder agregar comportamiento.

##### Partes importantes
- Componente: La clase orignal que esta siendo decorada y a la que se le adiconan o mejoran comportamientos.
- IComponent: La interfaz que identifica a los objetos que pueden ser decorados.
- Operación: La operacion en Componente que puede ser reemplazada.
- Decorador: La clase que implementa a IComponent y adiciona el estado o comportamiento.

![Decorator Diagram](https://github.com/fercala/Design-patterns/blob/master/Structural/Decorator/Decorator.png?raw=true)

### Ejemplo de uso
- Añadir responsabilidades a objetos individuales de forma dinámica y transparente
- Responsabilidades de un objeto pueden ser retiradas
- Cuando la extensión mediante la herencia no es viable
- Hay una necesidad de extender la funcionalidad de una clase, pero no hay razones para extenderlo a través de la herencia.
- Existe la necesidad de extender dinámicamente la funcionalidad de un objeto y quizás quitar la funcionalidad extendida.