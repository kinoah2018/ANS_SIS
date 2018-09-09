CREATE DATABASE ANS_DATABASE
USE ANS_DATABASE

USE MASTERo
DROP DATABASE ANS_DATABASE


select * from TBL_SECTION
select * from TBL_GRADE
select * from TBL_SUBJECT
select * from TBL_STUDENT
select * from TBL_PARENT
select * from TBL_USERS
SELECT * FROM TBL_USERTYPE
SELECT * FROM TBL_SECURITY
select * from tbl_teacher
--------USER MASTER-FILE-------------------------------------------------------

CREATE TABLE TBL_USERS
(
USER_ID INT IDENTITY(1,1) PRIMARY KEY,
USER_LASTNAME VARCHAR(50) NOT NULL,
USER_FIRSTNAME VARCHAR(50) NOT NULL,
USER_MIDDLENAME VARCHAR(50) ,
USER_USERNAME VARCHAR(50) NOT NULL,
USER_PASSWORD VARCHAR(50) NOT NULL,
USER_CONTACT VARCHAR(50) NOT NULL,
ISACTIVE BIT DEFAULT '1',	
USER_DATEADDED DATETIME DEFAULT GETDATE(),
USER_CREATOR VARCHAR(50) NOT NULL,
USER_TYPEID INT FOREIGN KEY REFERENCES TBL_USERTYPE(USER_TYPEID),
USER_IMAGE VARCHAR(MAX),
)

-------- USER PROCEDURE SAVE ---------------------------------------------------

ALTER PROCEDURE SP_USERSAVE
@USER_LASTNAME VARCHAR (50),
@USER_FIRSTNAME VARCHAR (50),
@USER_MIDDLENAME VARCHAR (50),
@USER_USERNAME VARCHAR (50),
@USER_PASSWORD VARCHAR (50),
@USER_CONTACTNO VARCHAR (50), 
@USER_CREATOR VARCHAR (50),
@USER_TYPE INT,
@USER_IMAGE VARCHAR(MAX)
AS 
BEGIN
INSERT INTO TBL_USERS VALUES(@USER_LASTNAME,@USER_FIRSTNAME,@USER_MIDDLENAME,@USER_USERNAME,@USER_PASSWORD,@USER_CONTACTNO,'1',GETDATE(),@USER_CREATOR,@USER_TYPE,@USER_IMAGE);
END

-------- USER PROCEDURE UPDATE --------------------------------------------------

ALTER PROCEDURE SP_USERUPDATE
@USER_ID INT,
@USER_LASTNAME VARCHAR (50),
@USER_FIRSTNAME VARCHAR (50),
@USER_MIDDLENAME VARCHAR (50),
@USER_USERNAME VARCHAR (50),
@ISACTIVE BIT,
@USER_IMAGE VARCHAR(MAX)
AS 
BEGIN
UPDATE TBL_USERS
SET USER_LASTNAME = @USER_LASTNAME, USER_FIRSTNAME = @USER_FIRSTNAME, USER_MIDDLENAME = @USER_MIDDLENAME,
	USER_USERNAME = @USER_USERNAME,  ISACTIVE = @ISACTIVE  ,USER_IMAGE = @USER_IMAGE
WHERE USER_ID = @USER_ID
END

---------PROCEDURE VERIFY PASSWORD----------------------------------------------------

ALTER PROCEDURE SP_VERIFYPASSWORD
@USER_ID INT,
@USER_PASSWORD VARCHAR(50)
AS
BEGIN
SELECT USER_PASSWORD FROM TBL_USERS WHERE USER_PASSWORD = @USER_PASSWORD AND USER_ID = @USER_ID
END
-------- USER PROCEDURE VIEW ---------------------------------------------------------

ALTER PROCEDURE SP_USERVIEW
AS
BEGIN
SELECT * FROM TBL_USERS
END
-------- USER PROCEDURE VIEW ---------------------------------------------------------

ALTER PROCEDURE SP_USERSEARCH
@SEARCHKEY VARCHAR(MAX)
AS
BEGIN
SELECT * FROM TBL_USERS
WHERE USER_LASTNAME LIKE @SEARCHKEY + '%' 
END

-------- USER PROCEDURE ACCOUNTRECOVERY--------------------------------------------

CREATE PROCEDURE SP_ACCOUNTRECOVERY
@USER_USERNAME VARCHAR(50),
@SECU_QUESTION VARCHAR(50),
@SECU_ANSWER VARCHAR(50)
AS
BEGIN
SELECT        dbo.TBL_USERS.USER_USERNAME, dbo.TBL_SECURITY.SECU_QUESTION, dbo.TBL_SECURITY.SECU_ANSWER
FROM            dbo.TBL_SECURITY INNER JOIN
                         dbo.TBL_USERS ON dbo.TBL_SECURITY.USER_ID = dbo.TBL_USERS.USER_ID
