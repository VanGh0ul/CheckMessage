select 	m.id,  m.message,  m.user_id, u.name as round_name
	from message m  inner join user u on m.user_id = u.id 