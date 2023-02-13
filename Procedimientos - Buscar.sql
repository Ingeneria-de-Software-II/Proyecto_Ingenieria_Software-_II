Use Restaurantes
go
Create procedure [dbo].[Buscar_Plato]
	 @Dato varchar(20)
	 as
Select
 PlatoID as ID,
 Nombre,
 Categoria,
 Descripcion,
 Precio
 from Plato
 where Nombre like @Dato + '%' 
GO

Alter procedure [dbo].[Buscar_Bebida] @Dato varchar(20)
as
	Select 
		B.Nombre,
		P.NombreCompania + ', ' + LM.Municipio + ', ' + D.NombreDepartamento Proveedor,
		B.Precio
	from Bebida B
	Inner Join Proveedor P ON B.ProveedorID = P.ProveedorID
	INNER JOIN LocalidadMunicipio LM ON LM.LocalidadID = P.LocalidadID
	INNER JOIN Departamento D ON D.DepartamentoID = LM.DepartamentoID
	where Nombre like @Dato + '%' 
GO
