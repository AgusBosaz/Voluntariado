# Sistema de Voluntariado

## Descripción

Aplicación de consola desarrollada en C# para gestionar participantes de un sistema de voluntariado.

El sistema permite registrar voluntarios y coordinadores, almacenarlos en una lista y mostrar la información de todos los participantes registrados.

## Estructura

### Participantes
Clase base que contiene los datos comunes de todos los participantes:

- Nombre
- DNI

### Voluntario
Clase que hereda de Participantes y representa a los voluntarios del sistema:

- Horas trabajadas

### Coordinador
Clase que hereda de Participantes y agrega información específica:

- Área asignada
- Cantidad de personas a cargo

## Funcionalidades

- Agregar voluntarios.
- Agregar coordinadores.
- Mostrar todos los participantes registrados.
- Salir del programa.

## Conceptos aplicados

- Programación Orientada a Objetos (POO)
- Herencia
- Encapsulamiento
- Polimorfismo
- Uso de listas (`List<Participantes>`)

## Tecnologías utilizadas

- C#
- Aplicación de Consola

## Autor

Maximo Criado y Agustín Bosaz
