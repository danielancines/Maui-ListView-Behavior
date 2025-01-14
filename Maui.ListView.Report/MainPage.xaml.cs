﻿using System.Collections.ObjectModel;
using System.Diagnostics;

namespace Maui.ListView.Report;

public partial class MainPage : ContentPage
{
	public ObservableCollection<Person> People { get; set; } = new ObservableCollection<Person>();

	public MainPage()
	{
		InitializeComponent();
		this.BindingContext = this;

        this.Loaded += MainPage_Loaded;
	}

    private void MainPage_Loaded(object sender, EventArgs e)
    {
		this.People.Add(new Person() { Name = "First", IsSelected = true });
        this.People.Add(new Person() { Name = "Second", IsSelected = false });
    }

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
		this.MyLabel.Text = this.People.FirstOrDefault(p => p.IsSelected).Name;
		
    }
}

public class Person
{
	public string Name { get; set; }
	public bool IsSelected { get; set; }
}

public class MyRadioButton : RadioButton
{
	public MyRadioButton()
	{
		Debug.WriteLine($"Im Alive {this.GetHashCode()}");
	}
}


