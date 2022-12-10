USE [db_marehotel]
GO
/****** Object:  Table [dbo].[tbl_checkout]    Script Date: 25/11/2021 01:56:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_checkout](
	[no_cpf] [char](11) NOT NULL,
	[pc_quarto] [char](8) NOT NULL,
	[pc_serviço] [char](10) NOT NULL,
	[nm_hospede] [char](20) NOT NULL,
	[no_quarto] [char](5) NOT NULL,
	[hr_entrada] [char](4) NOT NULL,
	[hr_saida] [char](4) NOT NULL,
	[pagamento] [varchar](10) NULL,
	[dias] [char](5) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_funcionario]    Script Date: 25/11/2021 01:56:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_funcionario](
	[cd_funcionario] [int] IDENTITY(1,1) NOT NULL,
	[ds_login] [varchar](20) NOT NULL,
	[ds_senha] [char](10) NOT NULL,
	[nm_funcionario] [varchar](60) NOT NULL,
	[nm_email] [varchar](60) NULL,
	[no_cpf] [char](11) NOT NULL,
	[nm_sexo] [varchar](10) NULL,
	[nm_turno] [varchar](5) NOT NULL,
	[no_nascimento] [char](10) NOT NULL,
	[no_cep] [char](9) NOT NULL,
	[nm_estado] [varchar](20) NOT NULL,
	[nm_cidade] [varchar](20) NOT NULL,
	[nm_bairro] [varchar](20) NOT NULL,
	[nm_complemento] [varchar](20) NOT NULL,
	[no_telefone] [char](20) NULL,
	[no_celular] [char](12) NULL,
	[nm_funcao] [varchar](20) NOT NULL,
	[nm_endereco] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[cd_funcionario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_hospedes]    Script Date: 25/11/2021 01:56:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_hospedes](
	[cd_hospede] [int] IDENTITY(1,1) NOT NULL,
	[nm_hospede] [varchar](60) NOT NULL,
	[nm_email] [varchar](60) NULL,
	[no_cpf] [char](11) NOT NULL,
	[nm_sexo] [varchar](10) NULL,
	[no_nascimento] [char](10) NOT NULL,
	[nm_cidade] [varchar](20) NOT NULL,
	[no_celular] [char](12) NULL,
PRIMARY KEY CLUSTERED 
(
	[cd_hospede] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_quartos]    Script Date: 25/11/2021 01:56:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_quartos](
	[no_quarto] [int] NOT NULL,
	[no_andar] [int] NOT NULL,
	[nm_status] [char](12) NULL,
	[no_preço] [char](20) NOT NULL,
	[cd_hospede] [char](5) NULL,
	[nm_hospede] [varchar](60) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tlb_reservas]    Script Date: 25/11/2021 01:56:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tlb_reservas](
	[no_reserva] [char](20) NOT NULL,
	[no_quarto] [char](3) NOT NULL,
	[no_hospedes] [char](2) NOT NULL,
	[no_data] [char](10) NOT NULL
) ON [PRIMARY]
GO
