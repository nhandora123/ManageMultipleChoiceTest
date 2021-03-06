USE [QL_TRACNGHIEM]
GO
/****** Object:  Table [dbo].[BAITHI]    Script Date: 12/08/2020 15:46:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BAITHI](
	[MABT] [varchar](10) NOT NULL,
	[MSSV] [varchar](10) NULL,
	[MAKT] [varchar](10) NULL,
	[thoiGianBatDau] [datetime] NULL,
	[thoiGianKetThuc] [datetime] NULL,
	[tienDo] [float] NULL,
	[diem] [float] NULL,
 CONSTRAINT [PK_BAITHI] PRIMARY KEY CLUSTERED 
(
	[MABT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CAUHOI]    Script Date: 12/08/2020 15:46:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CAUHOI](
	[MACH] [varchar](10) NOT NULL,
	[tenCH] [nvarchar](256) NULL,
	[MAKT] [varchar](10) NOT NULL,
 CONSTRAINT [PK_CAUHOI] PRIMARY KEY CLUSTERED 
(
	[MACH] ASC,
	[MAKT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CAUTRALOI]    Script Date: 12/08/2020 15:46:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CAUTRALOI](
	[MACTL] [varchar](10) NOT NULL,
	[tenCTL] [nvarchar](256) NULL,
	[dapAn] [int] NULL,
	[MACH] [varchar](10) NOT NULL,
	[MAKT] [varchar](10) NOT NULL,
 CONSTRAINT [PK_CAUTRALOI] PRIMARY KEY CLUSTERED 
(
	[MACTL] ASC,
	[MACH] ASC,
	[MAKT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[COITHI]    Script Date: 12/08/2020 15:46:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[COITHI](
	[MSGV] [varchar](10) NOT NULL,
	[MAKT] [varchar](10) NOT NULL,
 CONSTRAINT [PK_COITHI] PRIMARY KEY CLUSTERED 
(
	[MSGV] ASC,
	[MAKT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CHITIETBAITHI]    Script Date: 12/08/2020 15:46:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHITIETBAITHI](
	[MACT] [varchar](10) NOT NULL,
	[tenBaiThi] [nvarchar](256) NULL,
	[MABT] [varchar](10) NULL,
	[MACTL] [varchar](10) NULL,
	[MACH] [varchar](10) NULL,
	[MAKT] [varchar](10) NULL,
 CONSTRAINT [PK_CHITIETBAITHI] PRIMARY KEY CLUSTERED 
(
	[MACT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GIAOVIEN]    Script Date: 12/08/2020 15:46:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GIAOVIEN](
	[MSGV] [varchar](10) NOT NULL,
	[matKhau] [varchar](100) NULL,
	[hoTen] [nvarchar](256) NULL,
 CONSTRAINT [PK_GIAOVIEN] PRIMARY KEY CLUSTERED 
(
	[MSGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KYTHI]    Script Date: 12/08/2020 15:46:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KYTHI](
	[MAKT] [varchar](10) NOT NULL,
	[matKhau] [varchar](30) NULL,
	[tenKT] [nvarchar](256) NULL,
	[thoiGianLamBai] [int] NULL,
	[thoiGianMoDe] [datetime] NULL,
	[thoiGianDongDe] [datetime] NULL,
	[MSGV] [varchar](10) NULL,
 CONSTRAINT [PK_KYTHI] PRIMARY KEY CLUSTERED 
(
	[MAKT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SINHVIEN]    Script Date: 12/08/2020 15:46:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SINHVIEN](
	[MSSV] [varchar](10) NOT NULL,
	[matKhau] [varchar](100) NOT NULL,
	[hoTen] [nvarchar](256) NOT NULL,
	[maLop] [varchar](10) NOT NULL,
 CONSTRAINT [PK_SINHVIEN] PRIMARY KEY CLUSTERED 
(
	[MSSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  UserDefinedFunction [dbo].[FormatCTL]    Script Date: 12/08/2020 15:46:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[FormatCTL] (
    @makt nvarchar(10)
)
RETURNS TABLE
AS
RETURN
	SELECT [MACH], [DA01], [DA02], [DA03], [DA04] 
	FROM
	(
	 SELECT MACH, MACTL, dapAn FROM CAUTRALOI WHERE MAKT = @makt
	) as source
	PIVOT
	(
		MAX(dapAn) FOR MACTL IN ([DA01], [DA02], [DA03], [DA04])
	) as target
GO
INSERT [dbo].[BAITHI] ([MABT], [MSSV], [MAKT], [thoiGianBatDau], [thoiGianKetThuc], [tienDo], [diem]) VALUES (N'BT01', N'0001', N'KT01', CAST(N'2020-12-08 14:25:56.000' AS DateTime), CAST(N'2020-12-08 14:26:28.000' AS DateTime), 80, 6.66666666666667)
INSERT [dbo].[BAITHI] ([MABT], [MSSV], [MAKT], [thoiGianBatDau], [thoiGianKetThuc], [tienDo], [diem]) VALUES (N'BT02', N'0001', N'KT02', CAST(N'2020-12-08 15:27:02.000' AS DateTime), CAST(N'2020-12-08 15:27:07.000' AS DateTime), 80, 0)
INSERT [dbo].[BAITHI] ([MABT], [MSSV], [MAKT], [thoiGianBatDau], [thoiGianKetThuc], [tienDo], [diem]) VALUES (N'BT03', N'0002', N'KT01', CAST(N'2020-12-08 15:34:17.000' AS DateTime), CAST(N'2020-12-08 15:35:28.000' AS DateTime), 80, 5.55555555555556)
INSERT [dbo].[CAUHOI] ([MACH], [tenCH], [MAKT]) VALUES (N'CH01', N'Trai dat co bao nhieu luc dia', N'KT01')
INSERT [dbo].[CAUHOI] ([MACH], [tenCH], [MAKT]) VALUES (N'CH01', N'I didn’t think his the comments were very appropriate at the time.', N'KT04')
INSERT [dbo].[CAUHOI] ([MACH], [tenCH], [MAKT]) VALUES (N'CH02', N'Trai dat co bao nhieu luc dia 3', N'KT01')
INSERT [dbo].[CAUHOI] ([MACH], [tenCH], [MAKT]) VALUES (N'CH03', N'Trai dat co bao nhieu luc dia 3', N'KT01')
INSERT [dbo].[CAUHOI] ([MACH], [tenCH], [MAKT]) VALUES (N'CH04', N'Trai dat co bao nhieu luc dia 4', N'KT01')
INSERT [dbo].[CAUHOI] ([MACH], [tenCH], [MAKT]) VALUES (N'CH05', N'Trai dat co bao nhieu luc dia 5', N'KT01')
INSERT [dbo].[CAUHOI] ([MACH], [tenCH], [MAKT]) VALUES (N'CH06', N'Trai dat co bao nhieu luc dia 6', N'KT01')
INSERT [dbo].[CAUHOI] ([MACH], [tenCH], [MAKT]) VALUES (N'CH07', N'Trai dat co bao nhieu luc dia 8', N'KT01')
INSERT [dbo].[CAUHOI] ([MACH], [tenCH], [MAKT]) VALUES (N'CH08', N'I didn’t think his the comments were very appropriate at the time', N'KT01')
INSERT [dbo].[CAUHOI] ([MACH], [tenCH], [MAKT]) VALUES (N'CH09', N'GCSE are not compulsory, but they are the most common qualifications GCSE are not compulsory, but they are the most common qualifications taken by students', N'KT01')
INSERT [dbo].[CAUTRALOI] ([MACTL], [tenCTL], [dapAn], [MACH], [MAKT]) VALUES (N'DA01', N'4', 1, N'CH01', N'KT01')
INSERT [dbo].[CAUTRALOI] ([MACTL], [tenCTL], [dapAn], [MACH], [MAKT]) VALUES (N'DA01', N'correct  ', 1, N'CH01', N'KT04')
INSERT [dbo].[CAUTRALOI] ([MACTL], [tenCTL], [dapAn], [MACH], [MAKT]) VALUES (N'DA01', N'4', 0, N'CH02', N'KT01')
INSERT [dbo].[CAUTRALOI] ([MACTL], [tenCTL], [dapAn], [MACH], [MAKT]) VALUES (N'DA01', N'4', 0, N'CH03', N'KT01')
INSERT [dbo].[CAUTRALOI] ([MACTL], [tenCTL], [dapAn], [MACH], [MAKT]) VALUES (N'DA01', N'4', 0, N'CH04', N'KT01')
INSERT [dbo].[CAUTRALOI] ([MACTL], [tenCTL], [dapAn], [MACH], [MAKT]) VALUES (N'DA01', N'4', 0, N'CH05', N'KT01')
INSERT [dbo].[CAUTRALOI] ([MACTL], [tenCTL], [dapAn], [MACH], [MAKT]) VALUES (N'DA01', N'4', 0, N'CH06', N'KT01')
INSERT [dbo].[CAUTRALOI] ([MACTL], [tenCTL], [dapAn], [MACH], [MAKT]) VALUES (N'DA01', N'4', 1, N'CH07', N'KT01')
INSERT [dbo].[CAUTRALOI] ([MACTL], [tenCTL], [dapAn], [MACH], [MAKT]) VALUES (N'DA01', N'right ', 0, N'CH08', N'KT01')
INSERT [dbo].[CAUTRALOI] ([MACTL], [tenCTL], [dapAn], [MACH], [MAKT]) VALUES (N'DA01', N'required ', 1, N'CH09', N'KT01')
INSERT [dbo].[CAUTRALOI] ([MACTL], [tenCTL], [dapAn], [MACH], [MAKT]) VALUES (N'DA02', N'5', 0, N'CH01', N'KT01')
INSERT [dbo].[CAUTRALOI] ([MACTL], [tenCTL], [dapAn], [MACH], [MAKT]) VALUES (N'DA02', N'. right     ', 0, N'CH01', N'KT04')
INSERT [dbo].[CAUTRALOI] ([MACTL], [tenCTL], [dapAn], [MACH], [MAKT]) VALUES (N'DA02', N'5', 1, N'CH02', N'KT01')
INSERT [dbo].[CAUTRALOI] ([MACTL], [tenCTL], [dapAn], [MACH], [MAKT]) VALUES (N'DA02', N'5', 0, N'CH03', N'KT01')
INSERT [dbo].[CAUTRALOI] ([MACTL], [tenCTL], [dapAn], [MACH], [MAKT]) VALUES (N'DA02', N'5', 0, N'CH04', N'KT01')
INSERT [dbo].[CAUTRALOI] ([MACTL], [tenCTL], [dapAn], [MACH], [MAKT]) VALUES (N'DA02', N'5', 0, N'CH05', N'KT01')
INSERT [dbo].[CAUTRALOI] ([MACTL], [tenCTL], [dapAn], [MACH], [MAKT]) VALUES (N'DA02', N'5', 0, N'CH06', N'KT01')
INSERT [dbo].[CAUTRALOI] ([MACTL], [tenCTL], [dapAn], [MACH], [MAKT]) VALUES (N'DA02', N'5', 0, N'CH07', N'KT01')
INSERT [dbo].[CAUTRALOI] ([MACTL], [tenCTL], [dapAn], [MACH], [MAKT]) VALUES (N'DA02', N' correct     ', 0, N'CH08', N'KT01')
INSERT [dbo].[CAUTRALOI] ([MACTL], [tenCTL], [dapAn], [MACH], [MAKT]) VALUES (N'DA02', N'applied ', 0, N'CH09', N'KT01')
INSERT [dbo].[CAUTRALOI] ([MACTL], [tenCTL], [dapAn], [MACH], [MAKT]) VALUES (N'DA03', N'7', 0, N'CH01', N'KT01')
INSERT [dbo].[CAUTRALOI] ([MACTL], [tenCTL], [dapAn], [MACH], [MAKT]) VALUES (N'DA03', N'exact ', 0, N'CH01', N'KT04')
INSERT [dbo].[CAUTRALOI] ([MACTL], [tenCTL], [dapAn], [MACH], [MAKT]) VALUES (N'DA03', N'7', 0, N'CH02', N'KT01')
INSERT [dbo].[CAUTRALOI] ([MACTL], [tenCTL], [dapAn], [MACH], [MAKT]) VALUES (N'DA03', N'7', 1, N'CH03', N'KT01')
INSERT [dbo].[CAUTRALOI] ([MACTL], [tenCTL], [dapAn], [MACH], [MAKT]) VALUES (N'DA03', N'7', 0, N'CH04', N'KT01')
INSERT [dbo].[CAUTRALOI] ([MACTL], [tenCTL], [dapAn], [MACH], [MAKT]) VALUES (N'DA03', N'7', 0, N'CH05', N'KT01')
INSERT [dbo].[CAUTRALOI] ([MACTL], [tenCTL], [dapAn], [MACH], [MAKT]) VALUES (N'DA03', N'7', 0, N'CH06', N'KT01')
INSERT [dbo].[CAUTRALOI] ([MACTL], [tenCTL], [dapAn], [MACH], [MAKT]) VALUES (N'DA03', N'7', 0, N'CH07', N'KT01')
INSERT [dbo].[CAUTRALOI] ([MACTL], [tenCTL], [dapAn], [MACH], [MAKT]) VALUES (N'DA03', N'exact', 0, N'CH08', N'KT01')
INSERT [dbo].[CAUTRALOI] ([MACTL], [tenCTL], [dapAn], [MACH], [MAKT]) VALUES (N'DA03', N'fulfilled ', 0, N'CH09', N'KT01')
INSERT [dbo].[CAUTRALOI] ([MACTL], [tenCTL], [dapAn], [MACH], [MAKT]) VALUES (N'DA04', N'8', 0, N'CH01', N'KT01')
INSERT [dbo].[CAUTRALOI] ([MACTL], [tenCTL], [dapAn], [MACH], [MAKT]) VALUES (N'DA04', N'suitable', 0, N'CH01', N'KT04')
INSERT [dbo].[CAUTRALOI] ([MACTL], [tenCTL], [dapAn], [MACH], [MAKT]) VALUES (N'DA04', N'8', 0, N'CH02', N'KT01')
INSERT [dbo].[CAUTRALOI] ([MACTL], [tenCTL], [dapAn], [MACH], [MAKT]) VALUES (N'DA04', N'8', 0, N'CH03', N'KT01')
INSERT [dbo].[CAUTRALOI] ([MACTL], [tenCTL], [dapAn], [MACH], [MAKT]) VALUES (N'DA04', N'8', 1, N'CH04', N'KT01')
INSERT [dbo].[CAUTRALOI] ([MACTL], [tenCTL], [dapAn], [MACH], [MAKT]) VALUES (N'DA04', N'8', 1, N'CH05', N'KT01')
INSERT [dbo].[CAUTRALOI] ([MACTL], [tenCTL], [dapAn], [MACH], [MAKT]) VALUES (N'DA04', N'8', 1, N'CH06', N'KT01')
INSERT [dbo].[CAUTRALOI] ([MACTL], [tenCTL], [dapAn], [MACH], [MAKT]) VALUES (N'DA04', N'8', 0, N'CH07', N'KT01')
INSERT [dbo].[CAUTRALOI] ([MACTL], [tenCTL], [dapAn], [MACH], [MAKT]) VALUES (N'DA04', N'suitable', 1, N'CH08', N'KT01')
INSERT [dbo].[CAUTRALOI] ([MACTL], [tenCTL], [dapAn], [MACH], [MAKT]) VALUES (N'DA04', N'specialized', 0, N'CH09', N'KT01')
INSERT [dbo].[CHITIETBAITHI] ([MACT], [tenBaiThi], [MABT], [MACTL], [MACH], [MAKT]) VALUES (N'CT01', N'Bài Thi Trắc Nghiệm', N'BT01', N'DA01', N'CH01', N'KT01')
INSERT [dbo].[CHITIETBAITHI] ([MACT], [tenBaiThi], [MABT], [MACTL], [MACH], [MAKT]) VALUES (N'CT02', N'Bài Thi Trắc Nghiệm', N'BT01', N'DA02', N'CH02', N'KT01')
INSERT [dbo].[CHITIETBAITHI] ([MACT], [tenBaiThi], [MABT], [MACTL], [MACH], [MAKT]) VALUES (N'CT03', N'Bài Thi Trắc Nghiệm', N'BT01', N'DA03', N'CH03', N'KT01')
INSERT [dbo].[CHITIETBAITHI] ([MACT], [tenBaiThi], [MABT], [MACTL], [MACH], [MAKT]) VALUES (N'CT04', N'Bài Thi Trắc Nghiệm', N'BT01', N'DA04', N'CH04', N'KT01')
INSERT [dbo].[CHITIETBAITHI] ([MACT], [tenBaiThi], [MABT], [MACTL], [MACH], [MAKT]) VALUES (N'CT05', N'Bài Thi Trắc Nghiệm', N'BT01', N'DA01', N'CH05', N'KT01')
INSERT [dbo].[CHITIETBAITHI] ([MACT], [tenBaiThi], [MABT], [MACTL], [MACH], [MAKT]) VALUES (N'CT06', N'Bài Thi Trắc Nghiệm', N'BT01', N'DA02', N'CH06', N'KT01')
INSERT [dbo].[CHITIETBAITHI] ([MACT], [tenBaiThi], [MABT], [MACTL], [MACH], [MAKT]) VALUES (N'CT07', N'Bài Thi Trắc Nghiệm', N'BT01', N'DA03', N'CH07', N'KT01')
INSERT [dbo].[CHITIETBAITHI] ([MACT], [tenBaiThi], [MABT], [MACTL], [MACH], [MAKT]) VALUES (N'CT08', N'Bài Thi Trắc Nghiệm', N'BT01', N'DA04', N'CH08', N'KT01')
INSERT [dbo].[CHITIETBAITHI] ([MACT], [tenBaiThi], [MABT], [MACTL], [MACH], [MAKT]) VALUES (N'CT09', N'Bài Thi Trắc Nghiệm', N'BT01', N'DA01', N'CH09', N'KT01')
INSERT [dbo].[CHITIETBAITHI] ([MACT], [tenBaiThi], [MABT], [MACTL], [MACH], [MAKT]) VALUES (N'CT10', N'Bài Thi Trắc Nghiệm', N'BT03', N'DA01', N'CH01', N'KT01')
INSERT [dbo].[CHITIETBAITHI] ([MACT], [tenBaiThi], [MABT], [MACTL], [MACH], [MAKT]) VALUES (N'CT11', N'Bài Thi Trắc Nghiệm', N'BT03', N'DA02', N'CH02', N'KT01')
INSERT [dbo].[CHITIETBAITHI] ([MACT], [tenBaiThi], [MABT], [MACTL], [MACH], [MAKT]) VALUES (N'CT12', N'Bài Thi Trắc Nghiệm', N'BT03', N'DA03', N'CH03', N'KT01')
INSERT [dbo].[CHITIETBAITHI] ([MACT], [tenBaiThi], [MABT], [MACTL], [MACH], [MAKT]) VALUES (N'CT13', N'Bài Thi Trắc Nghiệm', N'BT03', N'DA03', N'CH04', N'KT01')
INSERT [dbo].[CHITIETBAITHI] ([MACT], [tenBaiThi], [MABT], [MACTL], [MACH], [MAKT]) VALUES (N'CT14', N'Bài Thi Trắc Nghiệm', N'BT03', N'DA04', N'CH05', N'KT01')
INSERT [dbo].[CHITIETBAITHI] ([MACT], [tenBaiThi], [MABT], [MACTL], [MACH], [MAKT]) VALUES (N'CT15', N'Bài Thi Trắc Nghiệm', N'BT03', N'DA04', N'CH06', N'KT01')
INSERT [dbo].[CHITIETBAITHI] ([MACT], [tenBaiThi], [MABT], [MACTL], [MACH], [MAKT]) VALUES (N'CT16', N'Bài Thi Trắc Nghiệm', N'BT03', N'DA02', N'CH07', N'KT01')
INSERT [dbo].[CHITIETBAITHI] ([MACT], [tenBaiThi], [MABT], [MACTL], [MACH], [MAKT]) VALUES (N'CT17', N'Bài Thi Trắc Nghiệm', N'BT03', N'DA02', N'CH08', N'KT01')
INSERT [dbo].[CHITIETBAITHI] ([MACT], [tenBaiThi], [MABT], [MACTL], [MACH], [MAKT]) VALUES (N'CT18', N'Bài Thi Trắc Nghiệm', N'BT03', N'DA03', N'CH09', N'KT01')
INSERT [dbo].[GIAOVIEN] ([MSGV], [matKhau], [hoTen]) VALUES (N'1001      ', N'123', N'hieu nhan noras')
INSERT [dbo].[GIAOVIEN] ([MSGV], [matKhau], [hoTen]) VALUES (N'1002      ', N'123', N'hieu nhan noras')
INSERT [dbo].[GIAOVIEN] ([MSGV], [matKhau], [hoTen]) VALUES (N'1003      ', N'123', N'hieu nhan noras')
INSERT [dbo].[GIAOVIEN] ([MSGV], [matKhau], [hoTen]) VALUES (N'1004      ', N'123', N'hieu nhan noras')
INSERT [dbo].[GIAOVIEN] ([MSGV], [matKhau], [hoTen]) VALUES (N'1005      ', N'123', N'hieu nhan noras')
INSERT [dbo].[GIAOVIEN] ([MSGV], [matKhau], [hoTen]) VALUES (N'1006      ', N'123', N'hieu nhan noras')
INSERT [dbo].[KYTHI] ([MAKT], [matKhau], [tenKT], [thoiGianLamBai], [thoiGianMoDe], [thoiGianDongDe], [MSGV]) VALUES (N'KT01', N'123', N'Test dau vao', 50, CAST(N'2020-03-02 20:23:00.000' AS DateTime), CAST(N'2020-03-02 20:20:00.000' AS DateTime), N'1001      ')
INSERT [dbo].[KYTHI] ([MAKT], [matKhau], [tenKT], [thoiGianLamBai], [thoiGianMoDe], [thoiGianDongDe], [MSGV]) VALUES (N'KT02', N'123', N'Test dau vao', 60, CAST(N'2020-02-03 20:23:00.000' AS DateTime), CAST(N'2020-02-03 20:20:00.000' AS DateTime), N'1001      ')
INSERT [dbo].[KYTHI] ([MAKT], [matKhau], [tenKT], [thoiGianLamBai], [thoiGianMoDe], [thoiGianDongDe], [MSGV]) VALUES (N'KT03', N'123', N'KT Tieng Anh', 115, CAST(N'2020-08-12 12:30:00.000' AS DateTime), CAST(N'2020-08-12 13:30:00.000' AS DateTime), N'1001      ')
INSERT [dbo].[KYTHI] ([MAKT], [matKhau], [tenKT], [thoiGianLamBai], [thoiGianMoDe], [thoiGianDongDe], [MSGV]) VALUES (N'KT04', N'123', N'ki thi van hoc', 30, CAST(N'2020-08-12 12:30:00.000' AS DateTime), CAST(N'2020-08-12 13:30:00.000' AS DateTime), N'1001      ')
INSERT [dbo].[SINHVIEN] ([MSSV], [matKhau], [hoTen], [maLop]) VALUES (N'0001', N'123', N'hieu nhan noras', N'18CDTH2')
INSERT [dbo].[SINHVIEN] ([MSSV], [matKhau], [hoTen], [maLop]) VALUES (N'0002', N'123', N'hieu nhan noras', N'18CDTH2')
INSERT [dbo].[SINHVIEN] ([MSSV], [matKhau], [hoTen], [maLop]) VALUES (N'0003', N'123', N'hieu nhan noras', N'18CDTH2')
INSERT [dbo].[SINHVIEN] ([MSSV], [matKhau], [hoTen], [maLop]) VALUES (N'0004', N'123', N'hieu nhan noras', N'18CDTH2')
INSERT [dbo].[SINHVIEN] ([MSSV], [matKhau], [hoTen], [maLop]) VALUES (N'0005', N'123', N'hieu nhan noras', N'18CDTH2')
INSERT [dbo].[SINHVIEN] ([MSSV], [matKhau], [hoTen], [maLop]) VALUES (N'0006', N'123', N'hieu nhan noras', N'18CDTH2')
ALTER TABLE [dbo].[BAITHI]  WITH CHECK ADD  CONSTRAINT [FK_BAITHI_KYTHI] FOREIGN KEY([MAKT])
REFERENCES [dbo].[KYTHI] ([MAKT])
GO
ALTER TABLE [dbo].[BAITHI] CHECK CONSTRAINT [FK_BAITHI_KYTHI]
GO
ALTER TABLE [dbo].[BAITHI]  WITH CHECK ADD  CONSTRAINT [FK_BAITHI_SINHVIEN] FOREIGN KEY([MSSV])
REFERENCES [dbo].[SINHVIEN] ([MSSV])
GO
ALTER TABLE [dbo].[BAITHI] CHECK CONSTRAINT [FK_BAITHI_SINHVIEN]
GO
ALTER TABLE [dbo].[CAUHOI]  WITH CHECK ADD  CONSTRAINT [FK_CAUHOI_KYTHI] FOREIGN KEY([MAKT])
REFERENCES [dbo].[KYTHI] ([MAKT])
GO
ALTER TABLE [dbo].[CAUHOI] CHECK CONSTRAINT [FK_CAUHOI_KYTHI]
GO
ALTER TABLE [dbo].[CAUTRALOI]  WITH CHECK ADD  CONSTRAINT [FK_CAUTRALOI_CAUHOI] FOREIGN KEY([MACH], [MAKT])
REFERENCES [dbo].[CAUHOI] ([MACH], [MAKT])
GO
ALTER TABLE [dbo].[CAUTRALOI] CHECK CONSTRAINT [FK_CAUTRALOI_CAUHOI]
GO
ALTER TABLE [dbo].[COITHI]  WITH CHECK ADD  CONSTRAINT [FK_COITHI_GIAOVIEN] FOREIGN KEY([MSGV])
REFERENCES [dbo].[GIAOVIEN] ([MSGV])
GO
ALTER TABLE [dbo].[COITHI] CHECK CONSTRAINT [FK_COITHI_GIAOVIEN]
GO
ALTER TABLE [dbo].[COITHI]  WITH CHECK ADD  CONSTRAINT [FK_COITHI_KYTHI] FOREIGN KEY([MAKT])
REFERENCES [dbo].[KYTHI] ([MAKT])
GO
ALTER TABLE [dbo].[COITHI] CHECK CONSTRAINT [FK_COITHI_KYTHI]
GO
ALTER TABLE [dbo].[CHITIETBAITHI]  WITH CHECK ADD  CONSTRAINT [fk_CHITIETBAITHI_BAITHI] FOREIGN KEY([MABT])
REFERENCES [dbo].[BAITHI] ([MABT])
GO
ALTER TABLE [dbo].[CHITIETBAITHI] CHECK CONSTRAINT [fk_CHITIETBAITHI_BAITHI]
GO
ALTER TABLE [dbo].[CHITIETBAITHI]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETBAITHI_CAUTRALOI] FOREIGN KEY([MACTL], [MACH], [MAKT])
REFERENCES [dbo].[CAUTRALOI] ([MACTL], [MACH], [MAKT])
GO
ALTER TABLE [dbo].[CHITIETBAITHI] CHECK CONSTRAINT [FK_CHITIETBAITHI_CAUTRALOI]
GO