WHERE TBL_USERS.USER_USERNAME = @USER_USERNAME AND TBL_SECURITY.SECU_QUESTION = @SECU_QUESTION AND TBL_SECURITY.SECU_ANSWER = @SECU_ANSWER
END

-------- USER PROCEDURE UPDATEDEFAULTPASS--------------------------------------------

ALTER PROCEDURE SP_CHANGEDEFAULTPASS
@USER_ID INT,
@USER_USERNAME VARCHAR(50),
@USER_PASSWORD VARCHAR(50)
AS
BEGIN
UPDATE TBL_USERS 
SET USER_PASSWORD = @USER_PASSWORD , USER_USERNAME = @USER_USERNAME 
WHERE USER_ID = @USER_ID
END
select * from tbl_users
-------- USER PROCEDURE UPDATEPASS--------------------------------------------

CREATE PROCEDURE SP_CHANGEUSERPASS
@USER_USERNAME VARCHAR(50),
@USER_PASSWORD VARCHAR(50)
AS
BEGIN
UPDATE TBL_USERS 
SET  USER_PASSWORD = @USER_PASSWORD
WHERE USER_USERNAME = @USER_USERNAME
END

--------SECURITY MASTER-FILE-------------------------------------------------------

CREATE TABLE TBL_SECURITY
(
SECU_ID INT IDENTITY(1,1) PRIMARY KEY,
SECU_QUESTION VARCHAR(50),
SECU_ANSWER VARCHAR(50) ,
USER_ID INT FOREIGN KEY REFERENCES TBL_USERS(USER_ID)
)

-------- USER PROCEDURE SECURITYSAVE-----------------------------------------------

CREATE PROCEDURE SP_SECUSAVE
@SECU_QUESTION VARCHAR(50),
@SECU_ANSWER VARCHAR(50) ,
@USER_ID INT
AS
BEGIN 
INSERT INTO TBL_SECURITY VALUES
(@SECU_QUESTION,@SECU_ANSWER,@USER_ID)
END

--------USERTYPE MASTER-FILE-------------------------------------------------------

CREATE TABLE TBL_USERTYPE
(
USER_TYPEID INT IDENTITY(1,1) PRIMARY KEY,
USER_TYPE VARCHAR(50)
)

-------STUENT SCHOOLYEAR--------------------------------------------------------------

CREATE TABLE TBL_SCHOOLYEAR
(
SCHOOLYEAR_ID INT IDENTITY(1,1) PRIMARY KEY,
SCHOOLYEAR VARCHAR(50)
)

CREATE PROCEDURE SP_SYSAVE
@SCHOOLYEAR VARCHAR(50)
AS
BEGIN
INSERT INTO TBL_SCHOOLYEAR VALUES
(@SCHOOLYEAR)
END

CREATE PROCEDURE SP_SYUPDATE
@SCHOOLYEAR_ID INT,
@SCHOOLYEAR VARCHAR(50)
AS
BEGIN
UPDATE TBL_SCHOOLYEAR
SET SCHOOLYEAR=@SCHOOLYEAR
WHERE SCHOOLYEAR_ID=@SCHOOLYEAR_ID
END

CREATE PROCEDURE SP_SYVIEW
AS
BEGIN
SELECT * FROM TBL_SCHOOLYEAR
END
-------STUENT MASTER-FILE--------------------------------------------------------------

CREATE TABLE TBL_STUDENT
(
ST_ID int identity(1,1),
ST_CURRENTID VARCHAR(50) PRIMARY KEY,
ST_FIRSTNAME VARCHAR(50) NOT NULL,
ST_MIDDLENAME VARCHAR(50),
ST_LASTNAME VARCHAR(50) NOT NULL,
ST_YEARLEVEL VARCHAR(50) NOT NULL,
ST_BIRTHDATE DATE NOT NULL,
ST_AGE INT NOT NULL,
ST_BIRTHPLACE VARCHAR(50) NOT NULL,	
ST_ADDRESS VARCHAR(50) NOT NULL,
ST_GENDER VARCHAR(50) NOT NULL,
ISACTIVE BIT DEFAULT 1,
ST_HEIGHT DECIMAL(5,2),
ST_WEIGHT DECIMAL(5,2),
ST_BPSYSTOLIC INT CHECK(ST_BPSYSTOLIC>0),
ST_BPDIASTOLIC INT CHECK(ST_BPDIASTOLIC>0),
ST_FORM137 VARCHAR(50) NOT NULL,
ST_FORM138 VARCHAR(50) NOT NULL,
ST_GOODMORAL VARCHAR(50) NOT NULL,
ST_NSO VARCHAR(50) NOT NULL,
P_ID INT FOREIGN KEY REFERENCES TBL_PARENT(P_ID),
SEC_ID INT FOREIGN KEY REFERENCES TBL_SECTION(SEC_ID),
SCHOOLYEAR_ID INT FOREIGN KEY REFERENCES TBL_SCHOOLYEAR(SCHOOLYEAR_ID)
)


