	/****** Object:  User [##MS_PolicyEventProcessingLogin##]    Script Date: 5/20/2023 9:30:03 PM ******/
	CREATE USER [##MS_PolicyEventProcessingLogin##] FOR LOGIN [##MS_PolicyEventProcessingLogin##] WITH DEFAULT_SCHEMA=[dbo]
	GO
	/****** Object:  User [##MS_AgentSigningCertificate##]    Script Date: 5/30/2022 9:30:03 PM ******/
	CREATE USER [##MS_AgentSigningCertificate##] FOR LOGIN [##MS_AgentSigningCertificate##]
	GO
	/****** Object:  Table [dbo].[Account]    Script Date: 5/20/2032 9:30:03 PM ******/
	SET ANSI_NULLS ON
	GO
	SET QUOTED_IDENTIFIER ON
	GO
	CREATE TABLE [dbo].[Account](
		[account_number] [int] NOT NULL,
		[account_type] [varchar](120) NOT NULL,
		[Balance] [float] NOT NULL,
		[Cus_SSN] [int] NOT NULL,
	PRIMARY KEY CLUSTERED 
	(
		[account_number] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
	) ON [PRIMARY]
	GO
	/****** Object:  Table [dbo].[Admin]    Script Date: 5/20/2023 9:30:03 PM ******/
	SET ANSI_NULLS ON
	GO
	SET QUOTED_IDENTIFIER ON
	GO
	CREATE TABLE [dbo].[Admin](
		[Address] [varchar](255) NOT NULL,
		[Name] [varchar](255) NOT NULL,
		[Phone] [varchar](11) NOT NULL,
		[Code] [varchar](120) NOT NULL,
	UNIQUE NONCLUSTERED 
	(
		[Phone] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
	) ON [PRIMARY]
	GO
	/****** Object:  Table [dbo].[Bank]    Script Date: 5/30/2022 9:30:03 PM ******/
	SET ANSI_NULLS ON
	GO
	SET QUOTED_IDENTIFIER ON
	GO
	CREATE TABLE [dbo].[Bank](
		[Name] [varchar](255) NOT NULL,
		[Code] [varchar](120) NOT NULL,
		[Address] [varchar](255) NOT NULL,
	PRIMARY KEY CLUSTERED 
	(
		[Code] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
	) ON [PRIMARY]
	GO
	/****** Object:  Table [dbo].[Branch]    Script Date: 5/30/2022 9:30:03 PM ******/
	SET ANSI_NULLS ON
	GO
	SET QUOTED_IDENTIFIER ON
	GO
	CREATE TABLE [dbo].[Branch](
		[Address] [varchar](255) NOT NULL,
		[Branch_Number] [int] NOT NULL,
		[Code] [varchar](120) NOT NULL,
	PRIMARY KEY CLUSTERED 
	(
		[Branch_Number] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
	) ON [PRIMARY]
	GO
	/****** Object:  Table [dbo].[Customer]    Script Date: 5/30/2022 9:30:03 PM ******/
	SET ANSI_NULLS ON
	GO
	SET QUOTED_IDENTIFIER ON
	GO
	CREATE TABLE [dbo].[Customer](
		[Cus_SSN] [int] NOT NULL,
		[cus_name] [varchar](255) NOT NULL,
		[cus_phone] [varchar](11) NOT NULL,
		[cus_address] [varchar](255) NOT NULL,
		[password] [varchar](120) NOT NULL,
		[email] [varchar](255) NOT NULL,
		[Branch_Number] [int] NOT NULL,
	PRIMARY KEY CLUSTERED 
	(
		[Cus_SSN] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
	) ON [PRIMARY]
	GO
	/****** Object:  Table [dbo].[Employee]    Script Date: 5/30/2022 9:30:03 PM ******/
	SET ANSI_NULLS ON
	GO
	SET QUOTED_IDENTIFIER ON
	GO
	CREATE TABLE [dbo].[Employee](
		[id] [varchar](50) NOT NULL,
		[Address] [varchar](255) NOT NULL,
		[phone] [varchar](11) NOT NULL,
		[Name] [varchar](255) NOT NULL,
		[password] [varchar](120) NOT NULL,
		[email] [varchar](255) NOT NULL,
		[Branch_Number] [int] NOT NULL,
	PRIMARY KEY CLUSTERED 
	(
		[id] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
	) ON [PRIMARY]
	GO
	/****** Object:  Table [dbo].[Loan]    Script Date: 5/30/2022 9:30:03 PM ******/
	SET ANSI_NULLS ON
	GO
	SET QUOTED_IDENTIFIER ON
	GO
	CREATE TABLE [dbo].[Loan](
		[loan_num] [int] NOT NULL,
		[loan_amount] [float] NOT NULL,
		[laon_type] [varchar](120) NOT NULL,
		[Cus_SSN] [int] NOT NULL,
		[Branch_Number] [int] NOT NULL,
		[Employee_id] [varchar](50) NULL,
		[Employee_Name] [varchar](50) NULL,
		[Status] [varchar](225) NULL,
	PRIMARY KEY CLUSTERED 
	(
		[loan_num] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
	) ON [PRIMARY]
	GO
	/****** Object:  Table [dbo].[User_]    Script Date: 5/30/2022 9:30:03 PM ******/
	SET ANSI_NULLS ON
	GO
	SET QUOTED_IDENTIFIER ON
	GO
	CREATE TABLE [dbo].[User_](
		[username] [varchar](255) NOT NULL,
		[gender] [varchar](30) NOT NULL,
		[password] [varchar](120) NOT NULL,
		[email] [varchar](255) NOT NULL,
		[country] [varchar](220) NOT NULL,
		[phone_number] [varchar](11) NOT NULL,
	PRIMARY KEY CLUSTERED 
	(
		[password] ASC,
		[email] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
	UNIQUE NONCLUSTERED 
	(
		[phone_number] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
	) ON [PRIMARY]
	GO
	ALTER TABLE [dbo].[Account]  WITH CHECK ADD FOREIGN KEY([Cus_SSN])
	REFERENCES [dbo].[Customer] ([Cus_SSN])
	GO
	ALTER TABLE [dbo].[Admin]  WITH CHECK ADD FOREIGN KEY([Code])
	REFERENCES [dbo].[Bank] ([Code])
	GO
	ALTER TABLE [dbo].[Branch]  WITH CHECK ADD FOREIGN KEY([Code])
	REFERENCES [dbo].[Bank] ([Code])
	GO
	ALTER TABLE [dbo].[Customer]  WITH CHECK ADD  CONSTRAINT [Branch_Number_fk] FOREIGN KEY([Branch_Number])
	REFERENCES [dbo].[Branch] ([Branch_Number])
	GO
	ALTER TABLE [dbo].[Customer] CHECK CONSTRAINT [Branch_Number_fk]
	GO
	ALTER TABLE [dbo].[Customer]  WITH CHECK ADD FOREIGN KEY([password], [email])
	REFERENCES [dbo].[User_] ([password], [email])
	GO
	ALTER TABLE [dbo].[Employee]  WITH CHECK ADD FOREIGN KEY([password], [email])
	REFERENCES [dbo].[User_] ([password], [email])
	GO
	ALTER TABLE [dbo].[Employee]  WITH CHECK ADD FOREIGN KEY([Branch_Number])
	REFERENCES [dbo].[Branch] ([Branch_Number])
	GO
	ALTER TABLE [dbo].[Loan]  WITH CHECK ADD FOREIGN KEY([Branch_Number])
	REFERENCES [dbo].[Branch] ([Branch_Number])
	GO
	ALTER TABLE [dbo].[Loan]  WITH CHECK ADD FOREIGN KEY([Cus_SSN])
	REFERENCES [dbo].[Customer] ([Cus_SSN])
	GO
	ALTER TABLE [dbo].[Loan]  WITH CHECK ADD FOREIGN KEY([Employee_id])
	REFERENCES [dbo].[Employee] ([id])
	GO
	ALTER TABLE [dbo].[Loan]
ADD CONSTRAINT FK_ChildTable_ParentTable
FOREIGN KEY ([Cus_SSN])
REFERENCES [dbo].[Customer] ([Cus_SSN])
ON DELETE CASCADE;

ALTER TABLE [dbo].[Account]
ADD CONSTRAINT FK_ChildTable_ParentTable
FOREIGN KEY ([Cus_SSN])
REFERENCES [dbo].[Customer] ([Cus_SSN])
ON DELETE CASCADE;
