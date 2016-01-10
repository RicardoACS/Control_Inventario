
CREATE TABLE articulo
(
idArticulo INT PRIMARY KEY,
descripcion VARCHAR(50) UNIQUE
);

CREATE TABLE empresas
(
idEmpresa INT,
nombreEmpresa VARCHAR(50) UNIQUE,
CONSTRAINT pk_idEmpresa PRIMARY KEY (idEmpresa)
);

CREATE TABLE item
(
idItem INT,
descripcion VARCHAR(50) UNIQUE,
idArticulo INT,
CONSTRAINT pk_idItem PRIMARY KEY (idItem),
CONSTRAINT fk_item_articulo foreign key (idArticulo) references articulo (idArticulo)
);

CREATE TABLE centroCosto
(
idLocal INT,
nombreCentroCosto VARCHAR(50),
idEmpresa INT,
CONSTRAINT pk_idLocal PRIMARY KEY (idLocal),
CONSTRAINT fk_centro_empresa foreign key (idEmpresa) references empresa (idEmpresa)
);

CREATE TABLE compras
(
numeroDoc INT,
fecha VARCHAR(20),
idArticulo INT,
idItem INT,
cantidad INT,
precio INT,
CONSTRAINT pk_numeroDoc PRIMARY KEY (numeroDoc),
CONSTRAINT fk_compras_articulo foreign key (idArticulo) references articulo (idArticulo),
CONSTRAINT fk_compras_item foreign key (idItem) references item (idItem)
);


CREATE TABLE rebajarStock
(
idRebajarStock INT,
idItem INT,
idLocal INT,
cantidad INT,
fecha DATE,
CONSTRAINT pk_rebajarStock PRIMARY KEY (idRebajarStock),
CONSTRAINT fk_rebajarStock_idItem foreign key (idItem) references item (idItem),
CONSTRAINT fk_rebajarStock_centroCosto foreign key (idLocal) references centroCosto(idLocal)
);

CREATE TABLE insumos
(
idInsumos INT,
nroGuia INT,
fechaGuia DATE,
cantidad INT,
fechaRealizacion DATE,
idArticulo INT,
idItem INT,
idLocal INT,
CONSTRAINT pk_idInsumos PRIMARY KEY (idInsumos),
CONSTRAINT fk_insumo_idItem FOREIGN KEY (idItem) REFERENCES item (idItem),
CONSTRAINT fk_insumo_centroCosto FOREIGN KEY (idLocal) REFERENCES centroCosto(idLocal),
CONSTRAINT fk_insumo_articulo FOREIGN KEY (idArticulo) REFERENCES articulo(idArticulo)
);

/** Consulta EXCEL sobre consumo **/

SELECT c.numeroDoc AS 'Nª de Doc', c.fecha AS 'Fecha', i.descripcion AS 'Descripción', c.precio AS 'Precio Unitario', c.cantidad AS 'Saldo Físico', (c.precio * c.cantidad) AS 'Total Físico'
FROM compras c INNER JOIN item i ON c.idItem = i.idItem
ORDER BY 1 AND 2;

/** Consulta EXCEL sobre Total insumos del mes **/

SELECT ce.nombreCentroCosto AS 'Local', i.descripcion AS 'Item', r.cantidad AS 'Cantidad', c.precio AS 'Valor Unitario', (c.precio * r.cantidad) AS 'Total'
FROM rebajarStock r 
INNER JOIN centroCosto ce ON r.idLocal = ce.idLocal 
INNER JOIN item i ON r.idItem = i.idItem
INNER JOIN compras c ON c.idItem = i.IdItem
ORDER BY 1;

/** UPdate item del rebajarStock **/
UPDATE rebajarStock SET idItem = 17 WHERE idRebajarStock = 1;

/** Ver los que está en rebajarStock **/
SELECT r.idItem 'Rebajar ID', i.idItem 'ID', i.descripcion
FROM rebajarStock r INNER JOIN item i ON r.idItem = i.idItem

SELECT r.idItem 'Rebajar ID', i.idItem 'ID', i.descripcion, c.nombreCentroCosto
FROM rebajarStock r INNER JOIN item i ON r.idItem = i.idItem
INNER JOIN centroCosto c ON c.idLocal = r.idLocal;

/** CONSULTA SOBRE INSUMOS **/

SELECT ce.nombreCentroCosto AS 'Local', a.descripcion AS 'Articulo', ins.cantidad AS 'Cantidad', c.precio AS 'Valor Unitario', (c.precio * ins.cantidad) AS 'Total'
FROM insumos ins
INNER JOIN centroCosto ce ON ins.idLocal = ce.idLocal
INNER JOIN item i ON ins.idItem = i.idItem
LEFT JOIN compras c ON i.idItem = c.IdItem
INNER JOIN articulo a ON a.idArticulo = ins.idArticulo
GROUP BY 1
ORDER BY 1;

