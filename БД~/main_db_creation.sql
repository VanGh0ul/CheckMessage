drop database databasesList;

create database databasesList;

use databasesList;

create table messageType(

	id int auto_increment primary key,
	name varchar(200)
);

insert into messageType
(name)
value
	("В программе"),
    ("В браузере");

create table DBList(
	id int auto_increment primary key,
    server varchar(255),
    database_name varchar(255),
    username varchar(255),
    password varchar(255),
    port varchar(255),
    
    message_table_name varchar(255),
	login_column_name varchar(255),
	count_column_name varchar(255),
	
	message_type_id int,
    index(message_type_id),
    foreign key (message_type_id) references messageType(id)
);

create table actionType (

	id int auto_increment primary key,
	name varchar(200)
);

insert into actionType
(name)
values
	("Added new db"),
    ("Deleted db");

create table dbLogs (
	
    user_login varchar(255),
    pc_name varchar(255),
    log_date datetime,
    
    action_type_id int,
    index(action_type_id),
    foreign key (action_type_id) references actionType(id)
);
