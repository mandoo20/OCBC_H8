CREATE DATABASE Bank;


--1
CREATE TABLE customers(
	customerNumber INT identity(1,1) Primary Key,
	customerName VARCHAR(50) NOT NULL,
	contactLastName VARCHAR(50) NOT NULL,
	contactFirstName VARCHAR(50) NOT NULL,
	phone varchar(20) NOT NULL,
	addressLine1 VARCHAR(100) NOT NULL,
	addressLine2 VARCHAR(100) NOT NULL,
	city VARCHAR(25) NOT NULL,
	state VARCHAR(25) NOT NULL,
	postalCode VARCHAR(10) NOT NULL,
	country VARCHAR(50) NOT NULL,
	salesRepEmployeeNumber VARCHAR(20) NOT NULL,
	creditLimit INT not null
);


INSERT INTO customers(customerName,contactLastName,
contactFirstName,phone,addressLine1,addressLine2,city,state,postalCode,country,salesRepEmployeeNumber,creditLimit)VALUES(
'Armando','Ongko','Armando','082391435579','jl.Sripulau','jl.rawabelong','Bengkalis','kec.Bengkalis','28143','Riau','#2031415',20000000);

INSERT INTO customers(customerName,contactLastName,
contactFirstName,phone,addressLine1,addressLine2,city,state,postalCode,country,salesRepEmployeeNumber,creditLimit)VALUES(
'Albedo','zagsd','Albedo','8272123','jl.perpustakaan','jl.DragonSpine','Monstads','DragonSpine','12345','Teyvat','#2031343',50000000);

INSERT INTO customers(customerName,contactLastName,
contactFirstName,phone,addressLine1,addressLine2,city,state,postalCode,country,salesRepEmployeeNumber,creditLimit)VALUES(
'Xiao','Karma','Xiao','82391235579','jl.tianQuan','jl.azhre','suhua','Liyue','12342','Teyvat','#2231415',80000000);

INSERT INTO customers(customerName,contactLastName,
contactFirstName,phone,addressLine1,addressLine2,city,state,postalCode,country,salesRepEmployeeNumber,creditLimit)VALUES(
'Kazuha','Kaedehara','Kazuha','822145579','jl.archipelago','jl.bajak laut','naka','Inazuma','28149','Teyvat','#2031420',15000000);

INSERT INTO customers(customerName,contactLastName,
contactFirstName,phone,addressLine1,addressLine2,city,state,postalCode,country,salesRepEmployeeNumber,creditLimit)VALUES(
'Keqing','Neko','Keqing','0823914329422','jl.pegunungan','jl.Rex Lapis','Qixing','Liyue','28199','Teyvat','#2033315',25000000);



SELECT * from customers;

--2
CREATE TABLE products(
	productCode int identity(1,1) Primary Key,
	productName VARCHAR(50) NOT NULL,
	productLine VARCHAR(50) NOT NULL,
	productScale int NOT NULL,
	productVendor varchar(50) NOT NULL,
	productDescription text NOT NULL,
	quantityInStock int NOT NULL,
	buyPrice int NOT NULL,
	MSRP varchar(50) NOT NULL
);

INSERT into products(productName,productLine,productScale,productVendor,productDescription,quantityInStock,buyPrice,MSRP) values 
('Scarlett','Cosmetic',5,'Unilever','Bagus Bagus Bagus Bagus Bagus',1500,48900,46000);

INSERT into products(productName,productLine,productScale,productVendor,productDescription,quantityInStock,buyPrice,MSRP) values 
('Indomie','Food & Beverage',8,'Indofood','Seleraku!',20043,2500,2300);

INSERT into products(productName,productLine,productScale,productVendor,productDescription,quantityInStock,buyPrice,MSRP) values 
('Milku','Food & Beverage',5,'IndoSusu','susu asli',5393,3000,2500);

INSERT into products(productName,productLine,productScale,productVendor,productDescription,quantityInStock,buyPrice,MSRP) values 
('Spotify','music',5,'music Ent','Dengarkan lagu',300,54900,49900);

INSERT into products(productName,productLine,productScale,productVendor,productDescription,quantityInStock,buyPrice,MSRP) values 
('Logitech Speaker','Electronic & Komputer',8,'Logitech Indonesia','Ceria Ceria',300,159000,146000);

--3
CREATE TABLE productlines(
	productLine int identity(1,1) Primary Key,
	textDescription text not NULL,
	htmlDescription text NOT NULL,
	image varchar(255) NOT NULL
);

INSERT into productlines (textDescription,htmlDescription,[image]) values('Food & Beverage','food.html','asdkeofggnakdsadahsjf.jpg');

INSERT into productlines (textDescription,htmlDescription,[image]) values('Cosmetic','cosmetic.html','lldfpegkokfaodj.jpg');

INSERT into productlines (textDescription,htmlDescription,[image]) values('Games','games.html','askdoegjeajdkjkvnraww.jpg');

INSERT into productlines (textDescription,htmlDescription,[image]) values('Music','music.html','askdeiofgkgekgasf.jpg');

INSERT into productlines (textDescription,htmlDescription,[image]) values('Sport','sport.html','ajkigjtroehwbewjr.jpg');
--4
CREATE TABLE orders(
	orderNumber int identity(1,1) Primary Key,
	orderDate DATE NOT NULL,
	requiredDate DATE NOT NULL,
	shippedDate DATE NOT NULL,
	status varchar(10) NOT NULL,
	comments varchar(255) NOT NULL,
	customerNumber int NOT NULL
);

INSERT into orders (orderDate,requiredDate,shippedDate,status,comments,customerNumber) values('2021-10-20','2021-10-25',
'2021-10-21','Shipping','Segera diproses',1);

