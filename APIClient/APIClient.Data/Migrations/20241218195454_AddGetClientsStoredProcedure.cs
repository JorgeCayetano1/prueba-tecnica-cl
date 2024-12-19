using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIClient.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddGetClientsStoredProcedure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                CREATE PROCEDURE GetClients
                    @Page INT,
                    @Size INT
                AS
                BEGIN
                    SET NOCOUNT ON;
                    WITH CTE AS (
				        SELECT 
				            Id, 
				            Name, 
				            Country, 
				            Phone,
				            COUNT(*) OVER () AS TotalCount
				        FROM Clients
				    )
				    SELECT 
				        Id, 
				        Name, 
				        Country, 
				        Phone,
				        TotalCount
				    FROM CTE
                    ORDER BY Id
                    OFFSET (@Page - 1) * @Size ROWS
                    FETCH NEXT @Size ROWS ONLY;
                END
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP PROCEDURE GetClients");
        }
    }
}
