USE master
GO

--drop database if it exists
IF DB_ID('final_capstone') IS NOT NULL
BEGIN
	ALTER DATABASE final_capstone SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
	DROP DATABASE final_capstone;
END

CREATE DATABASE final_capstone
GO

USE final_capstone
GO

--create tables
CREATE TABLE users (
	user_id int IDENTITY(1,1) NOT NULL,
	username varchar(50) NOT NULL,
	password_hash varchar(200) NOT NULL,
	salt varchar(200) NOT NULL,
	user_role varchar(50) NOT NULL,
	firstname varchar(50),
	age int
	CONSTRAINT PK_user PRIMARY KEY (user_id)
)

CREATE TABLE user_genre (
	user_id int NOT NULL,
	genre_id int NOT NULL
)

CREATE TABLE user_movie (
	user_id int NOT NULL,
	movie_id int NOT NULL
)

CREATE TABLE user_friends (
	relationship_id int IDENTITY(1,1) NOT NULL,
	user_id1 int NOT NULL,
	user_id2 int NOT NULL,
	CONSTRAINT PK_user_friends PRIMARY KEY (relationship_id)
)

CREATE TABLE user_comments(
	comment_id int IDENTITY(1,1) NOT NULL,
	user_author_id int NOT NULL,
	user_posted_id int NOT NULL,
	comment_text varchar(MAX) NOT NULL
	CONSTRAINT PK_user_comments PRIMARY KEY (comment_id)

)




--populate  data
INSERT INTO users (username, password_hash, salt, user_role) VALUES ('user','Jg45HuwT7PZkfuKTz6IB90CtWY4=','LHxP4Xh7bN0=','user');
INSERT INTO users (username, password_hash, salt, user_role) VALUES ('admin','YhyGVQ+Ch69n4JMBncM4lNF/i9s=', 'Ar/aB2thQTI=','admin');
INSERT INTO users (username, password_hash, salt, user_role, firstname) VALUES ('Josephina366', 'GkshdfT9W4irkdTTxsEDkf/i6s=', 'Rt+bseWmd0=', 'user', 'Josephina');
INSERT INTO users (username, password_hash, salt, user_role) VALUES ('Tamagotchi2000', 'Mdssdf43knirkdTTxsED/4rjf=', 'Bzt+bHmdksd=3', 'user');
INSERT INTO users (username, password_hash, salt, user_role) VALUES ('Cleveland97', 'Adjisd83jdkscmTxs/ahd46s=', 'Fjgbrijtjf=4/3=', 'user');

INSERT INTO user_friends (user_id1, user_id2) VALUES ('3', '4')
INSERT INTO user_friends (user_id1, user_id2) VALUES ('3', '1')
INSERT INTO user_friends (user_id1, user_id2) VALUES ('3', '5')

INSERT INTO user_comments (user_author_id, user_posted_id, comment_text) VALUES (4, 3, 'I love your taste in movies!');

--associative tables testing data
INSERT INTO user_genre (user_id, genre_id) VALUES (3, 100);
INSERT INTO user_movie (user_id, movie_id) VALUES (3, 10);


GO

