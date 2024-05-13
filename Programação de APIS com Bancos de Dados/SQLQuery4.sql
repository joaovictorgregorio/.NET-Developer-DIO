SELECT
	[Nome] + ', Cor: ' + [Cor] + ' - ' + [Genero] NomeProdutoCompleto, -- Concatenando colunas
	UPPER(Nome) Nome, -- Transformando a coluna em letras maiúsculas
	LOWER(Cor) Cor, -- Transformando a coluna em letras minúsculas
	FORMAT(DataCadastro, 'dd/MM/yyyy HH:mm') Data -- Apresenta o formato da data de uma maneira diferente do convencional
FROM [Produtos]

SELECT * FROM [Produtos]

-- Adicionando uma nova coluna a tabela
ALTER TABLE [Produtos]
	ADD DataCadastro DATETIME2

-- Excluindo uma coluna completa da tebela
ALTER TABLE [Produtos]
	DROP COLUMN DataCadastro

-- Atribuindo data atual para a coluna DataCadastro
UPDATE [Produtos] SET DataCadastro = GETDATE()