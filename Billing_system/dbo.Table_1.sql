CREATE TABLE [dbo].[Biling_seans]
(
	[Id_Abonent_For_Seans] INT NOT NULL PRIMARY KEY, 
    [Time_Start] TIME NOT NULL, 
    [Time_End] TIME NOT NULL, 
    [Tarif] NVARCHAR(MAX) NOT NULL, 
    [Type_data] NCHAR(10) NOT NULL, 
    [Size_byte,] NCHAR(10) NOT NULL
)
