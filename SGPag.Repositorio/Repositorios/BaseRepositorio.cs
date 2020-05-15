using SGPag.Dominio.Contratos;
using SGPag.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SGPag.Repositorio.Repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {
        protected readonly SGPagContexto SGPagContexto;

        public BaseRepositorio(SGPagContexto sGPagContexto)
        {
            SGPagContexto = sGPagContexto;
        }
        public void Adicionar(TEntity entity)
        {
            SGPagContexto.Set<TEntity>().Add(entity);
            SGPagContexto.SaveChanges();
        }
        public void Atualizar(TEntity entity)
        {
            SGPagContexto.Set<TEntity>().Update(entity);
            SGPagContexto.SaveChanges();
        }
        public TEntity ObterPorId(int id)
        {
            return SGPagContexto.Set<TEntity>().Find(id);
        }
        public IEnumerable<TEntity> ObterTodos()
        {
            return SGPagContexto.Set<TEntity>().ToList() ;
        }
        public void Remover(TEntity entity)
        {
            SGPagContexto.Remove(entity);
            SGPagContexto.SaveChanges();
        }
        public void Dispose()
        {
            SGPagContexto.Dispose();
        }
    }
}
