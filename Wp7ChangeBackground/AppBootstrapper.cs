namespace Wp7ChangeBackground
{
	using System;
	using System.Collections.Generic;
	using Caliburn.Micro;

  public class Wp7ChangeBackground : PhoneBootstrapper {
    PhoneContainer container;

    protected override void Configure() {
      container = new PhoneContainer(RootFrame);

      container.RegisterPhoneServices();
      container.PerRequest<MainPageViewModel>();

      AddCustomConventions();
    }

    static void AddCustomConventions() {
      //ellided  
    }

    protected override object GetInstance(Type service, string key) {
      return container.GetInstance(service, key);
    }

    protected override IEnumerable<object> GetAllInstances(Type service) {
      return container.GetAllInstances(service);
    }

    protected override void BuildUp(object instance) {
      container.BuildUp(instance);
    }
  }
}
