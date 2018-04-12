create database hw5_Sells

use hw5_Sells

CREATE TABLE Buyers
(
    Buyer_id INT primary key identity,
    firstName VARCHAR(20) not null,
    LastName VARCHAR(20) not null
)


CREATE TABLE Sellers
(
    Seller_id INT primary key identity,
    firstName VARCHAR(20) not null,
    LastName VARCHAR(20) not null
)

CREATE TABLE Deals
(
    Deal_id INT primary key identity,
    seller_id int references Sellers(Seller_id),
	buyer_id int references Buyers(Buyer_id),
	[sum] int not null,
	deal_date date not null
)



insert into Buyers
values
('AAA','aaa'),
('BBB','bbb'),
('CCC','ccc')

insert into Sellers
values
('S_AAA','s_aaa'),
('S_BBB','s_bbb'),
('S_CCC','s_ccc')

insert into Deals
values
(1, 1, 10000, '5/7/2018'),
(1, 2, 15000, '7/7/2018'),
(2, 2, 20000, '9/7/2018')

select * from Buyers
select * from Sellers
select * from Deals

