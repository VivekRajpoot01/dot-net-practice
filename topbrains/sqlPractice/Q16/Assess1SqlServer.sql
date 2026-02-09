CREATE database Assess1DB;

Use Assess1DB

-- Create Sales_Raw table
CREATE TABLE Sales_Raw

(

    OrderID INT,

    OrderDate VARCHAR(20),

    CustomerName VARCHAR(100),

    CustomerPhone VARCHAR(20),

    CustomerCity VARCHAR(50),

    ProductNames VARCHAR(200),   -- Multiple products comma-separated

    Quantities VARCHAR(100),     -- Multiple quantities comma-separated

    UnitPrices VARCHAR(100),     -- Multiple prices comma-separated

    SalesPerson VARCHAR(100)

);


-- insert data into table

INSERT INTO Sales_Raw VALUES

(101, '2024-01-05', 'Ravi Kumar', '9876543210', 'Chennai',

 'Laptop,Mouse', '1,2', '55000,500', 'Anitha'),

 

(102, '2024-01-06', 'Priya Sharma', '9123456789', 'Bangalore',

 'Keyboard,Mouse', '1,1', '1500,500', 'Anitha'),

 

(103, '2024-01-10', 'Ravi Kumar', '9876543210', 'Chennai',

 'Laptop', '1', '54000', 'Suresh'),

 

(104, '2024-02-01', 'John Peter', '9988776655', 'Hyderabad',

 'Monitor,Mouse', '1,1', '12000,500', 'Anitha'),

 

(105, '2024-02-10', 'Priya Sharma', '9123456789', 'Bangalore',

 'Laptop,Keyboard', '1,1', '56000,1500', 'Suresh');


 select * from Sales_Raw;


 -- create customer table

 CREATE table Customer
 (
    CustomerID INT IDENTITY(1,1) PRIMARY KEY,
    CustomerName VARCHAR(100),
    CustomerPhone VARCHAR(20),
    CustomerCity VARCHAR(50)
 );

 -- cretee product table

 CREATE table Product
 (
    ProductID INT IDENTITY(1,1) PRIMARY KEY,
    ProductName VARCHAR(100),
    Quantity INT,
    UnitPrice DECIMAL(10,2)
 );

 -- create order table

 CREATE table Orders
 (
    OrderID INT PRIMARY KEY,
    OrderDate DATE,
    CustomerID INT,
    SalesPerson VARCHAR(100),
    FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID)
 );

 -- create salesPerson table
 
 create table SalesPerson
 (
    SalesPersonID INT IDENTITY(1,1) PRIMARY KEY,
    SalesPersonName VARCHAR(100)
 );

 -- create order details table

create table OrderDetails
(
    OrderDetailID INT IDENTITY(1,1) PRIMARY KEY,
    OrderID INT,
    ProductID INT,
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),
    FOREIGN KEY (ProductID) REFERENCES Product(ProductID)
);



