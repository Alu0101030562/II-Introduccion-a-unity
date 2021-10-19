## Interfaces Inteligentes - Introduccion a unity

Siguiendo el guión de la práctica punto por punto, en primer lugar colocamos los objetos 3D básicos, los cuales en mi caso escogí un cubo y una esfera, la cual coloqué encima del cubo utilizando las coordenadas x, y, z. Donde la única coordenada que se diferencia en ambos objetos es la del eje y, ya que de esta manera estarán en la misma posición pero a diferente altura.

En el siguiente punto procederemos a incluir un objeto complejo del paquete de Standard Assets en nuestro mini proyecto a un personaje llamado Ethan, este paquete lo encontraremos en la Asset Store. Tras descargarlo e importarlo al programa, insertamos a nuestro personaje en el plano en las coordenadas que queramos.

Tras realizar el paso anterior, el siguiente es repetir el mismo proceso, con la diferencia de que no podremos escoger un objeto del paquete Standard Assets, sino que debemos coger un objeto de la Asset Store. En mi caso escogí una sombrilla y una silla de playa de otro paquete que descargamos e importamos desde la Asset Store. Este paquete se llama Beach Essentials y es totalmente gratuito.

De la misma forma en la que añadimos los objetos 3D en el paso uno, en este punto añadimos un terreno que deformamos utilizando la herramienta de *Paint Terrain* para generar pequeñas montañas que más adelante rodearán un lago. Por otra parte, a este terreno le dimos una textura de arena simulando una zona árida como si fuera una playa. Para ello tuvimos que escoger la opción de *Paint textures* y cargar dichas texturas para luego poner la textura sobre las distintas superficies del terreno.

A continuación, el punto que realizamos es el de etiquetar cada objeto del proyecto. Para llevar a cabo este punto seleccionamos cada objeto que tenemos en la lista de jerarquía y los etiquetamos en la pestaña *Tag*. De esta manera, agrupamos los objetos para que nos sea más fácil saber a qué pertenecen, por ejemplo, todas las palmeras que añadimos pertenecen a la etiqueta de **environment**, los objetos 3D basicos y demas objetos pertenecen a la etiqueta **objects** y las luces pertenecen a la etiqueta **light**, etc.

En el punto de iluminación solo tuvimos que añadir un punto de luz más, ya que el proyecto ya trae una luz direccional por defecto. Dicha luz que añadimos se trata de un foco de luz (Spot light), el cual colocamos lateralmente para enfocar todo el entorno con el personaje y demas objetos añadidos.

Por último, añadimos un pequeño lago en el interior de las montañas, el cual se encontraba en el paquete de Standard Assets, y para generar las palmeras usaremos el objeto que se encuentra en el paquete de Standard Assets.
