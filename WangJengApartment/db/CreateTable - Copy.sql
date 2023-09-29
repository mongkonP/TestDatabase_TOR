CREATE TABLE [dbo].[tbl_Amount](
	[amID] [int] NOT NULL PRIMARY KEY,
	[Room] [int] NULL,
	[Water_price] [nvarchar](10) NULL,
	[Electricity_price] [nvarchar](10) NULL,
	[Man_Edit] [nvarchar](255) NULL,
	[Date_Edit] [datetime] NULL
) ON [PRIMARY]
GO


CREATE TABLE [dbo].[tbl_Customer](
	[cusID] [int] NOT NULL PRIMARY KEY,
	[cusCardID] [nvarchar](15) NULL,
	[cusName] [nvarchar](max) NULL,
	[cusAddredd] [nvarchar](max) NULL,
	[cusPhone] [nvarchar](20) NULL,
	[cusEmail] [nvarchar](100) NULL,
	[cusLine] [nvarchar](255) NULL,
	[cusContact] [nvarchar](255) NULL,
	[cusContactPhone] [nvarchar](20) NULL,
	[cusFile_1] [nvarchar](255) NULL,
	[cusFile_2] [nvarchar](255) NULL,
	[cusFile_3] [nvarchar](255) NULL,
	[cusFile_4] [nvarchar](255) NULL,
	[cusCarID] [nvarchar](25) NULL,
	[cusCarPic] [nvarchar](255) NULL,
	[Man_Edit] [nvarchar](255) NULL,
	[Date_Edit] [datetime] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[tbl_Employee](
	[empID] [int] NOT NULL PRIMARY KEY,
	[empCardID] [nvarchar](15) NULL,
	[empCardIDFile] [nvarchar](255) NULL,
	[empName] [nvarchar](max) NULL,
	[empPic] [nvarchar](max) NULL,
	[empAddress] [nvarchar](max) NULL,
	[empPhone] [nvarchar](255) NULL,
	[empLine] [nvarchar](255) NULL,
	[empContact] [nvarchar](255) NULL,
	[empContactPhone] [nvarchar](255) NULL,
	[empUsername] [nvarchar](255) NULL,
	[empPasswprd] [nvarchar](255) NULL,
	[empFile_1] [nvarchar](255) NULL,
	[empFile_2] [nvarchar](255) NULL,
	[empstatus] [bit] NOT NULL,
	[AdminStatus] [bit] NOT NULL,
	[Man_Edit] [nvarchar](255) NULL,
	[Date_Edit] [datetime] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
CREATE TABLE [dbo].[tbl_Location](
	[lcID] [int] NOT NULL PRIMARY KEY,
	[location_name] [nvarchar](255) NULL,
	[Address] [nvarchar](max) NULL,
	[map] [nvarchar](255) NULL ,
	[Man_Edit] [nvarchar](255) NULL,
	[Date_Edit] [datetime] NULL
	
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[tbl_Payment](
	[pmID] [nvarchar](50) NULL PRIMARY KEY,
	[rentID] [int] NULL
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[tbl_Rent](
	[rentID] [nvarchar](255) NOT NULL PRIMARY KEY,
	[Room] [int] NULL,
	[Customer] [int] NULL,
	[DateReservations] [datetime] NULL,
	[DateIn] [datetime] NULL,
	[DateOut] [datetime] NULL,
	[Employee] [int] NULL,
	[File_1] [nvarchar](255) NULL,
	[File_2] [nvarchar](255) NULL,
	[File_3] [nvarchar](255) NULL,
	[Man_Edit] [nvarchar](255) NULL,
	[Date_Edit] [datetime] NULL
) ON [PRIMARY]
GO


CREATE TABLE [dbo].[tbl_Roomtype](
	[rtID] [int] NOT NULL PRIMARY KEY,
	[room_type] [nvarchar](255) NULL
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[tbl_Room](
	[roomID] [int] NOT NULL PRIMARY KEY,
	[Location] [int] NULL,
	[RoomNum] [nvarchar](255) NULL,
	[Roomtype] [int] NULL,
	[Rent_price] [nvarchar](255) NULL,
	[Water_price] [nvarchar](255) NULL,
	[Electricity_price] [nvarchar](255) NULL,
	[Furniture_price] [nvarchar](255) NULL,
	[Deposit_price] [nvarchar](255) NULL,
	[CableTV_price] [nvarchar](255) NULL,
	[Net_price] [nvarchar](255) NULL,
	[Central_price] [nvarchar](255) NULL,
	[Payday] [nvarchar](255) NULL,
	[Status] [bit] NOT NULL,
	[Man_Edit] [nvarchar](255) NULL,
	[Date_Edit] [datetime] NULL
) ON [PRIMARY]
GO


CREATE TABLE [dbo].[tblSystem](
	[sysID] [nvarchar](255) NULL PRIMARY KEY,
	[sysName] [nvarchar](255) NULL,
	[sysValue] [nvarchar](255) NULL
) ON [PRIMARY]
GO


ALTER TABLE [dbo].[tbl_Room]
ADD CONSTRAINT FK_Room_Roomtype
FOREIGN KEY ([Roomtype])
REFERENCES [dbo].[tbl_Roomtype]([rtID]);

ALTER TABLE [dbo].[tbl_Room]
ADD CONSTRAINT FK_Room_Location
FOREIGN KEY ([Location])
REFERENCES [dbo].[tbl_Location]([lcID]);


ALTER TABLE [dbo].[tbl_Rent]
ADD CONSTRAINT FK_Rent_Room
FOREIGN KEY ([Room])
REFERENCES [dbo].[tbl_Room]([roomID]);

ALTER TABLE [dbo].[tbl_Rent]
ADD CONSTRAINT FK_Rent_Customer
FOREIGN KEY ([Customer])
REFERENCES [dbo].[tbl_Customer]([cusID]);

ALTER TABLE [dbo].[tbl_Rent]
ADD CONSTRAINT FK_Rent_Employee
FOREIGN KEY ([Employee])
REFERENCES [dbo].[tbl_Employee]([empID]);


ALTER TABLE [dbo].[tbl_Amount]
ADD CONSTRAINT FK_Amount_Room
FOREIGN KEY ([Room])
REFERENCES [dbo].[tbl_Room]([roomID]);