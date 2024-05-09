-- Selecionando colunas especificas da tabela (Clientes).
-- SELECT Nome, Sobrenome, Email, DataCadastro FROM Clientes

-- Selecionando todos os dados da tabela (Clientes).
-- SELECT * FROM Clientes

-- Filtrando a busca por alguma característica especifica
-- WHERE Nome = 'Ken' AND Sobrenome = 'Reynolds'

-- Consulta o (Nome) inciado com a letra K e a % ignora o que vem adiante dos nomes selecionados. 
-- A % também pode ser usada antes %K% selecionando todos os nomes com a letra K
-- WHERE Nome LIKE 'K%'

-- Ordenando (Nome) em ordem crescente
-- ORDER BY Nome, Sobrenome

-- Insert demonstrando as colunas da tabela
-- INSERT INTO Clientes (Nome, Sobrenome, Email, AceitaComunicados, DataCadastro)
-- VALUES ('Joao Victor', 'Gregorio', 'joaodasilva@gmail.com', 1, GETDATE()) -- GETDATE() função que retorna a hora e a data atual

-- Insert omitindo as colunas da tabela, apenas a informações que serão adicionadas
-- INSERT INTO Clientes VALUES ('Maria', 'Soares', 'mariasoares@hotmail.com', 0, GETDATE())

SELECT * FROM Clientes

-- Teste para possível erro
BEGIN TRAN
-- Retorna o estado anterior dos dados
ROLLBACK

-- Exclusão de registros da tabela
DELETE Clientes
WHERE Nome = 'Ken' AND Email = 'email@email.com'

-- Atualiza informações da tabela, sempre usar este comando com o WHERE junto direcionando para o ID, o SET atribui o novo valor
-- UPDATE Clientes
-- SET Email = 'kensanchez@yahoo.com',
	-- AceitaComunicados = 1,
	-- DataCadastro = GETDATE()