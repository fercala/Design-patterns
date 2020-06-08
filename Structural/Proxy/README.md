# Proxy 
El patrón Proxy es un patrón estructural que tiene como propósito proporcionar un subrogado o intermediario de un objeto para controlar su acceso.

Da soporte a objetos que controla la creación y el acceso a otros objtetos. Es un punto intermedio entre el cliente y eso objetos que son activados cuand se cumplen con determinado requisitos.


### Tipos de proxies
El patrón proxy se usa cuando se necesita una referencia a un objeto más flexible o sofisticada que un puntero. Dependiendo de la función que se desea realizar con dicha referencia podemos distinguir diferentes tipos de proxies:
- proxy remoto: representante local de un objeto remoto.
- proxy virtual: crea objetos costosos bajo demanda.
- proxy de protección: controla el acceso al objeto original
- proxy de referencia inteligente: sustituto de un puntero que lleva a cabo operaciones adicionales cuando se accede a un objeto (ej. contar número de referencias al objeto real, cargar un objeto persistente bajo demanda en memoria, control de concurrencia de acceso tal como bloquear el objeto para impedir acceso concurrente, …).

### Diagrama
El siguiente diagrama muestra como el cliente hace consumo del objeto sujeto atravez del Proxy.

##### Partes importantes
- ISujeto: Interfaz común de los proxy y sujgetos. Esto permite usarlos e intercambiarlos cuando sea necesario.
- Sujeto: La clase que es representada por el proxy, la clase que deseamos usar una vez que el proxy nos permita.
- Proxy: La clase que crea, controla y da acceso al sujeto.
- Petición: Una operación en el sujeto que es enviada vía el proxy.

![Proxy Diagram](https://github.com/fercala/Design-patterns/blob/master/Structural/Proxy/Proxy.png?raw=true)

### Ejemplo de uso
- Un ejemplo de Proxy puede ser el mecanismo para registrarse y hacer login a un sitio web. No se tiene acceso a determinados objetos hasta que el usuario no este registrado y lleve a cabo el login de forma correcta.
- Otro uso de proxy es presentar a un objeto que toma tiempo o recursos en crearse, de esta forma el cliente piensa que esta comunicado con el objeto mientras el proxy decide la creación cuando sea realmente necesario. Es decir difernciamos la instalación del momento real de su uso.
- Su un cálculo lleva mucho tiempo en realizarse, modemos usar proxy para mostrar resultados intermedios.
- ADO.NET hace uso de proxy para llevar a cabo la conectividad con base de datos.

