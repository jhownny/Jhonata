use ti91_jhonata;

select * from tb_cursos

 -- drop procedure SP_NovoCurso;
 
delimiter |
CREATE PROCEDURE SP_NovoCurso(
_crs_nome varchar(90),
_crs_categoria varchar(30),
_crs_valor decimal(10,2),
_crs_carga_horaria int
)
BEGIN
insert into tb_cursos(crs_nome, crs_categoria, crs_valor, crs_carga_horaria, crs_ativo, crs_data_cadastro )
values(_crs_nome, _crs_categoria, _crs_valor, _crs_carga_horaria, default, default);
select * from tb_cursos where crs_codigo = (select @@identity);
end
|



delimiter |
CREATE PROCEDURE SP_AtualizarCurso(
_crs_codigo int,
_crs_nome varchar(90),
_crs_categoria varchar(50),
_crs_valor decimal(10,2),
_crs_carga_horaria int
)
BEGIN 
UPDATE tb_cursos set nome =_crs_nome, categoria = _crs_categoria, valor = _crs_valor, cargaHoraria = _crs_carga_horaria where crs_codigo = _id;
end
|