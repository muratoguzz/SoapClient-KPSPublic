## Implementation of the KPSPublic microservice using the Adapter design pattern.

## Creating a Database

Run this command in your database management system to create a database named `MemberDb` and create a table named `Members` in it.ypass permissions to delete matching refs.

```sql
USE MemberDb;

CREATE TABLE Members (
    Id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    DateOfBirth DATE NOT NULL,   

    TcNo CHAR(11) NOT NULL,
    Email NVARCHAR(100) NOT NULL UNIQUE
);
```

## Usage Instructions

To use the application, please enter your credentials in the `Program.cs` file of the `MemberRegistration.ConsoleUI` layer.
