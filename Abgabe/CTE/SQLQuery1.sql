USE ProjektArbeit;
GO

WITH CTE_Artikelgruppe_artikels (
	id, name)
AS (
	SELECT	Id ,
			name
	From Articelsgrupps
	union All
	SELECT id ,
			Bezeichnung
	From Articels
)
SELECT	Id ,
		name 

FROM CTE_Artikelgruppe_artikels;
GO