--------STUDENT PROCEDURE_SAVE-----------------------	----------------------------

ALTER PROCEDURE SP_STSAVE
@ST_CURRENTID VARCHAR(50),
@ST_FIRSTNAME VARCHAR(50),
@ST_MIDDLENAME VARCHAR(50),
@ST_LASTNAME VARCHAR(50),
@ST_YEARLEVEL VARCHAR(50),
@ST_BIRTHDATE DATE,
@ST_AGE INT,
@ST_BIRTHPLACE VARCHAR(50),	
@ST_ADDRESS VARCHAR(50),
@ST_GENDER VARCHAR(50),
@ST_HEIGHT DECIMAL(5,2),
@ST_WEIGHT DECIMAL(5,2),
@ST_BPSYSTOLIC INT,
@ST_BPDIASTOLIC INT,
@ST_FORM137 VARCHAR(50),
@ST_FORM138 VARCHAR(50),
@ST_GOODMORAL VARCHAR(50),
@ST_NSO VARCHAR(50),
@NAME VARCHAR(50),
@P_CONTACT VARCHAR(50),
@P_OCCUPATION VARCHAR(50),
@SEC_ID INT,
@SCHOOLYEAR_ID INT
AS
BEGIN
INSERT INTO TBL_PARENT VALUES
(@NAME,@P_CONTACT,@P_OCCUPATION)
INSERT INTO TBL_STUDENT VALUES
(@ST_CURRENTID,@ST_FIRSTNAME,@ST_MIDDLENAME,@ST_LASTNAME,@ST_YEARLEVEL,@ST_BIRTHDATE,@ST_AGE,@ST_BIRTHPLACE,@ST_ADDRESS,@ST_GENDER,1,@ST_HEIGHT,@ST_WEIGHT,@ST_BPSYSTOLIC,@ST_BPDIASTOLIC,@ST_FORM137,@ST_FORM138,@ST_GOODMORAL,@ST_NSO,@@IDENTITY,@SEC_ID,@SCHOOLYEAR_ID)
END

--------STUDENT PROCEDURE_UPDATE---------------------------------------------------

ALTER PROCEDURE SP_STUPDATE
@ST_CURRENTID VARCHAR(50),
@ST_FIRSTNAME VARCHAR(50),
@ST_MIDDLENAME VARCHAR(50),
@ST_LASTNAME VARCHAR(50),
@ST_YEARLEVEL VARCHAR(50),
@ST_BIRTHDATE DATE,
@ST_AGE INT,
@ST_BIRTHPLACE VARCHAR(50),	
@ST_ADDRESS VARCHAR(50),
@ST_GENDER VARCHAR(50),
@ISACTIVE BIT,
@ST_HEIGHT DECIMAL(5,2),
@ST_WEIGHT DECIMAL(5,2),
@ST_BPSYSTOLIC INT,
@ST_BPDIASTOLIC INT,
@ST_FORM137 VARCHAR(50),
@ST_FORM138 VARCHAR(50),
@ST_GOODMORAL VARCHAR(50),
@ST_NSO VARCHAR(50),
@P_ID INT,
@P_NAME VARCHAR(50),
@P_CONTACT VARCHAR(50),
@P_OCCUPATION VARCHAR(50),
@SEC_ID INT,
@SEC_NAME VARCHAR(50),
@SCHOOLYEAR_ID INT,
@SCHOOLYEAR VARCHAR(50)
AS
BEGIN
UPDATE TBL_PARENT
SET     P_NAME=@P_NAME,P_CONTACT=@P_CONTACT,P_OCCUPATION=@P_OCCUPATION
WHERE   P_ID = @P_ID
UPDATE TBL_STUDENT
SET	   ST_FIRSTNAME=@ST_FIRSTNAME,ST_MIDDLENAME=@ST_MIDDLENAME,ST_LASTNAME=@ST_LASTNAME,ST_YEARLEVEL=@ST_YEARLEVEL,ST_BIRTHDATE=@ST_BIRTHDATE,ST_AGE=@ST_AGE,ST_BIRTHPLACE=@ST_BIRTHPLACE,ST_ADDRESS=@ST_ADDRESS,
	   ST_GENDER=@ST_GENDER,ISACTIVE=@ISACTIVE,ST_HEIGHT=@ST_HEIGHT,ST_WEIGHT=@ST_WEIGHT,ST_BPSYSTOLIC = @ST_BPSYSTOLIC , ST_BPDIASTOLIC=@ST_BPDIASTOLIC,ST_FORM137=@ST_FORM137,ST_FORM138=@ST_FORM138,ST_GOODMORAL=@ST_GOODMORAL,ST_NSO=@ST_NSO
