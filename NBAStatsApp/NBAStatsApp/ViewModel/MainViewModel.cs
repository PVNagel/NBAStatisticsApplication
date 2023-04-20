using NBAStatsApp.Model;
using NBAStatsApp.Model.Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NBAStatsApp.ViewModel
{
    public class MainViewModel
    {
        private PlayerRepo playerRepo = new PlayerRepo();

        public ObservableCollection<PlayerViewModel> PlayersVM { get; set; } = new();
        private PlayerViewModel playerViewModel;
        public MainViewModel()
        {
            playerRepo.PlayerAPI();
            foreach (Player player in playerRepo.GetAll())
            {
                PlayerViewModel playerVM = new(player);
                PlayersVM.Add(playerVM);
            }
        }
    }
}
