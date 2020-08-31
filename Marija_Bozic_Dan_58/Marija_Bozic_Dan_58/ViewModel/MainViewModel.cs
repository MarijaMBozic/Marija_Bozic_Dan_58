using Marija_Bozic_Dan_58.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Marija_Bozic_Dan_58.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        List<XOModel> listaXOModela = new List<XOModel>();
        List<XOModel> freeList = new List<XOModel>();
        bool isStartOfGame=true;
        bool isEndGame;

        #region Constructor
        public MainViewModel(MainWindow main)
        {
            filde_11 = new XOModel("", 11);
            filde_12 = new XOModel("", 12);
            filde_13 = new XOModel("", 13);
            filde_21 = new XOModel("", 21);
            filde_22 = new XOModel("", 22);
            filde_23 = new XOModel("", 23);
            filde_31 = new XOModel("", 31);
            filde_32 = new XOModel("", 32);
            filde_33 = new XOModel("", 33);
            listaXOModela.Add(filde_11);
            listaXOModela.Add(filde_12);
            listaXOModela.Add(filde_13);
            listaXOModela.Add(filde_21);
            listaXOModela.Add(filde_22);
            listaXOModela.Add(filde_23);
            listaXOModela.Add(filde_31);
            listaXOModela.Add(filde_32);
            listaXOModela.Add(filde_33);
        }
        #endregion

        #region Property
        private XOModel filde_11;
        public XOModel Filde_11
        {
            get
            {
                return filde_11;
            }
            set
            {
                filde_11 = value;
                OnPropertyChanged("Filde_11");
            }
        }

        private XOModel filde_12;
        public XOModel Filde_12
        {
            get
            {
                return filde_12;
            }
            set
            {
                filde_12 = value;
                OnPropertyChanged("Filde_12");
            }
        }

        private XOModel filde_13;
        public XOModel Filde_13
        {
            get
            {
                return filde_13;
            }
            set
            {
                filde_13 = value;
                OnPropertyChanged("Filde_13");
            }
        }

        private XOModel filde_21;
        public XOModel Filde_21
        {
            get
            {
                return filde_21;
            }
            set
            {
                filde_21 = value;
                OnPropertyChanged("Filde_21");
            }
        }

        private XOModel filde_22;
        public XOModel Filde_22
        {
            get
            {
                return filde_22;
            }
            set
            {
                filde_22 = value;
                OnPropertyChanged("Filde_22");
            }
        }

        private XOModel filde_23;
        public XOModel Filde_23
        {
            get
            {
                return filde_23;
            }
            set
            {
                filde_23 = value;
                OnPropertyChanged("Filde_23");
            }
        }

        private XOModel filde_31;
        public XOModel Filde_31
        {
            get
            {
                return filde_31;
            }
            set
            {
                filde_31 = value;
                OnPropertyChanged("Filde_31");
            }
        }

        private XOModel filde_32;
        public XOModel Filde_32
        {
            get
            {
                return filde_32;
            }
            set
            {
                filde_32 = value;
                OnPropertyChanged("Filde_32");
            }
        }

        private XOModel filde_33;
        public XOModel Filde_33
        {
            get
            {
                return filde_33;
            }
            set
            {
                filde_33 = value;
                OnPropertyChanged("Filde_33");
            }
        }



        #endregion

        #region Method
        /// <summary>
        /// SecectO() randomly assigns an "O" value to a free button
        /// </summary>

        public void SecectO()
        {
            freeList.Clear();
            isStartOfGame = false;
            Random rnd = new Random();
            foreach(XOModel model in listaXOModela)
            {
                if(model.ValueXY==string.Empty)
                {
                    freeList.Add(model);
                }
            }
            
            if (freeList.Count > 0 && !isEndGame)
            {
                XOModel freeModel = freeList[rnd.Next(0, freeList.Count)];
                freeModel.ValueXY = "O";
                freeModel.IsEnabled = false;                
            }
            CheckTheWinner();
        }
        /// <summary>
        /// Reset() after the game is over and there is no winner it resets the game
        /// </summary>
        public void Reset()
        {
            for (int i = 0; i < listaXOModela.Count; i++)
            {
                listaXOModela[i].ValueXY = string.Empty;
                listaXOModela[i].IsEnabled = true;
            }
            isEndGame = false;
        }

        /// <summary>
        /// DisableAll() after the player wins, disable further play
        /// </summary>
        public void DisableAll()
        {
            foreach(XOModel model in listaXOModela)
            {
                model.IsEnabled = false;
            }
        }

        /// <summary>
        /// CheckTheWinner() after entering the value, it checks if there is a winner
        /// </summary>

        public void CheckTheWinner()
        {
            foreach (XOModel model in listaXOModela)
            {
                if (filde_11.ValueXY != string.Empty && filde_12.ValueXY == filde_11.ValueXY && filde_13.ValueXY == filde_11.ValueXY)
                {
                    if (filde_11.ValueXY == "X")
                    {
                        MessageBox.Show("Your are the winner!");
                        isEndGame = true;
                        DisableAll();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Computer are the winner!");
                        isEndGame = true;
                        DisableAll();
                        break;
                    }
                }
                else if (filde_11.ValueXY != string.Empty && filde_21.ValueXY == filde_11.ValueXY && filde_31.ValueXY == filde_11.ValueXY)
                {
                    if (filde_11.ValueXY == "X")
                    {
                        MessageBox.Show("Your are the winner!");
                        isEndGame = true;
                        DisableAll();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Computer are the winner!");
                        isEndGame = true;
                        DisableAll();
                        break;
                    }
                }
                else if (filde_11.ValueXY != string.Empty && filde_22.ValueXY == filde_11.ValueXY && filde_33.ValueXY == filde_11.ValueXY)
                {
                    if (filde_11.ValueXY == "X")
                    {
                        MessageBox.Show("Your are the winner!");
                        isEndGame = true;
                        DisableAll();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Computer are the winner!");
                        isEndGame = true;
                        DisableAll();
                        
                        break;
                    }
                }
                else if (filde_21.ValueXY != string.Empty && filde_22.ValueXY == filde_21.ValueXY && filde_23.ValueXY == filde_21.ValueXY)
                {
                    if (filde_21.ValueXY == "X")
                    {
                        MessageBox.Show("Your are the winner!");
                        isEndGame = true;
                        DisableAll();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Computer are the winner!");
                        isEndGame = true;
                        DisableAll();
                        break;
                    }
                }
                else if (filde_31.ValueXY != string.Empty && filde_32.ValueXY == filde_31.ValueXY && filde_33.ValueXY == filde_31.ValueXY)
                {
                    if (filde_31.ValueXY == "X")
                    {
                        MessageBox.Show("Your are the winner!");
                        isEndGame = true;
                        DisableAll();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Computer are the winner!");
                        isEndGame = true;
                        DisableAll();
                        break;
                    }
                }
                else if (filde_12.ValueXY != string.Empty && filde_22.ValueXY == filde_12.ValueXY && filde_32.ValueXY == filde_12.ValueXY)
                {
                    if (filde_12.ValueXY == "X")
                    {
                        MessageBox.Show("Your are the winner!");
                        isEndGame = true;
                        DisableAll();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Computer are the winner!");
                        isEndGame = true;
                        DisableAll();
                        break;
                    }
                }
                else if (filde_13.ValueXY != string.Empty && filde_33.ValueXY == filde_13.ValueXY && filde_23.ValueXY == filde_13.ValueXY)
                {
                    if (filde_13.ValueXY == "X")
                    {
                        MessageBox.Show("Your are the winner!");
                        isEndGame = true;
                        DisableAll();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Computer are the winner!");
                        isEndGame = true;
                        DisableAll();
                        break;
                    }
                }
                else if (filde_31.ValueXY != string.Empty && filde_22.ValueXY == filde_31.ValueXY && filde_13.ValueXY == filde_31.ValueXY)
                {
                    if (filde_31.ValueXY == "X")
                    {
                        MessageBox.Show("Your are the winner!");
                        isEndGame = true;
                        DisableAll();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Computer are the winner!");
                        isEndGame = true;
                        DisableAll();
                        break;
                    }
                }
                else
                {
                    if(freeList.Count==0 && !isEndGame && !isStartOfGame)
                    {
                        Reset();
                        break;
                    }
                    
                }
            }
        }
    #endregion

    }
}
