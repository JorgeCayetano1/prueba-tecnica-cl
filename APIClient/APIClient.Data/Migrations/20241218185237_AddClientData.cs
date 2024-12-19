using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIClient.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddClientData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                            
                INSERT INTO Clients (Name, Country, Phone) VALUES
                ('John Doe', 'USA', '+1-555-1234'),
                ('Jane Smith', 'Canada', '+1-416-9876'),
                ('Carlos García', 'Mexico', '+52-55-1234-5678'),
                ('Anna Müller', 'Germany', '+49-30-123456'),
                ('Akira Yamamoto', 'Japan', '+81-3-1234-5678'),
                ('Sofia Rossi', 'Italy', '+39-06-12345678'),
                ('Liam O’Connor', 'Ireland', '+353-1-1234567'),
                ('Chen Wei', 'China', '+86-10-12345678'),
                ('Aisha Mohammed', 'UAE', '+971-2-1234567'),
                ('Ivan Petrov', 'Russia', '+7-495-123-4567'),
                ('Emma Brown', 'Australia', '+61-2-1234-5678'),
                ('Diego Torres', 'Argentina', '+54-11-1234-5678'),
                ('Elena Popescu', 'Romania', '+40-21-123-4567'),
                ('Lucas Silva', 'Brazil', '+55-21-1234-5678'),
                ('Marie Dubois', 'France', '+33-1-12345678'),
                ('David Andersen', 'Denmark', '+45-12-34-56-78'),
                ('Mohammed Khan', 'India', '+91-22-1234-5678'),
                ('Emily Johnson', 'UK', '+44-20-1234-5678'),
                ('Ahmed Ali', 'Egypt', '+20-2-12345678'),
                ('Sophia Lee', 'South Korea', '+82-2-123-4567'),
                ('Pablo Fernández', 'Spain', '+34-91-123-4567'),
                ('Nora Svensson', 'Sweden', '+46-8-123-4567'),
                ('Isabella Neri', 'Italy', '+39-02-87654321'),
                ('Liam Walker', 'New Zealand', '+64-9-123-4567'),
                ('Olivia Martínez', 'Colombia', '+57-1-1234567'),
                ('Yusuf Demir', 'Turkey', '+90-212-123-4567'),
                ('Hassan Al-Saleh', 'Saudi Arabia', '+966-11-123-4567'),
                ('Mia Clarke', 'South Africa', '+27-11-1234567'),
                ('Sven Koch', 'Germany', '+49-89-123-4567'),
                ('Chloe Nguyen', 'Vietnam', '+84-24-1234567'),
                ('Adriana Vasquez', 'Peru', '+51-1-1234567'),
                ('Benjamin Carter', 'USA', '+1-212-9876'),
                ('Victoria Kim', 'South Korea', '+82-51-7654321'),
                ('Daniel Brown', 'Canada', '+1-604-7654321'),
                ('Sara Lindberg', 'Norway', '+47-22-123456'),
                ('Arjun Sharma', 'India', '+91-11-9876-5432'),
                ('Julia Hoffmann', 'Austria', '+43-1-23456789'),
                ('Luca Ferrari', 'Italy', '+39-06-11223344'),
                ('Ethan Williams', 'USA', '+1-312-555-4321'),
                ('Fatima Yusuf', 'Nigeria', '+234-1-2345678'),
                ('Alejandro Moreno', 'Chile', '+56-2-9876543'),
                ('Natalie Cook', 'Australia', '+61-3-7654321'),
                ('Noah Becker', 'Germany', '+49-40-9876543'),
                ('Mariam Ibrahim', 'Sudan', '+249-11-9876543'),
                ('Oscar Cruz', 'Ecuador', '+593-2-1234567'),
                ('Diana Reyes', 'Panama', '+507-123-4567'),
                ('Amara Okafor', 'Nigeria', '+234-803-123-4567'),
                ('Victor Huang', 'Taiwan', '+886-2-1234567'),
                ('Gabriel Sousa', 'Portugal', '+351-21-1234567'),
                ('Hannah Wilson', 'New Zealand', '+64-4-9876543');

            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                DELETE FROM Client;
            ");
        }
    }
}
