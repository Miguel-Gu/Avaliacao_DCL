CREATE DATABASE DCL_QUESTAO2;
GO

USE DCL_QUESTAO2;
GO

CREATE TABLE PRODUTO (
  IDPRODUTO SMALLINT PRIMARY KEY IDENTITY,
  NOME_PROD VARCHAR(200) UNIQUE,
  PRC_PROD MONEY NOT NULL
  );
GO

CREATE TABLE CORES (
  IDCOR SMALLINT PRIMARY KEY IDENTITY,
  NOME_COR VARCHAR(200) UNIQUE NOT NULL,
  PRC_COR MONEY NOT NULL,
  IDPRODUTO SMALLINT FOREIGN KEY REFERENCES PRODUTO(IDPRODUTO) NOT NULL
  );
GO

INSERT INTO PRODUTO (NOME_PROD, PRC_PROD)
VALUES ('Monitor LCD Samsung 740N', '750.00'),
	   ('Mouse Microsoft', '40.00'),
	   ('Notebook Sony Vaio', '11320.34'),
	   (NULL, '392.99');
GO

INSERT INTO CORES (NOME_COR, PRC_COR, IDPRODUTO)
VALUES ('Preto', '5.00', '1'),
	   ('Azul', '10.00', '1'),
	   ('Amarelo', '20.00', '2'),
	   ('Chumbo', '3.00', '4');
GO

SELECT * FROM PRODUTO;

SELECT * FROM CORES;

SELECT NOME_PROD [Nome do Produto], PRC_PROD + ISNULL(PRC_COR,0) [Pre?o do Produto], (PRC_PROD + ISNULL(PRC_COR,0))*1.1 [Pre?o do Produto + 10%], (PRC_PROD + ISNULL(PRC_COR,0))*0.9 [Pre?o do Produto - 10%], NOME_COR [Cor do Produto] FROM PRODUTO
LEFT JOIN CORES
ON PRODUTO.IDPRODUTO = CORES.IDPRODUTO
WHERE NOME_PROD IS NOT NULL
ORDER BY PRC_PROD