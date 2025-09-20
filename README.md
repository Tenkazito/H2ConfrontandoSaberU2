# Cuestionario
1. ¿Qué es el encapsulamiento y cómo protege la integridad de los datos en un sistema orientado a objetos?
R:/ Es un pilar del POO que consiste en ocultar los datos de una clase restringiendo su acceso directo declarandolos como private, para acceder a estos datos o atributos se deben usar métodos públicos para interactuar con ellos, de modo que no se puedan modificar los atributos a cualquier cosa sino que los métodos controlen estos cambios según se necesite ajustar.

2. ¿Cómo la herencia fomenta la reutilización de código en programación orientada a objetos?
R:/ Las clases derivadas pueden usar las funcionalidades de la clase base de modo que no se tenga que volver a escribir el mismo código, haciéndolo todo más reutilizable. Y las clases derivadas pueden añadir sus métodos y atributos específicos según se necesite.

3. ¿Cuál es la relación entre el polimorfismo y la flexibilidad en el código?
R:/ El polimorfismo permite hacer que el código trabaje con distintos tipos de objetos de forma parecida usando una clase base como herencia, esto hace el codigo mas flexible debido a que se pueden añadir nuevas funcionalidades o tipos sin modificar el código base. Reduce la necesidad de escribir codigo especifico para cada tipo de objeto.

4. ¿Por qué la abstracción es fundamental para la programación orientada a objetos?
R:/ Porque permite identificar las características esenciales de un objeto, haciendo su diseño más simple y su código más fácil de entender y mantener, esto promueve que los componentes del objeto sean independientes y reutilizables.

5. ¿Qué problemas soluciona el principio de responsabilidad única (SRP)?
R:/ Soluciona que un objeto tenga varias funciones o responsabilidades, haciendo que este tenga solo una responsabilidad, ya que teniendo varias, un cambio en una puede afectar al resto, hace la clase mas compleja y propensa a errores.

6. ¿De qué manera el principio de abierto/cerrado (OCP) permite la extensión de sistemas sin modificar el código existente?
R:/ Al tener una clase base con ciertas funciones integradas, si se crea una clase derivada, a esta se le podrá implementar funcionalidades extra a los de la clase base, esto sin modificar la anterior, de modo que se pueda extender el funcionamiento pero sin modificar la clase base.

7. ¿Por qué es importante cumplir con el principio de sustitución de Liskov (LSP) en el diseño orientado a objetos?
R:/ Porque asegura que las clases derivadas puedan seguir cumpliendo las funciones de la clase base, garantizando que el código que depende de la clase base pueda ser reutilizado en clases derivadas sin ajustes o modificaciones adicionales.

8. ¿Cómo el patrón Singleton controla el acceso global a una única instancia de una clase?
R:/ Al tener un constructor privado impide que se creen nuevas instancias de la clase, además la única instancia está en una variable estática dentro de la clase, y luego con un método público y estático se devuelve la instancia o la crea si no existe.

9. ¿Qué ventajas ofrece el patrón de diseño Factory Method al crear objetos?
R:/ Con este diseño el código depende de abstracciones en vez de clases específicas, facilita añadir nuevos objetos sin modificar el código base y permite la extensión de programa con nuevas clases.

10. ¿Cómo el patrón Strategy facilita la sustitución de algoritmos en tiempo de ejecución?
R:/ Los algoritmos están en una clase que usa una interfaz común, de modo que se pueden cambiar dinámicamente, y para añadir algoritmos se hace creando nuevas clases con la interfaz común.

# Ejemplos de codigo
Dentro de la carpeta del proyecto esta una clase con cada ejemplo, de pilares de POO, principios de diseño y patrones de diseño.

# Conclusiones de la guia
- Los pilares del poo son de gran importancia para crear clases con sentido y que puedan ejercer bien su trabajo, cuidando de
  su seguridad y modo de trabajo.
- Los principios de diseño permiten el correcto uso de las clases y ayudan a evitar futuros errores cuando empieza a crecer un correcto,
  es importante seguirlos para hacer buen codigo y clases en general, que sea claro, escalable y facil de mantener.
- Los patrones de diseño proporcionan soluciones adecuadas para problemas comunes a la hora de desarrollar codigo, haciendo que este sea
  mas flexible, reutilizable y sencillo de expandir.
