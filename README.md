# Entrega del Laboratorio

## Investigación sobre Markdown (MD)

Markdown es un lenguaje de marcado que permite formatear texto de manera sencilla, sin complicarse mucho. 
Se usa en archivos README de proyectos para dejar todo claro, como explicar lo que se hizo en el proyecto, 
qué hace, cómo usarlo, entre otras cosas. Lo bueno de Markdown es que no se  necesita saber HTML para darle 
formato al texto. Solo con poner los símbolos como `#` para los títulos o `-` para las listas, ya se puede 
estructurar todo el contenido.En resumen, es una forma fácil y limpia de hacer documentación.

### ¿Por qué se usa Markdown?
- **Facilidad de uso**: Se utiliza caracteres simples como `#`, `*`, y `-` para crear títulos, listas, y enlaces,
- sin necesidad de aprender un lenguaje complejo como HTML.
- **Legibilidad**: Los archivos Markdown son legibles en formato plano, lo que significa que puedes ver el contenido
- sin necesidad de un procesador específico.
- **Compatibilidad**: Muchos sistemas de control de versiones y plataformas de colaboración (como GitHub) soportan
- Markdown para crear documentación de proyectos.
  
## ¿Para qué crees que se usan los operadores lógicos en programación?

Los operadores lógicos en programación se usan para tomar decisiones. Son claves cuando necesitas comparar cosas, por 
ejemplo, ver si dos cosas son iguales o si una condición es verdadera o falsa. Son súper útiles porque te permiten 
controlar el flujo de tu programa, como decirle "si esto pasa, haz esto, si no, haz otra cosa". Hacen que el programa 
maneje codiciones de forma mas fácil.

## ¿Por qué es importante declarar correctamente el tipo de dato de una variable?

Es clave declarar bien el tipo de dato de las variables porque, si se declara un tipo de dato incorrecto, el programa 
puede fallar o hacer confuso el código. El tipo de dato define cómo se va a almacenar y manipular la información, y 
si no lo definimos bien, pueden surgir varios problemas. Por ejemplo, si se quiere almacenar un número decimal, pero 
se declara la variable como un tipo de dato entero el número podría perder la parte decimal y el resultado no será el 
esperado.

Otro problema es que, si se declara una variable de tipo `string` para almacenar números, el programa puede no entender 
lo que se está intentando hacer, ya que los números en una cadena de texto (string) no son lo mismo que los números en 
variables de tipo int o float. 

Además, cuando se declara correctamente el tipo de dato, el código es más fácil de entender para otras personas que quieran 
trabajar o darle mantenimiento al código en el futuro. También ayuda al rendimiento del programa. Puede hacer que el programa 
corra más rápido y ocupe menos recursos.

## Enunciado 1: Clasificación de edad
Un programa debe determinar la categoría de una persona según su edad:

-Menos de 12 años: Niño
-Entre 12 y 17 años: Adolescente
-Entre 18 y 59 años: Adulto
-60 años o más: Adulto mayor

### ¿Qué estructura usarías? ¿if-else o switch? ¿Por qué
En este caso, **usaría la estructura if-else** porque es más adecuada para este tipo de comparación. Ya que el switch no es tan 
flexible cuando se trata de comparaciones que  implican rangos de valores, como en este caso. 

La estructura **if-else** permite hacer comparaciones directas con los rangos de edades. Así que la mejor opción para utilizar
es **if-else**, ya que puedo hacer rangos de manera más sencilla y clara.

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Introduce tu edad:");
        int edad = int.Parse(Console.ReadLine());

        if (edad < 12)
        {
            Console.WriteLine("Niño");
        }
        else if (edad >= 12 && edad <= 17)
        {
            Console.WriteLine("Adolescente");
        }
        else if (edad >= 18 && edad <= 59)
        {
            Console.WriteLine("Adulto");
        }
        else
        {
            Console.WriteLine("Adulto mayor");
        }
    }
}

## Enunciado 2: Día de la semana
Crear un programa que reciba un número del 1 al 7 y devuelva el nombre del día correspondiente.

### ¿Qué estructura usarías? ¿if-else o switch? ¿Por qué?
Usaría la estructura **switch** porque es más directa y eficiente para este tipo de problemas en donde se trabaja con un número 
que representa diferentes opciones. El **switch** es ideal para usarlo cuando se tiene una variable con un conjunto específico 
de valores posibles y se quiere realizar una acción para cada uno de esos valores. En este caso, el número del 1 al 7 representa 
días específicos de la semana, lo que hace al **switch** la opción perfecta para asignar a cada número su respectivo día.

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Introduce un número del 1 al 7:");
        int numero = int.Parse(Console.ReadLine());

        switch (numero)
        {
            case 1:
                Console.WriteLine("Lunes");
                break;
            case 2:
                Console.WriteLine("Martes");
                break;
            case 3:
                Console.WriteLine("Miércoles");
                break;
            case 4:
                Console.WriteLine("Jueves");
                break;
            case 5:
                Console.WriteLine("Viernes");
                break;
            case 6:
                Console.WriteLine("Sábado");
                break;
            case 7:
                Console.WriteLine("Domingo");
                break;
            default:
                Console.WriteLine("Número inválido");
                break;
        }
    }
}

## Enunciado 3: Verificación de acceso
-Si el usuario ingresó el nombre y contraseña correctos, mostrar "Acceso concedido".
-Si solo ingresó el nombre correcto pero la contraseña es incorrecta, mostrar "Contraseña incorrecta".
-Si el nombre de   usuario no existe, mostrar "Usuario no registrado".Un usuario intenta iniciar sesión en una aplicación.Debes verificar:

### ¿Qué estructura usarías? ¿if-else o switch? ¿Por qué?
Usaría la estructura **if-else** porque se comparan dos valores (usuario y contraseña) y es una forma más sencilla y directa de analizar
las condiciones. Con **if-else**, podemos verificar si el usuario ingresó los datos correctos, si la contraseña es incorrecta o si el usuario
no está registrado, todo de manera clara y estructurada. Ya que así es más directo en las comparaciones.

### ¿Qué estructura usarías? ¿if-else o switch? ¿Por qué?  
Usaría la estructura **if-else** porque se comparan dos valores (usuario y contraseña) y es una forma más sencilla y directa de analizar las condiciones.  
Con `if-else`, podemos verificar si el usuario ingresó los datos correctos, si la contraseña es incorrecta o si el usuario no está registrado, todo de manera clara y estructurada.  

**Datos registrados:**  
- **Usuario:** Lester  
- **Contraseña:** lester1234  

```csharp
using System;

class Program
{
    static void Main()
    {
        string usuarioRegistrado = "Lester";
        string contrasenaRegistrada = "lester1234";

        Console.WriteLine("Introduce tu nombre de usuario:");
        string usuario = Console.ReadLine();

        Console.WriteLine("Introduce tu contraseña:");
        string contrasena = Console.ReadLine();

        if (usuario == usuarioRegistrado && contrasena == contrasenaRegistrada)
        {
            Console.WriteLine("Acceso concedido");
        }
        else if (usuario == usuarioRegistrado && contrasena != contrasenaRegistrada)
        {
            Console.WriteLine("Contraseña incorrecta");
        }
        else
        {
            Console.WriteLine("Usuario no registrado");
        }
    }
}



