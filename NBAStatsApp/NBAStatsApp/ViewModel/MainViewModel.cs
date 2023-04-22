using NBAStatsApp.Model;
using NBAStatsApp.Model.Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NBAStatsApp.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private PlayerRepo playerRepo = new PlayerRepo();

        public ObservableCollection<PlayerViewModel> PlayersVM { get; set; } = new();

        private PlayerViewModel playerViewModel;
        public PlayerViewModel SelectedPlayerVM
        {
            get { return playerViewModel; }
            set 
            { 
                playerViewModel = value; 
                OnPropertyChanged("SelectedPlayerVM"); 
            }
        }

        public MainViewModel()
        {
            playerRepo.PlayerAPI();
            //playerRepo.TestAPI();
            foreach (Player player in playerRepo.GetAll())
            {
                PlayerViewModel playerVM = new(player);
                PlayersVM.Add(playerVM);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}