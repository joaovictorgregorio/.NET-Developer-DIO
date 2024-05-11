SELECT * FROM Produtos

-- COUNT retorna a contagem de linhas da tabela, muito utilizado, pois os dados ser�o milhares no dia a dia.
-- QuantidadeProdutos est� nomeando a informa��o que estou buscando.
SELECT COUNT(*) QuantidadeProdutos FROM Produtos

SELECT COUNT(*) QuantidadeProdutosTamanhoM FROM Produtos WHERE Tamanho = 'M'

-- Soma os valores, funciona apenas para tipos n�mericos.
SELECT SUM(Preco) PrecoTotal FROM Produtos WHERE Tamanho = 'M'

SELECT MAX(Preco) ProdutoMaisCaroTamanhoP FROM Produtos WHERE Tamanho = 'G'
SELECT MIN(Preco) ProdutoMaisBaratoTamanhoP FROM Produtos WHERE Tamanho = 'G'
SELECT AVG(Preco) MediaValoresProdutos FROM Produtos