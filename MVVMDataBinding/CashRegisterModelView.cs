using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using CashRegister;

namespace MVVMDataBinding
{
    public class CashRegisterModelView: INotifyPropertyChanged
    {
        /// <summary>
        /// Event that notifies when properties change
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// CashDrawer Object
        /// </summary>
        CashDrawer drawer = new CashDrawer();

        /// <summary>
        /// The total current value of the drawer
        /// </summary>
        double TotalValue => drawer.TotalValue;

        /// <summary>
        /// Gets or sets the number of pennies in the cash register
        /// </summary>
        public int Pennies
        {
            get => drawer.Pennies;

            set
            {
                if (drawer.Pennies == value || value < 0) return;
                var quantity = value - drawer.Pennies;
                if (quantity > 0)
                {
                    drawer.AddCoin(Coins.Penny, quantity);
                }
                else
                {
                    drawer.RemoveCoin(Coins.Penny, -quantity);
                }
                InvokePropertyChanged("Pennies");
            }
        }
        /// <summary>
        /// Gets or sets the number of pennies in the cash register
        /// </summary>
        public int Nickels
        {
            get => drawer.Nickels;

            set
            {
                if (drawer.Nickels == value || value < 0) return;
                var quantity = value - drawer.Nickels;
                if (quantity > 0)
                {
                    drawer.AddCoin(Coins.Nickel, quantity);
                }
                else
                {
                    drawer.RemoveCoin(Coins.Nickel, -quantity);
                }
                InvokePropertyChanged("Nickels");
            }
        }

        /// <summary>
        /// Gets or sets the number of pennies in the cash register
        /// </summary>
        public int Dimes
        {
            get => drawer.Dimes;

            set
            {
                if (drawer.Dimes == value || value < 0) return;
                var quantity = value - drawer.Dimes;
                if (quantity > 0)
                {
                    drawer.AddCoin(Coins.Dime, quantity);
                }
                else
                {
                    drawer.RemoveCoin(Coins.Dime, -quantity);
                }
                InvokePropertyChanged("Dimes");
            }
        }

        /// <summary>
        /// Gets or sets the number of pennies in the cash register
        /// </summary>
        public int Quarters
        {
            get => drawer.Quarters;

            set
            {
                if (drawer.Quarters == value || value < 0) return;
                var quantity = value - drawer.Quarters;
                if (quantity > 0)
                {
                    drawer.AddCoin(Coins.Quarter, quantity);
                }
                else
                {
                    drawer.RemoveCoin(Coins.Quarter, -quantity);
                }
                InvokePropertyChanged("Pennies");
            }
        }

        /// <summary>
        /// Gets or sets the number of Fiftys in the cash register
        /// </summary>
        public int Ones
        {
            get => drawer.Ones;

            set
            {
                if (drawer.Ones == value || value < 0) return;
                var quantity = value - drawer.Ones;
                if (quantity > 0)
                {
                    drawer.AddBill(Bills.One, quantity);
                }
                else
                {
                    drawer.RemoveBill(Bills.One, -quantity);
                }
                InvokePropertyChanged("Ones");
            }
        }

        /// <summary>
        /// Gets or sets the number of Fiftys in the cash register
        /// </summary>
        public int Twos
        {
            get => drawer.Twos;

            set
            {
                if (drawer.Twos == value || value < 0) return;
                var quantity = value - drawer.Twos;
                if (quantity > 0)
                {
                    drawer.AddBill(Bills.Two, quantity);
                }
                else
                {
                    drawer.RemoveBill(Bills.Two, -quantity);
                }
                InvokePropertyChanged("Twos");
            }
        }

        /// <summary>
        /// Gets or sets the number of Fiftys in the cash register
        /// </summary>
        public int Fives
        {
            get => drawer.Fives;

            set
            {
                if (drawer.Fives == value || value < 0) return;
                var quantity = value - drawer.Fives;
                if (quantity > 0)
                {
                    drawer.AddBill(Bills.Five, quantity);
                }
                else
                {
                    drawer.RemoveBill(Bills.Five, -quantity);
                }
                InvokePropertyChanged("Fives");
            }
        }

        /// <summary>
        /// Gets or sets the number of Fiftys in the cash register
        /// </summary>
        public int Tens
        {
            get => drawer.Tens;

            set
            {
                if (drawer.Tens == value || value < 0) return;
                var quantity = value - drawer.Tens;
                if (quantity > 0)
                {
                    drawer.AddBill(Bills.Ten, quantity);
                }
                else
                {
                    drawer.RemoveBill(Bills.Ten, -quantity);
                }
                InvokePropertyChanged("Tens");
            }
        }


        /// <summary>
        /// Gets or sets the number of pennies in the cash register
        /// </summary>
        public int Twenties
        {
            get => drawer.Twenties;

            set
            {
                if (drawer.Twenties == value || value < 0) return;
                var quantity = value - drawer.Twenties;
                if (quantity > 0)
                {
                    drawer.AddBill(Bills.Twenty, quantity);
                }
                else
                {
                    drawer.RemoveBill(Bills.Twenty, -quantity);
                }
                InvokePropertyChanged("Twenties");
            }
        }

        /// <summary>
        /// Gets or sets the number of Fiftys in the cash register
        /// </summary>
        public int Fiftys
        {
            get => drawer.Fifties;

            set
            {
                if (drawer.Fifties == value || value < 0) return;
                var quantity = value - drawer.Fifties;
                if (quantity > 0)
                {
                    drawer.AddBill(Bills.Fifty, quantity);
                }
                else
                {
                    drawer.RemoveBill(Bills.Fifty, -quantity);
                }
                InvokePropertyChanged("Fiftys");
            }
        }

        /// <summary>
        /// Gets or sets the number of Fiftys in the cash register
        /// </summary>
        public int Hundreds
        {
            get => drawer.Hundreds;

            set
            {
                if (drawer.Hundreds == value || value < 0) return;
                var quantity = value - drawer.Hundreds;
                if (quantity > 0)
                {
                    drawer.AddBill(Bills.Hundred, quantity);
                }
                else
                {
                    drawer.RemoveBill(Bills.Hundred, -quantity);
                }
                InvokePropertyChanged("Hundreds");
            }
        }

        /// <summary>
        /// Invokes the PropertyChanged event for denomination properties
        /// and the TotalValue
        /// </summary>
        /// <param name="denomination">The property that is changing</param>
        void InvokePropertyChanged(string denomination)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(denomination));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalValue"));
        }
    }
}
