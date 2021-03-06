USE master;
GO

DROP DATABASE dbLigma;
GO

CREATE DATABASE dbLigma;
GO

USE dbLigma;

CREATE TABLE tbEndereco(
	cep char(8) not null,
	numero smallint not null,
	logradouro varchar(10),
	nomeRua varchar(30),
	bairro varchar(25),
	cidade varchar(25),
	UF char(2),
	complemento varchar(20),
	CONSTRAINT PK_cep_numero PRIMARY KEY(cep, numero)
	);
GO

CREATE TABLE tbFuncionario(
	codFunc smallint not null
	CONSTRAINT PK_codFunc PRIMARY KEY,
	dataNasc date not null,
	nome varchar(75) not null,
	RG char(10) not null,
	CPF decimal(11) not null,
	telFixo decimal(8),
	telCel decimal(9),
	salario money not null,
	numero smallint not null,
	cep char(8) not null,
	CONSTRAINT FK_num_cep FOREIGN KEY(cep, numero) REFERENCES tbEndereco(cep, numero)
);
GO

CREATE TABLE tbProfessor (
	codProf smallint  not null
	CONSTRAINT PK_codProf PRIMARY KEY,
	idioma varchar(15),
	codFunc smallint not null
	CONSTRAINT FK_codFunc FOREIGN KEY REFERENCES tbFuncionario(codFunc)
);

GO

CREATE TABLE tbAluno(
	codAluno smallint identity(1,1) not null	
	CONSTRAINT PK_idAluno PRIMARY KEY,
	dataNasc date not null,
	nome varchar(150) not null,
	cpf decimal(11) not null,
	rg varchar(10) not null,
	periodo varchar(50) not null,
	dataMatricula date not null,
	datafinal date not null,
	telFixo decimal(10),
	telCel decimal(11),
	codTurma smallint not null
	CONSTRAINT FK_codTurma FOREIGN KEY REFERENCES tbTurma(codTurma),
	cargo varchar(25) not null,
	cep char(8) not null,
	numero smallint not null,
	CONSTRAINT FK_cep_numero FOREIGN KEY(cep, numero) REFERENCES tbEndereco(cep,numero),
);
GO

CREATE TABLE tbAulaAluno(
	codAula smallint not null 
	CONSTRAINT FK_codAulaAluno FOREIGN KEY REFERENCES tbAula(codAula),
	codAluno smallint not null
	CONSTRAINT FK_codAlunoAula FOREIGN KEY REFERENCES tbAluno(codAluno),
	CONSTRAINT PK_codAula_codAluno PRIMARY KEY(codAula, codAluno)
);

email senha codlogin