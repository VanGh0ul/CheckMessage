
use pp04_test;
INSERT INTO message(message, user_id) 
VALUES('message', (SELECT id FROM user WHERE name = 'Flex'))