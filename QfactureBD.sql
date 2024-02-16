create database Qfacture
use Qfacture

create table TipoUsuario(
IdTipo int primary key not null,
DescripcionTipo varchar(40)
)

create table Usuario(
IdUsuario int primary key not null identity(1,1),
NombreUsuario varchar(50),
Contraseña varchar(50),
Estado varchar(50) default 'Activo',

IdTipo int foreign key references TipoUsuario(IdTipo)
)

create table DatosUsuario(
Nombre varchar(50),
Apellido varchar (50),
RFC varchar(15),
DomicilioFiscal varchar(100),
CodigoPostal varchar(50),

IdUsuario int foreign key references Usuario(IdUsuario)
)

create table Receptor(
RFCReceptor varchar(100) primary key not null,
NombreReceptor varchar(MAX),
DomicilioReceptor varchar(MAX),
CodigoPostalReceptor varchar(MAX)
)

create table Factura(
Folio varchar(100) primary key not null,
SerieFiscal varchar(MAX),
FechaOperacion varchar(MAX),
FechaExpedicion varchar(MAX),
NIF varchar(MAX),
TipoMoneda varchar(MAX),
Total money,

IdUsuario int foreign key references Usuario(IdUsuario),
RFCReceptor varchar(100) foreign key references Receptor(RFCReceptor)
)

create table Concepto(
IdConcepto int primary key not null identity(1,1),
Descripcion varchar(30),
Cantidad int,
PrecioUnitario money,
Descuento decimal(5,2),
IVA decimal(5,2),

Folio varchar(100) foreign key references Factura(Folio)
)

alter table Usuario add constraint U_Nombre unique (NombreUsuario)

insert into TipoUsuario values (1,'Administrador')
insert into TipoUsuario values (2,'Usuario')

create view informacion
as
SELECT       dbo.DatosUsuario.Nombre, dbo.DatosUsuario.Apellido, dbo.DatosUsuario.RFC, dbo.DatosUsuario.DomicilioFiscal,
dbo.DatosUsuario.CodigoPostal, dbo.Usuario.NombreUsuario, dbo.Usuario.Contraseña, dbo.Usuario.Estado, dbo.Usuario.IdUsuario

FROM            dbo.DatosUsuario JOIN dbo.Usuario ON dbo.DatosUsuario.IdUsuario = dbo.Usuario.IdUsuario

select *  from informacion

create view Consulta
as
SELECT dbo.Usuario.IdUsuario, dbo.Factura.Folio, CONCAT(dbo.DatosUsuario.Nombre, dbo.DatosUsuario.Apellido) as Nombre, dbo.DatosUsuario.RFC,
dbo.DatosUsuario.DomicilioFiscal, dbo.DatosUsuario.CodigoPostal, dbo.Receptor.NombreReceptor, dbo.Receptor.RFCReceptor, dbo.Receptor.DomicilioReceptor, 
dbo.Receptor.CodigoPostalReceptor, dbo.Factura.FechaExpedicion, dbo.Factura.FechaOperacion, dbo.Factura.NIF, dbo.Factura.SerieFiscal, dbo.Factura.TipoMoneda,
dbo.Concepto.Descripcion, dbo.Concepto.Cantidad, dbo.Concepto.PrecioUnitario, dbo.Concepto.Descuento, dbo.Concepto.IVA as Impuesto,
dbo.Factura.Total

FROM dbo.DatosUsuario 
JOIN dbo.Usuario ON dbo.DatosUsuario.IdUsuario = dbo.Usuario.IdUsuario 
JOIN dbo.Factura ON dbo.Usuario.IdUsuario = dbo.Factura.IdUsuario
JOIN dbo.Receptor ON dbo.Factura.RFCReceptor = dbo.Receptor.RFCReceptor
JOIN dbo.Concepto ON dbo.Factura.Folio = dbo.Concepto.Folio

select * from Consulta