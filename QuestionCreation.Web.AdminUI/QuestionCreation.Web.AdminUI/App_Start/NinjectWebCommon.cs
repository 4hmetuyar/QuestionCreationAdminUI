[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(QuestionCreation.Web.AdminUI.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(QuestionCreation.Web.AdminUI.App_Start.NinjectWebCommon), "Stop")]

namespace QuestionCreation.Web.AdminUI.App_Start
{
    using Microsoft.Web.Infrastructure.DynamicModuleHelper;
    using Ninject;
    using Ninject.Web.Common;
    using Ninject.Web.Common.WebHost;
    using Business.IService;
    using Business.Service;
    using Repository.IRepository;
    using Repository.Repository;
    using System;
    using System.Data.Entity;
    using System.Web;

    public static class NinjectWebCommon
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start()
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }

        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }

        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<DbContext>().ToConstructor(_ => new DbContext("DataContext"));
            kernel.Bind<IAnswerService>().To<AnswerService>(); 
            kernel.Bind<IQuestionService>().To<QuestionService>(); 
            kernel.Bind<IQuizService>().To<QuizService>(); 
            kernel.Bind<IUserService>().To<UserService>(); 


            kernel.Bind<IAnswerRepository>().To<AnswerRepository>(); 
            kernel.Bind<IQuestionRepository>().To<QuestionRepository>(); 
            kernel.Bind<IQuizRepository>().To<QuizRepository>(); 
            kernel.Bind<IUserRepository>().To<UserRepository>(); 

         }
    }
}