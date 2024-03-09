# adonet

> select [Id],[Name],[SmallName] from [dbo].[Sizes]

IN SQL &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; C# (adonet)		<br/><br/>

DataBase &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; DataSet		<br/>
Tables &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; DataTable		<br/>
Row &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; DataRow		<br/>
Column &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Column		<br/>

- [Ado Net Introduction](https://www.javatpoint.com/ado-net-introduction)
- [ConnectionString](https://www.connectionstrings.com)


IN SQL &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; C# (ORM)		<br/><br/>

DataBase &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; DbContext		<br/>
Tables &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; DbSet		<br/>
Row &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Class		<br/>
Column &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Property		<br/><br/><br/>


- [ORM - Object Relational Mapping Database Tools](https://www.freecodecamp.org/news/what-is-an-orm-the-meaning-of-object-relational-mapping-database-tools/)
- Ef Core
- Dapper

--------------------------------------------------------------------------
### Dependencies
	- Microsoft.EntityFrameworkCore		Version="8.0.2" 
	- Microsoft.EntityFrameworkCore.Tools	Version="8.0.2" 
	- Microsoft.EntityFrameworkCore.SqlServer	Version="8.0.2" 

--------------------------------------------------------------------------
- Database First
- Code First

### Commands of Migration
> add-migration Initial

> update-database

> update-database &lt;migration-name&gt;

> remove-migration

### Windows Authentification
> Data Source=.;Database=ShopDb;Trusted_Connection=True;Encrypt=false;
<br/>

### SqlServer Authentification
> Data Source=.;Database=ShopDb;User Id=adonet;Password=query;Encrypt=false;
<br/>

### Creating a Model for an Existing Database in Entity Framework Core
> Scaffold-DbContext "Data Source=.;Database=ShopDb;User Id=adonet;Password=query;Encrypt=false" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models