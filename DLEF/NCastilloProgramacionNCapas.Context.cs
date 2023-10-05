﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DLEF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class NCastilloProgramacionNCapasEntities : DbContext
    {
        public NCastilloProgramacionNCapasEntities()
            : base("name=NCastilloProgramacionNCapasEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Rol> Rols { get; set; }
        public virtual DbSet<Colonia> Colonias { get; set; }
        public virtual DbSet<Direccion> Direccions { get; set; }
        public virtual DbSet<Estado> Estadoes { get; set; }
        public virtual DbSet<Municipio> Municipios { get; set; }
        public virtual DbSet<Pai> Pais { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Aseguradora> Aseguradoras { get; set; }
        public virtual DbSet<Empleado> Empleadoes { get; set; }
        public virtual DbSet<Empresa> Empresas { get; set; }
    
        public virtual ObjectResult<RolGetAll_Result> RolGetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RolGetAll_Result>("RolGetAll");
        }
    
        public virtual ObjectResult<ColoniaGetByIdMunicipio_Result> ColoniaGetByIdMunicipio(Nullable<int> idMunicipio)
        {
            var idMunicipioParameter = idMunicipio.HasValue ?
                new ObjectParameter("IdMunicipio", idMunicipio) :
                new ObjectParameter("IdMunicipio", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ColoniaGetByIdMunicipio_Result>("ColoniaGetByIdMunicipio", idMunicipioParameter);
        }
    
        public virtual ObjectResult<EstadoGetByIdPais_Result> EstadoGetByIdPais(Nullable<int> idPais)
        {
            var idPaisParameter = idPais.HasValue ?
                new ObjectParameter("IdPais", idPais) :
                new ObjectParameter("IdPais", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<EstadoGetByIdPais_Result>("EstadoGetByIdPais", idPaisParameter);
        }
    
        public virtual ObjectResult<MunicipioGetByIdEstado_Result> MunicipioGetByIdEstado(Nullable<int> idEstado)
        {
            var idEstadoParameter = idEstado.HasValue ?
                new ObjectParameter("IdEstado", idEstado) :
                new ObjectParameter("IdEstado", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<MunicipioGetByIdEstado_Result>("MunicipioGetByIdEstado", idEstadoParameter);
        }
    
        public virtual ObjectResult<PaisGetAll_Result> PaisGetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PaisGetAll_Result>("PaisGetAll");
        }
    
        public virtual ObjectResult<UsuarioGetById_Result> UsuarioGetById(Nullable<int> idUsuario)
        {
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UsuarioGetById_Result>("UsuarioGetById", idUsuarioParameter);
        }
    
        public virtual int UsuarioAdd(string userName, string nombre, string apellidoPaterno, string apellidoMaterno, string correo, string contraseña, string sexo, string telefono, string celular, Nullable<System.DateTime> fechaNacimiento, string curp, Nullable<int> idRol, string calle, Nullable<int> numeroExterior, Nullable<int> numeroInterior, Nullable<int> idColonia, string imagen, ObjectParameter filasAfectadas)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var apellidoPaternoParameter = apellidoPaterno != null ?
                new ObjectParameter("ApellidoPaterno", apellidoPaterno) :
                new ObjectParameter("ApellidoPaterno", typeof(string));
    
            var apellidoMaternoParameter = apellidoMaterno != null ?
                new ObjectParameter("ApellidoMaterno", apellidoMaterno) :
                new ObjectParameter("ApellidoMaterno", typeof(string));
    
            var correoParameter = correo != null ?
                new ObjectParameter("Correo", correo) :
                new ObjectParameter("Correo", typeof(string));
    
            var contraseñaParameter = contraseña != null ?
                new ObjectParameter("Contraseña", contraseña) :
                new ObjectParameter("Contraseña", typeof(string));
    
            var sexoParameter = sexo != null ?
                new ObjectParameter("Sexo", sexo) :
                new ObjectParameter("Sexo", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("Telefono", telefono) :
                new ObjectParameter("Telefono", typeof(string));
    
            var celularParameter = celular != null ?
                new ObjectParameter("Celular", celular) :
                new ObjectParameter("Celular", typeof(string));
    
            var fechaNacimientoParameter = fechaNacimiento.HasValue ?
                new ObjectParameter("FechaNacimiento", fechaNacimiento) :
                new ObjectParameter("FechaNacimiento", typeof(System.DateTime));
    
            var curpParameter = curp != null ?
                new ObjectParameter("Curp", curp) :
                new ObjectParameter("Curp", typeof(string));
    
            var idRolParameter = idRol.HasValue ?
                new ObjectParameter("IdRol", idRol) :
                new ObjectParameter("IdRol", typeof(int));
    
            var calleParameter = calle != null ?
                new ObjectParameter("Calle", calle) :
                new ObjectParameter("Calle", typeof(string));
    
            var numeroExteriorParameter = numeroExterior.HasValue ?
                new ObjectParameter("NumeroExterior", numeroExterior) :
                new ObjectParameter("NumeroExterior", typeof(int));
    
            var numeroInteriorParameter = numeroInterior.HasValue ?
                new ObjectParameter("NumeroInterior", numeroInterior) :
                new ObjectParameter("NumeroInterior", typeof(int));
    
            var idColoniaParameter = idColonia.HasValue ?
                new ObjectParameter("IdColonia", idColonia) :
                new ObjectParameter("IdColonia", typeof(int));
    
            var imagenParameter = imagen != null ?
                new ObjectParameter("Imagen", imagen) :
                new ObjectParameter("Imagen", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UsuarioAdd", userNameParameter, nombreParameter, apellidoPaternoParameter, apellidoMaternoParameter, correoParameter, contraseñaParameter, sexoParameter, telefonoParameter, celularParameter, fechaNacimientoParameter, curpParameter, idRolParameter, calleParameter, numeroExteriorParameter, numeroInteriorParameter, idColoniaParameter, imagenParameter, filasAfectadas);
        }
    
        public virtual int UsuarioDelete(Nullable<int> idUsuario, ObjectParameter filasAfectadas)
        {
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UsuarioDelete", idUsuarioParameter, filasAfectadas);
        }
    
        public virtual int UsuarioUpdate(Nullable<int> idUsuario, string userName, string nombre, string apellidoPaterno, string apellidoMaterno, string correo, string contraseña, string sexo, string telefono, string celular, Nullable<System.DateTime> fechaNacimiento, string curp, Nullable<int> idRol, string calle, Nullable<int> numeroExterior, Nullable<int> numeroInterior, Nullable<int> idColonia, string imagen, ObjectParameter filasAfectadas)
        {
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(int));
    
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var apellidoPaternoParameter = apellidoPaterno != null ?
                new ObjectParameter("ApellidoPaterno", apellidoPaterno) :
                new ObjectParameter("ApellidoPaterno", typeof(string));
    
            var apellidoMaternoParameter = apellidoMaterno != null ?
                new ObjectParameter("ApellidoMaterno", apellidoMaterno) :
                new ObjectParameter("ApellidoMaterno", typeof(string));
    
            var correoParameter = correo != null ?
                new ObjectParameter("Correo", correo) :
                new ObjectParameter("Correo", typeof(string));
    
            var contraseñaParameter = contraseña != null ?
                new ObjectParameter("Contraseña", contraseña) :
                new ObjectParameter("Contraseña", typeof(string));
    
            var sexoParameter = sexo != null ?
                new ObjectParameter("Sexo", sexo) :
                new ObjectParameter("Sexo", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("Telefono", telefono) :
                new ObjectParameter("Telefono", typeof(string));
    
            var celularParameter = celular != null ?
                new ObjectParameter("Celular", celular) :
                new ObjectParameter("Celular", typeof(string));
    
            var fechaNacimientoParameter = fechaNacimiento.HasValue ?
                new ObjectParameter("FechaNacimiento", fechaNacimiento) :
                new ObjectParameter("FechaNacimiento", typeof(System.DateTime));
    
            var curpParameter = curp != null ?
                new ObjectParameter("Curp", curp) :
                new ObjectParameter("Curp", typeof(string));
    
            var idRolParameter = idRol.HasValue ?
                new ObjectParameter("IdRol", idRol) :
                new ObjectParameter("IdRol", typeof(int));
    
            var calleParameter = calle != null ?
                new ObjectParameter("Calle", calle) :
                new ObjectParameter("Calle", typeof(string));
    
            var numeroExteriorParameter = numeroExterior.HasValue ?
                new ObjectParameter("NumeroExterior", numeroExterior) :
                new ObjectParameter("NumeroExterior", typeof(int));
    
            var numeroInteriorParameter = numeroInterior.HasValue ?
                new ObjectParameter("NumeroInterior", numeroInterior) :
                new ObjectParameter("NumeroInterior", typeof(int));
    
            var idColoniaParameter = idColonia.HasValue ?
                new ObjectParameter("IdColonia", idColonia) :
                new ObjectParameter("IdColonia", typeof(int));
    
            var imagenParameter = imagen != null ?
                new ObjectParameter("Imagen", imagen) :
                new ObjectParameter("Imagen", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UsuarioUpdate", idUsuarioParameter, userNameParameter, nombreParameter, apellidoPaternoParameter, apellidoMaternoParameter, correoParameter, contraseñaParameter, sexoParameter, telefonoParameter, celularParameter, fechaNacimientoParameter, curpParameter, idRolParameter, calleParameter, numeroExteriorParameter, numeroInteriorParameter, idColoniaParameter, imagenParameter, filasAfectadas);
        }
    
        public virtual int UsuarioChangeStatus(Nullable<int> idUsuario, Nullable<bool> status)
        {
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(int));
    
            var statusParameter = status.HasValue ?
                new ObjectParameter("Status", status) :
                new ObjectParameter("Status", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UsuarioChangeStatus", idUsuarioParameter, statusParameter);
        }
    
        public virtual int AseguradoraDelete(Nullable<int> idAseguradora)
        {
            var idAseguradoraParameter = idAseguradora.HasValue ?
                new ObjectParameter("IdAseguradora", idAseguradora) :
                new ObjectParameter("IdAseguradora", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AseguradoraDelete", idAseguradoraParameter);
        }
    
        public virtual ObjectResult<AseguradoraGetAll_Result> AseguradoraGetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AseguradoraGetAll_Result>("AseguradoraGetAll");
        }
    
        public virtual ObjectResult<AseguradoraGetById_Result> AseguradoraGetById(Nullable<int> idAseguradora)
        {
            var idAseguradoraParameter = idAseguradora.HasValue ?
                new ObjectParameter("IdAseguradora", idAseguradora) :
                new ObjectParameter("IdAseguradora", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AseguradoraGetById_Result>("AseguradoraGetById", idAseguradoraParameter);
        }
    
        public virtual int AseguradoraUpdate(Nullable<int> idAseguradora, string nombre, Nullable<int> idUsuario)
        {
            var idAseguradoraParameter = idAseguradora.HasValue ?
                new ObjectParameter("IdAseguradora", idAseguradora) :
                new ObjectParameter("IdAseguradora", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AseguradoraUpdate", idAseguradoraParameter, nombreParameter, idUsuarioParameter);
        }
    
        public virtual int AseguradoraAdd(string nombre, Nullable<int> idUsuario)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AseguradoraAdd", nombreParameter, idUsuarioParameter);
        }
    
        public virtual ObjectResult<UsuarioDropList_Result> UsuarioDropList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UsuarioDropList_Result>("UsuarioDropList");
        }
    
        public virtual ObjectResult<GetByEmail_Result> GetByEmail(string correo)
        {
            var correoParameter = correo != null ?
                new ObjectParameter("Correo", correo) :
                new ObjectParameter("Correo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetByEmail_Result>("GetByEmail", correoParameter);
        }
    
        public virtual int EmpleadoAdd(string numeroEmpleado, string rfc, string nombre, string apellidoPaterno, string apellidoMaterno, string email, string telefono, Nullable<System.DateTime> fechaNacimiento, string nss, Nullable<System.DateTime> fechaIngreso, string foto, Nullable<int> idEmpresa)
        {
            var numeroEmpleadoParameter = numeroEmpleado != null ?
                new ObjectParameter("NumeroEmpleado", numeroEmpleado) :
                new ObjectParameter("NumeroEmpleado", typeof(string));
    
            var rfcParameter = rfc != null ?
                new ObjectParameter("Rfc", rfc) :
                new ObjectParameter("Rfc", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var apellidoPaternoParameter = apellidoPaterno != null ?
                new ObjectParameter("ApellidoPaterno", apellidoPaterno) :
                new ObjectParameter("ApellidoPaterno", typeof(string));
    
            var apellidoMaternoParameter = apellidoMaterno != null ?
                new ObjectParameter("ApellidoMaterno", apellidoMaterno) :
                new ObjectParameter("ApellidoMaterno", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("Telefono", telefono) :
                new ObjectParameter("Telefono", typeof(string));
    
            var fechaNacimientoParameter = fechaNacimiento.HasValue ?
                new ObjectParameter("FechaNacimiento", fechaNacimiento) :
                new ObjectParameter("FechaNacimiento", typeof(System.DateTime));
    
            var nssParameter = nss != null ?
                new ObjectParameter("Nss", nss) :
                new ObjectParameter("Nss", typeof(string));
    
            var fechaIngresoParameter = fechaIngreso.HasValue ?
                new ObjectParameter("FechaIngreso", fechaIngreso) :
                new ObjectParameter("FechaIngreso", typeof(System.DateTime));
    
            var fotoParameter = foto != null ?
                new ObjectParameter("Foto", foto) :
                new ObjectParameter("Foto", typeof(string));
    
            var idEmpresaParameter = idEmpresa.HasValue ?
                new ObjectParameter("IdEmpresa", idEmpresa) :
                new ObjectParameter("IdEmpresa", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("EmpleadoAdd", numeroEmpleadoParameter, rfcParameter, nombreParameter, apellidoPaternoParameter, apellidoMaternoParameter, emailParameter, telefonoParameter, fechaNacimientoParameter, nssParameter, fechaIngresoParameter, fotoParameter, idEmpresaParameter);
        }
    
        public virtual ObjectResult<EmpleadoGetById_Result> EmpleadoGetById(string numeroEmpleado)
        {
            var numeroEmpleadoParameter = numeroEmpleado != null ?
                new ObjectParameter("NumeroEmpleado", numeroEmpleado) :
                new ObjectParameter("NumeroEmpleado", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<EmpleadoGetById_Result>("EmpleadoGetById", numeroEmpleadoParameter);
        }
    
        public virtual int EmpleadoUpdate(string numeroEmpleado, string rfc, string nombre, string apellidoPaterno, string apellidoMaterno, string email, string telefono, Nullable<System.DateTime> fechaNacimiento, string nss, Nullable<System.DateTime> fechaIngreso, string foto, Nullable<int> idEmpresa)
        {
            var numeroEmpleadoParameter = numeroEmpleado != null ?
                new ObjectParameter("NumeroEmpleado", numeroEmpleado) :
                new ObjectParameter("NumeroEmpleado", typeof(string));
    
            var rfcParameter = rfc != null ?
                new ObjectParameter("Rfc", rfc) :
                new ObjectParameter("Rfc", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var apellidoPaternoParameter = apellidoPaterno != null ?
                new ObjectParameter("ApellidoPaterno", apellidoPaterno) :
                new ObjectParameter("ApellidoPaterno", typeof(string));
    
            var apellidoMaternoParameter = apellidoMaterno != null ?
                new ObjectParameter("ApellidoMaterno", apellidoMaterno) :
                new ObjectParameter("ApellidoMaterno", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("Telefono", telefono) :
                new ObjectParameter("Telefono", typeof(string));
    
            var fechaNacimientoParameter = fechaNacimiento.HasValue ?
                new ObjectParameter("FechaNacimiento", fechaNacimiento) :
                new ObjectParameter("FechaNacimiento", typeof(System.DateTime));
    
            var nssParameter = nss != null ?
                new ObjectParameter("Nss", nss) :
                new ObjectParameter("Nss", typeof(string));
    
            var fechaIngresoParameter = fechaIngreso.HasValue ?
                new ObjectParameter("FechaIngreso", fechaIngreso) :
                new ObjectParameter("FechaIngreso", typeof(System.DateTime));
    
            var fotoParameter = foto != null ?
                new ObjectParameter("Foto", foto) :
                new ObjectParameter("Foto", typeof(string));
    
            var idEmpresaParameter = idEmpresa.HasValue ?
                new ObjectParameter("IdEmpresa", idEmpresa) :
                new ObjectParameter("IdEmpresa", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("EmpleadoUpdate", numeroEmpleadoParameter, rfcParameter, nombreParameter, apellidoPaternoParameter, apellidoMaternoParameter, emailParameter, telefonoParameter, fechaNacimientoParameter, nssParameter, fechaIngresoParameter, fotoParameter, idEmpresaParameter);
        }
    
        public virtual ObjectResult<UsuarioGetAll_Result> UsuarioGetAll(string nombre, string apellidoPaterno)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var apellidoPaternoParameter = apellidoPaterno != null ?
                new ObjectParameter("ApellidoPaterno", apellidoPaterno) :
                new ObjectParameter("ApellidoPaterno", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UsuarioGetAll_Result>("UsuarioGetAll", nombreParameter, apellidoPaternoParameter);
        }
    
        public virtual ObjectResult<EmpleadoGetAll_Result> EmpleadoGetAll(Nullable<int> idEmpresa, string nombre)
        {
            var idEmpresaParameter = idEmpresa.HasValue ?
                new ObjectParameter("IdEmpresa", idEmpresa) :
                new ObjectParameter("IdEmpresa", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<EmpleadoGetAll_Result>("EmpleadoGetAll", idEmpresaParameter, nombreParameter);
        }
    
        public virtual ObjectResult<EmpresaGetAll_Result> EmpresaGetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<EmpresaGetAll_Result>("EmpresaGetAll");
        }
    
        public virtual ObjectResult<DependienteGetByIdEmpleado_Result> DependienteGetByIdEmpleado(string numeroEmpleado)
        {
            var numeroEmpleadoParameter = numeroEmpleado != null ?
                new ObjectParameter("NumeroEmpleado", numeroEmpleado) :
                new ObjectParameter("NumeroEmpleado", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DependienteGetByIdEmpleado_Result>("DependienteGetByIdEmpleado", numeroEmpleadoParameter);
        }
    
        public virtual ObjectResult<DependienteGetById_Result> DependienteGetById(Nullable<int> idDependiente)
        {
            var idDependienteParameter = idDependiente.HasValue ?
                new ObjectParameter("IdDependiente", idDependiente) :
                new ObjectParameter("IdDependiente", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DependienteGetById_Result>("DependienteGetById", idDependienteParameter);
        }
    
        public virtual int DependienteUpdate(Nullable<int> idDependiente, string nombre, string apellidoPaterno, string apellidoMaterno, Nullable<System.DateTime> fechaNacimiento, string estadoCivil, string genero, string telefono, string rfc)
        {
            var idDependienteParameter = idDependiente.HasValue ?
                new ObjectParameter("IdDependiente", idDependiente) :
                new ObjectParameter("IdDependiente", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var apellidoPaternoParameter = apellidoPaterno != null ?
                new ObjectParameter("ApellidoPaterno", apellidoPaterno) :
                new ObjectParameter("ApellidoPaterno", typeof(string));
    
            var apellidoMaternoParameter = apellidoMaterno != null ?
                new ObjectParameter("ApellidoMaterno", apellidoMaterno) :
                new ObjectParameter("ApellidoMaterno", typeof(string));
    
            var fechaNacimientoParameter = fechaNacimiento.HasValue ?
                new ObjectParameter("FechaNacimiento", fechaNacimiento) :
                new ObjectParameter("FechaNacimiento", typeof(System.DateTime));
    
            var estadoCivilParameter = estadoCivil != null ?
                new ObjectParameter("EstadoCivil", estadoCivil) :
                new ObjectParameter("EstadoCivil", typeof(string));
    
            var generoParameter = genero != null ?
                new ObjectParameter("Genero", genero) :
                new ObjectParameter("Genero", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("Telefono", telefono) :
                new ObjectParameter("Telefono", typeof(string));
    
            var rfcParameter = rfc != null ?
                new ObjectParameter("Rfc", rfc) :
                new ObjectParameter("Rfc", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DependienteUpdate", idDependienteParameter, nombreParameter, apellidoPaternoParameter, apellidoMaternoParameter, fechaNacimientoParameter, estadoCivilParameter, generoParameter, telefonoParameter, rfcParameter);
        }
    
        public virtual int DependienteAdd(string nombre, string apellidoPaterno, string apellidoMaterno, Nullable<System.DateTime> fechaNacimiento, string estadoCivil, string genero, string telefono, string rfc, string numeroEmpleado)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var apellidoPaternoParameter = apellidoPaterno != null ?
                new ObjectParameter("ApellidoPaterno", apellidoPaterno) :
                new ObjectParameter("ApellidoPaterno", typeof(string));
    
            var apellidoMaternoParameter = apellidoMaterno != null ?
                new ObjectParameter("ApellidoMaterno", apellidoMaterno) :
                new ObjectParameter("ApellidoMaterno", typeof(string));
    
            var fechaNacimientoParameter = fechaNacimiento.HasValue ?
                new ObjectParameter("FechaNacimiento", fechaNacimiento) :
                new ObjectParameter("FechaNacimiento", typeof(System.DateTime));
    
            var estadoCivilParameter = estadoCivil != null ?
                new ObjectParameter("EstadoCivil", estadoCivil) :
                new ObjectParameter("EstadoCivil", typeof(string));
    
            var generoParameter = genero != null ?
                new ObjectParameter("Genero", genero) :
                new ObjectParameter("Genero", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("Telefono", telefono) :
                new ObjectParameter("Telefono", typeof(string));
    
            var rfcParameter = rfc != null ?
                new ObjectParameter("Rfc", rfc) :
                new ObjectParameter("Rfc", typeof(string));
    
            var numeroEmpleadoParameter = numeroEmpleado != null ?
                new ObjectParameter("NumeroEmpleado", numeroEmpleado) :
                new ObjectParameter("NumeroEmpleado", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DependienteAdd", nombreParameter, apellidoPaternoParameter, apellidoMaternoParameter, fechaNacimientoParameter, estadoCivilParameter, generoParameter, telefonoParameter, rfcParameter, numeroEmpleadoParameter);
        }
    
        public virtual int DependienteDelete(Nullable<int> idDependiente)
        {
            var idDependienteParameter = idDependiente.HasValue ?
                new ObjectParameter("IdDependiente", idDependiente) :
                new ObjectParameter("IdDependiente", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DependienteDelete", idDependienteParameter);
        }
    
        public virtual int EmpleadoDelete(string numeroEmpleado)
        {
            var numeroEmpleadoParameter = numeroEmpleado != null ?
                new ObjectParameter("NumeroEmpleado", numeroEmpleado) :
                new ObjectParameter("NumeroEmpleado", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("EmpleadoDelete", numeroEmpleadoParameter);
        }
    }
}
