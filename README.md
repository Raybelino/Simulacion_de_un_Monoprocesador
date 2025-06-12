# Simulación de un Monoprocesador en C#

Este proyecto es una simulación básica del funcionamiento de un sistema monoprocesador, donde las tareas se ejecutan secuencialmente, una a la vez, sin multitarea ni paralelismo.

## Objetivo del proyecto

Comprender cómo funciona un sistema monoprocesador al ejecutar tareas en orden de llegada, simulando el tiempo de ejecución de cada una.


## Estructura del Proyecto (clases)

### 1. `Tarea.cs`
La clase `Tarea` representa una tarea con:
- `Nombre` (string)
- `Duracion` (int) (en segundos)
- Método `Ejecutar()` que simula la ejecución y la espera de las tareas.

### 2. `Monoprocesador.cs`
Clase que administra la cola de tareas:
- Lista `colaTareas`
- Método `AgregarTarea()` para añadir tareas
- Método `EjecutarTareas()` que ejecuta todas las tareas en orden.

### 3. `Program.cs`
Archivo principal con el método `Main()`:
- Permite al usuario elegir entre ingresar tareas manualmente o usar tareas predeterminadas.
- Ejecuta las tareas usando una instancia de `Monoprocesador`.

## Tecnologías usadas

- Lenguaje: **C#**
- Entorno sugerido: **Visual Studio / .NET Core**
- Funcionalidad de temporizador: `Thread.Sleep()`

## Estudiante

- **Nombre:** Jorge Rayber Acosta Carvajal
- **Matricula:** 2023-1772
- **Fecha:** 12/6/2025