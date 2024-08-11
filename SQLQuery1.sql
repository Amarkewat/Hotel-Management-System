CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY IDENTITY(1,1),
    EmployeeCode VARCHAR(20) NOT NULL,
    EmployeeName VARCHAR(100) NOT NULL,
    Address VARCHAR(255),
    CityCode VARCHAR(10),
    DateOfBirth DATE,
    Education VARCHAR(100),
    DesignationCode VARCHAR(20),
    Remark VARCHAR(255),
    DeleteFlag BIT DEFAULT 0 -- Default value for delete flag is set to 0 (false)
);