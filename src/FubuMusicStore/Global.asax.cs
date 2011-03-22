﻿using System;
using System.Web.Routing;
using FubuFastPack.Persistence;
using FubuFastPack.StructureMap;
using FubuMVC.Core;

namespace FubuMusicStore
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            FubuApplication.For<FubuMusicStoreRegistry>()
                .ContainerFacility(() =>
                                       {
                                           var container = DatabaseDriver.BootstrapContainer();

                                           return new TransactionalStructureMapContainerFacility(container);
                                       })
                .Packages(x => x.Assembly(typeof (IRepository).Assembly))
                .Bootstrap(RouteTable.Routes);

            HibernatingRhinos.Profiler.Appender.NHibernate.NHibernateProfiler.Initialize();
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}