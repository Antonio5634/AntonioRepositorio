-- questao 1
--questao 2
--SELECT A.Nome, C.Curso from TBAluno as A inner join TBCurso as C on A.TBCurso_id = C.Id order by Curso
SELECT A.Nome, C.Nome_curso from TBAluno as A inner join TBCurso as C on A.TBCurso_id = C.id Order By TBMatricula
-- questao 3
select Email from TBAluno where DataNascimento >  '01/01/1995' 
-- questao 4
select count(*) from  TBAluno
-- questao 5
-- questao 6
select Nome from TBAluno where DataNascimento <= '01/01/1996'
-- questao 7
select Nome from TBAluno where Sexo = 'F'
-- questao 8
-- questao 9
select Nome from TBCurso order by Nome
-- questao 10
