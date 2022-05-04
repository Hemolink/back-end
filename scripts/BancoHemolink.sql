USE [master]
GO
/****** Object:  Database [Hemolink]    Script Date: 03/05/2022 22:10:20 ******/
CREATE DATABASE [Hemolink]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Hemolink', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Hemolink.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Hemolink_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Hemolink_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Hemolink] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Hemolink].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Hemolink] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Hemolink] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Hemolink] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Hemolink] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Hemolink] SET ARITHABORT OFF 
GO
ALTER DATABASE [Hemolink] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Hemolink] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Hemolink] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Hemolink] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Hemolink] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Hemolink] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Hemolink] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Hemolink] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Hemolink] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Hemolink] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Hemolink] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Hemolink] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Hemolink] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Hemolink] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Hemolink] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Hemolink] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Hemolink] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Hemolink] SET RECOVERY FULL 
GO
ALTER DATABASE [Hemolink] SET  MULTI_USER 
GO
ALTER DATABASE [Hemolink] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Hemolink] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Hemolink] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Hemolink] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Hemolink] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Hemolink] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Hemolink', N'ON'
GO
ALTER DATABASE [Hemolink] SET QUERY_STORE = OFF
GO
USE [Hemolink]
GO
/****** Object:  Table [dbo].[Agenda]    Script Date: 03/05/2022 22:10:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Agenda](
	[ID_AGENDAMENTO] [int] IDENTITY(1,1) NOT NULL,
	[AGENDAMENTO] [datetime] NOT NULL,
	[ID_DOADOR] [int] NOT NULL,
 CONSTRAINT [PK_Agenda] PRIMARY KEY CLUSTERED 
(
	[ID_AGENDAMENTO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Doador]    Script Date: 03/05/2022 22:10:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doador](
	[ID_DOADOR] [int] IDENTITY(1,1) NOT NULL,
	[NOME] [varchar](20) NOT NULL,
	[SOBRENOME] [varchar](20) NOT NULL,
	[DATA_NASCIMENTO] [date] NOT NULL,
	[EMAIL] [varchar](100) NOT NULL,
	[SENHA] [varchar](30) NOT NULL,
	[TIPO_SANGUINEO] [varchar](3) NULL,
	[CPF] [char](11) NOT NULL,
	[ULTIMA_DOACAO] [date] NOT NULL,
	[SEXO] [char](1) NOT NULL,
	[PESO] [decimal](6, 3) NOT NULL,
 CONSTRAINT [PK_Doador] PRIMARY KEY CLUSTERED 
(
	[ID_DOADOR] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [IX_Doador] UNIQUE NONCLUSTERED 
(
	[CPF] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UK_email] UNIQUE NONCLUSTERED 
(
	[EMAIL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Questionario]    Script Date: 03/05/2022 22:10:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Questionario](
	[ID_FORMULARIO] [int] IDENTITY(1,1) NOT NULL,
	[ID_DOADOR] [int] NOT NULL,
	[BEBIDA_ALCOLICA] [bit] NULL,
	[RESFRIADO_GRIPADO] [bit] NULL,
	[FEBRE] [bit] NULL,
	[DOR_PEITO] [bit] NULL,
	[DOENCA_CRONICA] [bit] NULL,
	[DOENCA_GRAVE] [varchar](60) NULL,
	[EXTRACAO_DENTARIA] [bit] NULL,
	[CIRURGIA_ODONTOLOGICA] [bit] NULL,
	[REMEDIO_CONTROLADO] [varchar](120) NULL,
	[VACINOU] [bit] NULL,
	[RECEBEU_TRANSFUSAO] [bit] NULL,
	[RECEBEU_PLASMA] [bit] NULL,
	[RECEBEU_PLAQUETAS] [bit] NULL,
	[TATUAGEM] [bit] NULL,
	[PIERCING] [bit] NULL,
	[ACUPUNTURA] [bit] NULL,
	[BIO_ACIDENTE] [bit] NULL,
	[ANESTESIA_GERAL] [bit] NULL,
	[JA_OPERADO] [bit] NULL,
	[TRANSPLANTE_ORGAO] [bit] NULL,
	[PROCEDIMENTO_ENDOSCOPICO] [bit] NULL,
	[TESTE_HIV] [bit] NULL,
	[JA_FOI_PRESO] [bit] NULL,
	[VIAGEM_EXTERIOR] [bit] NULL,
	[DESMAIO] [bit] NULL,
	[CONVULSAO] [bit] NULL,
	[AVC] [bit] NULL,
	[DERRAME] [bit] NULL,
	[DENGUE] [bit] NULL,
	[ZIKA] [bit] NULL,
	[CHIKUNGUNYA] [bit] NULL,
	[DIABETES] [bit] NULL,
	[HEPATITE] [bit] NULL,
	[IST] [bit] NULL,
	[ASMA] [bit] NULL,
	[BRONQUITE] [bit] NULL,
	[ALERGIA] [varchar](100) NULL,
	[CHOQUE_ANAFILATICO] [bit] NULL,
	[CANCER] [bit] NULL,
	[TUMOR] [bit] NULL,
	[LEUCEMIA] [bit] NULL,
	[VACA_LOUCA] [bit] NULL,
	[FERIDA] [bit] NULL,
	[COCEIRA] [bit] NULL,
	[DROGAS_ILICITAS] [bit] NULL,
	[SEXO_SEM_PROTECAO] [bit] NULL,
	[SEXUALMENTE_ATIVO] [bit] NULL,
	[SEXO_PAGO] [bit] NULL,
	[QUANTIDADE_PARCEIROS_SEXUAIS] [int] NULL,
	[RELACAO_CASA_DE_MASSAGEM] [bit] NULL,
	[RELACAO_SWING] [bit] NULL,
	[RELACAO_CASA_PROSTITUICAO] [bit] NULL,
	[SEXO_ENTRE_HOMENS] [bit] NULL,
	[RELACAO_HOMEM_HOMEM] [bit] NULL,
	[GRAVIDA] [bit] NULL,
	[QUANTAS_GRAVIDEZES] [int] NULL,
	[PARTO] [bit] NULL,
	[ABORTO] [bit] NULL,
	[AMAMENTANDO] [bit] NULL,
	[FUMA] [bit] NULL,
	[SUSPEITA_COVID] [bit] NULL,
	[OBSERVACOES] [varchar](500) NULL,
 CONSTRAINT [PK_Questionario] PRIMARY KEY CLUSTERED 
(
	[ID_FORMULARIO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sangue]    Script Date: 03/05/2022 22:10:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sangue](
	[TIPO] [varchar](3) NOT NULL,
	[NIVEL_ATUAL] [decimal](5, 2) NOT NULL,
	[PRIORITARIO] [bit] NULL,
	[ULTIMA_ATUALIZACAO] [date] NOT NULL,
 CONSTRAINT [PK_SANGUE] PRIMARY KEY CLUSTERED 
(
	[TIPO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Agenda]  WITH CHECK ADD  CONSTRAINT [FK_Agenda_Doador] FOREIGN KEY([ID_DOADOR])
REFERENCES [dbo].[Doador] ([ID_DOADOR])
GO
ALTER TABLE [dbo].[Agenda] CHECK CONSTRAINT [FK_Agenda_Doador]
GO
ALTER TABLE [dbo].[Doador]  WITH CHECK ADD  CONSTRAINT [FK_Doador_Sangue] FOREIGN KEY([TIPO_SANGUINEO])
REFERENCES [dbo].[Sangue] ([TIPO])
GO
ALTER TABLE [dbo].[Doador] CHECK CONSTRAINT [FK_Doador_Sangue]
GO
ALTER TABLE [dbo].[Questionario]  WITH CHECK ADD  CONSTRAINT [FK_Questionario_Doador] FOREIGN KEY([ID_DOADOR])
REFERENCES [dbo].[Doador] ([ID_DOADOR])
GO
ALTER TABLE [dbo].[Questionario] CHECK CONSTRAINT [FK_Questionario_Doador]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Homem 60 dias, mulher 90' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Doador', @level2type=N'COLUMN',@level2name=N'ULTIMA_DOACAO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'se sim ultima ingestao e orientar a nao ingerir 72h antes da doação' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Questionario', @level2type=N'COLUMN',@level2name=N'BEBIDA_ALCOLICA'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'15 DIAS' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Questionario', @level2type=N'COLUMN',@level2name=N'RESFRIADO_GRIPADO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'_ULT_30DIAS' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Questionario', @level2type=N'COLUMN',@level2name=N'FEBRE'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'QUANDO FAZ EXERCICIO FISICO ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Questionario', @level2type=N'COLUMN',@level2name=N'DOR_PEITO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'6 MESES' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Questionario', @level2type=N'COLUMN',@level2name=N'EXTRACAO_DENTARIA'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'12 MESES' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Questionario', @level2type=N'COLUMN',@level2name=N'VACINOU'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'12 MESES' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Questionario', @level2type=N'COLUMN',@level2name=N'RECEBEU_TRANSFUSAO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'12 MESES' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Questionario', @level2type=N'COLUMN',@level2name=N'RECEBEU_PLASMA'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'12 MESES' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Questionario', @level2type=N'COLUMN',@level2name=N'RECEBEU_PLAQUETAS'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'12 MESES' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Questionario', @level2type=N'COLUMN',@level2name=N'TATUAGEM'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'12 MESES' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Questionario', @level2type=N'COLUMN',@level2name=N'PIERCING'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'12 MESES' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Questionario', @level2type=N'COLUMN',@level2name=N'ACUPUNTURA'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'AGULHAS OU MATERIAL BIOLOGICO 12 MESES' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Questionario', @level2type=N'COLUMN',@level2name=N'BIO_ACIDENTE'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'6 MESES' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Questionario', @level2type=N'COLUMN',@level2name=N'ANESTESIA_GERAL'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'12 MESES' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Questionario', @level2type=N'COLUMN',@level2name=N'TRANSPLANTE_ORGAO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'6 MESES' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Questionario', @level2type=N'COLUMN',@level2name=N'PROCEDIMENTO_ENDOSCOPICO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'12 MESES TEM Q SER A DATA DE SAIDA ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Questionario', @level2type=N'COLUMN',@level2name=N'JA_FOI_PRESO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'12 MESES' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Questionario', @level2type=N'COLUMN',@level2name=N'VIAGEM_EXTERIOR'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'12 MESES' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Questionario', @level2type=N'COLUMN',@level2name=N'DESMAIO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'12 MESES' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Questionario', @level2type=N'COLUMN',@level2name=N'CONVULSAO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'CHECAR FOTO' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Questionario', @level2type=N'COLUMN',@level2name=N'DENGUE'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'_APOS_11ANOS' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Questionario', @level2type=N'COLUMN',@level2name=N'HEPATITE'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'12 MESES SE PAGOU OU FOI PAGO PARA FAZER SEXO' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Questionario', @level2type=N'COLUMN',@level2name=N'SEXO_PAGO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'12 MESES' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Questionario', @level2type=N'COLUMN',@level2name=N'QUANTIDADE_PARCEIROS_SEXUAIS'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'12 MESES' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Questionario', @level2type=N'COLUMN',@level2name=N'RELACAO_CASA_PROSTITUICAO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N' SO VALE HOMEM COM HOMEM PERGUNTA PARA HOMEM SOMENTE' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Questionario', @level2type=N'COLUMN',@level2name=N'SEXO_ENTRE_HOMENS'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'TEVE RELACAO COM HOMEM QUE TRANSOU COM OUTRO HOMEM NOS ULTIMOS 6 MESES' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Questionario', @level2type=N'COLUMN',@level2name=N'RELACAO_HOMEM_HOMEM'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'6 MESES' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Questionario', @level2type=N'COLUMN',@level2name=N'PARTO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'6 MESES' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Questionario', @level2type=N'COLUMN',@level2name=N'ABORTO'
GO
USE [master]
GO
ALTER DATABASE [Hemolink] SET  READ_WRITE 
GO
