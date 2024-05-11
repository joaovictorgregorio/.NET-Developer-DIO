SELECT * FROM Produtos

-- COUNT retorna a contagem de linhas da tabela, muito utilizado, pois os dados serão milhares no dia a dia.
-- QuantidadeProdutos está nomeando a informação que estou buscando.
SELECT COUNT(*) QuantidadeProdutos FROM Produtos

SELECT COUNT(*) QuantidadeProdutosTamanhoM FROM Produtos WHERE Tamanho = 'M'

-- Soma os valores, funciona apenas para tipos númericos.
SELECT SUM(Preco) PrecoTotal FROM Produtos WHERE Tamanho = 'M'

SELECT MAX(Preco) ProdutoMaisCaroTamanhoP FROM Produtos WHERE Tamanho = 'G'
SELECT MIN(Preco) ProdutoMaisBaratoTamanhoP FROM Produtos WHERE Tamanho = 'G'
SELECT AVG(Preco) MediaValoresProdutos FROM Produtos