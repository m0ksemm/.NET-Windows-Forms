using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Barley_break_WPF
{
    internal class GamePresenter
    {
        private readonly IModel _model;
        private readonly IBarleyBreakView _view;
        public GamePresenter(IModel model, IBarleyBreakView view) 
        {
            _model = model;
            _view = view;
            _view.MooveEvent += new EventHandler<EventArgs>(Moove);
            _view.RestartEvent += new EventHandler<EventArgs>(Restart);
            _view.Field = _model.Field;

            IfWin();
        }
        private void Restart(object sender, EventArgs e) 
        {
            try
            {
                int k = 0;
                int[,] arr = new int[4, 4];
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(0); j++)
                        arr[i, j] = ++k;
                }

                for (int index = 0; index < 1000; index++)
                {
                    bool key = true;
                    while (key)
                    {
                        int i = 0, j = 0;
                        for (int _i = 0; _i < arr.GetLength(0); _i++)
                        {
                            for (int _j = 0; _j < arr.GetLength(0); _j++)
                            {
                                if (arr[_i, _j] == 16)
                                {
                                    i = _i;
                                    j = _j;
                                    break;
                                }
                            }
                        }

                        Random rnd = new Random();
                        int _case = rnd.Next(0, 4);

                        int tmp;
                        switch (_case)
                        {
                            case 0:
                                if (i - 1 >= 0)
                                {
                                    tmp = arr[i - 1, j];
                                    arr[i - 1, j] = arr[i, j];
                                    arr[i, j] = tmp;
                                }
                                key = false;
                                break;
                            case 1:
                                if (j - 1 >= 0)
                                {
                                    tmp = arr[i, j - 1];
                                    arr[i, j - 1] = arr[i, j];
                                    arr[i, j] = tmp;
                                }
                                key = false;
                                break;
                            case 2:
                                if (i + 1 < 4)
                                {
                                    tmp = arr[i + 1, j];
                                    arr[i + 1, j] = arr[i, j];
                                    arr[i, j] = tmp;
                                }
                                key = false;
                                break;
                            case 3:
                                if (j + 1 < 4)
                                {
                                    tmp = arr[i, j + 1];
                                    arr[i, j + 1] = arr[i, j];
                                    arr[i, j] = tmp;
                                }
                                key = false;
                                break;
                        }
                    }
                }

                _model.Field = arr;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            UpdateView();
            IfWin();
        }
        private void Moove(object sender, EventArgs e) 
        {
            try 
            {
                int[,] arr = _view.Field;

                if (_view.X == 3 && _view.Y == 2) 
                {
                    if (arr[3, 3] == 16) 
                    {
                        arr[3, 3] = arr[_view.X, _view.Y];
                        arr[_view.X, _view.Y] = 16;
                    }
                    else if (arr[3, 1] == 16)
                    {
                        arr[3, 1] = arr[_view.X, _view.Y];
                        arr[_view.X, _view.Y] = 16;
                    }
                    else if (arr[2, 2] == 16)
                    {
                        arr[2, 2] = arr[_view.X, _view.Y];
                        arr[_view.X, _view.Y] = 16;
                    }
                }
                else if (_view.X == 3 && _view.Y == 3) 
                {
                    if (arr[3, 2] == 16)
                    {
                        arr[3, 2] = arr[_view.X, _view.Y];
                        arr[_view.X, _view.Y] = 16;
                    }
                    else if (arr[2, 3] == 16) 
                    {
                        arr[2, 3] = arr[_view.X, _view.Y];
                        arr[_view.X, _view.Y] = 16;
                    } 
                }
                else if (_view.X == 2 && _view.Y == 3)
                {
                    if (arr[3, 3] == 16)
                    {
                        arr[3, 3] = arr[_view.X, _view.Y];
                        arr[_view.X, _view.Y] = 16;
                    }
                    else if (arr[2, 2] == 16) 
                    {
                        arr[2, 2] = arr[_view.X, _view.Y];
                        arr[_view.X, _view.Y] = 16;
                    }
                    else if (arr[1, 3] == 16)
                    {
                        arr[1, 3] = arr[_view.X, _view.Y];
                        arr[_view.X, _view.Y] = 16;
                    }
                }
                else if (_view.X == 3 && _view.Y == 1)
                {
                    if (arr[3, 2] == 16)
                    {
                        arr[3, 2] = arr[_view.X, _view.Y];
                        arr[_view.X, _view.Y] = 16;
                    }
                    else if (arr[3, 0] == 16)
                    {
                        arr[3, 0] = arr[_view.X, _view.Y];
                        arr[_view.X, _view.Y] = 16;
                    }
                    else if (arr[2, 1] == 16)
                    {
                        arr[2, 1] = arr[_view.X, _view.Y];
                        arr[_view.X, _view.Y] = 16;
                    }
                }
                else if (_view.X == 3 && _view.Y == 0)
                {
                    if (arr[3, 1] == 16)
                    {
                        arr[3, 1] = arr[_view.X, _view.Y];
                        arr[_view.X, _view.Y] = 16;
                    }
                    else if (arr[2, 0] == 16)
                    {
                        arr[2, 0] = arr[_view.X, _view.Y];
                        arr[_view.X, _view.Y] = 16;
                    }
                }
                else if (_view.X == 2 && _view.Y == 2)
                {
                    if (arr[3, 2] == 16)
                    {
                        arr[3, 2] = arr[_view.X, _view.Y];
                        arr[_view.X, _view.Y] = 16;
                    }
                    else if (arr[2, 1] == 16)
                    {
                        arr[2, 1] = arr[_view.X, _view.Y];
                        arr[_view.X, _view.Y] = 16;
                    }
                    else if (arr[2, 3] == 16)
                    {
                        arr[2, 3] = arr[_view.X, _view.Y];
                        arr[_view.X, _view.Y] = 16;
                    }
                    else if (arr[1, 2] == 16)
                    {
                        arr[1, 2] = arr[_view.X, _view.Y];
                        arr[_view.X, _view.Y] = 16;
                    }
                }
                else if (_view.X == 2 && _view.Y == 1) 
                {
                    if (arr[3, 1] == 16)
                    {
                        arr[3, 1] = arr[_view.X, _view.Y];
                        arr[_view.X, _view.Y] = 16;
                    }
                    else if (arr[2, 0] == 16)
                    {
                        arr[2, 0] = arr[_view.X, _view.Y];
                        arr[_view.X, _view.Y] = 16;
                    }
                    else if (arr[2, 2] == 16)
                    {
                        arr[2, 2] = arr[_view.X, _view.Y];
                        arr[_view.X, _view.Y] = 16;
                    }
                    else if (arr[1, 1] == 16)
                    {
                        arr[1, 1] = arr[_view.X, _view.Y];
                        arr[_view.X, _view.Y] = 16;
                    }
                }
                else if (_view.X == 2 && _view.Y == 0)
                {
                    if (arr[3, 0] == 16)
                    {
                        arr[3, 0] = arr[_view.X, _view.Y];
                        arr[_view.X, _view.Y] = 16;
                    }
                    else if (arr[2, 1] == 16)
                    {
                        arr[2, 1] = arr[_view.X, _view.Y];
                        arr[_view.X, _view.Y] = 16;
                    }
                    else if (arr[1, 0] == 16)
                    {
                        arr[1, 0] = arr[_view.X, _view.Y];
                        arr[_view.X, _view.Y] = 16;
                    }
                }
                else if (_view.X == 1 && _view.Y == 3) 
                {
                    if (arr[2, 3] == 16)
                    {
                        arr[2, 3] = arr[_view.X, _view.Y];
                        arr[_view.X, _view.Y] = 16;
                    }
                    else if (arr[0, 3] == 16)
                    {
                        arr[0, 3] = arr[_view.X, _view.Y];
                        arr[_view.X, _view.Y] = 16;
                    }
                    else if (arr[1, 2] == 16)
                    {
                        arr[1, 2] = arr[_view.X, _view.Y];
                        arr[_view.X, _view.Y] = 16;
                    }
                }
                else if (_view.X == 1 && _view.Y == 2)
                {
                    if (arr[2, 2] == 16)
                    {
                        arr[2, 2] = arr[_view.X, _view.Y];
                        arr[_view.X, _view.Y] = 16;
                    }
                    else if (arr[0, 2] == 16)
                    {
                        arr[0, 2] = arr[_view.X, _view.Y];
                        arr[_view.X, _view.Y] = 16;
                    }
                    else if (arr[1, 1] == 16)
                    {
                        arr[1, 1] = arr[_view.X, _view.Y];
                        arr[_view.X, _view.Y] = 16;
                    }
                    else if (arr[1, 3] == 16)
                    {
                        arr[1, 3] = arr[_view.X, _view.Y];
                        arr[_view.X, _view.Y] = 16;
                    }
                }
                else if (_view.X == 1 && _view.Y == 1)
                {
                    if (arr[2, 1] == 16)
                    {
                        arr[2, 1] = arr[_view.X, _view.Y];
                        arr[_view.X, _view.Y] = 16;
                    }
                    else if (arr[0, 1] == 16)
                    {
                        arr[0, 1] = arr[_view.X, _view.Y];
                        arr[_view.X, _view.Y] = 16;
                    }
                    else if (arr[1, 0] == 16)
                    {
                        arr[1, 0] = arr[_view.X, _view.Y];
                        arr[_view.X, _view.Y] = 16;
                    }
                    else if (arr[1, 2] == 16)
                    {
                        arr[1, 2] = arr[_view.X, _view.Y];
                        arr[_view.X, _view.Y] = 16;
                    }
                }
                else if (_view.X == 1 && _view.Y == 0)
                {
                    if (arr[2, 0] == 16)
                    {
                        arr[2, 0] = arr[_view.X, _view.Y];
                        arr[_view.X, _view.Y] = 16;
                    }
                    else if (arr[0, 0] == 16)
                    {
                        arr[0, 0] = arr[_view.X, _view.Y];
                        arr[_view.X, _view.Y] = 16;
                    }
                    else if (arr[1, 1] == 16)
                    {
                        arr[1, 1] = arr[_view.X, _view.Y];
                        arr[_view.X, _view.Y] = 16;
                    }
                }
                else if (_view.X == 0 && _view.Y == 3) 
                {
                    if (arr[0, 2] == 16)
                    {
                        arr[0, 2] = arr[_view.X, _view.Y];
                        arr[_view.X, _view.Y] = 16;
                    }
                    else if (arr[1, 3] == 16)
                    {
                        arr[1, 3] = arr[_view.X, _view.Y];
                        arr[_view.X, _view.Y] = 16;
                    }
                }
                else if (_view.X == 0 && _view.Y == 2)
                {
                    if (arr[0, 1] == 16)
                    {
                        arr[0, 1] = arr[_view.X, _view.Y];
                        arr[_view.X, _view.Y] = 16;
                    }
                    else if (arr[1, 2] == 16)
                    {
                        arr[1, 2] = arr[_view.X, _view.Y];
                        arr[_view.X, _view.Y] = 16;
                    }
                    else if (arr[0, 3] == 16)
                    {
                        arr[0, 3] = arr[_view.X, _view.Y];
                        arr[_view.X, _view.Y] = 16;
                    }
                }
                else if (_view.X == 0 && _view.Y == 1)
                {
                    if (arr[0, 0] == 16)
                    {
                        arr[0, 0] = arr[_view.X, _view.Y];
                        arr[_view.X, _view.Y] = 16;
                    }
                    else if (arr[1, 1] == 16)
                    {
                        arr[1, 1] = arr[_view.X, _view.Y];
                        arr[_view.X, _view.Y] = 16;
                    }
                    else if (arr[0, 2] == 16)
                    {
                        arr[0, 2] = arr[_view.X, _view.Y];
                        arr[_view.X, _view.Y] = 16;
                    }
                }
                else if (_view.X == 0 && _view.Y == 0)
                {
                    if (arr[1, 0] == 16)
                    {
                        arr[1, 0] = arr[_view.X, _view.Y];
                        arr[_view.X, _view.Y] = 16;
                    }
                    else if (arr[0, 1] == 16)
                    {
                        arr[0, 1] = arr[_view.X, _view.Y];
                        arr[_view.X, _view.Y] = 16;
                    }
                }
                _model.Field= arr;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            UpdateView();
            IfWin();
        }
        private void UpdateView() 
        {
            _view.Field = _model.Field; 
        }

        private void IfWin()  
        {
            int count = 0;
            int number = 1;
            int[] arr = new int[16];
            int k = 0;

            for (int i = 0; i < _model.Field.GetLength(0); i++)
            {
                for (int j = 0; j < _model.Field.GetLength(0); j++)
                {
                    arr[k++] = _model.Field[i, j];
                }
            }
            for (int i = 0; i < 15; i++) 
            {
                if (arr[i] == number++) 
                {
                    count++;
                }
            }
            _view.Progress = count;
        }
    }
}
