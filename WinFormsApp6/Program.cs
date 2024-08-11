using Model.BL;
using Model.DAL;
using Model.Domain;
using Ninject;
using Ninject.Modules;
using Presenter;
using Shared;
using System.Configuration;
using System.Collections.Specialized;
using System.Xml.Linq;

namespace WinFormsApp
{
	internal static class Program
	{
		[STAThread]
		static void Main()
		{
			ApplicationConfiguration.Initialize();
			IKernel ninjectKernel = new StandardKernel(new SimpleConfigModule());
			MainPresenter presenter = ninjectKernel.Get<MainPresenter>();


			//Application.Run(new Form1());
		}
	}

	class SimpleConfigModule : NinjectModule
	{
		public override void Load()
		{
			string? repo = ConfigurationManager.AppSettings.Get("Repository");
			switch (repo)
			{
				case "SQLite":
					Bind<IRepository<Employee>>().To<SQLiteRepository<Employee>>().InSingletonScope();
					break;
				case "Dapper":
					Bind<IRepository<Employee>>().To<DapperRepository<Employee>>().InSingletonScope();
					break;
				default:
					Bind<IRepository<Employee>>().To<FakeRepository<Employee>>().InSingletonScope();
					break;
			};
			Bind<IMainView>().To<Form1>().InSingletonScope();
			Bind<IMainModel>().To<MainModel>().InSingletonScope();
		}
	}
}