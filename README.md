# ☕ Colombian Coffee

## 👥 Integrantes y Roles

- **Juan Camilo Amezquita** *(Líder)* → Creación y desarrollo del módulo de generación de catálogo PDF.  
- **Juan Manuel Basto** → Encargado del diseño y creación de la base de datos.  
- **Daniel Alejandro Duran** → Responsable de la arquitectura del proyecto usando las metodologías Vertical Slice y Arquitectura Hexagonal.  

---

Colombian Coffee es una aplicación de escritorio desarrollada en **C#** con **Entity Framework** y **MySQL**, que permite explorar, filtrar y administrar un catálogo de las principales variedades de café cultivadas en Colombia.  
El sistema incluye un panel administrativo con gestión **CRUD**, filtros avanzados y generación de **catálogos PDF** personalizados.

---

## 📜 Descripción

Colombia es reconocida mundialmente por producir uno de los cafés más finos y suaves del planeta.  
Este proyecto busca centralizar información técnica y visual de las variedades de café, permitiendo:

- Visualizar fichas técnicas con datos agronómicos, historia y linaje genético.
- Filtrar por porte, tamaño de grano, altitud, rendimiento y resistencias.
- Generar reportes en **PDF** personalizados.
- Administrar el contenido mediante un panel seguro con usuarios y roles.

---

## 🛠 Tecnologías

- **Lenguaje:** C# (.NET Console Application)
- **Base de datos:** MySQL
- **ORM:** Entity Framework
- **Patrones:** Arquitectura Hexagonal + Vertical Slice, SOLID
- **PDF:** Librerías como IronPDF, Syncfusion o CraftMyPDF
- **Control de versiones:** Git / GitHub

---

## 📂 Estructura de la Base de Datos

La base de datos incluye las siguientes tablas:

1. **usuarios** → Administración y autenticación.
2. **variedades** → Información principal de cada variedad de café.
3. **resistencias** → Tipos de resistencia a enfermedades.
4. **variedades_resistencias** → Relación entre variedades y resistencias.
5. **imagenes_variedad** → Galería de imágenes por variedad.
6. **historial_cambios** → Registro de modificaciones realizadas.
7. **reportes_pdf** → Historial de reportes generados.
8. **favoritos** → Variedades guardadas por cada usuario.

📌 El **diagrama entidad-relación** está disponible en formato `.png` y `.mwb` para MySQL Workbench.

---

## 📑 Funcionalidades

### Módulo de exploración
- Visualización de ficha técnica.
- Filtros combinados por atributos agronómicos y resistencias.
- Búsqueda avanzada.

### Panel administrativo
- CRUD completo de variedades, imágenes y atributos.
- Gestión de usuarios y roles.
- Historial de cambios por usuario.

### Generador de PDF
- Exportación de catálogos filtrados.
- Vista previa antes de descarga.
- Registro histórico de reportes generados.

---

## 🚀 Instalación

1. **Clonar repositorio:**
   ```bash
   git clone https://github.com/usuario/colombian-coffee.git