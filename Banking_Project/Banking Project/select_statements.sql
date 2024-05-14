/*Select Statement 1*/
Select Branch.Branch_Number as 'Branches with no Customers'
from Branch
where Branch.Branch_Number not in (select Customer.Branch_Number from Customer);
/*Select Statement 2*/
Select Branch.Branch_Number as 'Branches with no Employees'
from Branch
where Branch.Branch_Number not in (select Employee.Branch_Number from Employee); 



/*Select Statement 3*/
select Employee_id,count(*) as no_of_loans from Loan
        group by Employee_id
          having count(*) =(select max(no_of_loans) from 
            (select Employee_id,count(*) as no_of_loans from Loan group by Employee_id) Loan)
/*Select Statement 4*/

select Cus_SSN,count(*) as no_of_loans from Loan
        group by Cus_SSN
          having count(*) =(select max(no_of_loans) from 
            (select Cus_SSN,count(*) as no_of_loans from Loan group by Cus_SSN) Loan)


/*Select Statement 5*/
Select Customer.cus_name as 'Customers with no loans'
from Customer
where Customer.Cus_SSN not in (select Loan.Cus_SSN from Loan);




/*Select Statement 6*/
SELECT  Customer.Cus_SSN , 
Customer.cus_name,
Customer.cus_phone , 
Customer.cus_address ,
Customer.email ,
Customer.password,
Customer.Branch_Number,
count( distinct Loan.Employee_id) As 'Number of employees Customer dealt with' from Loan right outer join Customer on Customer.Cus_SSN = Loan.Cus_SSN
GROUP BY Customer.Cus_SSN ,
Customer.cus_name , Customer.cus_phone , 
Customer.cus_address, 
Customer.email ,
Customer.password,
Customer.Branch_Number;




