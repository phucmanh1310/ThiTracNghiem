USE [master]
GO
/****** Object:  Database [ThiTracNghiem]    Script Date: 12/9/2024 9:43:40 AM ******/
CREATE DATABASE [ThiTracNghiem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ThiTracNghiem', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MANH\MSSQL\DATA\ThiTracNghiem.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ThiTracNghiem_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MANH\MSSQL\DATA\ThiTracNghiem_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [ThiTracNghiem] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ThiTracNghiem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ThiTracNghiem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ThiTracNghiem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ThiTracNghiem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ThiTracNghiem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ThiTracNghiem] SET ARITHABORT OFF 
GO
ALTER DATABASE [ThiTracNghiem] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ThiTracNghiem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ThiTracNghiem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ThiTracNghiem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ThiTracNghiem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ThiTracNghiem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ThiTracNghiem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ThiTracNghiem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ThiTracNghiem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ThiTracNghiem] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ThiTracNghiem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ThiTracNghiem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ThiTracNghiem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ThiTracNghiem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ThiTracNghiem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ThiTracNghiem] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ThiTracNghiem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ThiTracNghiem] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ThiTracNghiem] SET  MULTI_USER 
GO
ALTER DATABASE [ThiTracNghiem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ThiTracNghiem] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ThiTracNghiem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ThiTracNghiem] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [ThiTracNghiem] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ThiTracNghiem] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'ThiTracNghiem', N'ON'
GO
ALTER DATABASE [ThiTracNghiem] SET QUERY_STORE = OFF
GO
USE [ThiTracNghiem]
GO
/****** Object:  Table [dbo].[CauHoi]    Script Date: 12/9/2024 9:43:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CauHoi](
	[MaCauHoi] [int] IDENTITY(1,1) NOT NULL,
	[NDCauHoi] [nvarchar](4000) NULL,
	[MaPhan] [smallint] NULL,
	[HinhAnh] [varchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCauHoi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DapAn]    Script Date: 12/9/2024 9:43:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DapAn](
	[MaCauTraLoi] [int] IDENTITY(1,1) NOT NULL,
	[NDCauTraLoi] [nvarchar](max) NULL,
	[MaCauHoi] [nvarchar](50) NULL,
	[DungSai] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCauTraLoi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KetQua]    Script Date: 12/9/2024 9:43:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KetQua](
	[MaKetQua] [int] NOT NULL,
	[LanThi] [int] NOT NULL,
	[KetQuaThi] [varchar](5) NOT NULL,
	[MaThiSinh] [int] NOT NULL,
	[ThoiGian] [int] NOT NULL,
 CONSTRAINT [PK_KetQua] PRIMARY KEY CLUSTERED 
(
	[MaKetQua] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Phan]    Script Date: 12/9/2024 9:43:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phan](
	[MaPhan] [int] IDENTITY(1,1) NOT NULL,
	[TenPhan] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 12/9/2024 9:43:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[Username] [varchar](20) NOT NULL,
	[Password] [varchar](20) NOT NULL,
	[IsAdmin] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThiSinh]    Script Date: 12/9/2024 9:43:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThiSinh](
	[MaThiSinh] [int] IDENTITY(1,1) NOT NULL,
	[HoTenThiSinh] [nvarchar](50) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[GioiTinh] [char](1) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[Username] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaThiSinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CauHoi] ON 

INSERT [dbo].[CauHoi] ([MaCauHoi], [NDCauHoi], [MaPhan], [HinhAnh]) VALUES (1, N'Phần của đường bộ được sử dụng cho các phương tiện giao thông qua lại là gì?', 1, NULL)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NDCauHoi], [MaPhan], [HinhAnh]) VALUES (2, N'“Làn đường” là gì?', 1, NULL)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NDCauHoi], [MaPhan], [HinhAnh]) VALUES (3, N'Trong các khái niệm dưới đây, “dải phân cách” được hiểu như thế nào là đúng?', 1, NULL)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NDCauHoi], [MaPhan], [HinhAnh]) VALUES (4, N'“Dải phân cách” trên đường bộ gồm những loại nào?', 1, NULL)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NDCauHoi], [MaPhan], [HinhAnh]) VALUES (5, N'Người lái xe được hiểu như thế nào trong các khái niệm dưới đây?', 1, NULL)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NDCauHoi], [MaPhan], [HinhAnh]) VALUES (6, N'Đường mà trên đó phương tiện tham gia giao thông được các phương tiện giao thông đến
từ hướng khác nhường đường khi qua nơi đường giao nhau, được cắm biển báo hiệu
đường ưu tiên là loại đường gì?', 1, NULL)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NDCauHoi], [MaPhan], [HinhAnh]) VALUES (7, N'Khái niệm “phương tiện giao thông cơ giới đường bộ” được hiểu thế nào là đúng?', 1, NULL)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NDCauHoi], [MaPhan], [HinhAnh]) VALUES (8, N'Khái niệm “phương tiện giao thông thô sơ đường bộ” được hiểu thế nào là đúng?', 1, NULL)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NDCauHoi], [MaPhan], [HinhAnh]) VALUES (9, N'“Phương tiện tham gia giao thông đường bộ” gồm những loại nào?', 1, NULL)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NDCauHoi], [MaPhan], [HinhAnh]) VALUES (10, N'Người điều khiển phương tiện giao thông đường bộ mà trong cơ thể có chất ma tuý có
bị nghiêm cấm hay không ?', 6, NULL)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NDCauHoi], [MaPhan], [HinhAnh]) VALUES (11, N'Sử dụng rượu bia khi lái xe, nếu bị phát hiện thì bị xử lý như thế nào?', 6, NULL)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NDCauHoi], [MaPhan], [HinhAnh]) VALUES (12, N' 

Khái niệm về văn hóa giao thông được hiểu như thế nào là đúng? ', 2, NULL)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NDCauHoi], [MaPhan], [HinhAnh]) VALUES (13, N'Trong các hành vi dưới đây, người lái xe mô tô có văn hóa giao thông phải ứng xử như thế
nào? 
 ', 2, NULL)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NDCauHoi], [MaPhan], [HinhAnh]) VALUES (14, N'Trong các hành vi dưới đây, người lái xe ô tô, mô tô có văn hóa giao thông phải ứng xử như
thế nào? 
 ', 2, NULL)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NDCauHoi], [MaPhan], [HinhAnh]) VALUES (15, N' 

Khi xảy ra tai nạn giao thông, có người bị thương nghiêm trọng, người lái xe và người có
mặt tại hiện trường vụ tai nạn phải thực hiện các công việc gì dưới đây? ', 2, NULL)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NDCauHoi], [MaPhan], [HinhAnh]) VALUES (16, N'Trên đường đang xảy ra ùn tắc những hành vi nào sau đây là thiếu văn hóa khi tham gia
giao thông? 
 ', 2, NULL)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NDCauHoi], [MaPhan], [HinhAnh]) VALUES (17, N'Khi điều khiển xe mô tô tay ga xuống đường dốc dài, độ dốc cao, người lái xe cần thực
hiện các thao tác nào dưới đây để đảm bảo an toàn? ', 6, NULL)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NDCauHoi], [MaPhan], [HinhAnh]) VALUES (18, N'Khi quay đầu xe, người lái xe cần phải quan sát và thực hiện các thao tác nào để đảm bảo
an toàn giao thông? 
 ', 3, NULL)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NDCauHoi], [MaPhan], [HinhAnh]) VALUES (19, N'Khi tránh nhau trên đường hẹp, người lái xe cần phải chú ý những điểm nào để đảm bảo an
toàn giao thông? 
 ', 3, NULL)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NDCauHoi], [MaPhan], [HinhAnh]) VALUES (20, N'Khi điều khiển xe trên đường vòng người lái xe cần phải làm gì để đảm bảo an toàn?', 3, NULL)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NDCauHoi], [MaPhan], [HinhAnh]) VALUES (21, N'Để đạt được hiệu quả phanh cao nhất, người lái xe mô tô phải sử dụng các kỹ năng
như thế nào dưới đây? ', 3, NULL)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NDCauHoi], [MaPhan], [HinhAnh]) VALUES (22, N'Khi đang lái xe mô tô và ô tô, nếu có nhu cầu sử dụng điện thoại để nhắn tin hoặc gọi điện,
người lái xe phải thực hiện như thế nào trong các tình huống nêu dưới đây? ', 6, NULL)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NDCauHoi], [MaPhan], [HinhAnh]) VALUES (23, N' 

Những thói quen nào dưới đây khi điều khiển xe mô tô tay ga tham gia giao thông dễ gây
tai nạn nguy hiểm? ', 3, NULL)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NDCauHoi], [MaPhan], [HinhAnh]) VALUES (24, N' 

Khi điều khiển xe mô tô quay đầu người lái xe cần thực hiện như thế nào để đảm bảo an
toàn? ', 3, NULL)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NDCauHoi], [MaPhan], [HinhAnh]) VALUES (25, N' 

Tay ga trên xe mô tô hai bánh có tác dụng gì trong các trường hợp dưới đây? ', 3, NULL)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NDCauHoi], [MaPhan], [HinhAnh]) VALUES (26, N' 

Gương chiếu hậu của xe mô tô hai bánh, có tác dụng gì trong các trường hợp dưới đây? ', 3, NULL)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NDCauHoi], [MaPhan], [HinhAnh]) VALUES (27, N'Để đảm bảo an toàn khi tham gia giao thông, người lái xe lái xe mô tô hai bánh cần điều
khiển tay ga như thế nào trong các trường hợp dưới đây? 
 ', 3, NULL)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NDCauHoi], [MaPhan], [HinhAnh]) VALUES (28, N'Kỹ thuật cơ bản để giữ thăng bằng khi điều khiển xe mô tô đi trên đường gồ ghề như thế
nào trong các trường hợp dưới đây? 
 ', 3, NULL)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NDCauHoi], [MaPhan], [HinhAnh]) VALUES (29, N'Biển nào dưới đây xe gắn máy được phép đi vào? ', 4, NULL)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NDCauHoi], [MaPhan], [HinhAnh]) VALUES (30, N'

Biển nào báo hiệu cấm xe mô tô hai bánh đi vào? ', 4, NULL)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NDCauHoi], [MaPhan], [HinhAnh]) VALUES (31, N'Khi gặp biển nào thì xe mô tô hai bánh được đi vào?', 4, NULL)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NDCauHoi], [MaPhan], [HinhAnh]) VALUES (32, N'Biển nào cấm quay đầu xe? ', 4, NULL)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NDCauHoi], [MaPhan], [HinhAnh]) VALUES (33, N'Biển nào cấm xe rẽ trái? ', 4, NULL)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NDCauHoi], [MaPhan], [HinhAnh]) VALUES (34, N'

Khi gặp biển nào xe được rẽ trái? ', 4, NULL)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NDCauHoi], [MaPhan], [HinhAnh]) VALUES (35, N'
 
Biển nào cấm các phương tiện giao thông đường bộ rẽ phải? ', 4, NULL)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NDCauHoi], [MaPhan], [HinhAnh]) VALUES (36, N'

Biển nào cấm các phương tiện giao thông đường bộ rẽ trái? ', 4, NULL)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NDCauHoi], [MaPhan], [HinhAnh]) VALUES (37, N'

Biển nào cho phép xe rẽ trái? ', 4, NULL)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NDCauHoi], [MaPhan], [HinhAnh]) VALUES (38, N'
Biển nào xe quay đầu không bị cấm? ', 4, NULL)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NDCauHoi], [MaPhan], [HinhAnh]) VALUES (39, N'Thứ tự các xe đi như thế nào là đúng quy tắc giao thông?', 5, NULL)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NDCauHoi], [MaPhan], [HinhAnh]) VALUES (40, N'Thứ tự các xe đi như thế nào là đúng quy tắc giao thông? 

', 5, NULL)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NDCauHoi], [MaPhan], [HinhAnh]) VALUES (41, N'

Trường hợp này xe nào được quyền đi trước? ', 5, NULL)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NDCauHoi], [MaPhan], [HinhAnh]) VALUES (42, N'Xe nào được quyền đi trước trong trường hợp này?', 5, NULL)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NDCauHoi], [MaPhan], [HinhAnh]) VALUES (43, N'Theo tín hiệu đèn, xe nào được phép đi? ', 5, NULL)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NDCauHoi], [MaPhan], [HinhAnh]) VALUES (44, N' 
Các xe đi theo hướng mũi tên, xe nào vi phạm quy tắc giao thông? 

 ', 5, NULL)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NDCauHoi], [MaPhan], [HinhAnh]) VALUES (45, N'Thứ tự các xe đi như thế nào là đúng quy tắc giao thông? ', 5, NULL)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NDCauHoi], [MaPhan], [HinhAnh]) VALUES (46, N'Trong trường hợp này xe nào đỗ vi phạm quy tắc giao thông? ', 5, NULL)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NDCauHoi], [MaPhan], [HinhAnh]) VALUES (47, N'Theo hướng mũi tên, những hướng nào xe gắn máy đi được?', 5, NULL)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NDCauHoi], [MaPhan], [HinhAnh]) VALUES (48, N'Xe nào đỗ vi phạm quy tắc giao thông? ', 5, NULL)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NDCauHoi], [MaPhan], [HinhAnh]) VALUES (49, N'Người ngồi trên xe mô tô hai bánh, ba bánh, xe gắn máy. Khi tham gia giao thông có được mang vác vật cồng kềnh hay không?', 6, NULL)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NDCauHoi], [MaPhan], [HinhAnh]) VALUES (50, N'Người ngồi trên xe mô tô hai bánh, xe mô tô ba bánh, xe gắn máy. Khi tham gia giao thông có được bám, kéo hoặc đẩy các phương tiện khác hay không?', 6, NULL)
SET IDENTITY_INSERT [dbo].[CauHoi] OFF
GO
SET IDENTITY_INSERT [dbo].[DapAn] ON 

INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (1, N'Phần mặt đường và lề đường.', N'1', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (2, N'Phần đường xe chạy', N'1', 1)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (3, N'Phần đường xe cơ giới.', N'1', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (4, N'Là một phần của phần đường xe chạy được chia theo chiều dọc của đường, sử dụng cho 
xe chạy', N'2', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (5, N'Là một phần của phần đường xe chạy được chia theo chiều dọc của đường, có bề rộng đủ
cho xe chạy an toàn.', N'2', 1)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (6, N'Là đường cho xe ô tô chạy, dừng, đỗ an toàn.', N'2', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (7, N'Là bộ phận của đường để ngăn cách không cho các loại xe vào những nơi không được phép.', N'3', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (8, N'Là bộ phận của đường để phân tách phần đường xe chạy và
hành lang an toàn giao thông.', N'3', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (9, N'Là bộ phận của đường để phân chia mặt đường thành hai chiều xe chạy riêng biệt hoặc để phân
chia phần đường của xe cơ giới và xe thô sơ.', N'3', 1)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (10, N'Dải phân cách gồm loại cố định và loại di động.', N'4', 1)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (11, N'Dải phân cách gồm tường chống ồn, hộ lan cứng và hộ lan mềm', N'4', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (12, N'Dải phân cách gồm giá
long môn và biển báo hiệu đường bộ.', N'4', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (13, N'Là người điều khiển xe cơ giới', N'5', 1)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (14, N'Là người điều khiển xe thô sơ.', N'5', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (15, N'Là người điều khiển xe có súc vật kéo.', N'5', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (16, N'Đường không ưu tiên.', N'6', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (17, N'Đường tỉnh lộ', N'6', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (18, N'Đường quốc lộ', N'6', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (19, N'Đường ưu tiên', N'6', 1)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (20, N'Gồm xe ô tô; máy kéo; xe mô tô hai bánh; xe mô tô ba bánh; xe gắn máy; xe cơ giới dùng cho người khuyết tật và xe máy chuyên dùng', N'7', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (21, N'Gồm xe ô tô; máy kéo; rơ moóc hoặc sơ mi rơ moóc được kéo bởi xe ô tô, máy kéo; xe mô tô
hai bánh; xe mô tô ba bánh, xe gắn máy (kể cả xe máy điện) và các loại xe tương tự.', N'7', 1)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (22, N'Gồm xe đạp (kể cả xe đạp máy, xe đạp điện), xe xích lô, xe lăn dùng cho người khuyết tật, xe
súc vật kéo và các loại xe tương tự.', N'8', 1)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (23, N'Gồm xe đạp (kể cả xe đạp máy, xe đạp điện), xe gắn máy, xe cơ giới dùng cho người khuyết
tật và xe máy chuyên dùng.', N'8', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (24, N'Gồm xe ô tô, máy kéo, rơ moóc hoặc sơ mi rơ moóc được kéo bởi xe ô tô, máy kéo.', N'8', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (32, N'Chỉ bị nhắc nhở', N'11', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (33, N'Bị xử phạt hành chính hoặc có thể bị xử lý hình sự tùy theo mức độ vi phạm.', N'11', 1)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (34, N'Không bị xử lý hình sự.', N'11', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (35, N'', N'11', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (36, N'Bị nghiêm cấm.', N'10', 1)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (37, N'Không bị nghiêm cấm.', N'10', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (38, N'Không bị nghiêm cấm, nếu có chất ma tuý ở mức nhẹ, có thể điều khiển phương tiện tham', N'10', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (39, N'', N'10', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (44, N'Phương tiện giao thông cơ giới đường bộ', N'9', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (45, N'Phương tiện giao thông thô sơ đường bộ và xe máy chuyên dùng.', N'9', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (46, N'Cả ý 1 và ý 2.', N'9', 1)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (47, N'', N'9', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (48, N' Là sự hiểu biết và chấp hành nghiêm chỉnh pháp luật về giao thông; là ý thức trách nhiệm
với cộng đồng khi tham gia giao thông.', N'12', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (49, N' Là ứng xử có văn hóa, có tình yêu thương con người trong các tình huống không may xảy
ra khi tham gia giao thông. ', N'12', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (50, N'Cả ý 1 và ý 2', N'12', 1)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (51, N' Điều khiển xe đi bên phải theo chiều đi của mình; đi đúng phần đường, làn đường quy định;
đội mũ bảo hiểm đạt chuẩn, cài quai đúng quy cách. ', N'13', 1)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (52, N'Điều khiển xe đi trên phần đường, làn đường có ít phương tiện tham gia giao thông. ', N'13', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (53, N'Điều khiển xe và đội mũ bảo hiểm ở nơi có biển báo bắt buộc đội mũ bảo hiểm', N'13', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (54, N'Điều khiển xe đi bên phải theo chiều đi của mình; đi đúng phần đường, làn đường quy định;
dừng, đỗ xe đúng nơi quy định; đã uống rượu, bia thì không lái xe', N'14', 1)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (55, N' Điều khiển xe đi trên phần đường, làn đường có ít phương tiện giao thông; dừng xe, đỗ xe ở
nơi thuận tiện hoặc theo yêu cầu của hành khách, của người thân. ', N'14', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (56, N' Dừng và đỗ xe ở nơi thuận tiện cho việc chuyên chở hành khách và giao nhận hàng hóa; sử
dụng ít rượu, bia thì có thể lái xe. ', N'14', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (57, N'Thực hiện sơ cứu ban đầu trong trường hợp khẩn cấp; thông báo vụ tai nạn đến cơ quan
thi hành pháp luật.', N'15', 1)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (58, N'Nhanh chóng lái xe gây tai nạn hoặc đi nhờ xe khác ra khỏi hiện trường vụ tai nạn.', N'15', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (59, N'Cả ý 1 và ý 2. ', N'15', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (60, N'Bấm còi liên tục thúc giục các phương tiện phía trước nhường đường', N'16', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (61, N'Đi lên vỉa hè, tận dùng mọi khoảng trống để nhanh chóng thoát khỏi nơi ùn tắc', N'16', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (62, N'Lấn sang trái đường cố gắng vượt lên xe khác. ', N'16', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (63, N'Tất cả các ý nêu trên', N'16', 1)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (64, N'Giữ tay ga ở mức độ phù hợp, sử dụng phanh trước và phanh sau để giảm tốc độ', N'17', 1)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (65, N'Nhả hết tay ga, tắt động cơ, sử dụng phanh trước và phanh sau để giảm tốc độ. ', N'17', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (66, N'Sử dụng phanh trước để giảm tốc độ kết hợp với tắt chìa khóa điện của xe', N'17', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (67, N'Quan sát biển báo hiệu để biết nơi được phép quay đầu; quan sát kỹ địa hình nơi chọn để quay
đầu; lựa chọn quỹ đạo quay đầu xe cho thích hợp; quay đầu xe với tốc độ thấp; thường xuyên
báo tín hiệu để người, các phương tiện xung quanh được biết; nếu quay đầu xe ở nơi nguy
hiểm thì đưa đầu xe về phía nguy hiểm đưa đuôi xe về phía an toàn', N'18', 1)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (68, N'Quan sát biển báo hiệu để biết nơi được phép quay đầu; quan sát kỹ địa hình nơi chọn để quay
đầu; lựa chọn quỹ đạo quay đầu xe; quay đầu xe với tốc độ tối đa; thường xuyên báo tín hiệu
để người, các phương tiện xung quanh được biết; nếu quay đầu xe ở nơi nguy hiểm thì đưa
đuôi xe về phía nguy hiểm và đầu xe về phía an toàn.', N'18', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (69, N' Không nên đi cố vào đường hẹp; xe đi ở sườn núi nên dừng lại trước để nhường đường; khi
dừng xe nhường đường phải đỗ ngay ngắn.', N'19', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (70, N'Trong khi tránh nhau không nên đổi số; khi tránh nhau ban đêm, phải tắt đèn pha bật đèn cốt', N'19', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (71, N'Khi tránh nhau ban đêm, phải thường xuyên bật đèn pha tắt đèn cốt. ', N'19', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (72, N'Cả ý 1 và ý 2.', N'19', 1)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (73, N'Quan sát cẩn thận các chướng ngại vật và báo hiệu bằng còi, đèn; giảm tốc độ tới mức cần thiết, về
số thấp và thực hiện quay vòng với tốc độ phù hợp với bán kính cong của đường vòng.', N'20', 1)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (74, N'Quan sát cẩn thận các chướng ngại vật và báo hiệu bằng còi, đèn; tăng tốc để nhanh chóng qua
đường vòng, đạp ly hợp (côn) và giảm tốc độ sau khi qua đường vòng', N'20', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (75, N'Sử dụng phanh trước', N'21', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (76, N'Sử dụng phanh sau', N'21', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (77, N'Giảm hết ga; sử dụng đồng thời cả phanh sau và phanh trước', N'21', 1)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (78, N'Giảm tốc độ để đảm bảo an toàn với xe phía trước và sử dụng điện thoại để liên lạc. ', N'22', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (79, N'Giảm tốc độ để dừng xe ở nơi cho phép dừng xe sau đó sử dụng điện thoại để liên lạc', N'22', 1)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (80, N'Tăng tốc độ để cách xa xe phía sau và sử dụng điện thoại để liên lạc.', N'22', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (81, N'Sử dụng còi. ', N'23', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (82, N'Phanh đồng thời cả phanh trước và phanh sau', N'23', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (83, N'Chỉ sử dụng phanh trước.', N'23', 1)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (84, N'Bật tín hiệu báo rẽ trước khi quay đầu, từ từ giảm tốc độ đến mức có thể dừng lại.', N'24', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (85, N'Chỉ quay đầu xe tại những nơi được phép quay đầu.', N'24', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (86, N'Quan sát an toàn các phương tiện tới từ phía trước, phía sau, hai bên đồng thời nhường đường
cho xe từ bên phải và phía trước đi tới', N'24', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (87, N'Tất cả các ý nêu trên.', N'24', 1)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (88, N'Để điều khiển xe chạy về phía trước.', N'25', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (89, N'Để điều tiết công suất động cơ qua đó điều khiển tốc độ của xe.', N'25', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (90, N'Để điều khiển xe chạy lùi.', N'25', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (91, N'Cả ý 1 và ý 2', N'25', 1)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (92, N'Để quan sát an toàn phía bên trái khi chuẩn bị rẽ trái', N'26', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (93, N'Để quan sát an toàn phía bên phải khi chuẩn bị rẽ phải', N'26', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (94, N'Để quan sát an toàn phía sau cả bên trái và bên phải trước khi chuyển hướng', N'26', 1)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (95, N'Để quan sát an toàn phía trước cả bên trái và bên phải trước khi chuyển hướng', N'26', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (96, N'Tăng ga thật nhanh, giảm ga từ từ', N'27', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (97, N'Tăng ga thật nhanh, giảm ga thật nhanh.', N'27', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (98, N'Tăng ga từ từ, giảm ga thật nhanh.', N'27', 1)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (99, N'Tăng ga từ từ, giảm ga từ từ.', N'27', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (100, N'Đứng thẳng trên giá gác chân lái sau đó hơi gập đầu gối và khuỷu tay, đi chậm để không
nẩy quá mạnh', N'28', 1)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (101, N'Ngồi lùi lại phía sau, tăng ga vượt nhanh qua đoạn đường xóc.', N'28', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (102, N'Ngồi lệch sang bên trái hoặc bên phải để lấy thăng bằng qua đoạn đường gồ ghề', N'28', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (103, N'Biển 1', N'29', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (104, N'Biển 2', N'29', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (105, N'Cả 2 biển', N'29', 1)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (106, N'Biển 1', N'30', 1)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (107, N'Biển 2', N'30', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (108, N'Biển 3', N'30', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (109, N'Không biển nào', N'31', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (110, N'Biển 1 và 2', N'31', 0)
GO
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (111, N'Biển 2 và 3', N'31', 1)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (112, N'Cả 3 biển', N'31', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (113, N'Biển 1', N'32', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (114, N'Biển 2', N'32', 1)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (115, N'Không biển nào', N'32', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (116, N'Cả 2 biển', N'32', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (117, N'Biển 1', N'33', 1)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (118, N'Biển 2', N'33', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (119, N'Cả hai biển', N'33', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (120, N'Biển 1', N'34', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (121, N'Biển 2', N'34', 1)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (122, N'Không biển nào', N'34', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (123, N'Biển 1 và 2', N'35', 1)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (124, N'Biển 1 và 3', N'35', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (125, N'Biển 2 và 3', N'35', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (126, N'Cả ba biển', N'35', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (127, N'Biển 1 và 2', N'36', 1)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (128, N'Biển 1 và 3', N'36', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (129, N'Biển 2 và 3', N'36', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (130, N'Cả ba biển', N'36', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (131, N'Biển 1', N'37', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (132, N'Biển 2', N'37', 1)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (133, N'hông biển nào', N'37', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (134, N'Biển 1', N'38', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (135, N'Biển 2', N'38', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (136, N'ả hai biển', N'38', 1)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (137, N'Xe tải, xe khách, xe con, mô tô', N'39', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (138, N'Xe tải, mô tô, xe khách, xe con', N'39', 1)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (139, N'Xe khách, xe tải, xe con, mô tô', N'39', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (140, N'ô tô, xe khách, xe tải, xe con', N'39', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (141, N'e tải, xe con, mô tô', N'40', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (142, N'Xe con, xe tải, mô tô', N'40', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (143, N'ô tô, xe con, xe tải', N'40', 1)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (144, N'Xe con, mô tô, xe tải', N'40', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (145, N'Mô tô', N'41', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (146, N'Xe con', N'41', 1)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (147, N'Mô tô', N'42', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (148, N'Xe cứu thương', N'42', 1)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (149, N'Xe con và xe khách', N'43', 1)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (150, N'ô tô', N'43', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (151, N'Xe khách, xe tải, mô tô', N'44', 1)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (152, N'Xe tải, xe con, mô tô', N'44', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (153, N'Xe khách, xe con, mô tô', N'44', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (154, N'Xe khách, xe tải, mô tô, xe con', N'45', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (155, N'Xe con, xe khách, xe tải, mô tô', N'45', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (156, N'ô tô, xe tải, xe khách, xe con', N'45', 1)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (157, N'ô tô, xe tải, xe con, xe khách', N'45', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (158, N'Xe tải', N'46', 1)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (159, N'Xe con và mô tô', N'46', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (160, N'Cả ba xe', N'46', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (161, N'Xe con và xe tải', N'46', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (162, N'Cả ba hướng', N'47', 1)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (163, N'Chỉ hướng 1 và 3', N'47', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (164, N'Chỉ hướng 1', N'47', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (165, N'Cả hai xe', N'48', 1)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (166, N'Không xe nào vi phạm', N'48', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (167, N'Chỉ xe mô tô vi phạm', N'48', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (168, N'hỉ xe tải vi phạm', N'48', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (169, N'Được mang, vác tuy trường hợp cụ thể', N'49', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (170, N'Không được mang, vác', N'49', 1)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (171, N'Được mang, vác nhưng phải đảm bảo an toàn', N'49', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (172, N'Được mang, vác tùy theo sức khỏe của bản thân', N'49', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (173, N'Được phép', N'50', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (174, N'Được bám trong trường hợp phương tiện của mình bị hỏng', N'50', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (175, N'Được kéo, đẩy trong trường hợp phương tiện khác bị hỏng', N'50', 0)
INSERT [dbo].[DapAn] ([MaCauTraLoi], [NDCauTraLoi], [MaCauHoi], [DungSai]) VALUES (176, N'Không được phép', N'50', 1)
SET IDENTITY_INSERT [dbo].[DapAn] OFF
GO
SET IDENTITY_INSERT [dbo].[Phan] ON 

INSERT [dbo].[Phan] ([MaPhan], [TenPhan]) VALUES (1, N'Khái niệm và quy tắc giao thông đường bộ ')
INSERT [dbo].[Phan] ([MaPhan], [TenPhan]) VALUES (2, N'Văn hóa giao thông và đạo đức người lái xe')
INSERT [dbo].[Phan] ([MaPhan], [TenPhan]) VALUES (3, N'Kỹ thuật người lái xe')
INSERT [dbo].[Phan] ([MaPhan], [TenPhan]) VALUES (4, N'Hệ thống biển báo hiệu đường bộ')
INSERT [dbo].[Phan] ([MaPhan], [TenPhan]) VALUES (5, N'Thế sa hình và kỹ năng xử lý tình huống giao thông')
INSERT [dbo].[Phan] ([MaPhan], [TenPhan]) VALUES (6, N'câu về tình huống mất an toàn giao thông nghiêm trọng (câu điểm liệt) :')
SET IDENTITY_INSERT [dbo].[Phan] OFF
GO
INSERT [dbo].[TaiKhoan] ([Username], [Password], [IsAdmin]) VALUES (N'admin', N'123', 1)
INSERT [dbo].[TaiKhoan] ([Username], [Password], [IsAdmin]) VALUES (N'Manh', N'123', 0)
INSERT [dbo].[TaiKhoan] ([Username], [Password], [IsAdmin]) VALUES (N'Thang', N'***', 0)
GO
SET IDENTITY_INSERT [dbo].[ThiSinh] ON 

INSERT [dbo].[ThiSinh] ([MaThiSinh], [HoTenThiSinh], [NgaySinh], [GioiTinh], [DiaChi], [Username]) VALUES (1, N'Trần Mạnh', CAST(N'2004-10-13' AS Date), N'M', N'123', N'Manh')
INSERT [dbo].[ThiSinh] ([MaThiSinh], [HoTenThiSinh], [NgaySinh], [GioiTinh], [DiaChi], [Username]) VALUES (2, N'Dao Xuan Thang', CAST(N'2024-12-01' AS Date), N'M', N'123', N'Thang')
SET IDENTITY_INSERT [dbo].[ThiSinh] OFF
GO
ALTER TABLE [dbo].[ThiSinh] ADD  DEFAULT ('M') FOR [GioiTinh]
GO
ALTER TABLE [dbo].[KetQua]  WITH CHECK ADD  CONSTRAINT [FK_MaThiSinh] FOREIGN KEY([MaThiSinh])
REFERENCES [dbo].[ThiSinh] ([MaThiSinh])
GO
ALTER TABLE [dbo].[KetQua] CHECK CONSTRAINT [FK_MaThiSinh]
GO
ALTER TABLE [dbo].[ThiSinh]  WITH CHECK ADD FOREIGN KEY([Username])
REFERENCES [dbo].[TaiKhoan] ([Username])
GO
USE [master]
GO
ALTER DATABASE [ThiTracNghiem] SET  READ_WRITE 
GO