WHERE  ST_CURRENTID = @ST_CURRENTID
UPDATE TBL_SECTION
SET	   SEC_NAME = @SEC_NAME
WHERE  SEC_ID= @SEC_ID
UPDATE TBL_SCHOOLYEAR
SET    SCHOOLYEAR=@SCHOOLYEAR
WHERE  SCHOOLYEAR_ID=@SCHOOLYEAR_ID
END

--------STUDENT PROCEDURE_SEARCH---------------------------------------------------

ALTER PROCEDURE SP_STSEARCH
@SEARCH_KEY VARCHAR(MAX)
AS
BEGIN
SELECT * FROM TBL_STUDENT 
WHERE ST_FIRSTNAME LIKE @SEARCH_KEY + '%' OR ST_LASTNAME LIKE @SEARCH_KEY + '%'
END

ALTER PROCEDURE SP_STREQSEARCH
@SEARCH_KEY VARCHAR(MAX)
AS
BEGIN
SELECT        ST_FIRSTNAME + ' ' + ST_MIDDLENAME + ' ' + ST_LASTNAME AS [STUDENT NAME], ST_FORM137 AS FORM137, ST_FORM138 AS FORM138, ST_GOODMORAL AS GOODMORAL, ST_NSO
FROM            dbo.TBL_STUDENT
WHERE ST_FIRSTNAME LIKE @SEARCH_KEY + '%' OR ST_LASTNAME LIKE @SEARCH_KEY + '%'
END

CREATE PROCEDURE SP_STVIEW
AS
BEGIN
SELECT * FROM TBL_STUDENT
END
--------STUDENT PROCEDURE_STCURRENTID---------------------------------------------------

ALTER PROCEDURE ST_CURRENTID
AS
BEGIN
DECLARE @ST_CURRENTID VARCHAR(50)
SELECT @ST_CURRENTID = IDENT_CURRENT('TBL_STUDENT')
RETURN @ST_CURRENTID
END

--------PARENT MASTER-FILE-------------------------------------------------------------

CREATE TABLE TBL_PARENT 
(
P_ID INT IDENTITY(1,1) PRIMARY KEY,
P_NAME VARCHAR(50) NOT NULL,
P_CONTACT VARCHAR(50) NOT NULL,
P_OCCUPATION VARCHAR(50) NOT NULL,
)

--------BMICOMPUTATION MASTER-FILE----------------------------------------------------

CREATE TABLE TBL_BMICOMP
(
BMI_ID INT IDENTITY(1,1) PRIMARY KEY,
BMI_HWRESULT VARCHAR(50),
BMI_BPRESULT VARCHAR(50),
ST_CURRENTID VARCHAR(50) FOREIGN KEY REFERENCES TBL_STUDENT(ST_CURRENTID)
)

CREATE PROCEDURE SP_VIEWBMI
AS
BEGIN
SELECT        dbo.TBL_STUDENT.ST_FIRSTNAME + ' ' + dbo.TBL_STUDENT.ST_MIDDLENAME + ' ' + dbo.TBL_STUDENT.ST_LASTNAME AS [STUDENT NAME], dbo.TBL_BMICOMP.BMI_HWRESULT AS [BODY MASS INDEX], 
                         dbo.TBL_BMICOMP.BMI_BPRESULT AS [BLOODPRESSURE]
FROM            dbo.TBL_BMICOMP INNER JOIN
                         dbo.TBL_STUDENT ON dbo.TBL_BMICOMP.ST_CURRENTID = dbo.TBL_STUDENT.ST_CURRENTID
END
--------GRADE MASTER-FILE-------------------------------------------------------------

CREATE TABLE TBL_GRADE
(
GRADE_ID INT IDENTITY(1,1) PRIMARY KEY,
ST_CURRENTID VARCHAR(50) FOREIGN KEY REFERENCES TBL_STUDENT(ST_CURRENTID),
GRADEPERIOD VARCHAR(50),
GRADE INT,
SUBJECT_ID INT FOREIGN KEY REFERENCES TBL_SUBJECT(SUBJECT_ID),
)
SELECT * FROM TBL_STUDENT
SELECT * FROM TBL_SUBJECT
SELECT AVG(GRADE)FROM TBL_GRADE
WHERE ST_CURRENTID='ST-00014' AND SUBJECT_ID = 1
SELECT GRADE FROM TBL_GRADE WHERE ST_CURRENTID = 'St-00014' AND SUBJECT_ID = 1
----------SUBJECT MASTER-FILE------------------------------------------------------------

CREATE TABLE TBL_SUBJECT
(
SUBJECT_ID INT IDENTITY(1,1) PRIMARY KEY,
SUBJECTNAME VARCHAR(50) NOT NULL
)

CREATE PROCEDURE SP_SUBSAVE
@SUBJECTNAME VARCHAR(50)
AS 
BEGIN
INSERT INTO TBL_SUBJECT VALUES(@SUBJECTNAME)
ENDE