INSERT into orders (orderDate,requiredDate,shippedDate,status,comments,customerNumber) values('2021-10-21','2021-10-26',
'2021-10-22','W.Payment','menunggu pembayaran',2);

INSERT into orders (orderDate,requiredDate,shippedDate,status,comments,customerNumber) values('2021-10-22','2021-10-27',
'2021-10-23','Shipping','sedang diantar kurir',3);

INSERT into orders (orderDate,requiredDate,shippedDate,status,comments,customerNumber) values('2021-10-23','2021-10-28',
'2021-10-24','Delivered','Telah diterima atas nama Armando',4);

INSERT into orders (orderDate,requiredDate,shippedDate,status,comments,customerNumber) values('2021-10-24','2021-10-29',
'2021-10-26','Shipping','Segera diproses ekspedisi',5);

--5
CREATE TABLE orderdetails(
	orderNumber int identity(1,1) Primary Key,
	productCode int NOT NULL,
	quantityOrdered int NOT NULL,
	priceEach int NOT NULL,
	orderLineNumber varchar(50) NOT NULL
);

INSERT into orderdetails (productCode,quantityOrdered,priceEach,orderLineNumber) values(2001,3,49000,'#kd03492');

INSERT into orderdetails (productCode,quantityOrdered,priceEach,orderLineNumber) values(2002,69,3000,'#kd05543');

INSERT into orderdetails (productCode,quantityOrdered,priceEach,orderLineNumber) values(2003,6,10000,'#kd04956');

INSERT into orderdetails (productCode,quantityOrdered,priceEach,orderLineNumber) values(2004,100,500,'#kd96569');

INSERT into orderdetails (productCode,quantityOrdered,priceEach,orderLineNumber) values(2005,2,39999,'#kd12345');
--6
CREATE TABLE payments(
	customerNumber int identity(1,1) ,
	checkNumber VARCHAR(50) not null,
	PaymentDate Date NOT NULL,
	amount int NOT NULL,
	primary key (customerNumber,checkNumber)
);

INSERT into payments (checkNumber,PaymentDate,amount) values('#B20334','2021-10-20',5932);

INSERT into payments (checkNumber,PaymentDate,amount) values('#B20236','2021-10-21',10);

INSERT into payments (checkNumber,PaymentDate,amount) values('#B29532','2021-10-22',492);

INSERT into payments (checkNumber,PaymentDate,amount) values('#B20605','2021-10-23',94);

INSERT into payments (checkNumber,PaymentDate,amount) values('#B20900','2021-10-24',20);

--7
CREATE TABLE employee(
	employeeNumber int identity(1,1) Primary Key,
	lastName VARCHAR(50) NOT NULL,
	firstName VARCHAR(50) NOT NULL,
	extension varchar(50) NOT NULL,
	email varchar(50) NOT NULL,
	officeCode varchar(10) NOT NULL,
	reportsTo varchar(25) NOT NULL,
	jobTitle varchar(25) NOT NULL,
);

INSERT into employee (lastName,firstName,extension,email,officeCode,reportsTo,jobTitle) values('ongko','armando','Manager',
'arm@ocobc.com','N2001','Jimin','Chief Technology Officer');

INSERT into employee (lastName,firstName,extension,email,officeCode,reportsTo,jobTitle) values('siregar','david','IT Staff',
'siregar@ocobc.com','N2002','Armando','Software Engineer Staff');

INSERT into employee (lastName,firstName,extension,email,officeCode,reportsTo,jobTitle) values('gadgetin','david','Content Creator',
'davic@ocobc.com','N2003','iqbal','Youtube Content Creator');

INSERT into employee (lastName,firstName,extension,email,officeCode,reportsTo,jobTitle) values('pengerti','budi','IT Staff',
'budi@ocobc.com','N2004','Eka','Senior Engineer Staff');

INSERT into employee (lastName,firstName,extension,email,officeCode,reportsTo,jobTitle) values('Cahyadi','Eka','Manager',
'eka@ocobc.com','N2005','Darwin','IT Manager Staff');

--8
CREATE TABLE offices(
	officeCode int identity(1,1) Primary Key,
	city VARCHAR(50) NOT NULL,
	phone VARCHAR(50) NOT NULL,
	addressLine1 VARCHAR(100) NOT NULL,
	addressLine2 VARCHAR(100) NOT NULL,
	state VARCHAR(25) NOT NULL,
	country VARCHAR(50) NOT NULL,
	postalCode VARCHAR(10) NOT NULL,
	territory varchar(20) not null
);

INSERT into offices (city,phone,addressLine1,addressLine2,state,country,postalCode,territory) values('Jakarta selatan','782353',
'jl.satrio','jl.sripulau','setia budi','siak','12039','Jaksel');

INSERT into offices (city,phone,addressLine1,addressLine2,state,country,postalCode,territory) values('Jakarta utara','2344512',
'jl.satria','jl.s.kasim','pambang','rawabelong','53221','Monstads');

INSERT into offices (city,phone,addressLine1,addressLine2,state,country,postalCode,territory) values('Jakarta timur','534645',
'jl.employee','jl.sudirman','bantan','pademangan','24652','Liyue');

INSERT into offices (city,phone,addressLine1,addressLine2,state,country,postalCode,territory) values('Jakarta pusat','345322',
'jl.bunga','jl.hangtuah','wonosari','sungai putih','28734','Inazuma');

INSERT into offices (city,phone,addressLine1,addressLine2,state,country,postalCode,territory) values('Jakarta barat','67456334',
'jl.sial','jl.antara','tanjung palu','selat baru','284523','Sumeru');



