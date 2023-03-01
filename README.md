# **MANUAL DE USUARIO**

# **ÍNDICE DE CONTENIDOS**

***INDICE DE CONTENIDOS***
- [**MANUAL DE USUARIO**](#manual-de-usuario)
- [**ÍNDICE DE CONTENIDOS**](#índice-de-contenidos)
- [**INTRODUCCIÓN**](#introducción)
- [**APLICACIÓN DE ESCRITORIO**](#aplicación-de-escritorio)
  - [**LOGIN**](#login)
  - [**MANTENIMIENTO DE GUARDIAS**](#mantenimiento-de-guardias)
    - [**CREAR UNA NUEVA GUARDIA**](#crear-una-nueva-guardia)
    - [**MODIFICAR UNA GUARDIA EXISTENTE**](#modificar-una-guardia-existente)
    - [**ELIMINAR GUARDIA**](#eliminar-guardia)
    - [**FILTRAR GUARDIAS**](#filtrar-guardias)
      
    
# **INTRODUCCIÓN**

La aplicación trata de la administración de guardias de profesores por parte de administración
recuerde que solo los usuarios que son de la administración pueden acceder a la aplicación.

Ningún otro usuario como un profesor puede acceder

Tambien Dispone de una plicación móvil para realizar las mismas operaciones que en la aplicación de escritorio

---

# **APLICACIÓN DE ESCRITORIO**

## **LOGIN**

Al iniciar la aplicación, se encotrará con esta ventana:

![login]

Aquí tendrá que proporcionar su `Nombre de ususario` y `Contraseña`

Si alguno de los campos no es correcto, saldrá un pop-up diciendo que su usuario o contraseña no son correctos

puede intentarlo las veces que necesite

---

## **MANTENIMIENTO DE GUARDIAS**
Al iniciar sesion correctamente con su usuario, se cerrará la ventana de inicio de sesion y aparecerá la ventana de los mantenimientos de guardias

![mantenimientoG]

Esta contiene todas las guardias que estan registradas en la base de datos de las guardias
en una lista.

Esta contiene las columnas: `Fecha`, `Hora`, `Falta`, `Sustituye` y `Estado`

Usted puede realizar las siguientes opciones en esta ventana:

  * Crear Una nueva guardia
  * Modificar una guardia existente
  * Eliminar una guardia
  * Filtrar una guardia

---

### **CREAR UNA NUEVA GUARDIA**

Usted puede crear una nueva guardia haciendo click en el botón **Nueva**
o puede hacer click derecho en la lista y hacer click en el botón de **Nuevo**

![CMmantenimientoG]

Al hacer click en el botón nuevo se encotrará en esta ventana

![CrearGuardia]

Aquí podra rellenar los datos de la guardia:

```markdown
    * Profesor ausente
    * Fecha de ausencia
    * Aula de ausencia
    * Profesor al que sustituye
    * Hora de ausenca
    * Grupo
    * Observaciones de ausencia
    * Estado de guardia
````

Para seleccionar un profesor ausente y un profesor sustituto
tendrá que hacer click en el ó **Examinar**

Este se le presentará con la siguiente ventana:

![SeleccionarProfe]

Aqui podra seleccionar un profesor el cual Sustituirá o Ausentará, 
puede buscarlo por su nombre o DNI

Una vez seleccionados los profesores puede hacer lo suiguiente, aunque esto es `opcional`

Con el botón de **Autorrellenar** 
Segun el profesor la fecha y la hora autorellenará aula y grupo (Excepto las observaciones y Estado)

![DatosRellenados]

Una vez rellenado todos los datos, haga click en el botón **Guardar** y ya estaria añadida la guardia a la lista de guardias

![NuevaGuardia]

---

### **MODIFICAR UNA GUARDIA EXISTENTE**

Para modificar una guardia existente necesitar ir a la lista de guardias, hacer click derecho en la guardia que used desea modificar y hacer click en el botón **Modificar**

En este caso modificaré la guardia que acabo de crear:

![CMmantenimientoGModif]

Al hacer click en el botón, Se encotrará con la misma ventana de creacion de guardia, pero tendrá los datos rellenados de la guardia

Este se puede modificar cualquier dato que necesite modificar, en este caso modificaré la fecha y la pondré a la actual, tambien cambiaré el profesor que esta ausente a Paula

![DatosModificados]

Una vez modificado veremos que se ha cambiado la fecha y el profesor ausente

![ListaModificada]

---

### **ELIMINAR GUARDIA**

Para eliminar la guardia necesita ir a la lista de guardias, hacer click derecho en la guardia que used desea modificar y hacer click en el botón **Eliminar**

![CMmantenimientoGElim]

Al hacer click en el botón de Eliminar, saldrá un pop-up preguntando si de verdad quieres borrar la guardia

![Pop-UpEliminar]

Si das al botón de acceptar, se eliminará de la lista de guardias

---

### **FILTRAR GUARDIAS**

Si necesitas buscar una guardia por nombre y apellidos del profesor podrás filtrar las guardias en la caja de texto arriba de la lista de guardias

![BarraFiltro]

si filtramos por nombre, realizará una busqueda de todas las guardias las cuales coinciden con el nombre y apellidos buscado

![FiltroJonhatan]



[login]: imagenesManual/Login.png "Ventana de Login"
[mantenimientoG]: imagenesManual/Mantenimiento_Guardias.png "Ventana de Mantenimiento de guardias"
[CMmantenimientoG]: imagenesManual/ContextMNuevo.png "ContextMenu de Mantenimiento de guardias"

[CrearGuardia]: imagenesManual/Nueva_Guardia.png "Ventana de Nueva guardia"
[SeleccionarProfe]: imagenesManual/Seleccionar_Profesor.png "Seleccionar profesor"
[DatosRellenados]: imagenesManual/Guardia_Datos.png "Datos rellenados en la nueva guardia"
[NuevaGuardia]: imagenesManual/Nueva_Guardia_Nuevo.png "Mostrando nueva guardia"

[CMmantenimientoGModif]: imagenesManual/ContextMModificar.png "ContextMenu de Mantenimiento de guardias para modificar"
[DatosModificados]: imagenesManual/Datos_Modificados.png "Datos modificados en guardia"
[ListaModificada]: imagenesManual/Lista_Modificadas.png "Profesor cambiado"


[CMmantenimientoGElim]: imagenesManual/ContextMEliminar.png "ContextMenu de Mantenimiento de guardias para eliminar"
[Pop-UpEliminar]: imagenesManual/MessageBox_Eliminar.png "pop-up para eliminar"


[BarraFiltro]: imagenesManual/Barra_filtro.png "barra de filtro"
[FiltroJonhatan]: imagenesManual/Filtro_Jonhatan.png "filtro jonhatan"
