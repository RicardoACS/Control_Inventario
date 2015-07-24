CREATE TABLE articulo
(
idArticulo int primary key,
descripcion varchar(50) unique
);

CREATE TABLE empresas
(
idEmpresa int,
nombreEmpresa varchar(50) unique,
constraint pk_idEmpresa primary key (idEmpresa)
);

CREATE TABLE item
(
idItem int,
descripcion varchar(50) unique,
idArticulo int,
constraint pk_idItem primary key (idItem),
constraint fk_item_articulo foreign key (idArticulo) references articulo (idArticulo)
);

CREATE TABLE centroCosto
(
idLocal int,
nombreCentroCosto varchar(50),
idEmpresa int,
constraint pk_idLocal primary key (idLocal),
constraint fk_centro_empresa foreign key (idEmpresa) references empresa (idEmpresa)
);

CREATE TABLE compras
(
numeroDoc int,
fecha varchar(20),
idArticulo int,
idItem int,
cantidad int,
precio int,
constraint pk_numeroDoc primary key (numeroDoc),
constraint fk_compras_articulo foreign key (idArticulo) references articulo (idArticulo),
constraint fk_compras_item foreign key (idItem) references item (idItem)
);


CREATE TABLE rebajarStock
(
idRebajarStock int,
idItem int,
idLocal int,
cantidad int,
constraint pk_rebajarStock primary key (idRebajarStock),
constraint fk_rebajarStock_idItem foreign key (idItem) references item (idItem),
constraint fk_rebajarStock_centroCosto foreign key (idLocal) references centroCosto(idLocal)
);
