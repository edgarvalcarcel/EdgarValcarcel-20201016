# Bertoni Albums
En este proyecto: "Albums" como prueba tecnica para Bertoni solutions, las dependencias de cada una de las capas fluyen hacia el círculo más interno de la estructura de arquitectura limpia utilizada. la capa Application toma su nombre de su posición en el núcleo de este diagrama de una arquitectura limpia(tomada del libro clean arquitecture. Robert Martin). en un diagrama de esta arquitectura se puede apreciar que la capa Application no tiene dependencias en otras capas de aplicaciones. Las entidades e interfaces de la aplicación están en el centro. Justo afuera, pero incluso en la capa Application, hay servicios de dominio, que típicamente implementan interfaces definidas en el círculo interno. Fuera de este capa Application, tanto la UI (MVC Core en este caso), como las capas de Infraestructura dependen de Application Core, pero no una de la otra (necesariamente). Debido a que Application no depende de Infraestructura, es muy fácil escribir pruebas unitarias automatizadas en este tipo de arquitectura
