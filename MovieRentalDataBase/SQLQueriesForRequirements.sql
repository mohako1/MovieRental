Create Database movierental;
-- a. 
SELECT 
    m.Type as MovieGenre,
    COUNT(*) as NumberOfRentals
FROM 
    Movie m
JOIN 
    RENTAL_DETAIL r ON m.Movie_ID = r.Movie_ID
GROUP BY 
    m.Type
ORDER BY 
    COUNT(*) DESC;

-- b. 





SELECT 
    m.Type as MovieGenre
FROM 
    Movie m
WHERE 
    m.Movie_ID NOT IN (
        SELECT DISTINCT
            r.Movie_ID
        FROM 
            RENTAL_DETAIL r
        WHERE 
            YEAR(r.Rental_Date) = YEAR(DATEADD(month, -1, GETDATE())) 
            AND MONTH(r.Rental_Date) = MONTH(DATEADD(month, -1, GETDATE())) 
    )
GROUP BY
    m.Type;







-- c.
SELECT 
    m.Type as MovieGenre,
    m.Name as MovieName,
    m.Year as AddedYear 
FROM 
    Movie m
ORDER BY 
    m.Type, m.Year;







-- d.
SELECT 
    c.*,  
    COUNT(r.Movie_ID) as NumberOfMoviesRented
FROM 
    Client c
LEFT JOIN 
    RENTAL_DETAIL r ON c.Client_ID = r.Client_ID
GROUP BY 
    c.Client_ID, c.Name, c.Password, c.Phone, c.Credit_Card, c.Address  -- Group by all Client columns
ORDER BY 
    c.Client_ID;







-- e.
SELECT 
    m.Type as MovieGenre,
    COUNT(*) as NumberOfRentals,
    SUM(rd.Price) AS TotalSales  
FROM 
    Movie m
JOIN 
    RENTAL_DETAIL r ON m.Movie_ID = r.Movie_ID
JOIN
    RENTAL_DETAIL rd ON r.Client_ID = rd.Client_ID AND r.Rental_Date = rd.Rental_Date -- Assuming Client_ID and Rental_Date link RentalDetail
GROUP BY 
    m.Type
ORDER BY 
    COUNT(*) DESC;







-- f.

SELECT 
    s.Name as SupplierName
FROM 
    Supplier s
WHERE 
    s.Supplier_ID NOT IN (
        SELECT DISTINCT
            m.Supplier_ID
        FROM 
            Movie m
        JOIN 
            RENTAL_DETAIL r ON m.Movie_ID = r.Movie_ID
        WHERE 
            r.Rental_Date >= DATEADD(month, -3, GETDATE())
    );