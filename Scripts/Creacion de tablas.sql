CREATE TABLE Transacciones (
	id INT IDENTITY PRIMARY KEY,
	Fecha_Operacion DATE,
	Fecha_Valor DATE,
	Concepto VARCHAR(300),
	Categoria VARCHAR(100),
	Importe DECIMAL(10,2),
	Saldo DECIMAL(10, 2),
	Divisa VARCHAR(5)
)