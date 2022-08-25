
select top(1)*
  from
   (SELECT TOP (5) [StartUpID],[StartUpName],[Funding]
      FROM StartUp
      order by [Funding] DESC
   )TopFiveStartUps
  order by TopFiveStartUps.[Funding] ASC


/*
Assume That Table StartUp has Columns:
StartUpID, StartUpName, Funding

and we return top five in funding then reverse the result set to get the 5th highest funded startup

*/