USE MASTER;
GO
IF EXISTS(SELECT * FROM sys.databases WHERE NAME = 'Projektarbeit') BEGIN
	DROP DATABASE TemporalDemo;
END;
GO
CREATE DATABASE TemporalDemo;
ALTER DATABASE TemporalDemo SET RECOVERY SIMPLE WITH NO_WAIT;
GO
USE TemporalDemo;
GO


  CREATE TABLE OP_Rechnung
   (	Kundennummer int, 
	Name VARCHAR(40) ,
	Strasse VARCHAR(30),
	PLZ CHAR(4) , 
	ORT VARCHAR(30) , 
	Land VARCHAR(12), 
	Rechnungsdatum Datetime, 
	RechnungNummer VARCHAR(40), 
	RechnungsbetragNetto VARCHAR(40), 
	RechnungsbetragBrutto VArchar(40) , 
	
   ) ;

  insert into OP_Rechnung values(26,'Hans Muster','Müllerstrasse 5','8055','St. Gallen','Schweden',
  convert(datetime,'31-JAN-2011'), '500','550');
