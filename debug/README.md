# InventarioFerreteria — Cómo ejecutar la aplicación

Esta carpeta contiene el **ejecutable (.exe)** de la aplicación.

## Requisitos

- Windows 10 u 11
- .NET 10 Desktop Runtime instalado (descargar desde https://dotnet.microsoft.com/download/dotnet/10.0)
- Si la aplicación usa base de datos, el servidor MariaDB debe estar activo y con la base de datos creada

## Cómo agregar el ejecutable a esta carpeta (estudiantes)

1. En Visual Studio, compilar el proyecto: menú **Compilar → Compilar solución** (`Ctrl + Shift + B`).
2. Abrir la carpeta de salida del proyecto: `bin\Debug\net10.0-windows\`
3. Copiar **todo el contenido** de esa carpeta (el `.exe` junto con sus `.dll` y archivos de configuración) dentro de esta carpeta `debug`.
4. Subir los cambios al repositorio:

```
git add -f debug/
git commit -m "Agrega ejecutable de la aplicación"
git push origin main
```

## Cómo ejecutar la aplicación

**Opción 1 — Doble clic**

Abrir la carpeta `debug` en el Explorador de archivos y hacer doble clic sobre el archivo `.exe`.

**Opción 2 — Desde el Símbolo del sistema (CMD)**

```
cd ruta\del\repositorio\debug
NombreDeLaAplicacion.exe
```

**Opción 3 — Desde PowerShell**

```
cd ruta\del\repositorio\debug
.\NombreDeLaAplicacion.exe
```

## Posibles problemas

- **Windows protegió su PC (SmartScreen):** hacer clic en *Más información* → *Ejecutar de todas formas*.
- **Falta .NET:** si aparece un mensaje pidiendo instalar .NET, instalar el *.NET 10 Desktop Runtime* indicado en los requisitos.
- **Error de conexión a la base de datos:** verificar que MariaDB esté en ejecución y que los datos de conexión (servidor, usuario, contraseña) sean correctos.
