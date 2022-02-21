using eProdaja.Model;
using eProdaja.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eProdaja.MobileApp.ViewModels
{
    public class ProizvodiViewModel : BaseViewModel
    {
        private readonly APIService _proizvodiService = new APIService("Proizvodi");
        private readonly APIService _vrsteProizvodaService = new APIService("VrsteProizvodum");

        public ProizvodiViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public ObservableCollection<Model.Proizvodi> ProizvodiList { get; set; } = new ObservableCollection<Model.Proizvodi>();
        public ObservableCollection<Model.VrsteProizvodum> VrsteProizvodaList { get; set; } = new ObservableCollection<Model.VrsteProizvodum>();

        VrsteProizvodum _selectedVrsteProizvoda = null;
        public VrsteProizvodum SelectedVrstaProizvoda
        {
            get { return _selectedVrsteProizvoda; }
            set 
            { 
                SetProperty(ref _selectedVrsteProizvoda, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }
            }
        }

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            if (VrsteProizvodaList.Count == 0)
            {
                var vrsteProizvodaList = await _vrsteProizvodaService.Get<List<VrsteProizvodum>>(null);

                foreach (var vrsteProizvoda in vrsteProizvodaList)
                {
                    VrsteProizvodaList.Add(vrsteProizvoda);
                }
            }

            if (SelectedVrstaProizvoda != null)
            {
                ProizvodSearchRequest search = new ProizvodSearchRequest();
                search.VrstaId = SelectedVrstaProizvoda.VrstaId;
                var list = await _proizvodiService.Get<IEnumerable<Proizvodi>>(search);

                ProizvodiList.Clear();
                foreach (var proizvod in list)
                {
                    ProizvodiList.Add(proizvod);
                }
            }

        }
    }
}
