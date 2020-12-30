using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileToDo
{
	[DesignTimeVisible(true)]
	public class MainViewModel : INotifyPropertyChanged
	{

		public MainViewModel()
		{
			_text = "";
			_lableText = "";
			_tasks = new ObservableCollection<Task>();
		}

		private string _text;
		private string _lableText;
		private ObservableCollection<Task> _tasks;
		
		public ObservableCollection<Task> Tasks
		{
			get => _tasks;
			set
			{
				_tasks = value;
				OnPropertyChanged(nameof(Tasks));
			}
		}

		public string LabelText
		{
			get => _lableText;
			set
			{
				_lableText = value;
				OnPropertyChanged(nameof(LabelText));
			}
		}

		public string Text
		{
			get => _text;
			set
			{
				_text = value;
				OnPropertyChanged(nameof(Text));
			}
		}
		
		private ICommand _buttonCommand;
		private ICommand _changechekCommand;
		
		public ICommand ButtonCommand => _buttonCommand ?? (_buttonCommand = new RelayCommand(ButtonCommandExe));
		public ICommand ChangechekCommand => _changechekCommand ?? (_changechekCommand = new RelayCommand(ChangechekCommandExe));


		
		private void ButtonCommandExe()
		{
			Task T = new Task();
			T.TextTask = Text;
			T.Id = Tasks.Count;
			Tasks.Add(T);
			Text = "";
		}
		private void ChangechekCommandExe()
		{
			throw new NotImplementedException();
		}

		
		public event PropertyChangedEventHandler PropertyChanged;
		private void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged == null)
				return;
			PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
