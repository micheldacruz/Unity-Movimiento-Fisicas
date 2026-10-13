# Unity-Movimiento-Fisicas

### Situación 1

Al tener `RigidBody` el cubo debería caer sobre el plano pero como ya se encuentra sobre el mismo no se observa ningún movimiento, la esfera no es un objeto físico, por tanto, no cae.
<img width="1772" height="848" alt="Situacion1" src="https://github.com/user-attachments/assets/afb5ae16-b369-444e-8478-257dcbcb91c2" />

### Situación 2

Ahora al ser tanto la esfera como el cubo objetos físicos esta impacta contra el cubo, generando una colisión sólida dinámica y respuesta física entre ambos cuerpos, y se desliza por el plano.
<img width="748" height="360" alt="Situacion2" src="https://github.com/user-attachments/assets/6d94600e-5df3-4bb9-b0ff-1639eed4cc61" />

### Situación 3

La esfera, al ser cinemática (`Is Kinematic` activado), ignora la gravedad y se queda fija en el aire; si el cubo u otro objeto la golpea, no la moverá.
<img width="748" height="360" alt="Situacion3" src="https://github.com/user-attachments/assets/bbda6658-f355-498b-bb74-2d561388d945" />

### Situación 4

Los tres objetos (plano, cubo y esfera) caen al vacío juntos por la gravedad al tener todos `Rigidbody` dinámico, ya que el plano no tiene un soporte fijo.
<img width="748" height="360" alt="Situacion4" src="https://github.com/user-attachments/assets/42c6ed44-272a-4c2e-a29f-7543fae6c7b1" />

### Situación 5

El plano permanece inmóvil al ser cinemático. La esfera y el cubo caen por gravedad; al impactar, la esfera (con 10 veces más masa) desplaza o empuja al cubo con mayor fuerza debido a su mayor inercia.
<img width="750" height="358" alt="Situacion5" src="https://github.com/user-attachments/assets/0a028d01-86d8-4f62-aca1-9c86a8a197ac" />

### Situación 6

Comportamiento similar a la situación 5, pero la esfera empuja al cubo de forma mucho más drástica e instantánea al tener una masa 100 veces superior, respondiendo a una diferencia de inercia extrema.
<img width="746" height="360" alt="Situacion6" src="https://github.com/user-attachments/assets/6cf5c993-2533-4659-aa77-cb282c486022" />

### Situación 7

Al añadir un material físico con fricción a la esfera, esta rueda o se frena con mayor adherencia sobre la superficie con la que impacta en lugar de deslizarse libremente.
<img width="748" height="360" alt="Situacion7" src="https://github.com/user-attachments/assets/fc71c21a-09f8-4ddb-996b-ae5ac34b622c" />

### Situación 8

La esfera permanece flotando en el aire al ser cinemática (`Is Kinematic` activado). Al ser además un `Trigger`, no genera colisión física ni bloquea a otros objetos.
<img width="750" height="358" alt="Situacion8" src="https://github.com/user-attachments/assets/9f545e65-5232-4a7e-9879-b78eb521de53" />


### Situación 9

La esfera cae por efecto de la gravedad al ser dinámica, pero al tener `Is Trigger` activado atraviesa por completo la geometría del cubo y del plano sin colisionar, cayendo hacia el infinito.
<img width="750" height="358" alt="Situacion9" src="https://github.com/user-attachments/assets/91e50387-8a5e-4c07-9501-848b43815191" />

## Ejercicios Físicas 3D - Scripts

## Ejercicio 1

* **Objetivo:** Movimiento físico de personaje con control total (sin inercia).
* **Desplazamiento:** Uso de `Rigidbody.MovePosition()` en `FixedUpdate` para mover el objeto de forma exacta.
* **Control diagonal:** Aplicación de `.normalized` en el vector de entrada para mantener la misma velocidad en las diagonales.
* **Sincronización:** Multiplicación por `Time.fixedDeltaTime` para un movimiento constante independiente de los FPS.

<img width="748" height="360" alt="Ejercicio1" src="https://github.com/user-attachments/assets/8dfefcb5-3754-44bb-8414-a38ed665a8cc" />

## Ejercicio 2

