SELECT
	Nome + ', Cor: ' + Cor + ' - ' + Genero NomeProdutoCompleto, -- Concatenando colunas
	UPPER(Nome) Nome, -- Transformando a coluna em letras maiúsculas
	LOWER(Cor) Cor -- Transformando a coluna em letras minúsculas
FROM Produtos