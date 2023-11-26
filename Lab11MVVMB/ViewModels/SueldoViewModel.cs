using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Lab11MVVMB.ViewModels
{
    public class SueldoViewModel : ViewModelBase
    {
        int sueldo;
        public int Sueldo 
        {
            get { return sueldo; } 
            set { 
                if(sueldo != value)
                {
                    sueldo = value;
                    OnPropertyChanged();
                }
            }
        }

        int gratificacion;
        public int Gratificacion
        {
            get { return gratificacion; }
            set
            {
                if (gratificacion != value)
                {
                    gratificacion = value;
                    OnPropertyChanged();
                }
            }
        }

        int descuento;
        public int Descuento
        {
            get { return descuento; }
            set
            {
                if (descuento != value)
                {
                    descuento = value;
                    OnPropertyChanged();
                }
            }
        }

        int sueldoneto;
        public int SueldoNeto
        {
            get { return sueldoneto; }
            set
            {
                if (sueldoneto != value)
                {
                    sueldoneto = value;
                    OnPropertyChanged();
                }
            }
        }

        double impuesto;
        public double Impuesto
        {
            get { return impuesto; }
            set
            {
                if (impuesto != value)
                {
                    impuesto = value;
                    OnPropertyChanged();
                }
            }
        }

        int sueldodescuento;
        public int SueldoDescuento
        {
            get { return sueldodescuento; }
            set
            {
                if(sueldodescuento != value)
                {
                    sueldodescuento = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand CalcularSueldoNeto { protected set; get; }
        public ICommand CalcularDescuento { protected set; get; }
        public ICommand CalcularImpuesto { protected set; get; }

        public SueldoViewModel() 
        {
            CalcularSueldoNeto = new Command (() =>
            {
                SueldoNeto = Sueldo + Gratificacion;
            });
            CalcularDescuento = new Command(() =>
            {
                SueldoDescuento = SueldoNeto - descuento;
            });
            CalcularImpuesto = new Command(() =>
            {
                Impuesto = SueldoNeto * 0.18;
            });
        }
        
    }
}
