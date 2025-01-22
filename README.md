OVERVIEW
Composition rewrite for commission based pay rate for employee’s to give correct amount of money from the employee’s commission price and the rate of their commission price. This is a complete rewrite of an inheritance based composition for employees commission pay from total sales. 

PROCESSING LOGIC
composition rewrite will change it form an inheritance class and method of grabbing to an easy method of getting the method rather then using super() or :base to get the complete information of the employee and their information with their complete total sales with their base salary to give a total of how much the company owes the employee. With using composition it helps with making some objects from inheritance to be redundant in a composition system.

DATA (INPUT/OUTPUT)
Input 
First name
last name
social security number
gross sales
commotion rate
base salary 

Output 
Full name 
total earnings (base salary + commission)
social security number (for reference)
attributes
firstName: gets the employee’s first name (string)
lastName: gets the employee’s last name (string)
SocialSecurtiyNumber: the social security number of the employee (string)
grossSales: the total sales made by the employee (float)
commissionRate: the rate at which the employee earns commission pay (float)
Methods
	__init__(...): constructor to initialize the employee with their personal details and commission based data.
	earnings(): calculates the earnings based on the commission and gross sales total.
	otherMethods like getFirstName():,getLastName():, GetsocialSecurityNumber(); etc., to retrieve the various data of the employee. 
basepluscommissionemployee class
commission employee: an instance of commission employee (this is composition relationship)
baseSalary: the fixed salary that is added to the commission earnings (float)
methods
__init__(...) constructor to initialize both the commission Employee instance and the base salary.
getFullEmpoyleeInfo(): returns a dictionary containing the employee’s full details (name SSN, total Earnings)
other methods like getFirstName():,getLastName():, getTotalSales() that returns specific attributes or values.

TESTING
core functionality test
Valid earnings calculator: tests that the system is properly calculating the correct amount based on gross sales, and the commission rate.
Input gross sales and commission rate.
expected output corrects earnings
boundary gross sales (edge case)
purpose: verifies that when the gross sale is zero, the commission base is zero the commission should be zero and the commission should be zero with only the salary should be unaffected.
