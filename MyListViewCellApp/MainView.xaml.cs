using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MyListViewCellApp
{
	public partial class MainView : TabbedPage
	{
		private ViewModel _viewModel = new ViewModel();
		public MainView ()
		{
			InitializeComponent ();
			this.BindingContext = this._viewModel;
		}

		public void MenuItemClicked(object sender, EventArgs e)
		{
			var menuItem = sender as MenuItem;
			var item = menuItem.CommandParameter as Item;

			if (menuItem.IsDestructive) {
				_viewModel.Items.Remove (item);
			} else {
				DisplayAlert ("Informações", item.Description, "Ok");
			}
		}
	}
}

