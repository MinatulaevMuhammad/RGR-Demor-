using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using ReactiveUI;
using System.Reactive.Linq;
using RGR_Demor_.Models;

namespace RGR_Demor_.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            CreateTabs();
            CreateGrid();
            CreateRequests();
            Content = Fv = new FirstViewModel(this);
            Sv = new SecondViewModel(this);
        }

        public FirstViewModel Fv { get; }
        public SecondViewModel Sv { get; }

        public void Change()
        {
            if (Content == Fv)
                Content = Sv;
            else if (Content == Sv)
                Content = Fv;
        }

        ViewModelBase content;
        public ViewModelBase Content
        {
            get { return content; }
            set { this.RaiseAndSetIfChanged(ref content, value); }
        }

        ObservableCollection<Tabs> tab;
        public ObservableCollection<Tabs> Tab
        {
            get { return tab; }
            set { this.RaiseAndSetIfChanged(ref tab, value); }
        }
        private void CreateTabs()
        {
            Tab = new ObservableCollection<Tabs>();
            Tab.Add(new Tabs("Horse", false));
            Tab.Add(new Tabs("Coach", false));
            Tab.Add(new Tabs("Owner", false));
            Tab.Add(new Tabs("Race", false));
            Tab.Add(new Tabs("Jockey", false));
            Tab.Add(new Tabs("Hippodrome", false));
            Tab.Add(new Tabs("Request 1", false));
            Tab.Add(new Tabs("Request 2", false));
        }

        ObservableCollection<Tabs> request;
        public ObservableCollection<Tabs> Request
        {
            get { return request; }
            set { this.RaiseAndSetIfChanged(ref request, value); }
        }

        private void CreateRequests()
        {
            Request = new ObservableCollection<Tabs>();
            Request.Add(new Tabs("Request 1", true));
            Request.Add(new Tabs("Request 2", true));
        }

        ObservableCollection<Grids> grid;
        public ObservableCollection<Grids> Grid
        {
            get { return grid; }
            set { this.RaiseAndSetIfChanged(ref grid, value); }
        }
        private void CreateGrid()
        {
            Grid = new ObservableCollection<Grids>();
            Grid.Add(new Grids("Life Is Good", "Colt", "$1,755,000"));
            Grid.Add(new Grids("Zandon", "Filly", "$913,500"));
            Grid.Add(new Grids("Epicenter", "Gelding", "$1,480,000"));
            Grid.Add(new Grids("Rich Strike", "Colt", "$1,932,500"));
            Grid.Add(new Grids("Secret Oath", "Filly", "$1,130,250"));

        }
    }
}