* **Objetivo:** Detección de colisiones físicas e interacción entre objetos dinámicos.
* **Eventos físicos:** Uso del método `OnCollisionEnter` para detectar el momento exacto del impacto.
* **Interacción visual y consola:** Modificación de color accediendo al `Renderer` e impresión del nombre del objeto impactado (`colision.gameObject.name`).
* **Filtrado por etiquetas:** Implementación de `CompareTag("Suelo")` para ignorar la superficie base y registrar únicamente los choques entre las propias figuras.

<img width="748" height="360" alt="Ejercicio2" src="https://github.com/user-attachments/assets/368086c2-616a-4cce-b68f-5865ffc33bbc" />

## Ejercicio 3

* **Objetivo:** Creación de áreas de interacción (Triggers) para aplicar efectos lógicos y visuales al personaje sin detener su movimiento.
* **Zonas permeables:** Activación de la casilla `Is Trigger` en los Colliders para que los objetos puedan ser atravesados sin generar colisiones físicas.
* **Eventos de volumen:** Uso de `OnTriggerEnter` para aplicar efectos inmediatos (cambiar el color, sumar daño) y `OnTriggerExit` para revertirlos al salir.
* **Materiales de desarrollo:** Aplicación de materiales semi-transparentes (reduciendo el valor Alpha) en las zonas Trigger para visualizar sus límites sin tapar al personaje durante las pruebas.

<img width="748" height="360" alt="Ejercicio3" src="https://github.com/user-attachments/assets/f1869565-4006-4882-a4eb-c8f19af52aad" />

## Ejercicio 4

* **Objetivo:** Optimización del motor físico y control selectivo de interacciones mediante el uso de Capas (Layers).
* **Clasificación:** Creación y asignación de las capas personalizadas `Jugador`, `Enemigos` y `Recolectables` para categorizar los GameObjects de la escena.
* **Layer Collision Matrix:** Configuración de la matriz de colisiones (`Edit > Project Settings > Physics`) para desactivar interacciones físicas innecesarias (Enemigo vs Enemigo, Enemigo vs Recolectable).
* **Configuración de Recolectables:** Activación de la propiedad `Is Trigger` en los colliders de los objetos recolectables para que sean detectados por el jugador mediante eventos (`OnTriggerEnter`) sin generar resistencia ni cálculos de choque sólido.

<img width="750" height="358" alt="Ejercicio4 1" src="https://github.com/user-attachments/assets/3114cf07-c30e-41cf-ad5f-9974914950b8" />

## Ejercicio 5

* **Objetivo:** Experimentación con las propiedades de los materiales físicos (`Physic Material`) y aplicación de fuerzas por impulso.
* **Propiedades físicas:** Configuración de `Dynamic/Static Friction` (0 para hielo, 1 para lija) y `Bounciness` (1 para rebote alto) para alterar el comportamiento de los objetos.
* **Modos de combinación:** Uso de `Friction Combine` (Minimum/Maximum) para asegurar que las propiedades del material predominen sobre las del suelo.
* **Aplicación de fuerza:** Implementación de `Rigidbody.AddForce()` con `ForceMode.Impulse` al detectar la tecla X (`Input.GetKeyDown`) para lanzar los objetos y visualizar sus diferencias de desplazamiento y rebote.

<img width="748" height="360" alt="Ejercicio5" src="https://github.com/user-attachments/assets/51f8a114-0372-4793-868c-47d660f16199" />

## Ejercicio 6

* **Objetivo:** Desplazamiento cinemático de objetos y detección de proximidad sin utilizar el motor de físicas (`Rigidbody`).
* **Movimiento y Rotación:** Implementación de `transform.LookAt()` para encarar al objetivo final (cilindro) y `transform.Translate()` para el avance continuo, independizando el movimiento de los cálculos físicos.
* **Detección de alcance (sin físicas):** Al carecer de componentes `Rigidbody`, la detección de impacto con el obstáculo (cubo) se resolvió matemáticamente calculando la magnitud del vector entre ambos objetos con `Vector3.Distance()`.
* **Modificación visual:** Acceso al componente `Renderer` del cubo para alterar su `material.color` en tiempo de ejecución al momento de cumplirse la condición de proximidad.

<img width="748" height="360" alt="Ejercicio6" src="https://github.com/user-attachments/assets/7811dd27-d440-4db4-a115-84a68b4d7ecf" />
