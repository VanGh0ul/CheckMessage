create database pp04;

create table user(
	id int auto_increment primary key,
    name varchar(255)
);

create table room(
	id int auto_increment primary key,
    name varchar(255),
    name boolean
);

create table participants(
	id int auto_increment primary key,
    
	user_id int,
    index(user_id),
    foreign key (user_id) references user(id),
    
    room_id int,
    index(room_id),
    foreign key (room_id) references room(id)
);

create table participants(
	id int auto_increment primary key,
    
    message text,
    
	user_id int,
    index(user_id),
    foreign key (user_id) references user(id),
    
    room_id int,
    index(room_id),
    foreign key (room_id) references room(id)
);


