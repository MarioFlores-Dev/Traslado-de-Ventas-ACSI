# Contabilizacion de ventas de puntos de venta

Aplicación para contabilizar las ventas del punto de venta

## Pevio a su instalacion
Es necesario comentar unas lineas en el rpt_poliza_ventas_POSFEL o en el caso que no existierta debemos de crear un sp con ese nombre que haga la contabilizacion y unicamente se deban de mandar los parametros.

## Es necesario crear lo siguiente:
Crear procedimientos almacenados (store procedures | sp).

    Crear sp para extraer la empresa:
        CREATE PROCEDURE [dbo].[sp_getEmpresas]
         as
            select 
                Id_Empresa,
                Nombre_Empresa
            from empresas

Luego un procedimiento para verificar los traslados, tomar en cuenta que hay que cambiar de donde extrae la informacion al ser a otra base de datos

    CREATE PROCEDURE [dbo].[sp_verificarTraslados] 
            @id_empresa int,
            @anio varchar(5),
            @mes varchar(5),
            @tipo varchar(5),
            @caja varchar(2)
        AS
	    select * from db_contabilidad_pfp.dbo.cabecera_Movimientos 
	    where ID_EMPRESA = @id_empresa  and ANIO = @anio and MES = @mes and TIPO = @tipo and substring(NUMERO,7,2) = @caja
    

## Instalación:

    - Se verifican los Procedimientos almacenados(sp)
    - Se ejecuta el setup.exe
    - Se configura el archivo app.config
    - Se genera el acceso directo.
    - Se cambia al nombre al acceso directo. 