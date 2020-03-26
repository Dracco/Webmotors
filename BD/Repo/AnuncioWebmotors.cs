using System.Collections.Generic;
using System.Linq;

namespace BD.Repo
{
    public class AnuncioWebmotors
    {
        public List<Models.AnuncioWebmotors> Consultar()
        {
            using (var db = new MainContextFactory().CreateDbContext(null))
            {
                return db.tb_AnuncioWebmotors.ToList();
            }
        }
        public Models.AnuncioWebmotors Consultar(int id)
        {
            using (var db = new MainContextFactory().CreateDbContext(null))
            {
                return db.tb_AnuncioWebmotors.Where(x => x.ID == id).FirstOrDefault();
            }
        }
        public void Incluir(Models.AnuncioWebmotors car)
        {
            using (var db = new MainContextFactory().CreateDbContext(null))
            {
                db.tb_AnuncioWebmotors.Add(car);
                db.SaveChanges();
            }
        }
        public void Atualizar(Models.AnuncioWebmotors car)
        {
            using (var db = new MainContextFactory().CreateDbContext(null))
            {
                db.tb_AnuncioWebmotors.Update(car);
                db.SaveChanges();
            }
        }
        public void Remover(Models.AnuncioWebmotors car)
        {
            using (var db = new MainContextFactory().CreateDbContext(null))
            {
                db.tb_AnuncioWebmotors.Remove(car);
                db.SaveChanges();
            }
        }
    }
}
