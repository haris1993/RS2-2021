using eProdaja.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eProdaja.MobileApp.ViewModels
{
    public class ProizvodiViewModel
    {
        private readonly APIService _proizvodiService = new APIService("Proizvodi");

        public ProizvodiViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public ObservableCollection<Model.Proizvodi> ProizvodiList { get; set; } = new ObservableCollection<Model.Proizvodi>();

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            var list = await _proizvodiService.Get<IEnumerable<Proizvodi>>(null);

            ProizvodiList.Clear();
            foreach (var proizvod in list)
            {
                ProizvodiList.Add(proizvod);
            }
        }
    }
}
