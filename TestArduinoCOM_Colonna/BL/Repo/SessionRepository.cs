using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestArduinoCOM.BL.Db;

namespace TestArduinoCOM.BL
{
	public class SessionRepository
	{
		//AppDbContext appDb = new AppDbContext("Data Source = data.db");

		string db_connectionString = "Data Source = data.db";

		IContextFactory _factory;

		public SessionRepository(IContextFactory f)
		{
			_factory = f;
		}

		public Session Create(string name)
		{
			Session res = new Session { Name = name };

			using (var db = _factory.Create(db_connectionString))
			{
				db.Entry(res).State = System.Data.Entity.EntityState.Added;
				db.SaveChanges();
			}

			//res = Load(res.Id);

			return res;
		}

		public void Init()
		{
			using (var db = _factory.Create(db_connectionString))
			{
				db.Sessions.FirstOrDefault();
			}
		}

		public IEnumerable<Session> GetAll()
		{
			using (var db = _factory.Create(db_connectionString))
			{
				IList<Session> res = db.Sessions.ToList();
				return res;
			}
		}

		public Session Load(int id)
		{
			using (var db = _factory.Create(db_connectionString))
			{
				return db.Sessions.Include("GPoints").FirstOrDefault(sesion => sesion.Id == id);
			}
		}

		object locker = new object();

		public void SaveGPoint(GPoint p)
		{
			Action a = () =>
			{
				lock (locker)
				{
					using (var db = _factory.Create(db_connectionString))
					{
						db.Entry(p).State = p.Id == 0 ? System.Data.Entity.EntityState.Added : System.Data.Entity.EntityState.Modified;
						db.SaveChanges();
					}
				}
			};
			
			Task.Run(a);
		}

		public void SaveGPointRange(IEnumerable<GPoint> c)
		{
			Action a = () =>
			{
				lock (locker)
				{
					using (var db = _factory.Create(db_connectionString))
					{
						foreach (var item in c)
						{
							db.Entry(item).State = item.Id == 0 ? System.Data.Entity.EntityState.Added : System.Data.Entity.EntityState.Modified;
						}

						db.SaveChanges();
					}
				}
			};

			Task.Run(a);
		}
	}
}