CREATE PROCEDURE SP_SUBUPDATE
@SUBJECT_ID INT,
@SUBJECTNAME VARCHAR(50)
AS
BEGIN
UPDATE TBL_SUBJECT
SET SUBJECTNAME=@SUBJECTNAME
WHERE SUBJECT_ID=@SUBJECT_ID
END

ALTER PROCEDURE SP_SUBVIEW
AS
BEGIN
SELECT        SUBJECT_ID AS ID, SUBJECTNAME AS SUBJECT
FROM            dbo.TBL_SUBJECT
END
--------SECTION MASTER-FILE------------------------------------------------------------

CREATE TABLE TBL_SECTION
(
SEC_ID INT IDENTITY(1,1) PRIMARY KEY,
SEC_NAME VARCHAR(50) NOT NULL,
SEC_CAPACITY INT NOT NULL,
T_ID INT  FOREIGN KEY REFERENCES TBL_TEACHER(T_ID),
)
ALTER TABLE TBL_SECTION
ADD SEC_YEARLEVEL VARCHAR(50)

ALTER PROCEDURE SP_SECTIONSAVE
@SEC_NAME VARCHAR(50),
@SEC_CAPACITY VARCHAR(50),
@T_ID INT,
@SEC_YEARLEVEL VARCHAR(50)
AS
BEGIN
INSERT INTO TBL_SECTION VALUES
(@SEC_NAME,@SEC_CAPACITY,@T_ID,@SEC_YEARLEVEL)
END

ALTER PROCEDURE SP_SECTIONUPDATE
@SEC_ID INT,
@SEC_NAME VARCHAR(50),
@SEC_CAPACITY VARCHAR(50),
@T_ID INT
AS
BEGIN
UPDATE TBL_SECTION
SET SEC_NAME=@SEC_NAME,SEC_CAPACITY=@SEC_CAPACITY
WHERE SEC_ID=@SEC_ID
UPDATE TBL_SECTION
SET T_FIRSTNAME = @T_FIRSTNAME,T_MIDDLENAME=@T_MIDDLENAME,T_LASTNAME=@T_LASTNAME
WHERE T_ID = @T_ID
END

ALTER PROCEDURE SP_SECVIEW
AS
BEGIN
SELECT        dbo.TBL_SECTION.SEC_ID, dbo.TBL_SECTION.SEC_NAME as SECTION, dbo.TBL_SECTION.SEC_CAPACITY as CAPACITY,dbo.TBL_SECTION.SEC_YEARLEVEL as [YEAR LEVEL], dbo.TBL_TEACHER.T_ID, 
                         dbo.TBL_TEACHER.T_FIRSTNAME + ' ' + dbo.TBL_TEACHER.T_MIDDLENAME + ' ' + dbo.TBL_TEACHER.T_LASTNAME AS [ADVISORY]
FROM            dbo.TBL_SECTION INNER JOIN
                         dbo.TBL_TEACHER ON dbo.TBL_SECTION.T_ID = dbo.TBL_TEACHER.T_ID
END

--------BOOKS MASTER-FILE--------------------------------------------------------------

CREATE TABLE TBL_BOOKS
(
B_ID INT IDENTITY(1,1) PRIMARY KEY,
B_BOOKNAME VARCHAR(50) NOT NULL,
B_BOOKDESC VARCHAR(50) NOT NULL,
BOOK_YEARLEVEL VARCHAR(50),
B_AUTHOR VARCHAR(50),
B_PUBLISHED DATE
)
select * from tbl_books
ALTER PROCEDURE SP_BOOKSSAVE
@B_BOOKNAME VARCHAR (50),
@B_BOOKDESC VARCHAR (50),
@BOOK_YEARLEVEL VARCHAR(50),	
@B_AUTHOR VARCHAR(50),
@B_PUBLISHED DATE
AS
BEGIN
INSERT INTO TBL_BOOKS VALUES
(@B_BOOKNAME,@B_BOOKDESC,@BOOK_YEARLEVEL,@B_AUTHOR,@B_PUBLISHED)
END

ALTER PROCEDURE SP_BOOKSUPDATE
@B_ID INT,
@B_BOOKNAME VARCHAR (50),
@B_BOOKDESC VARCHAR (50),
@BOOK_YEARLEVEL VARCHAR(50),
@B_AUTHOR VARCHAR(50),
@B_PUBLISHED DATE
AS
BEGIN
UPDATE TBL_BOOKS
SET B_BOOKNAME=@B_BOOKNAME,B_BOOKDESC=@B_BOOKDESC,BOOK_YEARLEVEL=@BOOK_YEARLEVEL,B_AUTHOR=@B_AUTHOR,B_PUBLISHED=@B_PUBLISHED
WHERE B_ID=@B_ID
END

ALTER PROCEDURE SP_BOOKSEARCH
@SEARCHKEY VARCHAR(MAX)
AS
BEGIN
SELECT * FROM TBL_BOOKS
WHERE B_BOOKNAME LIKE @SEARCHKEY + '%'
END

