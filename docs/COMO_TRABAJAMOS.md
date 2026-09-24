\# Cómo trabajamos en este repositorio



1\. Nunca se programa directamente en `main`.

2\. Cada tarea vive en su propia rama: `feature/<descripcion-corta>`.

3\. Antes de empezar: `git switch main` y `git pull`.

4\. Mensajes de commit en español, en presente, con prefijo:

&#x20;  - `feat:` nueva funcionalidad

&#x20;  - `fix:` corrección de un error

&#x20;  - `db:` cambios en scripts SQL

&#x20;  - `docs:` documentación

&#x20;  - `chore:` configuración, estructura, limpieza

5\. Todo cambio entra a `main` mediante un \*\*Pull Request\*\* revisado por otro integrante.

6\. Un solo integrante edita cada formulario (`\*.Designer.vb`) a la vez.

7\. Los scripts SQL no se editan una vez fusionados: los cambios nuevos van en un

&#x20;  script con el siguiente número (`04\_...sql`).

