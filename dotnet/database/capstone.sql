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
	user_role varchar(50) NOT NULL
	CONSTRAINT PK_user PRIMARY KEY (user_id)
)

CREATE TABLE genres (
	genre_id int IDENTITY(100,10) NOT NULL,
	genre_name varchar(50) NOT NULL,
	CONSTRAINT PK_genre PRIMARY KEY (genre_id)
)
CREATE TABLE user_genre (
	user_id int NOT NULL,
	genre_id int NOT NULL
)
CREATE TABLE movies (
	movie_id int IDENTITY (10, 1) NOT NULL,
	movie_name varchar(50) NOT NULL, 
	genre_id int NOT NULL
	CONSTRAINT PK_movie PRIMARY KEY (movie_id)
)
CREATE TABLE user_movie (
	user_id int NOT NULL,
	movie_id int NOT NULL
)



--populate  data
INSERT INTO users (username, password_hash, salt, user_role) VALUES ('user','Jg45HuwT7PZkfuKTz6IB90CtWY4=','LHxP4Xh7bN0=','user');
INSERT INTO users (username, password_hash, salt, user_role) VALUES ('admin','YhyGVQ+Ch69n4JMBncM4lNF/i9s=', 'Ar/aB2thQTI=','admin');
INSERT INTO users (username, password_hash, salt, user_role) VALUES ('Josephina366', 'GkshdfT9W4irkdTTxsEDkf/i6s=', 'Rt+bseWmd0=', 'user');
INSERT INTO users (username, password_hash, salt, user_role) VALUES ('Tamagotchi2000', 'Mdssdf43knirkdTTxsED/4rjf=', 'Bzt+bHmdksd=3', 'user');
INSERT INTO users (username, password_hash, salt, user_role) VALUES ('Cleveland97', 'Adjisd83jdkscmTxs/ahd46s=', 'Fjgbrijtjf=4/3=', 'user');


--associative tables testing data
INSERT INTO genres (genre_name) VALUES ('example genre');
INSERT INTO user_genre (user_id, genre_id) VALUES (3, 100);
INSERT INTO movies (movie_name, genre_id) VALUES ('example movie', 100);
INSERT INTO user_movie (user_id, movie_id) VALUES (3, 10);


GO
