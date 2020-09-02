/*SELECT 
	Biling_abonent.Name_abonent, 
	Biling_abonent.Surname_abonent, 
	'9.15.2019' AS Date_Start,
	 DATEADD(month,1,'1.11.2019') AS Date_End, 
	 SUM (
		CASE WHEN Biling_seans.Type_data=1 
		THEN DATEDIFF(second, Biling_seans.Time_Start, Biling_seans.Time_End) / 60 * 1 
		ELSE 
			CASE WHEN Biling_seans.Type_data=2 
			THEN  Biling_seans.Size_byte*10 
			ELSE DATEDIFF(second, Biling_seans.Time_Start, Biling_seans.Time_End)/3 
			END 
		END
	) AS price 
FROM Biling_seans JOIN Biling_abonent ON Biling_abonent.ID_Abonent=Biling_seans.Id_abonent_For_Seans 
WHERE 
	Biling_seans.Time_Start BETWEEN '9.15.2019' AND  DATEADD(month,1,'1.11.2019') AND
	Biling_seans.Time_End BETWEEN '9.15.2019' AND DATEADD(month,1,'1.11.2019') AND
	Surname_abonent LIKE '%а%' AND 
	Name_abonent LIKE '% %'
GROUP BY Biling_seans.Id_abonent_For_Seans, Biling_abonent.Name_Abonent, Biling_abonent.Surname_Abonent*/

SELECT * FROM Biling_seans;

/*SELECT 
Biling_abonent.Name_Abonent,  
Biling_abonent.Surname_Abonent,
'9.15.2019' AS Date_Start, 
DATEADD(month,1,'9.15.2019') AS Date_End,
 SUM ( CASE WHEN Biling_seans.Type_data=1 THEN DATEDIFF(second, Biling_seans.Time_Start, Biling_seans.Time_End) / 60 * 1 ELSE CASE WHEN Biling_seans.Type_data=2 THEN  Biling_seans.Size_byte*10 ELSE DATEDIFF(second, Biling_seans.Time_Start, Biling_seans.Time_End)/3 END END ) AS price FROM Biling_seans JOIN Biling_abonent ON Biling_abonent.ID_Abonent=Biling_seans.Id_abonent_For_Seans 
WHERE Biling_seans.Time_Start BETWEEN '7.20.2017' AND  DATEADD(month,1,'7.20.2019') AND  
--Biling_seans.Time_End BETWEEN '9.15.2019' AND DATEADD(month,1,'9.15.2019') AND 
Surname_abonent LIKE '%%' AND Name_abonent LIKE '%%' 
GROUP BY Biling_seans.Id_abonent_For_Seans, Biling_abonent.Name_Abonent, Biling_abonent.Surname_Abonent*/

SELECT Biling_abonent.Name_Abonent,  Biling_abonent.Surname_Abonent, 
'9.15.2019' AS Date_Start, DATEADD(month,1,'9.15.2019') AS Date_End, 
SUM ( 
CASE WHEN Biling_seans.Type_data=1 
THEN DATEDIFF(second, Biling_seans.Time_Start, Biling_seans.Time_End) / 60 * 1 
ELSE 
	CASE WHEN Biling_seans.Type_data=2 
	THEN  Biling_seans.Size_byte*10 
	ELSE DATEDIFF(second, Biling_seans.Time_Start, Biling_seans.Time_End)/3 
	END 
END ) AS price 
FROM Biling_seans JOIN Biling_abonent ON Biling_abonent.ID_Abonent=Biling_seans.Id_abonent_For_Seans 
WHERE 
Biling_seans.Time_Start BETWEEN '9.15.2019' AND  DATEADD(month,1,'9.15.2019') 
AND  Biling_seans.Time_End BETWEEN '10.15.2018' AND DATEADD(month,1,'10.15.2018') 
AND Surname_abonent LIKE '%Ры%' 
AND Name_abonent LIKE '%%' 
GROUP BY Biling_seans.Id_abonent_For_Seans, Biling_abonent.Name_Abonent, Biling_abonent.Surname_Abonent

