# BasicPhysics
## Introducción
Este proyecto es una práctica del uso básico de las físicas de Unity (6.2). Se le ha pedido a ChatGPT dos ejercicios que impliquen tanto detecciones de tipo collision o trigger, como interacciones con el movimiento de los objetos usando ``AddForce`` o ``velocity`` ([link](https://chatgpt.com/share/6970c1a6-68ec-8011-b246-2b94a858cf3c) a la conversación). Los ejercicios recibidos fueron levemente modificados; el resumen de los enunciados aplicados se encuentra a continuación. 

## Ejercicios  
### Ejercicio 1  
Se controla un cubo con las teclas de movimiento (``WASD`` o las flechas, espacio para saltar). El cubo se mueve por medio de fuerzas y solo puede saltar si está tocando el suelo.  
Repartidos por el espacio hay tres tipos de obtáculos:  
- Spring: Al entrar en contacto se impulsa al cubo hacia arriba.
- Mud: Al desplazarse por esta superficie el cubo sufre una resistencia, reduciendo su velocidad.
- Boost: Al entrar en contacto el cubo aumenta su velocidad en la dirección en la que esté yendo.

De base, el cubo es de color gris, cuando no está tocando el suelo se vuelve amarillo y cuando entra en contacto con un obstáculo Mud se mancha de marrón.  

  
**Aviso:** Para el mensaje de los commits se emplea el sistema 'Conventional commits', pero en los primeros el tipo debería ser ``feat`` en vez de ``build``.  

### Ejercicio 2  
Un cubo se mueve hacia delante con una velocidad constante, siendo imperturbable por el usuario.  
En su camino puede encontrarse con ciertos obstáculos:  
- Wall: El cubo detectará la pared y frenará antes de chocar conta ella.
- Horizontal Spring: Al entrar en contacto el cubo rebotará hacia atrás.
- Vertical Spring: Al entrar en contacto el cubo rebotará hacia arriba.  
  
Los obstáculos pueden ser desactivados al clicar sobre ellos, permitiendo que el cubo siga su camino. 
