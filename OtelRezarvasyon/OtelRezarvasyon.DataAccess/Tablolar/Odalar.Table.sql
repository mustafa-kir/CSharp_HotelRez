CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Oda No] INT NOT NULL, 
    [Oda Kişi Sayısı] NCHAR(10) NOT NULL, 
    [Oda Gunluk Ucreti] INT NOT NULL, 
    [Tarih Aralığı] DATETIME NULL, 
    [Durum] TINYINT NOT NULL, 
    [Oda Temsilcisi] NCHAR(20) NOT NULL
)
