﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebFormsMvp;
using WebFormsMvp.Binder;

namespace Techrepo.Web.PresenterFactories
{
    public class WebFormsMvpPresenterFactory:IPresenterFactory
    {
        private readonly ICustomPresenterFactory presenterFactory;

        public WebFormsMvpPresenterFactory(ICustomPresenterFactory presenterFactory)
        {
            if (presenterFactory == null)
            {
                throw new ArgumentNullException(nameof(presenterFactory));
            }

            this.presenterFactory = presenterFactory;
        }

        public IPresenter Create(Type presenterType, Type viewType, IView viewInstance)
        {
            return this.presenterFactory.GetPresenter(presenterType, viewInstance);
        }

        public void Release(IPresenter presenter)
        {
            if (presenter is IDisposable)
            {
                (presenter as IDisposable).Dispose();
            }
        }
    }
}