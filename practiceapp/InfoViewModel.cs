using System;
using System.Collections.Generic;

using System.ComponentModel;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;

namespace practiceapp
{
	public class InfoViewModel : INotifyPropertyChanged
	{
		public InfoViewModel()
		{
            this.GenderList = new List<GenderViewModel>(){
                new GenderViewModel(){Gender=Gender.Boy,DisPlayName="Boy"},
                new GenderViewModel(){Gender=Gender.Girl,DisPlayName="Girl"}
            };
            OnSaveInfo = new Command(() => { this.Bonus = 100;this.Name = "fdsfasdfasd1111"; },()=> { return true; });
		}

		public string Name
		{
            get { return this._model.Name; }
			set
			{
				if (this._model.Name != value)
				{
					this._model.Name = value;
					this.PropertyChanged?.DynamicInvoke(this, new PropertyChangedEventArgs(nameof(this.Name)));
				}
			}
		}
        public IEnumerable<GenderViewModel>GenderList{
            get;
        }
        public int GenderIndex{
            get {
               // return 0;
                return this.GenderList.ToList().FindIndex(a=>a.Gender==this._model.Gender);
            //  return   int.Parse(this.GenderList.Where(a => a.Gender == this._model.Gender)
              // .FirstOrDefault().Gender.ToString());

            }
            set{
                this._model.Gender = this.GenderList.ElementAt(value).Gender;
				this.PropertyChanged?.DynamicInvoke(this, new PropertyChangedEventArgs(nameof(this.GenderIndex)));

			}
           
        }
        public int Bonus{
            get { return this._model.Bonus; }
            set{
                this._model.Bonus = value;

			this.PropertyChanged?.DynamicInvoke(this, new PropertyChangedEventArgs(nameof(this.Bonus)));
                this.PropertyChanged?.DynamicInvoke(this, new PropertyChangedEventArgs(nameof(this.IsBonusGreaterZero)));
			}
        }
        public bool IsBonusGreaterZero{
            get {
                return this._model.Bonus > 0;
            }
        }
        public ICommand OnSaveInfo { get; private set; } 
        //private string _name;
        private InfoModel _model = new InfoModel();
		public event PropertyChangedEventHandler PropertyChanged;
	}
}
