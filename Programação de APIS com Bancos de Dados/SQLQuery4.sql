SELECT
	Nome + ', Cor: ' + Cor + ' - ' + Genero NomeProdutoCompleto, -- Concatenando colunas
	UPPER(Nome) Nome, -- Transformando a coluna em letras mai�sculas
	LOWER(Cor) Cor -- Transformando a coluna em letras min�sculas
FROM Produtos