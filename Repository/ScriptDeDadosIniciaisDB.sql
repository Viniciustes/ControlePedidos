USE [ControlePedido]
GO

IF EXISTS(SELECT 1 FROM [ControlePedido].[dbo].[tb_cidade])
BEGIN
	DELETE  [ControlePedido].[dbo].[tb_cidade];
	DELETE  [ControlePedido].[dbo].[tb_endereco];
	DELETE  [ControlePedido].[dbo].[tb_cliente];
	DELETE  [ControlePedido].[dbo].[tb_produto_categoria];
	DELETE  [ControlePedido].[dbo].[tb_produto];

	DBCC CHECKIDENT ('[ControlePedido].[dbo].[tb_cidade]', RESEED, 0);
	DBCC CHECKIDENT ('[ControlePedido].[dbo].[tb_endereco]', RESEED, 0);
	DBCC CHECKIDENT ('[ControlePedido].[dbo].[tb_cliente]', RESEED, 0);
	DBCC CHECKIDENT ('[ControlePedido].[dbo].[tb_produto_categoria]', RESEED, 0);
	DBCC CHECKIDENT ('[ControlePedido].[dbo].[tb_produto]', RESEED, 0);
END

INSERT INTO [dbo].[tb_cidade]
			   ([nome]
			   ,[uf]
			   ,[ativo]
			   ,[data_cadastro])
		 VALUES
			   ('Goiânia', 'GO', 0, GETDATE()),
			   ('Brasília', 'DF', 0, GETDATE()),
			   ('São Paulo', 'SP', 0, GETDATE()),
			   ('Belo Horizonte', 'BH', 0, GETDATE()),
			   ('Rio de Janeiro', 'RJ', 0, GETDATE())

INSERT INTO [dbo].[tb_endereco]
           ([tipo_endereco]
           ,[logradouro]
           ,[bairro]
           ,[cep]
           ,[ativo]
           ,[id_cidade]
           ,[data_cadastro])
     VALUES
           (0, 'Rua Sidney Pinheiro Filho', 'Palestina', '98010610' ,0 ,1 ,GETDATE()),
		   (1, 'Rua Flor de Jardim', 'Mangabeira', '64207540' ,1 ,3 ,GETDATE()),
		   (2, 'Vila Vicente de Castro', 'Brasília Teimosa', '38401324' ,0 ,2 ,GETDATE()),
		   (2, 'Rua Barão de Mauá 1790', 'Prefeito José Walter', '35625412' ,1 ,5 ,GETDATE()),
		   (3, 'Rua C Condomínio 4 Bloco 19', 'Santa Marta', '51010060' ,0 ,4 ,GETDATE())

INSERT INTO [dbo].[tb_cliente]
           ([nome]
           ,[cpf]
           ,[ativo]
           ,[id_endereco]
           ,[data_cadastro])
     VALUES
           ('Lucas Fernando Ferreira', '11562260588', 0, 2, GETDATE()),
		   ('Luciana Luana Rezende', '57709227295', 1, 4, GETDATE()),
		   ('Lívia Mariane Eduarda Rezende', '10703187104', 1, 5, GETDATE()),
		   ('Eduardo Iago Igor Duarte', '50723265518', 0, 1, GETDATE()),
		   ('Lucca Felipe Santos', '90525771964', 1, 3, GETDATE())

INSERT INTO [dbo].[tb_produto_categoria]
           ([nome]
           ,[ativo]
           ,[data_cadastro])
     VALUES
           ('Informática', 1, GETDATE()),
		   ('Escola', 0, GETDATE()),
		   ('Limpeza', 1, GETDATE()),
		   ('Bebidas', 0, GETDATE()),
		   ('Açougue', 1, GETDATE())

INSERT INTO [dbo].[tb_produto]
           ([nome]
           ,[codigo]
           ,[preco]
           ,[ativo]
           ,[id_categoria]
           ,[data_cadastro])
     VALUES
           ('Cerveja','9653214568', 4.90, 0, 4, GETDATE()),
		   ('Caderno','3631257600', 18.90, 0, 2, GETDATE()),
		   ('Teclado','5098027608', 145.85, 0, 1, GETDATE()),
		   ('Picanha Maturada','4023258601', 87.60, 0, 5, GETDATE()),
		   ('Detergente','7435545309', 2.65, 0, 3, GETDATE())
GO