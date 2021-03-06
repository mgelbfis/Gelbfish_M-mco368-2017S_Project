USE [master]
GO
/****** Object:  Database [HomeCooking]    Script Date: 8/16/2017 7:25:55 AM ******/
CREATE DATABASE [HomeCooking]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HomeCooking', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\HomeCooking.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'HomeCooking_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\HomeCooking_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [HomeCooking] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HomeCooking].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HomeCooking] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HomeCooking] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HomeCooking] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HomeCooking] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HomeCooking] SET ARITHABORT OFF 
GO
ALTER DATABASE [HomeCooking] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HomeCooking] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HomeCooking] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HomeCooking] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HomeCooking] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HomeCooking] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HomeCooking] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HomeCooking] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HomeCooking] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HomeCooking] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HomeCooking] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HomeCooking] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HomeCooking] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HomeCooking] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HomeCooking] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HomeCooking] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HomeCooking] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HomeCooking] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [HomeCooking] SET  MULTI_USER 
GO
ALTER DATABASE [HomeCooking] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HomeCooking] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HomeCooking] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HomeCooking] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [HomeCooking] SET DELAYED_DURABILITY = DISABLED 
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [valKai]    Script Date: 8/16/2017 7:25:55 AM ******/
CREATE LOGIN [valKai] WITH PASSWORD=N'°4øê­hõö0ãÆ°LÜÍíòj@z|ýÇ.­ru', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
ALTER LOGIN [valKai] DISABLE
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [tkrupka]    Script Date: 8/16/2017 7:25:55 AM ******/
CREATE LOGIN [tkrupka] WITH PASSWORD=N'Ç¢ çÂµìì''1·\°üéñÂÎW;é~ä*Ô', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
ALTER LOGIN [tkrupka] DISABLE
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [TestMid]    Script Date: 8/16/2017 7:25:55 AM ******/
CREATE LOGIN [TestMid] WITH PASSWORD=N'*zhèEqgTî1Èq''âU!½ÕeX9e·­4O©z\@', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=ON, CHECK_POLICY=ON
GO
ALTER LOGIN [TestMid] DISABLE
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [StudyingMid]    Script Date: 8/16/2017 7:25:55 AM ******/
CREATE LOGIN [StudyingMid] WITH PASSWORD=N'sé³¿ÛºA´É°M}Ì¯Åw(7GqÆNj>ì', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=ON, CHECK_POLICY=ON
GO
ALTER LOGIN [StudyingMid] DISABLE
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [richhull]    Script Date: 8/16/2017 7:25:55 AM ******/
CREATE LOGIN [richhull] WITH PASSWORD=N'1ýhd¹«Ç©_¿3Ð1(6ÞÈ¢òiú¶Å', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
ALTER LOGIN [richhull] DISABLE
GO
/****** Object:  Login [NT SERVICE\Winmgmt]    Script Date: 8/16/2017 7:25:55 AM ******/
CREATE LOGIN [NT SERVICE\Winmgmt] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
/****** Object:  Login [NT SERVICE\SQLWriter]    Script Date: 8/16/2017 7:25:55 AM ******/
CREATE LOGIN [NT SERVICE\SQLWriter] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
/****** Object:  Login [NT SERVICE\ReportServer$SQLEXPRESS]    Script Date: 8/16/2017 7:25:55 AM ******/
CREATE LOGIN [NT SERVICE\ReportServer$SQLEXPRESS] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
/****** Object:  Login [NT Service\MSSQL$SQLEXPRESS]    Script Date: 8/16/2017 7:25:55 AM ******/
CREATE LOGIN [NT Service\MSSQL$SQLEXPRESS] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
/****** Object:  Login [NT AUTHORITY\SYSTEM]    Script Date: 8/16/2017 7:25:55 AM ******/
CREATE LOGIN [NT AUTHORITY\SYSTEM] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [nanMarks]    Script Date: 8/16/2017 7:25:55 AM ******/
CREATE LOGIN [nanMarks] WITH PASSWORD=N'Ø#F)¾êv=ÉÐ>çÚ»Iã%öpî[÷', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
ALTER LOGIN [nanMarks] DISABLE
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [mgelbfis]    Script Date: 8/16/2017 7:25:55 AM ******/
CREATE LOGIN [mgelbfis] WITH PASSWORD=N'rö±ES¯£=f¹§ÝÌ¥ÃS-ßÁÿéÐ0M', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
ALTER LOGIN [mgelbfis] DISABLE
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [markM]    Script Date: 8/16/2017 7:25:55 AM ******/
CREATE LOGIN [markM] WITH PASSWORD=N'o÷²5".&mFÁ¨çko\@©e', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
ALTER LOGIN [markM] DISABLE
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [lobermeister]    Script Date: 8/16/2017 7:25:55 AM ******/
CREATE LOGIN [lobermeister] WITH PASSWORD=N'ý|ø]¯ÿp©õTøß.	¶¶yê$q}', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
ALTER LOGIN [lobermeister] DISABLE
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [lisaL]    Script Date: 8/16/2017 7:25:55 AM ******/
CREATE LOGIN [lisaL] WITH PASSWORD=N'¬ÒvoÓÔKáþ9iµÔPó_tqz', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
ALTER LOGIN [lisaL] DISABLE
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [LeeCust]    Script Date: 8/16/2017 7:25:55 AM ******/
CREATE LOGIN [LeeCust] WITH PASSWORD=N'ø½?ä
e''GÉÖG1£©8éºÔH8"n#Kò·£', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
ALTER LOGIN [LeeCust] DISABLE
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [KlineCust]    Script Date: 8/16/2017 7:25:55 AM ******/
CREATE LOGIN [KlineCust] WITH PASSWORD=N'ö$Ê`óV6msX1×7«3b@³ÌÖÑÿ&wÈ³', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
ALTER LOGIN [KlineCust] DISABLE
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [juanP]    Script Date: 8/16/2017 7:25:55 AM ******/
CREATE LOGIN [juanP] WITH PASSWORD=N'y\^NÏV
Þ::Ä{Êaó&DØÒºÿü¡ßØÝÏ ', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
ALTER LOGIN [juanP] DISABLE
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [JohnsonCust]    Script Date: 8/16/2017 7:25:55 AM ******/
CREATE LOGIN [JohnsonCust] WITH PASSWORD=N'OxY,5Ó²~:ÇÏ	¯£ÚTA©7ÃÙúúB¶/', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
ALTER LOGIN [JohnsonCust] DISABLE
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [harryH]    Script Date: 8/16/2017 7:25:55 AM ******/
CREATE LOGIN [harryH] WITH PASSWORD=N'ÐYË»G³!ð7æìlTÍ´p|fÒb}Ü1', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
ALTER LOGIN [harryH] DISABLE
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [guest]    Script Date: 8/16/2017 7:25:55 AM ******/
CREATE LOGIN [guest] WITH PASSWORD=N'\V³cáWØ_ ´ ¥#½S·
ÝÓ¥ h|', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
ALTER LOGIN [guest] DISABLE
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [garyG]    Script Date: 8/16/2017 7:25:55 AM ******/
CREATE LOGIN [garyG] WITH PASSWORD=N'mV/$(BãWð8r²Fá	4´³eÁîUx6', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
ALTER LOGIN [garyG] DISABLE
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [frankF]    Script Date: 8/16/2017 7:25:55 AM ******/
CREATE LOGIN [frankF] WITH PASSWORD=N'Ñ õß;Ö¯ò/ñ£5ÔÑ®vúpð÷°W)^', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
ALTER LOGIN [frankF] DISABLE
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [fergCust]    Script Date: 8/16/2017 7:25:55 AM ******/
CREATE LOGIN [fergCust] WITH PASSWORD=N'4iª,
Dv¢y¹M:~ÜËìé ²aº', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
ALTER LOGIN [fergCust] DISABLE
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [EveryCust]    Script Date: 8/16/2017 7:25:55 AM ******/
CREATE LOGIN [EveryCust] WITH PASSWORD=N'©ßÊ"@·Ì~bl!îÕPÁ£G)µo»T:©Þ>', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
ALTER LOGIN [EveryCust] DISABLE
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [dkrupka]    Script Date: 8/16/2017 7:25:55 AM ******/
CREATE LOGIN [dkrupka] WITH PASSWORD=N'0
Æ¿­ßXÆ0ÃcÔÄã;»È½yäL)ÓCÆ', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
ALTER LOGIN [dkrupka] DISABLE
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [dgelbfis]    Script Date: 8/16/2017 7:25:55 AM ******/
CREATE LOGIN [dgelbfis] WITH PASSWORD=N'u\I$¤z ²,~¡Ø,çÙ{vùúEB. £søöe', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
ALTER LOGIN [dgelbfis] DISABLE
GO
/****** Object:  Login [DESKTOP-H3B32JA\mbg]    Script Date: 8/16/2017 7:25:55 AM ******/
CREATE LOGIN [DESKTOP-H3B32JA\mbg] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [DeerCust]    Script Date: 8/16/2017 7:25:55 AM ******/
CREATE LOGIN [DeerCust] WITH PASSWORD=N'%³vp]ùç,QÝúëti[ª{ì8çÿ?¯½', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
ALTER LOGIN [DeerCust] DISABLE
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [davidC]    Script Date: 8/16/2017 7:25:55 AM ******/
CREATE LOGIN [davidC] WITH PASSWORD=N'Õ!öùõJÞ°ò/Ëa¹^³Û@L©+i
fÃ', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
ALTER LOGIN [davidC] DISABLE
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [csklar]    Script Date: 8/16/2017 7:25:55 AM ******/
CREATE LOGIN [csklar] WITH PASSWORD=N'çyñ}^aøPÛØðDßÙôNÖÞ|NwV³±', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
ALTER LOGIN [csklar] DISABLE
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [cmarcus]    Script Date: 8/16/2017 7:25:55 AM ******/
CREATE LOGIN [cmarcus] WITH PASSWORD=N'þTÕ\_Q YOÌ¥Õ~ý³?Ê[6oÓØßeIÊ', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
ALTER LOGIN [cmarcus] DISABLE
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [caugenstei]    Script Date: 8/16/2017 7:25:55 AM ******/
CREATE LOGIN [caugenstei] WITH PASSWORD=N'<®óáÛê¹C&ÈÃPePÏ$unÌd¶ì¡Ã', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
ALTER LOGIN [caugenstei] DISABLE
GO
/****** Object:  Login [BUILTIN\Users]    Script Date: 8/16/2017 7:25:55 AM ******/
CREATE LOGIN [BUILTIN\Users] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [BrooksCust]    Script Date: 8/16/2017 7:25:55 AM ******/
CREATE LOGIN [BrooksCust] WITH PASSWORD=N'ûòQ`¶°¥ÁøMeà¹+møU²¯rè½ô!»ó', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
ALTER LOGIN [BrooksCust] DISABLE
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [billD]    Script Date: 8/16/2017 7:25:55 AM ******/
CREATE LOGIN [billD] WITH PASSWORD=N'Òö''h-#wõÄvé±Ãú¼ÞfÇ¥xvQei°~', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
ALTER LOGIN [billD] DISABLE
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [bgelbfis]    Script Date: 8/16/2017 7:25:55 AM ******/
CREATE LOGIN [bgelbfis] WITH PASSWORD=N'!ý¯³
kÑo8å|cs 
Óÿé²¿¨,÷ nSXË', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
ALTER LOGIN [bgelbfis] DISABLE
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [bettyG]    Script Date: 8/16/2017 7:25:55 AM ******/
CREATE LOGIN [bettyG] WITH PASSWORD=N'2xtë§húb&ì]''v(+FÈ¢¥s%üú#©µ°', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
ALTER LOGIN [bettyG] DISABLE
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [BargainCust]    Script Date: 8/16/2017 7:25:55 AM ******/
CREATE LOGIN [BargainCust] WITH PASSWORD=N' Ëü4S{LÊúÂ3þÔºª#P0åÌx', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
ALTER LOGIN [BargainCust] DISABLE
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [AllSeasonCust]    Script Date: 8/16/2017 7:25:55 AM ******/
CREATE LOGIN [AllSeasonCust] WITH PASSWORD=N'«y]¥g²ÚL[ûÉ|·¦ráÖ:µ@ í×T', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
ALTER LOGIN [AllSeasonCust] DISABLE
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [AlCust]    Script Date: 8/16/2017 7:25:55 AM ******/
CREATE LOGIN [AlCust] WITH PASSWORD=N'JÏêJöF²þ}Ô@w7@ñÜuÑ:ve¥8²Ù', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
ALTER LOGIN [AlCust] DISABLE
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [agelbfis]    Script Date: 8/16/2017 7:25:55 AM ******/
CREATE LOGIN [agelbfis] WITH PASSWORD=N'>	ÌKÌÆ»¢&Ðb½^°cà\vyÙÍ$«@', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
ALTER LOGIN [agelbfis] DISABLE
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [##MS_PolicyTsqlExecutionLogin##]    Script Date: 8/16/2017 7:25:55 AM ******/
CREATE LOGIN [##MS_PolicyTsqlExecutionLogin##] WITH PASSWORD=N'+rv)ÏÙ4QñeV$À×ÓQ²G)L', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON
GO
ALTER LOGIN [##MS_PolicyTsqlExecutionLogin##] DISABLE
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [##MS_PolicyEventProcessingLogin##]    Script Date: 8/16/2017 7:25:55 AM ******/
CREATE LOGIN [##MS_PolicyEventProcessingLogin##] WITH PASSWORD=N'ð³-¯ËK9]ÃòB4u;Åñ©Ó8''_Ó_O×', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON
GO
ALTER LOGIN [##MS_PolicyEventProcessingLogin##] DISABLE
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [NT SERVICE\Winmgmt]
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [NT SERVICE\SQLWriter]
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [NT Service\MSSQL$SQLEXPRESS]
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [DESKTOP-H3B32JA\mbg]
GO
USE [HomeCooking]
GO
/****** Object:  User [tkrupkauser]    Script Date: 8/16/2017 7:25:55 AM ******/
CREATE USER [tkrupkauser] FOR LOGIN [tkrupka] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [mgelbfisuser]    Script Date: 8/16/2017 7:25:55 AM ******/
CREATE USER [mgelbfisuser] FOR LOGIN [mgelbfis] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [lobermeisteruser]    Script Date: 8/16/2017 7:25:55 AM ******/
CREATE USER [lobermeisteruser] FOR LOGIN [lobermeister] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [dkrupkauser]    Script Date: 8/16/2017 7:25:55 AM ******/
CREATE USER [dkrupkauser] FOR LOGIN [dkrupka] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [dgelbfisuser]    Script Date: 8/16/2017 7:25:55 AM ******/
CREATE USER [dgelbfisuser] FOR LOGIN [dgelbfis] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [csklaruser]    Script Date: 8/16/2017 7:25:55 AM ******/
CREATE USER [csklaruser] FOR LOGIN [csklar] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [cmarcususer]    Script Date: 8/16/2017 7:25:55 AM ******/
CREATE USER [cmarcususer] FOR LOGIN [cmarcus] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [caugensteiuser]    Script Date: 8/16/2017 7:25:55 AM ******/
CREATE USER [caugensteiuser] FOR LOGIN [caugenstei] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [bgelbfisuser]    Script Date: 8/16/2017 7:25:55 AM ******/
CREATE USER [bgelbfisuser] FOR LOGIN [bgelbfis] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [agelbfisuser]    Script Date: 8/16/2017 7:25:55 AM ******/
CREATE USER [agelbfisuser] FOR LOGIN [agelbfis] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  DatabaseRole [HC_CustomerRole]    Script Date: 8/16/2017 7:25:55 AM ******/
CREATE ROLE [HC_CustomerRole]
GO
ALTER ROLE [HC_CustomerRole] ADD MEMBER [tkrupkauser]
GO
ALTER ROLE [HC_CustomerRole] ADD MEMBER [mgelbfisuser]
GO
ALTER ROLE [HC_CustomerRole] ADD MEMBER [lobermeisteruser]
GO
ALTER ROLE [HC_CustomerRole] ADD MEMBER [dkrupkauser]
GO
ALTER ROLE [HC_CustomerRole] ADD MEMBER [dgelbfisuser]
GO
ALTER ROLE [HC_CustomerRole] ADD MEMBER [csklaruser]
GO
ALTER ROLE [HC_CustomerRole] ADD MEMBER [cmarcususer]
GO
ALTER ROLE [HC_CustomerRole] ADD MEMBER [caugensteiuser]
GO
ALTER ROLE [HC_CustomerRole] ADD MEMBER [bgelbfisuser]
GO
ALTER ROLE [HC_CustomerRole] ADD MEMBER [agelbfisuser]
GO
GRANT CONNECT TO [agelbfisuser] AS [dbo]
GO
GRANT CONNECT TO [bgelbfisuser] AS [dbo]
GO
GRANT CONNECT TO [caugensteiuser] AS [dbo]
GO
GRANT CONNECT TO [cmarcususer] AS [dbo]
GO
GRANT CONNECT TO [csklaruser] AS [dbo]
GO
GRANT CONNECT TO [dgelbfisuser] AS [dbo]
GO
GRANT CONNECT TO [dkrupkauser] AS [dbo]
GO
GRANT CONNECT TO [lobermeisteruser] AS [dbo]
GO
GRANT CONNECT TO [mgelbfisuser] AS [dbo]
GO
GRANT CONNECT TO [tkrupkauser] AS [dbo]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 8/16/2017 7:25:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customer](
	[CustID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](20) NOT NULL,
	[CustPassword] [varchar](40) NOT NULL,
	[CustBalance] [smallmoney] NOT NULL CONSTRAINT [DF_Balance]  DEFAULT ((0.00)),
 CONSTRAINT [PK_CUSTOMER] PRIMARY KEY CLUSTERED 
(
	[CustID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
GRANT INSERT ON [dbo].[Customer] TO [HC_CustomerRole] AS [dbo]
GO
GRANT SELECT ON [dbo].[Customer] TO [HC_CustomerRole] AS [dbo]
GO
GRANT UPDATE ON [dbo].[Customer] TO [HC_CustomerRole] AS [dbo]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 8/16/2017 7:25:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Product](
	[ProductID] [int] NOT NULL,
	[ProductName] [varchar](40) NOT NULL,
	[Price] [smallmoney] NOT NULL,
 CONSTRAINT [PK_PRODUCT] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
GRANT SELECT ON [dbo].[Product] TO [HC_CustomerRole] AS [dbo]
GO
/****** Object:  Table [dbo].[Purchase]    Script Date: 8/16/2017 7:25:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Purchase](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[CID] [int] NOT NULL,
	[PID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[OrderDate] [date] NULL CONSTRAINT [DF__Purchase__OrderD__145C0A3F]  DEFAULT (getdate()),
	[OrderTotal] [smallmoney] NULL,
 CONSTRAINT [PK_ORDER] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
GRANT INSERT ON [dbo].[Purchase] TO [HC_CustomerRole] AS [dbo]
GO
GRANT SELECT ON [dbo].[Purchase] TO [HC_CustomerRole] AS [dbo]
GO
ALTER TABLE [dbo].[Purchase]  WITH CHECK ADD  CONSTRAINT [FK_CUST] FOREIGN KEY([CID])
REFERENCES [dbo].[Customer] ([CustID])
GO
ALTER TABLE [dbo].[Purchase] CHECK CONSTRAINT [FK_CUST]
GO
ALTER TABLE [dbo].[Purchase]  WITH CHECK ADD  CONSTRAINT [FK_PRODUCT] FOREIGN KEY([PID])
REFERENCES [dbo].[Product] ([ProductID])
GO
ALTER TABLE [dbo].[Purchase] CHECK CONSTRAINT [FK_PRODUCT]
GO
/****** Object:  Trigger [dbo].[CreateCustLogin]    Script Date: 8/16/2017 7:25:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE TRIGGER [dbo].[CreateCustLogin]
   ON  [dbo].[Customer] 
   AFTER  INSERT
AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	declare @custID int;
	declare @userName varchar(20);
	declare @CustPassword varchar(40);
	declare @sql varchar(500);
	
	if exists (select * from inserted)
	  --a new record is being inserted into orderline
	  print 'inserting a new record'
	  begin
	    
	    select @custID = custID from inserted
	    select @userName = userName from inserted
	    select @CustPassword = custPassword from inserted
	    
	    print 'set up login for customer'    
		Set @sql = 'create login ' + @userName + ' with password = ''' + @custPassword + ''' , check_policy = off'
		exec(@sql)    
		
		print 'set up user for customer'
		set @sql = 'create user ' + @userName + 'user for login ' + @userName
		exec(@sql)   
		
		print 'add customer to customer role'
		
		set @sql = 'alter role HC_CustomerRole add member ' + @userName + 'user'
		exec(@sql)    
	   end
	       
END

GO
/****** Object:  Trigger [dbo].[UpdateCustBalance]    Script Date: 8/16/2017 7:25:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE TRIGGER [dbo].[UpdateCustBalance]
   ON  [dbo].[Purchase] 
   AFTER  INSERT
AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	

	declare @OrderID int;
	declare @CID int;
	declare @PID int;
	declare @Quantity int;
	declare @OrderTotal smallmoney;

	if exists (select * from inserted)
	  --a new record is being inserted into orderline
	  print 'inserting a new record'
	  begin
	    
	    select @OrderID = orderID from inserted
	    select @CID = CID from inserted
	    select @PID = PID from inserted
	    select @Quantity = Quantity from inserted
		if(@Quantity < 1)
		 begin
	            raiserror('cannot buy less than 1 item',10,1);
	            rollback transaction
	        end
		set @OrderTotal = ((select price from product where ProductID = @PID) * @Quantity)
	   
		print 'update orderTotal with calculated field'
		update Purchase set orderTotal = @OrderTotal where orderID = @OrderID

		update Purchase set OrderDate = GETDATE() where orderID = @OrderID
		 
	    print 'verify that balance will not be too high' 
		declare @balance smallmoney;
		select @balance = custbalance from customer where custid = @CID 
	    
		 print 'now update customer balance to reflect this order'  
		update customer
	       set CustBalance = CustBalance + @OrderTotal
	        where custID = @CID 

	    if (@balance + @OrderTotal) > 750.00
	        begin
			    ;
			    throw 50001, 'balance will be too high', 1
	            rollback transaction
	        end   

		
	             
	    
	                       
	   end
	  
END

GO
USE [master]
GO
ALTER DATABASE [HomeCooking] SET  READ_WRITE 
GO
