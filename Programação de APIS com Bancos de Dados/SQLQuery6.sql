SELECT * FROM [Clientes] WHERE Id = 4
SELECT * FROM [Enderecos] WHERE IdCliente = 4

-- Inserindo dados na tabela [Enderecos]
INSERT INTO [Enderecos] VALUES(4, 'Rua Teste', 'Bairro teste', 'Cidade teste', 'SP')

-- Junta as informações das duas tabelas, neste caso, [Clientes] e [Enderecos]
SELECT 
	C.Id,
	C.Nome,
	C.Sobrenome,
	C.AceitaComunicados, -- Refinando a busca
	E.Rua,
	E.Bairro,
	E.Cidade,
	E.Estado
FROM [Clientes] C 
INNER JOIN [Enderecos] E  -- Apelidando o nome das tabelas [C] e [E], serve apenas para o SELECT, com querys grandes o uso se torna recomendado.
ON C.Id = E.IdCliente 
WHERE C.Id = 4