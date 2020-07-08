USE [APMC]
GO
/****** Object:  StoredProcedure [Auth].[GetUserByName]    Script Date: 08-07-2020 4.00.12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create procedure [GetWaterRecovery](@date datetime)
as
begin
/*
exec GetWaterRecovery '20200101'
exec auth.GetUserByName 'sankarank'
exec auth.GetUserByName 'sankarank',1

*/
    
SELECT * Into #temp FROM   
(
   select *,case when CSUBLF = 16 then 'WATER_CHG' else 'WATER_DPC' end AS CSUBLF1  from T1920 where Month(DATE)=MONTH(@date) and YEAR(DATE)=Year(@date) and CSUBLF in(16,17) 
   Union
   Select *,case when CSUBLF = 16 then 'WATER_CHG' else 'WATER_DPC' end AS CSUBLF1 from Tr1920 where  Month(DATE)=MONTH(@date) and YEAR(DATE)=Year(@date) and CSUBLF in(16,17)

) t 
PIVOT(
    Max(AMT)
    FOR CSUBLF1 IN (
        [WATER_CHG], 
        [WATER_DPC])
) AS pivot_table;

Select VOC_NO As Recpt_No, convert(datetime, DATE, 103) As [DATE],CHEQ_NO As CH_NO,SHOP,SERIES,NUM As NO, CD,NARR,WATER_CHG,WATER_DPC into #temp1 from #temp

Select 
	Max([DATE]) As Date,
	Max(Recpt_No) As Recpt_No,
	Max(CH_NO) As CH_NO,
	Max(SHOP) As SHOP,
	Max(SERIES) As SERIES,
	Max(No) As No ,
	Max(CD) As CD,
	Sum(Convert(money,[WATER_CHG])) As [WATER_CHG],
	Sum(Convert(money,[WATER_DPC])) As [WATER_DPC] 
From #temp1 
Group by Series,Shop,CD

Drop table #temp1
Drop table #temp
end



