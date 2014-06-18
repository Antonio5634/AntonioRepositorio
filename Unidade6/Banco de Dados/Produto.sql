CREATE TABLE [dbo].[Pedido]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Data_Pedido] NCHAR(10) NULL, 
    [Quantidade] NCHAR(10) NULL, 
    [Produto_id] NCHAR(10) NULL, 
    [Cliente_id] NCHAR(10) NULL
	PRIMARY KEY CLUSTERED ([id] ASC),
	CONSTRAINT [FK_Pedido_Clienteid] FOREIGN KEY ([cliente_id]) REFERENCES [dbo].[cliente] ([id]) 
)
