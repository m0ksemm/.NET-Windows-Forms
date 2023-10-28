using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barley_break_WPF
{
    internal class Model : IModel
    {
        public int[,] field = new int[4,4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16} };
        public Model() 
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
                Field = arr;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int[,] Field
        {
            get
            {
                int[,] newField = new int[field.GetLength(0), field.GetLength(1)];
                for (int i = 0; i < field.GetLength(0); i++)
                {
                    for (int j = 0; j < field.GetLength(1); j++)
                    {
                        newField[i, j] = field[i, j];
                    }
                }
                return newField;
            }
            set
            {
                for (int i = 0; i < field.GetLength(0); i++)
                {
                    for (int j = 0; j < field.GetLength(1); j++)
                    {
                        field[i, j] = value[i, j];
                    }
                }
            }
        }
    }
}
