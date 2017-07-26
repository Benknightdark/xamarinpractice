using System;
using System.ComponentModel;

namespace practiceapp
{
    public class info : INotifyPropertyChanged
    {
        public info(){
            //_name = "test";
            Name = "test";
        }
            
        public string Name{
            get { return this._name; }
            set{
                if(this._name!=value){
                    this._name = value;
                    this.PropertyChanged?.DynamicInvoke(this, new PropertyChangedEventArgs(nameof(this.Name)));
                }
            }
        }
        private string _name;
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
