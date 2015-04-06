using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace MyListViewCellApp
{
	public class ViewModel
	{
		public ObservableCollection<Item> Items {
			get;
			set;
		}

		public ViewModel ()
		{
			this.Items = new ObservableCollection<Item> ();
			this.Items.Add (new Item { 
				Title = "Corinthians", 
				Description = "Sport Club Corinthians Paulista", 
				Image = "http://goo.gl/ntfGXQ",
				Selected = true
			});
			this.Items.Add (new Item { 
				Title = "São Paulo", 
				Description = "São Paulo Futebol Clube", 
				Image = "http://goo.gl/Gi0oUC",
				Selected = false
			});
			this.Items.Add (new Item { 
				Title = "Santos", 
				Description = "Santos Futebol Clube", 
				Image = "http://goo.gl/TEvVBT",
				Selected = true
			});
			this.Items.Add (new Item { 
				Title = "Portuguesa", 
				Description = "Associação Portuguesa de Desportos", 
				Image = "http://goo.gl/jZX9mk",
				Selected = false
			});
		}
	}

	public class Item : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		string title;
		public string Title {
			get {
				return title;
			}
			set {
				title = value;
				this.Notify ("Title");
			}
		}

		string description;
		public string Description {
			get {
				return description;
			}
			set {
				description = value;
				this.Notify ("Description");
			}
		}

		string image;
		public string Image {
			get {
				return image;
			}
			set {
				image = value;
				this.Notify ("Image");
			}
		}

		bool selected;
		public bool Selected {
			get {
				return selected;
			}
			set {
				selected = value;
				this.Notify ("Selected");
			}
		}

		public override string ToString ()
		{
			return this.Title;
		}

		private void Notify(string propertyName)
		{
			if(this.PropertyChanged != null)
				this.PropertyChanged (this, new PropertyChangedEventArgs (propertyName));
		}
	}
}