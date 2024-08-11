CREATE TABLE [dbo].[District] (
    [DistrictID]   INT            IDENTITY (1, 1) NOT NULL,
    [DistrictName] NVARCHAR (100) NULL,
    [IsDeleted] BIT            NULL,
    PRIMARY KEY CLUSTERED ([DistrictID] ASC)
);

CREATE TABLE [dbo].[City] (
    [CityID]   INT            IDENTITY (1, 1) NOT NULL,
    [CityName] NVARCHAR (100) NULL,
    [IsDeleted] BIT            NULL,
    PRIMARY KEY CLUSTERED ([CityID] ASC)
);