ALTER PROCEDURE SP_BOOKVIEW
AS
BEGIN
SELECT        B_ID AS ID, B_BOOKNAME AS BOOK, B_BOOKDESC AS DESCRIPTION, BOOK_YEARLEVEL AS [YEAR LEVEL], B_AUTHOR AS AUTHOR, B_PUBLISHED AS PUBLISHED
FROM            dbo.TBL_BOOKS
END
	
CREATE TABLE TBL_STUDBOOKS
(
STUDBOOKS_ID INT IDENTITY(1,1) PRIMARY KEY,
B_ID INT FOREIGN KEY REFERENCES TBL_BOOKS(B_ID) NOT NULL,
ST_CURRENTID VARCHAR(50) FOREIGN KEY REFERENCES TBL_STUDENT(ST_CURRENTID) NOT NULL,
RETURNDATE TIMESTAMP NULL
)
ALTER TABLE TBL_STUDBOOKS
ADD  RETURNDATE DATETIME NULL

select * from TBL_STUDBOOKS

CREATE PROCEDURE SP_VIEWSTUDBOOKS
AS BEGIN
SELECT        dbo.TBL_STUDENT.ST_CURRENTID, dbo.TBL_STUDENT.ST_FIRSTNAME + ' ' + dbo.TBL_STUDENT.ST_MIDDLENAME + ' ' + dbo.TBL_STUDENT.ST_LASTNAME AS [STUDENT NAME], dbo.TBL_BOOKS.B_ID, 
                         dbo.TBL_BOOKS.B_BOOKNAME AS BOOK, dbo.TBL_STUDBOOKS.RETURNDATE
FROM            dbo.TBL_BOOKS INNER JOIN
                         dbo.TBL_STUDBOOKS ON dbo.TBL_BOOKS.B_ID = dbo.TBL_STUDBOOKS.B_ID INNER JOIN
                         dbo.TBL_STUDENT ON dbo.TBL_STUDBOOKS.ST_CURRENTID = dbo.TBL_STUDENT.ST_CURRENTID
END
--------PAYMENTDETAILS MASTER-FILE-----------------------------------------------------

CREATE TABLE TBL_PAYMENTDETAILS
(
PD_ID INT IDENTITY(1,1) PRIMARY KEY,
PAYMENTFOR VARCHAR(50) NOT NULL,
PAYMENTAMOUNT MONEY NOT NULL,
SCHOOLYEAR_ID INT FOREIGN KEY REFERENCES TBL_SCHOOLYEAR(SCHOOLYEAR_ID),
PAYMENT_ID INT FOREIGN KEY REFERENCES TBL_PAYMENT(PAYMENT_ID)
)

ALTER PROCEDURE SP_PAYSAVE
@PAYMENTFOR VARCHAR(50),
@PAYMENTAMOUNT MONEY,
@SCHOOLYEAR_ID INT,
@PAYMENT_ID INT
AS
BEGIN
INSERT INTO TBL_PAYMENTDETAILS VALUES
(@PAYMENTFOR,@PAYMENTAMOUNT,@SCHOOLYEAR_ID,@PAYMENT_ID)
END

ALTER PROCEDURE SP_PAYUPDATE
@PD_ID INT,
@PAYMENTFOR VARCHAR(50),
@PAYMENTAMOUNT MONEY,
@SCHOOLYEAR_ID INT
AS
BEGIN
UPDATE TBL_PAYMENTDETAILS
SET PAYMENTFOR=@PAYMENTFOR,PAYMENTAMOUNT=@PAYMENTAMOUNT,SCHOOLYEAR_ID=@SCHOOLYEAR_ID
WHERE PD_ID=@PD_ID
END
ALTER PROCEDURE SP_PAYDETVIEW
AS 
BEGIN
SELECT        dbo.TBL_PAYMENTDETAILS.PD_ID, dbo.TBL_PAYMENTDETAILS.PAYMENTFOR, dbo.TBL_PAYMENTDETAILS.PAYMENTAMOUNT, dbo.TBL_SCHOOLYEAR.SCHOOLYEAR_ID, dbo.TBL_SCHOOLYEAR.SCHOOLYEAR
FROM            dbo.TBL_PAYMENTDETAILS INNER JOIN
                         dbo.TBL_SCHOOLYEAR ON dbo.TBL_PAYMENTDETAILS.SCHOOLYEAR_ID = dbo.TBL_SCHOOLYEAR.SCHOOLYEAR_ID
END

CREATE PROCEDURE SP_PAYSEARCH
@SEARCHKEY VARCHAR(MAX)
AS
BEGIN
SELECT * FROM TBL_PAYMENTDETAILS
WHERE PAYMENTFOR LIKE  @SEARCHKEY + '%'
END

CREATE TABLE TBL_PAYMENT
(
PAYMENT_ID INT IDENTITY(1,1) PRIMARY KEY,
PAYMENT_NAME VARCHAR(50),
PAYMENT_DESC VARCHAR(50)
)

