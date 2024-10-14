SELECT 
  * 
FROM 
  Product
WHERE 
  CategoryId = 3

  AND ProductPrice > 50
ORDER BY 
  ProductName DESC;
  /* This query filters products from the Products table where the CategoryId is 1 (Small) and the ProductPrice is more than 50. Furthermore it orders the content by ProductName Descending. */