
use pp04;

select (user.name) as User_name ,
		(room.name)as Room_name,
		room.type
from  user, room
where user.id = room.id;

