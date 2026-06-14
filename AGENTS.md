# pryEDPereiroB — AGENTS.md

.NET Framework 4.7.2 WinForms educational app (data structures).

## Build & run

- No NuGet packages, no tests, no CI, no linter/typecheck config.
- Open `pryEDPereiroB.slnx` in Visual Studio (2022+) and build/run (F5).
- Entry point: `pryEDPereiroB/Program.cs` → `frmPrincipal`.

## Project structure

| Path | Purpose |
|------|---------|
| `Clases/` | Data structure implementations (clsCola, clsPila, clsListaSimple, clsListaDoble, clsArbolBinario, clsGrafo) |
| `Clases/clsNodos.cs` | Generic node shared across all structures; `Anterior` ↔ `Izquierda`, `Siguiente` ↔ `Derecho` (same backing fields) |
| `Clases/clsArchivoTexto.cs` | Text file I/O helper (semicolon-delimited) |
| `Clases/clsBaseDeDatos.cs` | Access DB via OleDb (ACE OLEDB 12.0) |
| `DB/Libreria.mdb` | Access database, copied to output dir on build |
| `frm*.cs` | Each form is a data structure demo (naming: `frm` + Spanish concept) |

## Database

- Connection string: `Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DB\Libreria.mdb`
- Requires **Microsoft Access Database Engine 2010 Redistributable** (or full Office) installed on the build/run machine.
- `clsBaseDeDatos.Listar()` has two overloads: table-direct lookup or custom SQL via `CommandType.Text`.

## Known incomplete work (README)

- `frmArbolBinario`: populate DataGridView, wire radio buttons (InOrden/PreOrden/PostOrden), implement delete via ComboBox.

## Conventions

- All identifiers, comments, and UI labels are in **Spanish**.
- All classes in `Clases/` are `internal`, same namespace `pryEDPereiroB`.
- Overloaded `Recorrer()` methods dump to file, DataGridView, ListBox, ComboBox depending on signature.
- `clsArbolBinario.Recorrer(Grilla, string)` takes `"InOrden"`, `"PreOrden"`, or `"PostOrden"`.
- Tree recursive delete uses in-order successor strategy.

# AGENT.md - Sistema de Autogestión Estudiantil

## Proyecto
- Lenguaje: C# con .NET
- IDE: Visual Studio
- Tipo: Trabajo Práctico universitario - Estructuras de Datos

## Cómo compilar
- Abrir el archivo .sln en Visual Studio
- Build > Build Solution (Ctrl+Shift+B)
- Ejecutar con F5

## Convenciones del proyecto
- Idioma del código: español (nombres de clases, métodos y variables en español)
- Todas las estructuras de datos son implementaciones PROPIAS
- NO usar colecciones built-in de .NET (List<T>, Stack<T>, Queue<T>, etc.)
- Cada estructura de datos va en su propia clase y archivo .cs
- Usar propiedades y encapsulamiento (getters/setters)
- Namespaces deben respetar la estructura de carpetas del proyecto

## Estructuras de datos requeridas
El proyecto debe implementar las siguientes 7 estructuras:
1. Archivos de texto con POO
2. Pila (Stack) - Push, Pop, Peek, IsEmpty
3. Cola (Queue) - Enqueue, Dequeue, Peek, IsEmpty
4. Lista Simple y Doble - Insert, Delete, Search, Traverse
5. Grafo con representación matricial (matriz de adyacencia)
6. Árbol Binario - carga y recorridos (InOrder, PreOrder, PostOrder)
7. Base de datos - CRUD con SQL Server o SQLite

## Instrucciones para revisión
Cuando se pida revisar el proyecto:
1. Explorar TODA la solución: .sln, .csproj y cada archivo .cs
2. Verificar cada una de las 7 estructuras
3. Para cada una indicar:
   - Archivos/clases donde está implementada
   - Operaciones presentes
   - Qué falta o está incorrecto
4. Usar este formato de estado:
   - ✅ COMPLETO
   - ⚠️ INCOMPLETO
   - ❌ FALTANTE
5. Al finalizar, preguntar qué se desea corregir o implementar

## Instrucciones para implementar
Cuando se pida implementar o corregir algo:
- Respetar la arquitectura y namespaces existentes
- Mantener el estilo del código ya escrito
- Implementaciones propias, sin colecciones de .NET
- Agregar comentarios en español explicando la lógica
- Avisar si hay que modificar el Program.cs o menú principal