CREATE PROCEDURE SP_PAYMENTSAVE
@PAYMENT_NAME VARCHAR(50),
@PAYMENT_DESC VARCHAR(50)
AS
BEGIN
INSERT INTO TBL_PAYMENT VALUES
(@PAYMENT_NAME,@PAYMENT_DESC)
END

CREATE PROCEDURE SP_PAYMENTVIEW
AS
BEGIN
SELECT * FROM TBL_PAYMENT
END

--------TEACHER MASTER-FILE-------------------------------------------------------------

CREATE TABLE TBL_TEACHER
(
T_ID INT IDENTITY(1,1) PRIMARY KEY,
T_FIRSTNAME  VARCHAR(50) NOT NULL,
T_MIDDLENAME VARCHAR(50),
T_LASTNAME VARCHAR(50) NOT NULL,
ISACTIVE BIT,
T_CONTACTNUMBER VARCHAR(50) NOT NULL,
SUBJECT_ID INT FOREIGN KEY REFERENCES TBL_SUBJECT(SUBJECT_ID)
)

ALTER PROCEDURE SP_TEACHERSAVE
@T_FIRSTNAME  VARCHAR(50),
@T_MIDDLENAME VARCHAR(50),
@T_LASTNAME VARCHAR(50),
@T_CONTACTNUMBER VARCHAR(50),
@SUBJECT_ID INT
AS
BEGIN
INSERT INTO TBL_TEACHER VALUES
(@T_FIRSTNAME,@T_MIDDLENAME,@T_LASTNAME,1,@T_CONTACTNUMBER,@SUBJECT_ID)
END

ALTER PROCEDURE SP_TEACHERUPDATE
@T_ID INT,
@T_FIRSTNAME  VARCHAR(50),
@T_MIDDLENAME VARCHAR(50),
@T_LASTNAME VARCHAR(50),
@ISACTIVE BIT,
@T_CONTACTNUMBER VARCHAR(50),
@SUBJECT_ID INT,
@SUBJECTNAME VARCHAR(50)
AS
BEGIN
UPDATE TBL_TEACHER 
SET T_FIRSTNAME=@T_FIRSTNAME,T_MIDDLENAME=@T_MIDDLENAME,T_LASTNAME=@T_LASTNAME,ISACTIVE=@ISACTIVE,T_CONTACTNUMBER=@T_CONTACTNUMBER
WHERE T_ID=@T_ID
UPDATE TBL_SUBJECT
SET SUBJECTNAME=@SUBJECTNAME
WHERE SUBJECT_ID=@SUBJECT_ID
END

ALTER PROCEDURE SP_TEACHERVIEW
AS 
BEGIN
SELECT        dbo.TBL_TEACHER.T_ID AS ID, dbo.TBL_TEACHER.T_FIRSTNAME AS FIRSTNAME, dbo.TBL_TEACHER.T_MIDDLENAME AS MIDDLENAME, dbo.TBL_TEACHER.T_LASTNAME AS LASTNAME, 
                         dbo.TBL_TEACHER.ISACTIVE AS [ISACTIVE?], dbo.TBL_TEACHER.T_CONTACTNUMBER AS [CONTACT NUMBER], dbo.TBL_SUBJECT.SUBJECT_ID AS [SUBJECT ID], dbo.TBL_SUBJECT.SUBJECTNAME AS SUBJECT
FROM            dbo.TBL_SUBJECT INNER JOIN
                         dbo.TBL_TEACHER ON dbo.TBL_SUBJECT.SUBJECT_ID = dbo.TBL_TEACHER.SUBJECT_ID
END

CREATE PROCEDURE SP_TEACHERSEARCH
@SEARCHKEY VARCHAR(50)
AS
BEGIN
SELECT * FROM TBL_TEACHER
WHERE T_FIRSTNAME LIKE @SEARCHKEY + '%' OR T_LASTNAME LIKE @SEARCHKEY + '%'
END
--------INTERMIDIARY TABLE---------------------------------------------------------------

CREATE TABLE TBL_STANDPAY
(
STANDPAY_ID INT IDENTITY(1,1) PRIMARY KEY,
PD_ID INT FOREIGN KEY REFERENCES TBL_PAYMENTDETAILS(PD_ID),
ST_CURRENTID VARCHAR(50) FOREIGN KEY REFERENCES TBL_STUDENT(ST_CURRENTID)
)

CREATE TABLE TBL_THRINTERMEDIARYSEC
(
THRANDSEC_ID INT IDENTITY(1,1) PRIMARY KEY,
SEC_ID INT  FOREIGN KEY REFERENCES TBL_SECTION(SEC_ID),
T_ID INT  FOREIGN KEY REFERENCES TBL_TEACHER(T_ID)
)

--------TEACHERSCHEDULE MASTER-FILE-----------------------------------------------------

