# Inventario

**Descripción del Proyecto en Blazor - Sistema de Gestión de Productos y Proveedores**

El proyecto en Blazor se centra en el desarrollo de un sistema de gestión integral que permite administrar productos y proveedores de manera eficiente. La arquitectura del proyecto se basa en el uso del framework Blazor para lograr una experiencia de usuario fluida y altamente interactiva.

**Entidades Principales:**

1. **ProductoRequest:**
   - *Id:* Identificador único del producto.
   - *Stock:* Cantidad disponible en inventario.
   - *Descripción:* Descripción detallada del producto.
   - *ProveedorId:* Identificador del proveedor asociado al producto.
   - *CostoUnidad:* Costo unitario del producto.
   - *Importe:* Importe total del producto en inventario.

2. **ProveedorRequest:**
   - *Id:* Identificador único del proveedor.
   - *FullName:* Nombre completo del proveedor.
   - *PhoneNumber:* Número de teléfono de contacto del proveedor.
   - *Address:* Dirección física del proveedor.

**Funcionalidades Destacadas:**

1. **Registro y Gestión de Productos:**
   - Permite agregar nuevos productos con detalles como stock, descripción, proveedor asociado, costo por unidad, e importe total.
   - Ofrece funcionalidades para editar y eliminar productos existentes.

2. **Registro y Gestión de Proveedores:**
   - Facilita el registro de nuevos proveedores con información detallada, como nombre completo, número de teléfono y dirección.
   - Proporciona opciones para editar y eliminar proveedores existentes.

3. **Relación Producto-Proveedor:**
   - Establece una relación entre productos y proveedores, permitiendo una fácil asociación y visualización de los productos suministrados por cada proveedor.

4. **Visualización Intuitiva:**
   - Implementa una interfaz de usuario intuitiva utilizando Blazor para una experiencia de usuario amigable.
   - Utiliza componentes interactivos para la presentación y manipulación eficiente de datos.

**Tecnologías Utilizadas:**
- **Blazor:** Framework de desarrollo de aplicaciones web interactivas.
- **C#:** Lenguaje de programación principal.
- **Entity Framework:** Para la manipulación de datos y la interacción con la base de datos.
- **Razor Components:** Para la creación de componentes reutilizables en la interfaz de usuario.

Este proyecto tiene como objetivo ofrecer una solución completa y eficaz para la gestión de productos y proveedores, mejorando la eficiencia operativa y facilitando la toma de decisiones empresariales.