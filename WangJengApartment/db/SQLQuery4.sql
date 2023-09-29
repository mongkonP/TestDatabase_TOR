CREATE TABLE [dbo].[tbl_Amount](
	[amID] [int] NOT NULL,
	[rmID] [int] NULL,
	[Water_price] [nvarchar](255) NULL,
	[Electricity_price] [nvarchar](255) NULL,
	[Man_Edit] [nvarchar](255) NULL,
	[Date_Edit] [datetime] NULL
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[tbl_Car](
	[carID] [int] NOT NULL,
	[emp_id] [int] NULL,
	[car_type] [nvarchar](255) NULL,
	[license_plate] [nvarchar](255) NULL,
	[Man_Edit] [nvarchar](255) NULL,
	[Date_Edit] [datetime] NULL
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[tbl_Customer](
	[cusID] [int] NOT NULL,
	[cusCardID] [nvarchar](15) NULL,
	[cusName] [nvarchar](max) NULL,
	[cusAddredd] [nvarchar](max) NULL,
	[cusPhone] [nvarchar](255) NULL,
	[cusLine] [nvarchar](255) NULL,
	[cusContact] [nvarchar](255) NULL,
	[cusContactPhone] [nvarchar](255) NULL,
	[cusFile_1] [nvarchar](255) NULL,
	[cusFile_2] [nvarchar](255) NULL,
	[cusFile_3] [nvarchar](255) NULL,
	[cusFile_4] [nvarchar](255) NULL,
	[Man_Edit] [nvarchar](255) NULL,
	[Date_Edit] [datetime] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[tbl_Employee](
	[empID] [int] NOT NULL,
	[empCardID] [nvarchar](15) NULL,
	[empName] [nvarchar](max) NULL,
	[empAddredd] [nvarchar](max) NULL,
	[empPhone] [nvarchar](255) NULL,
	[empLine] [nvarchar](255) NULL,
	[empContact] [nvarchar](255) NULL,
	[empContactPhone] [nvarchar](255) NULL,
	[empUsername] [nvarchar](255) NULL,
	[empPasswprd] [nvarchar](255) NULL,
	[empFile_1] [nvarchar](255) NULL,
	[empFile_2] [nvarchar](255) NULL,
	[empFile_3] [nvarchar](255) NULL,
	[empFile_4] [nvarchar](255) NULL,
	[empstatus] [bit] NOT NULL,
	[AdminStatus] [bit] NOT NULL,
	[Man_Edit] [nvarchar](255) NULL,
	[Date_Edit] [datetime] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
CREATE TABLE [dbo].[tbl_Location](
	[lcID] [int] NOT NULL,
	[location_name] [nvarchar](255) NULL,
	[Address] [nvarchar](max) NULL,
	[rent_price] [nvarchar](255) NULL,
	[Central_price] [nvarchar](255) NULL,
	[Deposit_price] [nvarchar](255) NULL,
	[Electricity_price] [nvarchar](255) NULL,
	[Water_price] [nvarchar](255) NULL,
	[Furniture_price] [nvarchar](255) NULL,
	[Net_price] [nvarchar](255) NULL,
	[CableTV_price] [nvarchar](255) NULL,
	[motorcycle_count] [nvarchar](255) NULL,
	[car_count] [nvarchar](255) NULL,
	[dateC] [nvarchar](255) NULL,
	[Man_Edit] [nvarchar](255) NULL,
	[Date_Edit] [datetime] NULL,
	[map] [nvarchar](255) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[tbl_Payment](
	[pmID] [nvarchar](50) NULL,
	[rentID] [int] NULL
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[tbl_Rent](
	[rentID] [nvarchar](255) NOT NULL,
	[roomID] [int] NULL,
	[cusID] [int] NULL,
	[DateReservations] [datetime] NULL,
	[DateIn] [datetime] NULL,
	[DateOut] [datetime] NULL,
	[EmpID] [int] NULL,
	[File_1] [nvarchar](255) NULL,
	[File_2] [nvarchar](255) NULL,
	[File_3] [nvarchar](255) NULL,
	[Man_Edit] [nvarchar](255) NULL,
	[Date_Edit] [datetime] NULL
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[tbl_Room](
	[roomID] [int] NOT NULL,
	[lcID] [int] NULL,
	[roomNum] [nvarchar](255) NULL,
	[roomtype] [int] NULL,
	[rent_price] [nvarchar](255) NULL,
	[Water_price] [nvarchar](255) NULL,
	[Electricity_price] [nvarchar](255) NULL,
	[Furniture_price] [nvarchar](255) NULL,
	[Deposit_price] [nvarchar](255) NULL,
	[CableTV_price] [nvarchar](255) NULL,
	[Net_price] [nvarchar](255) NULL,
	[Central_price] [nvarchar](255) NULL,
	[dateC] [nvarchar](255) NULL,
	[status] [bit] NOT NULL,
	[Man_Edit] [nvarchar](255) NULL,
	[Date_Edit] [datetime] NULL
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[tbl_Roomtype](
	[rtID] [int] NOT NULL,
	[room_type] [nvarchar](255) NULL
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[tblSystem](
	[sysID] [nvarchar](255) NULL,
	[sysName] [nvarchar](255) NULL,
	[sysValue] [nvarchar](255) NULL
) ON [PRIMARY]
GO
