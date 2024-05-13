-- Neste caso, será realizado agrupamento e a contagem dos dados. A ordem dos comandos é muito importante, senão terá erros.
SELECT 
	[Tamanho], 
	COUNT(*) Quantidade 
FROM [Produtos]
WHERE [Tamanho] <> '' -- Significado, onde [Tamanho] seja <diferente> de 'vazio'
GROUP BY [Tamanho] -- Agrupamento dos dados
ORDER BY Quantidade DESC

SELECT * FROM [Clientes]

CREATE TABLE [Enderecos] (
	[Id] INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[IdCliente] INT NULL,
	[Rua] VARCHAR(255) NULL,
	[Bairro] VARCHAR(255) NULL,
	[Cidade] VARCHAR(255) NULL,
	[Estado] CHAR(2) NULL,

	CONSTRAINT FK_Enderecos_Clientes FOREIGN KEY(IdCliente) 
	REFERENCES Clientes([Id])
)

ALTER TABLE [Clientes]
	ADD CONSTRAINT PK_Clientes PRIMARY KEY([Id])