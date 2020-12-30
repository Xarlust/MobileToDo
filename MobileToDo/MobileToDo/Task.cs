using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using Xamarin.Forms;


namespace MobileToDo
{
	public class Task
	{
		public Task()
		{
			_id = 0;
			_check = false;
			_textTask = "";
		}
		private int _id;
		private bool _check;
		private string _textTask;

		public int Id
		{
			get => _id;
			set
			{
				_id = value;
				OnPropertyChanged(nameof(Id));
			}
		}

		public bool Check
		{
			get => _check;
			set
			{
				_check = value;
				OnPropertyChanged(nameof(Check));
			}
		}

		public string TextTask
		{
			get => _textTask;
			set
			{
				_textTask = value;
				OnPropertyChanged(nameof(TextTask));
			}
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