CREATE TABLE TBL_TEACHERSCHEDULE
(
TSCHED_ID INT IDENTITY(1,1) PRIMARY KEY,
TEACHER VARCHAR(50),
SEC_ID INT FOREIGN KEY REFERENCES TBL_SECTION(SEC_ID),
SUBJECT VARCHAR (50),
TIME_ID INT FOREIGN KEY REFERENCES TBL_SCHEDULETIME(TIME_ID)
)
 
ALTER PROCEDURE SP_THSCHEDSAVE
@TEARCHER VARCHAR(50),
@SEC_ID INT,
@SUBJECT VARCHAR (50),
@TIME_ID INT
AS
BEGIN
INSERT INTO TBL_TEACHERSCHEDULE VALUES
(@TEARCHER,@SEC_ID,@SUBJECT,@TIME_ID)
END

CREATE PROCEDURE SP_THSCHEDUPDATE
@SEC_ID INT,
@SEC_NAME VARCHAR(50),
@TIME_ID INT,
@TIME_START VARCHAR(50),
@TIME_END VARCHAR(50)
AS
BEGIN
UPDATE TBL_SECTION
SET SEC_NAME=@SEC_NAME
WHERE SEC_ID=@SEC_ID
UPDATE TBL_SCHEDULETIME
SET TIME_START=@TIME_START,TIME_END=@TIME_END
WHERE TIME_ID=@TIME_ID
END

ALTER PROCEDURE SP_THSCHEDSEARCH
@SEARCHKEY VARCHAR(MAX)
AS
BEGIN
SELECT        dbo.TBL_TEACHERSCHEDULE.TSCHED_ID, dbo.TBL_TEACHERSCHEDULE.TEARCHER,dbo.TBL_SECTION.SEC_ID, dbo.TBL_SECTION.SEC_NAME AS SECTION, 
                         dbo.TBL_SCHEDULETIME.TIME_ID, dbo.TBL_SCHEDULETIME.TIME_START + ' ' + dbo.TBL_SCHEDULETIME.TIME_END AS SCHEDULE
FROM            dbo.TBL_SCHEDULETIME INNER JOIN
                         dbo.TBL_TEACHERSCHEDULE ON dbo.TBL_SCHEDULETIME.TIME_ID = dbo.TBL_TEACHERSCHEDULE.TIME_ID INNER JOIN
                         dbo.TBL_SECTION ON dbo.TBL_TEACHERSCHEDULE.SEC_ID = dbo.TBL_SECTION.SEC_ID
WHERE TEARCHER LIKE @SEARCHKEY +'%'
END


ALTER PROCEDURE SP_THSCHEDVIEW
AS
BEGIN
SELECT        dbo.TBL_TEACHERSCHEDULE.TSCHED_ID, dbo.TBL_TEACHERSCHEDULE.TEARCHER, dbo.TBL_SECTION.SEC_ID, dbo.TBL_SECTION.SEC_NAME AS SECTION, 
                         dbo.TBL_SCHEDULETIME.TIME_ID, dbo.TBL_SCHEDULETIME.TIME_START + ' ' + dbo.TBL_SCHEDULETIME.TIME_END AS SCHEDULE
FROM            dbo.TBL_SCHEDULETIME INNER JOIN
                         dbo.TBL_TEACHERSCHEDULE ON dbo.TBL_SCHEDULETIME.TIME_ID = dbo.TBL_TEACHERSCHEDULE.TIME_ID INNER JOIN
                         dbo.TBL_SECTION ON dbo.TBL_TEACHERSCHEDULE.SEC_ID = dbo.TBL_SECTION.SEC_ID
END

--walay klarong function
--ALTER PROCEDURE SP_EXISTSEC
--@TEARCHER VARCHAR(50),
--@SEC_ID INT
--AS
--BEGIN
--SELECT        dbo.TBL_TEACHERSCHEDULE.SEC_ID
--FROM            dbo.TBL_SECTION INNER JOIN
--                         dbo.TBL_TEACHER ON dbo.TBL_SECTION.T_ID = dbo.TBL_TEACHER.T_ID INNER JOIN
--                         dbo.TBL_TEACHERSCHEDULE ON dbo.TBL_SECTION.SEC_ID = dbo.TBL_TEACHERSCHEDULE.SEC_ID
--END

CREATE TABLE TBL_SCHEDULETIME
(
TIME_ID INT IDENTITY(1,1) PRIMARY KEY,
TIME_START VARCHAR(50),
TIME_END VARCHAR(50)
)

CREATE PROCEDURE SP_SAVETIME
@TIME_START VARCHAR(50),
@TIME_END VARCHAR(50)
AS
BEGIN
INSERT INTO TBL_SCHEDULETIME VALUES
(@TIME_START,@TIME_END)
END

CREATE PROCEDURE SP_VIEWTIME
AS
BEGIN 
SELECT * FROM TBL_SCHEDULETIME
END





