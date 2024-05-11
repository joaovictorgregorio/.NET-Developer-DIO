CREATE TABLE Produtos (
	-- IDENTITY significa que o campo ser� alto incrementado pelo sistema 1 a 1.
	-- PRIMARY KEY garante que o ID ser� �nico.
	Id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	-- Tamanho m�ximo de 255 caracteres
	Nome varchar(255) NOT NULL,
	Cor varchar(50) NULL,
	-- DECIMAL recebe at� 13 d�gitos e ter� 2 casas decimais
	Preco decimal(13, 2) NOT NULL,
	Tamanho varchar(5) NULL,
	-- NOT NULL para campos obrigat�rios, n�o pode estar vazio e NULL para campos opcionais pode estar vazio.
	Genero char(1) NULL
)

SELECT * FROM Produtos