SELECT
 Biling_abonent.Name_Abonent,  Biling_abonent.Surname_Abonent,
  '6.10.2019' AS Date_Start, '6.12.2019'  AS Date_End, 
  SUM 
  ( CASE WHEN Biling_seans.Type_data=1 
  THEN DATEDIFF(second, Biling_seans.Time_Start, Biling_seans.Time_End) / 60 * 1 
  ELSE 
  CASE WHEN Biling_seans.Type_data=2 
  THEN Biling_seans.Size_byte*10 
  ELSE
   DATEDIFF(second, Biling_seans.Time_Start, Biling_seans.Time_End)/3 
   END 
   END ) AS price 
   FROM Biling_seans JOIN Biling_abonent 
   ON Biling_abonent.ID_Abonent=Biling_seans.Id_abonent_For_Seans 
   WHERE  Time_Start > '10.10.2018' AND Time_End < DATEADD(month,12,'10.14.2019') AND Surname_abonent LIKE '%%' AND Name_abonent LIKE '%%'
   GROUP BY Biling_seans.Id_abonent_For_Seans, Biling_abonent.Name_Abonent, Biling_abonent.Surname_Abonent
   /*SELECT Biling_abonent.Name_Abonent,  Biling_abonent.Surname_Abonent,'14.10.2019' AS Date_Start, '14.12.2019'  AS Date_End, SUM ( CASE WHEN Biling_seans.Type_data=1 THEN DATEDIFF(second, Biling_seans.Time_Start, Biling_seans.Time_End) / 60 * 1 ELSE CASE WHEN Biling_seans.Type_data=2 THEN Biling_seans.Size_byte*10 ELSE DATEDIFF(second, Biling_seans.Time_Start, Biling_seans.Time_End)/3 END END ) AS price FROM Biling_seans JOIN Biling_abonent ON Biling_abonent.ID_Abonent=Biling_seans.Id_abonent_For_Seans WHERE  Surname_abonent LIKE '%%' AND Name_abonent LIKE '%%' GROUP BY Biling_seans.Id_abonent_For_Seans, Biling_abonent.Name_Abonent, Biling_abonent.Surname_Abonent*/