dotnet ef migrations script --idempotent --project ..\Nethereum.eShop.SqlServer --context Nethereum.eShop.SqlServer.Catalog.SqlServerCatalogContext --output ..\Nethereum.eShop.SqlServer\Catalog\Migrations\Scripts\CreateCatalogDb.sql
dotnet ef migrations script --project ..\Nethereum.eShop.Sqlite --context Nethereum.eShop.Sqlite.Catalog.SqliteCatalogContext --output ..\Nethereum.eShop.Sqlite\Catalog\Migrations\Scripts\CreateCatalogDb.sql