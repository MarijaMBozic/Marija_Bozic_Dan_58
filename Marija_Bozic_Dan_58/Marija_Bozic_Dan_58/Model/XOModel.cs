using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marija_Bozic_Dan_58.Model
{
    public class XOModel:INotifyPropertyChanged
    {
        public int XY { get; set; }
        public bool isEnabeled=true;
        public bool IsEnabled
        {
            get
            {
                return isEnabeled;
            }
            set
            {
                isEnabeled = value;
                OnPropertyChanged("IsEnabled");
            }
        }
        public string valueXY;
        public string ValueXY
        {
            get
            {
                return valueXY;
            }
            set
            {
                valueXY = value;
                OnPropertyChanged("ValueXY");
            }        
        }

        public XOModel(string val, int xy)
        {
            this.XY = xy;
            this.ValueXY = val;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
