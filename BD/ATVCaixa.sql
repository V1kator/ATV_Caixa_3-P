CREATE DATABASE ATVCaixa;
USE ATVCaixa;

create table tb_Clientes(
id_cliente int not null PRIMARY key AUTO_INCREMENT,
nome VARCHAR(255),
cpf VARCHAR(20),
email VARCHAR(255),
telefone VARCHAR(255),
data_nacimento DATETIME
);

create table tb_Vendas(
id_venda INT not null PRIMARY key AUTO_INCREMENT,
data_venda DATE,
valor_total DOUBLE,
desconto DOUBLE,
valor_final DOUBLE,
tipo VARCHAR(255),
fk_cliente INT,
FOREIGN KEY(fk_cliente) REFERENCES tb_Clientes(id_cliente)
);

create table tb_Servicos(
id_servico int not null PRIMARY key AUTO_INCREMENT,
valor DOUBLE,
descricao varchar(255),
tempo FLOAT
);

create table tb_Vendas_Servicos(
id_venda_servico int PRIMARY key AUTO_INCREMENT,
valor_unitario DOUBLE,
quantidade INT,
fk_venda int not null,
fk_servico int not null,
FOREIGN KEY(fk_venda) REFERENCES tb_Vendas(id_venda) on DELETE CASCADE,
FOREIGN KEY(fk_servico) REFERENCES tb_Servicos(id_servico)
);

create table tb_Funcionarios(
id_funcionario int not null PRIMARY key AUTO_INCREMENT,
nome VARCHAR(255),
cpf VARCHAR(20)
);

create table tb_Caixas(
id_caixa int not null PRIMARY key AUTO_INCREMENT,
saldo_inicial DOUBLE,
total_entradas DOUBLE,
total_saidas DOUBLE,
status_caixa VARCHAR(255),
saldo_final DOUBLE,
fk_funcionario int not null,
FOREIGN KEY (fk_funcionario) REFERENCES tb_Funcionarios(id_funcionario) on DELETE CASCADE
);

create table tb_Recebimentos(
id_recebimento int not null PRIMARY key AUTO_INCREMENT,
valor DOUBLE,
data_vencimento DATETIME,
data_pagamento DATETIME,
status_recebimento VARCHAR(255),
fk_venda int,
FOREIGN KEY (fk_venda) REFERENCES tb_Vendas(id_venda),
fk_caixa int not null,
FOREIGN KEY (fk_caixa) REFERENCES tb_Caixas(id_caixa)
);

create table tb_Dispositivos(
id_dispositivo int not null PRIMARY key AUTO_INCREMENT,
aliquota DOUBLE,
descricao VARCHAR(255),
status_recebimento VARCHAR(255)
);

create table tb_Encargo(
id_encargo int not null PRIMARY key AUTO_INCREMENT,
valor DOUBLE,
descricao VARCHAR(255),
fk_recebimento int not null,
FOREIGN KEY (fk_recebimento) REFERENCES tb_Recebimentos(id_recebimento) ON DELETE CASCADE,
fk_dispositivo int not null,
FOREIGN KEY (fk_dispositivo) REFERENCES tb_Dispositivos(id_dispositivo)
);

create table tb_Fornecedores(
id_fornecedor int not null PRIMARY key AUTO_INCREMENT,
razao_social varchar(255),
nome varchar(255),
cnpj varchar (255),
ativo varchar (255),
atividade_economica varchar(255),
telefone varchar(20),
email varchar(255)
);

create table tb_Despesa(
id_despesa int not null PRIMARY key AUTO_INCREMENT,
valor DOUBLE,
data_vencimento DATETIME,
data_pagamento DATETIME,
status_despesa VARCHAR(255),
fk_caixa int not null,
fk_fornecedor int not null,
FOREIGN KEY (fk_caixa) REFERENCES tb_Caixas(id_caixa),
FOREIGN KEY (fk_fornecedor) REFERENCES tb_Fornecedores(id_fornecedor)
);


-- Inserindo dados na tabela tb_Funcionario
INSERT INTO tb_Funcionarios (nome, cpf) VALUES
('Carlos Lima', '123.321.456-00'),
('Fernanda Gomes', '456.654.789-00'),
('Rafael Torres', '789.987.123-00');

-- Inserindo dados na tabela tb_Cliente
INSERT INTO tb_Clientes (nome, cpf, email, telefone, data_nacimento) VALUES
('João Silva', '123.456.789-00', 'joao.silva@example.com', '(11) 1234-5678', '1985-04-12'),
('Maria Oliveira', '987.654.321-00', 'maria.oliveira@example.com', '(21) 8765-4321', '1990-07-15'),
('Pedro Santos', '456.789.123-00', 'pedro.santos@example.com', '(31) 1357-2468', '1975-11-22');

-- Inserindo dados na tabela tb_Vendas (3 com cliente e 2 sem cliente)
INSERT INTO tb_Vendas (data_venda, valor_total, desconto, valor_final, tipo, fk_cliente) VALUES
('2024-08-01', 100, 10, 90, 'A', 1),
('2024-08-02', 200.00, 20.00, 180.00, 'B', 2),
('2024-08-04', 250.00, 25.00, 225.00, 'B', NULL);

INSERT INTO tb_Fornecedores(razao_social, nome, cnpj, ativo, atividade_economica, telefone, email) VALUES
("Fornecedora de Energia Energiza LTDA", "Energiza", "12.345.678/0001-01", "Ativo", "Fornecedora de Energia", "(12)34567-8910", "Energiza@gmail.com"),
("Fornecedora de Água Caerde LTDA", "Caerde", "12.345.678/0001-02", "Ativo", "Fornecedora de Água", "(12)34567-8911", "Caerd@gmail.com");
