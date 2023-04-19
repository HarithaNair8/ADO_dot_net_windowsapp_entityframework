create database food
use food

create table userpassword
(
id int primary key,
usr varchar(250),
pwd varchar(250)
)
insert into userpassword values( 1 , 'admin', '123455')
select * from userpassword
----------------------------------------------------------------------------------------------------------------------------------
create table restaurant(
 restaurant_id int  primary key not null,
 restaurant_name varchar(250) not null,
 rcity varchar(250),
 rlocation varchar(250) not null,
)
drop table restaurant
insert into restaurant(restaurant_id,restaurant_name,rcity,rlocation) VALUES(101, 'hydrabadi spice','Karwar' ,'aundh')
insert into restaurant(restaurant_id,restaurant_name,rcity,rlocation) VALUES(102, 'hotel green park','Mangalore' ,'baner')
insert into restaurant(restaurant_id,restaurant_name,rcity,rlocation) VALUES(103, 'saffron', 'Mangalore','pashan')
insert into restaurant(restaurant_id,restaurant_name,rcity,rlocation) VALUES(104, 'thomson restro','Bangalore', 'sanghavi')
insert into restaurant(restaurant_id,restaurant_name,rcity,rlocation) VALUES(105, 'laa unico', 'Karwar','mukund nagar')
insert into restaurant(restaurant_id,restaurant_name,rcity,rlocation) VALUES(106, 'blue water', 'Ankola','ravet')
select * from restaurant
alter table restaurant add details varchar(250) 
alter table restaurant add branch varchar(250)
update restaurant set branch = 'ankola_01 ' WHERE branch IS NULL and restaurant_id = 106
ALTER TABLE restaurant 



--------------------------------------------------------------------------------------------------------------------------------------

create table fooditems(
 food_id int primary key not null,
 food_name varchar(250) not null,
 price_per_unit  decimal(5,2) not null,
 )
 insert into fooditems(food_id, food_name, price_per_unit) values
(9999411, 'allo paratha', '80.00'),
(9999412, 'veg meal', '120.00'),
(9999413, 'chapati', '20.00'),
(9999414, 'veg thali', '220.00'),
(9999415, 'chicken thali', '150.00'),
(9999416, 'veg biryani', '280.00'),
(9999417, 'mix veg', '180.00'),
(9999418, 'veg pulav', '190.00'),
(9999419, 'mix paratha', '180.00'),
(9999420, 'cold drink', '35.00'),
(9999421, 'paneer roll', '180.00'),
(9999422, 'veg roll', '180.00');
select * from fooditems

-----------------------------------------------------------------------------------------------------------------------------------

create table customer(
 customer_id int identity(11,1) primary key not null ,
 customer_name varchar(20) not null,
 contact_number varchar(11) not null,
 rcity varchar(250) not null,
 address varchar(30) not null,
)
alter table customer add username varchar(250) not null
alter table customer add pwdwrd varchar(250) not null
insert into customer values('pooja v' , '5454545454' , 'Karwar' , 'Green Street' , 'poojav' , 123456789)
select * from customer
drop table customer

----------------------------------------------------------------------------------------------------------------------------------------

create table order_food(
 orderF_id int identity(1000,1) not null ,
 customer_id int foreign key references customer(Customer_id)  not null,
 restaurant_id int foreign key references restaurant(Restaurant_id) not null,
 food_id int foreign key references fooditems(Food_id) not null,
 paymentmethod varchar(250),
 quantity int,
)
alter table Orderfood alter COLUMN OrderFid int primary key not null
select * from order_food
drop table order_food
-----------------------------------------------------------------------------------------------------------

--------------------------------------------------------------------------------------------

create table orderstatus
(
 order_id int identity(1000,1) primary key not null ,
 customer_id int foreign key references customer(Customer_id)  not null,
 grandtotal decimal(5,2) not null,
 payment varchar(250) not null
)
select * from orderstatus

--------------------------------------------------------------------------------------------------------------------------------------------------


select * from Userpassword
select * from Restaurant
select * from Fooditems
select * from Customer
select * from Orderstatus




-----------------------------------------------------------------------------------------------------------------------------------------------


































--select * from Order_status





















select * from Orderfood

--------------------------------------------------------------------------------------------------------------------------------
 --constraint pk_customer primary key (restaurant_id)--
 --constraint pk_foods primary key (food_id)
 --constraint pk_customer primary key (customer_id)
 --constraint pk_order_food primary key (orderF_id),
 ----constraint fk_payment_table foreign key (order_id) references payment_table(order_id),
 --constraint fk_order_details foreign key (order_id) references order_detail(order_id),
 --constraint fk_foods foreign key (food_id) references foods(food_id)
 --order_id int foreign key references Employees(empno) not null,


































 create table order_status(
 order_id int identity(1000,1) not null ,
 customer_id int foreign key references customer(Customer_id)  not null,
 grandtotal decimal(5,2) not null,
 ordstatus varchar(250)
)
select * from order_status
alter table order_status add paymtd varchar(250)
alter table order_status drop column "ordstatus"
insert into order_status values( 12 , 180.00 , 'COD')
alter table order_status alter COLUMN order_id int primary key ;
DROP table Order_status

 create database Chain_of_Restaurant
use Chain_of_Restaurant

create table Admin_credentials
(
AdminLoginID int identity(100,1) primary key not null,
AdminUserName varchar(30) not null,
AdminName Varchar(30) not null,
AdminPassword varchar(20) not null,
AdminMobileNo numeric not null
)

insert into Admin_Credentials values('Jaggu111','Jagadeesha Hegde','Jaggu@123',8105373454)

select * from Admin_Credentials

create table Customer_credentials
(
CustomerUserID int identity(1000,1) primary key not null,
CustomerName varchar(30) not null,
CustomerPassword varchar(20) not null,
CustomerAddress varchar(100) not null,
CustomerMobileNo int not null
)


create table Restaurant_Details
(
RestID int Identity(1,1) primary key not null,
RestName varchar(30) not null,
CityID char(4) not null,
CityName varchar(20) not null,
Address1 varchar(100) not null,
ContactNo numeric not null
)

insert into Restaurant_Details values('abc','udp1','Udupi','',8105373454)
select * from Restaurant_Details

create table FoodMenu
(
FoodID int identity(1,1) primary key not null,
FoodName varchar(30) not null,
FoodPrice decimal(5,2),
FoodQuantity int,
RestID int,
CityID char(4)
)

insert into FoodMenu values('idli',100.00,2,1,102)


select * from FoodMenu