using System;
using Csla;

namespace Business {
	[Serializable]
	public class Account : BusinessBase<Account> {
		public static readonly PropertyInfo<string> NameProperty = RegisterProperty<string>(x => x.Name);

		public string Name {
			get { return GetProperty(NameProperty); }
			set { SetProperty(NameProperty, value); }
		}

		public static Account NewAccount() {
			return DataPortal.Create<Account>();
		}

		protected override void DataPortal_Create() {
			using (BypassPropertyChecks) {
				Name = "name";
			}
		}
	}
}
