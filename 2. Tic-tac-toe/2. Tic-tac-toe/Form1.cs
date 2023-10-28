namespace _2._Tic_tac_toe
{
    public partial class Form1 : Form
    {
        private int[,] field = new int[3,3];  // Массив для данных игрового поля. 
        private int hardness;                 // Уровень ложности
        private int p;                        // Переменная для значения стороны, за которую играет пользователб
        private int c;                        // Переменная ..... за которую играет компьютер
        public Form1()
        {
            InitializeComponent();
            p = 1;
            c = 2;
             
            Text = "Tic-tac-toe";
            button10.Text = "Restart";
            hardness = 1; 
            checkBox1.Text = "Computer acts first";
        }

        private void SetPictures()  // Устанавливает картинки в соответствии со значением поля.
        {                   // |0 - ничего не ставит 1| - ставит крестик| 2 - ставит нолик|
            //button1
            if (field[0, 0] == 1)
                button1.Image = Image.FromFile("tic.png");
            else if (field[0, 0] == 2)
                button1.Image = Image.FromFile("tac.png");
            //button2
            if (field[0, 1] == 1)
                button2.Image = Image.FromFile("tic.png");
            else if (field[0, 1] == 2)
                button2.Image = Image.FromFile("tac.png");
            //button3
            if (field[0, 2] == 1)
                button3.Image = Image.FromFile("tic.png");
            else if (field[0, 2] == 2)
                button3.Image = Image.FromFile("tac.png");
            //button4
            if (field[1, 0] == 1)
                button4.Image = Image.FromFile("tic.png");
            else if (field[1, 0] == 2)
                button4.Image = Image.FromFile("tac.png");
            //button5
            if (field[1, 1] == 1)
                button5.Image = Image.FromFile("tic.png");
            else if (field[1, 1] == 2)
                button5.Image = Image.FromFile("tac.png");
            //button6
            if (field[1, 2] == 1)
                button6.Image = Image.FromFile("tic.png");
            else if (field[1, 2] == 2)
                button6.Image = Image.FromFile("tac.png");
            //button7
            if (field[2, 0] == 1)
                button7.Image = Image.FromFile("tic.png");
            else if (field[2, 0] == 2)
                button7.Image = Image.FromFile("tac.png");
            //button8
            if (field[2, 1] == 1)
                button8.Image = Image.FromFile("tic.png");
            else if (field[2, 1] == 2)
                button8.Image = Image.FromFile("tac.png");
            //button9
            if (field[2, 2] == 1)
                button9.Image = Image.FromFile("tic.png");
            else if (field[2, 2] == 2)
                button9.Image = Image.FromFile("tac.png");
        }

        private bool IsPlace()  // Проверка, есть ли ещё на поле места, в которых можно походить. 
        {
            int n = 0;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++) 
                {
                    if (field[i,j] != 0)
                        n++;
                }
            if (n == 9)
                return false;
            else return true;
        }
        private void CompAct(int h, int turn)   // Метод для совершения хода компьютером 
        {
            // Минимальная сложность. Компьютер делает ходы рандомно. 
            if (h == 1)   
            {
                while (true)
                {
                    Random rnd = new Random();
                    int x = rnd.Next(0, 3);
                    int y = rnd.Next(0, 3);
                    if (field[x, y] == 0)
                    {
                        field[x, y] = turn;
                        break;
                    }
                }
            }

            // Средняя сложность. Компьютер будет мешать Вам выиграть.
            if (h == 2)    // MEDIUM
            {
                while (true)
                {
                    if (turn == 1)
                    {    
                        if (field[0,0] == 2 && field[0, 1] == 2 && field[0, 2] == 0)  // 1oox
                        {
                            field[0, 2] = turn;
                            break;
                        }
                        else if (field[0, 0] == 2 && field[0, 2] == 2 && field[0, 1] == 0) // 1oxo
                        {
                            field[0, 1] = turn;
                            break;
                        }
                        else if (field[0, 1] == 2 && field[0, 2] == 2 && field[0, 0] == 0) // 1xoo
                        {
                            field[0, 0] = turn;
                            break;
                        }////////////////////////////////////
                        else if (field[1, 0] == 2 && field[1, 1] == 2 && field[1, 2] == 0) // 2oox
                        {
                            field[1, 2] = turn;
                            break;
                        }
                        else if (field[1, 0] == 2 && field[1, 2] == 2 && field[1, 1] == 0) // 2oxo
                        {
                            field[1, 1] = turn;
                            break;
                        }
                        else if (field[1, 1] == 2 && field[1, 2] == 2 && field[1, 0] == 0) // 2xoo
                        {
                            field[1, 0] = turn;
                            break;
                        }////////////////////////////////////
                        else if (field[2, 0] == 2 && field[2, 1] == 2 && field[2, 2] == 0)  // 3oox
                        {
                            field[2, 2] = turn;
                            break;
                        }
                        else if (field[2, 0] == 2 && field[2, 2] == 2 && field[2, 1] == 0) // 3oxo
                        {
                            field[2, 1] = turn;
                            break;
                        }
                        else if (field[2, 1] == 2 && field[2, 2] == 2 && field[2, 1] == 0) // 3xoo
                        {
                            field[2, 1] = turn;
                            break;
                        }////////////////////////////////////////////////////////
                        else if (field[0, 0] == 2 && field[1, 0] == 2 && field[2, 0] == 0)  // 1o
                        {                                                                   //  o
                            field[2, 0] = turn;                                             //  x
                            break;
                        }
                        else if (field[0, 0] == 2 && field[2, 0] == 2 && field[1, 0] == 0)  // 1o
                        {                                                                   //  x
                            field[1, 0] = turn;                                             //  o
                            break;
                        }
                        else if (field[1, 0] == 2 && field[2, 0] == 2 && field[0, 0] == 0)  // 1x
                        {                                                                   //  o
                            field[0, 0] = turn;                                             //  o
                            break;
                        }////////////////////////////////////
                        else if (field[0, 1] == 2 && field[1, 1] == 2 && field[2, 1] == 0)  // 2o
                        {                                                                   //  o
                            field[2, 1] = turn;                                             //  x
                            break;
                        }
                        else if (field[0, 1] == 2 && field[2, 1] == 2 && field[1, 1] == 0)  // 2o
                        {                                                                   //  x
                            field[1, 1] = turn;                                             //  o
                            break;
                        }
                        else if (field[1, 1] == 2 && field[2, 1] == 2 && field[0, 1] == 0)  // 2x
                        {                                                                   //  o
                            field[0, 1] = turn;                                             //  o
                            break;
                        }////////////////////////////////////
                        else if (field[0, 2] == 2 && field[1, 2] == 2 && field[2, 2] == 0)  // 3o
                        {                                                                   //  o
                            field[2, 2] = turn;                                             //  x
                            break;
                        }
                        else if (field[0, 2] == 2 && field[2, 2] == 2 && field[1, 2] == 0)  // 3o
                        {                                                                   //  x
                            field[1, 2] = turn;                                             //  o
                            break;
                        }
                        else if (field[1, 2] == 2 && field[2, 2] == 2 && field[0, 1] == 0)  // 3x
                        {                                                                   //  o
                            field[0, 1] = turn;                                             //  o
                            break;
                        }/////////////////////////////////////////////////////////////////////
                        else if (field[0, 0] == 2 && field[1, 1] == 2 && field[2, 2] == 0)  // o
                        {                                                                   //   o
                            field[2, 2] = turn;                                             //     x
                            break;
                        }
                        else if (field[0, 0] == 2 && field[2, 2] == 2 && field[1, 1] == 0)  // o
                        {                                                                   //   x
                            field[1, 1] = turn;                                             //     o
                            break;
                        }
                        else if (field[1, 1] == 2 && field[2, 2] == 2 && field[0, 0] == 0)  // x
                        {                                                                   //   o
                            field[0, 0] = turn;                                             //     o
                            break;
                        }//////////////////////////////////////////////////////
                        else if (field[2, 0] == 2 && field[1, 1] == 2 && field[0, 2] == 0)  //     x
                        {                                                                   //   o
                            field[0, 2] = turn;                                             // o
                            break;
                        }
                        else if (field[2, 0] == 2 && field[0, 2] == 2 && field[1, 1] == 0)  //     o
                        {                                                                   //   x
                            field[1, 1] = turn;                                             // o
                            break;
                        }
                        else if (field[1, 1] == 2 && field[0, 2] == 2 && field[2, 0] == 0)  //     o
                        {                                                                   //   o
                            field[2, 0] = turn;                                             // x
                            break;
                        }/////////////////////////////////////////////////////////////////////
                        else
                        {
                            Random rnd = new Random();
                            int x = rnd.Next(0, 3);
                            int y = rnd.Next(0, 3);
                            if (field[x, y] == 0)
                            {
                                field[x, y] = turn;
                                break;
                            }
                        }

                    }
                    if (turn == 2) 
                    {
                        if (field[0, 0] == 1 && field[0, 1] == 1 && field[0, 2] == 0)  // 1xxo
                        {
                            field[0, 2] = turn;
                            break;
                        }
                        else if (field[0, 0] == 1 && field[0, 2] == 1 && field[0, 1] == 0) // 1xox
                        {
                            field[0, 1] = turn;
                            break;
                        }
                        else if (field[0, 1] == 1 && field[0, 2] == 1 && field[0, 0] == 0) // 1oxx
                        {
                            field[0, 0] = turn;
                            break;
                        }////////////////////////////////////////////////////////////////////
                        else if (field[1, 0] == 1 && field[1, 1] == 1 && field[1, 2] == 0) // 2xxo
                        {
                            field[1, 2] = turn;
                            break;
                        }
                        else if (field[1, 0] == 1 && field[1, 2] == 1 && field[1, 1] == 0) // 2xox
                        {
                            field[1, 1] = turn;
                            break;
                        }
                        else if (field[1, 1] == 1 && field[1, 2] == 1 && field[1, 0] == 0) // 2oxx
                        {
                            field[1, 0] = turn;
                            break;
                        }////////////////////////////////////////////////////////////////////
                        else if (field[2, 0] == 1 && field[2, 1] == 1 && field[2, 2] == 0) // 3xxo
                        {
                            field[2, 2] = turn;
                            break;
                        }
                        else if (field[2, 0] == 1 && field[2, 2] == 1 && field[2, 1] == 0) // 3xox
                        {
                            field[2, 1] = turn;
                            break;
                        }
                        else if (field[2, 1] == 1 && field[2, 2] == 1 && field[2, 0] == 0) // 3oxx
                        {
                            field[2, 0] = turn;
                            break;
                        }/////////////////////////////////////////////////////////////////////
                        else if (field[0, 0] == 1 && field[1, 0] == 1 && field[2, 0] == 0)  // 1x
                        {                                                                   //  x
                            field[2, 0] = turn;                                             //  o
                            break;
                        }
                        else if (field[0, 0] == 1 && field[2, 0] == 1 && field[1, 0] == 0)  // 1x
                        {                                                                   //  o
                            field[1, 0] = turn;                                             //  x
                            break;
                        }
                        else if (field[1, 0] == 1 && field[2, 0] == 1 && field[0, 0] == 0)  // 1o
                        {                                                                   //  x
                            field[0, 0] = turn;                                             //  x
                            break;
                        }/////////////////////////////////////////////////////////////////////
                        else if (field[0, 1] == 1 && field[1, 1] == 1 && field[2, 1] == 0)  // 2x
                        {                                               //  x
                            field[2, 1] = turn;                         //  o
                            break;
                        }
                        else if (field[0, 1] == 1 && field[2, 1] == 1 && field[1, 1] == 0)  // 2x
                        {                                               //  o
                            field[1, 1] = turn;                         //  x
                            break;
                        }
                        else if (field[1, 1] == 1 && field[2, 1] == 1 && field[0, 1] == 0)  // 2o
                        {                                                                   //  x
                            field[0, 1] = turn;                                             //  x
                            break;
                        }////////////////////////////////////
                        else if (field[0, 2] == 1 && field[1, 2] == 1 && field[2, 2] == 0)  // 3x
                        {                                                                   //  x
                            field[2, 2] = turn;                                             //  o
                            break;
                        }
                        else if (field[0, 2] == 1 && field[2, 2] == 1 && field[1, 2] == 0)  // 3x
                        {                                                                   //  o
                            field[1, 2] = turn;                                             //  x
                            break;
                        }
                        else if (field[1, 2] == 1 && field[2, 2] == 1 && field[0, 1] == 0)  // 3o
                        {                                                                   //  x
                            field[0, 1] = turn;                                             //  x
                            break;
                        }//////////////////////////////////////////////////////
                        else if (field[0, 0] == 1 && field[1, 1] == 1 && field[2, 2] == 0)  // x
                        {                                                                   //   x
                            field[2, 2] = turn;                                             //     o
                            break;
                        }
                        else if (field[0, 0] == 1 && field[2, 2] == 1 && field[1, 1] == 0)  // x
                        {                                                                   //   o
                            field[1, 1] = turn;                                             //     x
                            break;
                        }
                        else if (field[1, 1] == 1 && field[2, 2] == 1 && field[0, 0] == 0)  // o
                        {                                                                   //   x
                            field[0, 0] = turn;                                             //     x
                            break;
                        }//////////////////////////////////////////////////////
                        else if (field[2, 0] == 1 && field[1, 1] == 1 && field[0, 2] == 0)  //     o
                        {                                                                   //   x
                            field[0, 2] = turn;                                             // x
                            break;
                        }
                        else if (field[2, 0] == 1 && field[0, 2] == 1 && field[1, 1] == 0)  //     x
                        {                                                                   //   o
                            field[1, 1] = turn;                                             // x
                            break;
                        }
                        else if (field[1, 1] == 1 && field[0, 2] == 1 && field[2, 0] == 0)  //     x
                        {                                                                   //   x
                            field[2, 0] = turn;                                             // o
                            break;
                        }
                        else
                        {
                            Random rnd = new Random();
                            int x = rnd.Next(0, 3);
                            int y = rnd.Next(0, 3);
                            if (field[x, y] == 0)
                            {
                                field[x, y] = turn;
                                break;
                            }
                        }
                    }
                    
                }
            }

            // Высокая сложность. При возможности, компьютер сделает 
            // победный ход, вместо того, чтобы заблокировать Ваш ход.
            if (h == 3)  
            {             
                while (true)
                {
                    if (turn == 1)
                    {
                        if (field[0, 0] == 1 && field[0, 1] == 1 && field[0, 2] == 0)  // 1oox
                        {
                            field[0, 2] = turn;
                            break;
                        }
                        else if (field[0, 0] == 1 && field[0, 2] == 1 && field[0, 1] == 0) // 1oxo
                        {
                            field[0, 1] = turn;
                            break;
                        }
                        else if (field[0, 1] == 1 && field[0, 2] == 1 && field[0, 0] == 0) // 1xoo
                        {
                            field[0, 0] = turn;
                            break;
                        }////////////////////////////////////
                        else if (field[1, 0] == 1 && field[1, 1] == 1 && field[1, 2] == 0) // 2oox
                        {
                            field[1, 2] = turn;
                            break;
                        }
                        else if (field[1, 0] == 1 && field[1, 2] == 1 && field[1, 1] == 0) // 2oxo
                        {
                            field[1, 1] = turn;
                            break;
                        }
                        else if (field[1, 1] == 1 && field[1, 2] == 1 && field[1, 0] == 0) // 2xoo
                        {
                            field[1, 0] = turn;
                            break;
                        }////////////////////////////////////
                        else if (field[2, 0] == 1 && field[2, 1] == 1 && field[2, 2] == 0)  // 3oox
                        {
                            field[2, 2] = turn;
                            break;
                        }
                        else if (field[2, 0] == 1 && field[2, 2] == 1 && field[2, 1] == 0) // 3oxo
                        {
                            field[2, 1] = turn;
                            break;
                        }
                        else if (field[2, 1] == 1 && field[2, 2] == 1 && field[2, 1] == 0) // 3xoo
                        {
                            field[2, 1] = turn;
                            break;
                        }////////////////////////////////////////////////////////
                        else if (field[0, 0] == 1 && field[1, 0] == 1 && field[2, 0] == 0)  // 1o
                        {                                                                   //  o
                            field[2, 0] = turn;                                             //  x
                            break;
                        }
                        else if (field[0, 0] == 1 && field[2, 0] == 1 && field[1, 0] == 0)  // 1o
                        {                                                                   //  x
                            field[1, 0] = turn;                                             //  o
                            break;
                        }
                        else if (field[1, 0] == 1 && field[2, 0] == 1 && field[0, 0] == 0)  // 1x
                        {                                                                   //  o
                            field[0, 0] = turn;                                             //  o
                            break;
                        }////////////////////////////////////
                        else if (field[0, 1] == 1 && field[1, 1] == 1 && field[2, 1] == 0)  // 2o
                        {                                                                   //  o
                            field[2, 1] = turn;                                             //  x
                            break;
                        }
                        else if (field[0, 1] == 1 && field[2, 1] == 1 && field[1, 1] == 0)  // 2o
                        {                                                                   //  x
                            field[1, 1] = turn;                                             //  o
                            break;
                        }
                        else if (field[1, 1] == 1 && field[2, 1] == 1 && field[0, 1] == 0)  // 2x
                        {                                                                   //  o
                            field[0, 1] = turn;                                             //  o
                            break;
                        }////////////////////////////////////
                        else if (field[0, 2] == 1 && field[1, 2] == 1 && field[2, 2] == 0)  // 3o
                        {                                                                   //  o
                            field[2, 2] = turn;                                             //  x
                            break;
                        }
                        else if (field[0, 2] == 1 && field[2, 2] == 1 && field[1, 2] == 0)  // 3o
                        {                                                                   //  x
                            field[1, 2] = turn;                                             //  o
                            break;
                        }
                        else if (field[1, 2] == 1 && field[2, 2] == 1 && field[0, 1] == 0)  // 3x
                        {                                                                   //  o
                            field[0, 1] = turn;                                             //  o
                            break;
                        }/////////////////////////////////////////////////////////////////////
                        else if (field[0, 0] == 1 && field[1, 1] == 1 && field[2, 2] == 0)  // o
                        {                                                                   //   o
                            field[2, 2] = turn;                                             //     x
                            break;
                        }
                        else if (field[0, 0] == 1 && field[2, 2] == 1 && field[1, 1] == 0)  // o
                        {                                                                   //   x
                            field[1, 1] = turn;                                             //     o
                            break;
                        }
                        else if (field[1, 1] == 1 && field[2, 2] == 1 && field[0, 0] == 0)  // x
                        {                                                                   //   o
                            field[0, 0] = turn;                                             //     o
                            break;
                        }//////////////////////////////////////////////////////
                        else if (field[2, 0] == 1 && field[1, 1] == 1 && field[0, 2] == 0)  //     x
                        {                                                                   //   o
                            field[0, 2] = turn;                                             // o
                            break;
                        }
                        else if (field[2, 0] == 1 && field[0, 2] == 1 && field[1, 1] == 0)  //     o
                        {                                                                   //   x
                            field[1, 1] = turn;                                             // o
                            break;
                        }
                        else if (field[1, 1] == 1 && field[0, 2] == 1 && field[2, 0] == 0)  //     o
                        {                                                                   //   o
                            field[2, 0] = turn;                                             // x
                            break;
                        }
                        ///////////////////-------------///////////////////////////////////////
                        ///////////////////-------------////////////////////////////////////////
                        //////////////////--------------///////////////////////////////////////
                        else if(field[0, 0] == 2 && field[0, 1] == 2 && field[0, 2] == 0)  // 1oox
                        {
                            field[0, 2] = turn;
                            break;
                        }
                        else if (field[0, 0] == 2 && field[0, 2] == 2 && field[0, 1] == 0) // 1oxo
                        {
                            field[0, 1] = turn;
                            break;
                        }
                        else if (field[0, 1] == 2 && field[0, 2] == 2 && field[0, 0] == 0) // 1xoo
                        {
                            field[0, 0] = turn;
                            break;
                        }////////////////////////////////////
                        else if (field[1, 0] == 2 && field[1, 1] == 2 && field[1, 2] == 0) // 2oox
                        {
                            field[1, 2] = turn;
                            break;
                        }
                        else if (field[1, 0] == 2 && field[1, 2] == 2 && field[1, 1] == 0) // 2oxo
                        {
                            field[1, 1] = turn;
                            break;
                        }
                        else if (field[1, 1] == 2 && field[1, 2] == 2 && field[1, 0] == 0) // 2xoo
                        {
                            field[1, 0] = turn;
                            break;
                        }////////////////////////////////////
                        else if (field[2, 0] == 2 && field[2, 1] == 2 && field[2, 2] == 0)  // 3oox
                        {
                            field[2, 2] = turn;
                            break;
                        }
                        else if (field[2, 0] == 2 && field[2, 2] == 2 && field[2, 1] == 0) // 3oxo
                        {
                            field[2, 1] = turn;
                            break;
                        }
                        else if (field[2, 1] == 2 && field[2, 2] == 2 && field[2, 1] == 0) // 3xoo
                        {
                            field[2, 1] = turn;
                            break;
                        }////////////////////////////////////////////////////////
                        else if (field[0, 0] == 2 && field[1, 0] == 2 && field[2, 0] == 0)  // 1o
                        {                                                                   //  o
                            field[2, 0] = turn;                                             //  x
                            break;
                        }
                        else if (field[0, 0] == 2 && field[2, 0] == 2 && field[1, 0] == 0)  // 1o
                        {                                                                   //  x
                            field[1, 0] = turn;                                             //  o
                            break;
                        }
                        else if (field[1, 0] == 2 && field[2, 0] == 2 && field[0, 0] == 0)  // 1x
                        {                                                                   //  o
                            field[0, 0] = turn;                                             //  o
                            break;
                        }////////////////////////////////////
                        else if (field[0, 1] == 2 && field[1, 1] == 2 && field[2, 1] == 0)  // 2o
                        {                                                                   //  o
                            field[2, 1] = turn;                                             //  x
                            break;
                        }
                        else if (field[0, 1] == 2 && field[2, 1] == 2 && field[1, 1] == 0)  // 2o
                        {                                                                   //  x
                            field[1, 1] = turn;                                             //  o
                            break;
                        }
                        else if (field[1, 1] == 2 && field[2, 1] == 2 && field[0, 1] == 0)  // 2x
                        {                                                                   //  o
                            field[0, 1] = turn;                                             //  o
                            break;
                        }////////////////////////////////////
                        else if (field[0, 2] == 2 && field[1, 2] == 2 && field[2, 2] == 0)  // 3o
                        {                                                                   //  o
                            field[2, 2] = turn;                                             //  x
                            break;
                        }
                        else if (field[0, 2] == 2 && field[2, 2] == 2 && field[1, 2] == 0)  // 3o
                        {                                                                   //  x
                            field[1, 2] = turn;                                             //  o
                            break;
                        }
                        else if (field[1, 2] == 2 && field[2, 2] == 2 && field[0, 1] == 0)  // 3x
                        {                                                                   //  o
                            field[0, 1] = turn;                                             //  o
                            break;
                        }/////////////////////////////////////////////////////////////////////
                        else if (field[0, 0] == 2 && field[1, 1] == 2 && field[2, 2] == 0)  // o
                        {                                                                   //   o
                            field[2, 2] = turn;                                             //     x
                            break;
                        }
                        else if (field[0, 0] == 2 && field[2, 2] == 2 && field[1, 1] == 0)  // o
                        {                                                                   //   x
                            field[1, 1] = turn;                                             //     o
                            break;
                        }
                        else if (field[1, 1] == 2 && field[2, 2] == 2 && field[0, 0] == 0)  // x
                        {                                                                   //   o
                            field[0, 0] = turn;                                             //     o
                            break;
                        }//////////////////////////////////////////////////////
                        else if (field[2, 0] == 2 && field[1, 1] == 2 && field[0, 2] == 0)  //     x
                        {                                                                   //   o
                            field[0, 2] = turn;                                             // o
                            break;
                        }
                        else if (field[2, 0] == 2 && field[0, 2] == 2 && field[1, 1] == 0)  //     o
                        {                                                                   //   x
                            field[1, 1] = turn;                                             // o
                            break;
                        }
                        else if (field[1, 1] == 2 && field[0, 2] == 2 && field[2, 0] == 0)  //     o
                        {                                                                   //   o
                            field[2, 0] = turn;                                             // x
                            break;
                        }/////////////////////////////////////////////////////////////////////
                        else
                        {
                            Random rnd = new Random();
                            int x = rnd.Next(0, 3);
                            int y = rnd.Next(0, 3);
                            if (field[x, y] == 0)
                            {
                                field[x, y] = turn;
                                break;
                            }
                        }

                    }
                    if (turn == 2)
                    {
                        if (field[0, 0] == 2 && field[0, 1] == 2 && field[0, 2] == 0)  // 1xxo
                        {
                            field[0, 2] = turn;
                            break;
                        }
                        else if (field[0, 0] == 2 && field[0, 2] == 2 && field[0, 1] == 0) // 1xox
                        {
                            field[0, 1] = turn;
                            break;
                        }
                        else if (field[0, 1] == 2 && field[0, 2] == 2 && field[0, 0] == 0) // 1oxx
                        {
                            field[0, 0] = turn;
                            break;
                        }////////////////////////////////////////////////////////////////////
                        else if (field[1, 0] == 2 && field[1, 1] == 2 && field[1, 2] == 0) // 2xxo
                        {
                            field[1, 2] = turn;
                            break;
                        }
                        else if (field[1, 0] == 2 && field[1, 2] == 2 && field[1, 1] == 0) // 2xox
                        {
                            field[1, 1] = turn;
                            break;
                        }
                        else if (field[1, 1] == 2 && field[1, 2] == 2 && field[1, 0] == 0) // 2oxx
                        {
                            field[1, 0] = turn;
                            break;
                        }////////////////////////////////////////////////////////////////////
                        else if (field[2, 0] == 2 && field[2, 1] == 2 && field[2, 2] == 0) // 3xxo
                        {
                            field[2, 2] = turn;
                            break;
                        }
                        else if (field[2, 0] == 2 && field[2, 2] == 2 && field[2, 1] == 0) // 3xox
                        {
                            field[2, 1] = turn;
                            break;
                        }
                        else if (field[2, 1] == 2 && field[2, 2] == 2 && field[2, 0] == 0) // 3oxx
                        {
                            field[2, 0] = turn;
                            break;
                        }/////////////////////////////////////////////////////////////////////
                        else if (field[0, 0] == 2 && field[1, 0] == 2 && field[2, 0] == 0)  // 1x
                        {                                                                   //  x
                            field[2, 0] = turn;                                             //  o
                            break;
                        }
                        else if (field[0, 0] == 2 && field[2, 0] == 2 && field[1, 0] == 0)  // 1x
                        {                                                                   //  o
                            field[1, 0] = turn;                                             //  x
                            break;
                        }
                        else if (field[1, 0] == 2 && field[2, 0] == 2 && field[0, 0] == 0)  // 1o
                        {                                                                   //  x
                            field[0, 0] = turn;                                             //  x
                            break;
                        }/////////////////////////////////////////////////////////////////////
                        else if (field[0, 1] == 2 && field[1, 1] == 2 && field[2, 1] == 0)  // 2x
                        {                                                                   //  x
                            field[2, 1] = turn;                                             //  o
                            break;
                        }
                        else if (field[0, 1] == 2 && field[2, 1] == 2 && field[1, 1] == 0)  // 2x
                        {                                                                   //  o
                            field[1, 1] = turn;                                             //  x
                            break;
                        }
                        else if (field[1, 1] == 2 && field[2, 1] == 2 && field[0, 1] == 0)  // 2o
                        {                                                                   //  x
                            field[0, 1] = turn;                                             //  x
                            break;
                        }////////////////////////////////////
                        else if (field[0, 2] == 2 && field[1, 2] == 2 && field[2, 2] == 0)  // 3x
                        {                                                                   //  x
                            field[2, 2] = turn;                                             //  o
                            break;
                        }
                        else if (field[0, 2] == 2 && field[2, 2] == 2 && field[1, 2] == 0)  // 3x
                        {                                                                   //  o
                            field[1, 2] = turn;                                             //  x
                            break;
                        }
                        else if (field[1, 2] == 2 && field[2, 2] == 2 && field[0, 1] == 0)  // 3o
                        {                                                                   //  x
                            field[0, 1] = turn;                                             //  x
                            break;
                        }//////////////////////////////////////////////////////
                        else if (field[0, 0] == 2 && field[1, 1] == 2 && field[2, 2] == 0)  // x
                        {                                                                   //   x
                            field[2, 2] = turn;                                             //     o
                            break;
                        }
                        else if (field[0, 0] == 2 && field[2, 2] == 2 && field[1, 1] == 0)  // x
                        {                                                                   //   o
                            field[1, 1] = turn;                                             //     x
                            break;
                        }
                        else if (field[1, 1] == 2 && field[2, 2] == 2 && field[0, 0] == 0)  // o
                        {                                                                   //   x
                            field[0, 0] = turn;                                             //     x
                            break;
                        }//////////////////////////////////////////////////////
                        else if (field[2, 0] == 2 && field[1, 1] == 2 && field[0, 2] == 0)  //     o
                        {                                                                   //   x
                            field[0, 2] = turn;                                             // x
                            break;
                        }
                        else if (field[2, 0] == 2 && field[0, 2] == 2 && field[1, 1] == 0)  //     x
                        {                                                                   //   o
                            field[1, 1] = turn;                                             // x
                            break;
                        }
                        else if (field[1, 1] == 2 && field[0, 2] == 2 && field[2, 0] == 0)  //     x
                        {                                                                   //   x
                            field[2, 0] = turn;                                             // o
                            break;
                        }
                        ///////////////////-------------///////////////////////////////////////
                        ///////////////////-------------////////////////////////////////////////
                        //////////////////--------------///////////////////////////////////////
                        else if (field[0, 0] == 1 && field[0, 1] == 1 && field[0, 2] == 0)  // 1xxo
                        {
                            field[0, 2] = turn;
                            break;
                        }
                        else if (field[0, 0] == 1 && field[0, 2] == 1 && field[0, 1] == 0) // 1xox
                        {
                            field[0, 1] = turn;
                            break;
                        }
                        else if (field[0, 1] == 1 && field[0, 2] == 1 && field[0, 0] == 0) // 1oxx
                        {
                            field[0, 0] = turn;
                            break;
                        }////////////////////////////////////////////////////////////////////
                        else if (field[1, 0] == 1 && field[1, 1] == 1 && field[1, 2] == 0) // 2xxo
                        {
                            field[1, 2] = turn;
                            break;
                        }
                        else if (field[1, 0] == 1 && field[1, 2] == 1 && field[1, 1] == 0) // 2xox
                        {
                            field[1, 1] = turn;
                            break;
                        }
                        else if (field[1, 1] == 1 && field[1, 2] == 1 && field[1, 0] == 0) // 2oxx
                        {
                            field[1, 0] = turn;
                            break;
                        }////////////////////////////////////////////////////////////////////
                        else if (field[2, 0] == 1 && field[2, 1] == 1 && field[2, 2] == 0) // 3xxo
                        {
                            field[2, 2] = turn;
                            break;
                        }
                        else if (field[2, 0] == 1 && field[2, 2] == 1 && field[2, 1] == 0) // 3xox
                        {
                            field[2, 1] = turn;
                            break;
                        }
                        else if (field[2, 1] == 1 && field[2, 2] == 1 && field[2, 0] == 0) // 3oxx
                        {
                            field[2, 0] = turn;
                            break;
                        }/////////////////////////////////////////////////////////////////////
                        else if (field[0, 0] == 1 && field[1, 0] == 1 && field[2, 0] == 0)  // 1x
                        {                                                                   //  x
                            field[2, 0] = turn;                                             //  o
                            break;
                        }
                        else if (field[0, 0] == 1 && field[2, 0] == 1 && field[1, 0] == 0)  // 1x
                        {                                                                   //  o
                            field[1, 0] = turn;                                             //  x
                            break;
                        }
                        else if (field[1, 0] == 1 && field[2, 0] == 1 && field[0, 0] == 0)  // 1o
                        {                                                                   //  x
                            field[0, 0] = turn;                                             //  x
                            break;
                        }/////////////////////////////////////////////////////////////////////
                        else if (field[0, 1] == 1 && field[1, 1] == 1 && field[2, 1] == 0)  // 2x
                        {                                               //  x
                            field[2, 1] = turn;                         //  o
                            break;
                        }
                        else if (field[0, 1] == 1 && field[2, 1] == 1 && field[1, 1] == 0)  // 2x
                        {                                               //  o
                            field[1, 1] = turn;                         //  x
                            break;
                        }
                        else if (field[1, 1] == 1 && field[2, 1] == 1 && field[0, 1] == 0)  // 2o
                        {                                                                   //  x
                            field[0, 1] = turn;                                             //  x
                            break;
                        }////////////////////////////////////
                        else if (field[0, 2] == 1 && field[1, 2] == 1 && field[2, 2] == 0)  // 3x
                        {                                                                   //  x
                            field[2, 2] = turn;                                             //  o
                            break;
                        }
                        else if (field[0, 2] == 1 && field[2, 2] == 1 && field[1, 2] == 0)  // 3x
                        {                                                                   //  o
                            field[1, 2] = turn;                                             //  x
                            break;
                        }
                        else if (field[1, 2] == 1 && field[2, 2] == 1 && field[0, 1] == 0)  // 3o
                        {                                                                   //  x
                            field[0, 1] = turn;                                             //  x
                            break;
                        }//////////////////////////////////////////////////////
                        else if (field[0, 0] == 1 && field[1, 1] == 1 && field[2, 2] == 0)  // x
                        {                                                                   //   x
                            field[2, 2] = turn;                                             //     o
                            break;
                        }
                        else if (field[0, 0] == 1 && field[2, 2] == 1 && field[1, 1] == 0)  // x
                        {                                                                   //   o
                            field[1, 1] = turn;                                             //     x
                            break;
                        }
                        else if (field[1, 1] == 1 && field[2, 2] == 1 && field[0, 0] == 0)  // o
                        {                                                                   //   x
                            field[0, 0] = turn;                                             //     x
                            break;
                        }//////////////////////////////////////////////////////
                        else if (field[2, 0] == 1 && field[1, 1] == 1 && field[0, 2] == 0)  //     o
                        {                                                                   //   x
                            field[0, 2] = turn;                                             // x
                            break;
                        }
                        else if (field[2, 0] == 1 && field[0, 2] == 1 && field[1, 1] == 0)  //     x
                        {                                                                   //   o
                            field[1, 1] = turn;                                             // x
                            break;
                        }
                        else if (field[1, 1] == 1 && field[0, 2] == 1 && field[2, 0] == 0)  //     x
                        {                                                                   //   x
                            field[2, 0] = turn;                                             // o
                            break;
                        }
                        else
                        {
                            Random rnd = new Random();
                            int x = rnd.Next(0, 3);
                            int y = rnd.Next(0, 3);
                            if (field[x, y] == 0)
                            {
                                field[x, y] = turn;
                                break;
                            }
                        }
                    }

                }
            }
        }

        private void button1_Click(object sender, EventArgs e) // Обработчик хода игрока
        {
            bool flag = true;
            if (sender == button1)
            {
                if (field[0, 0] == 0)
                {
                    field[0, 0] = p;
                    SetPictures();
                }
                else flag = false;
            }
            else if (sender == button2)
            {
                if (field[0, 1] == 0)
                {
                    field[0, 1] = p;
                    SetPictures();
                }
                else flag = false;
            }
            else if (sender == button3)
            {
                if (field[0, 2] == 0)
                {
                    field[0, 2] = p;
                    SetPictures();
                }
                else flag = false;
            }
            else if (sender == button4)
            {
                if (field[1, 0] == 0)
                {
                    field[1, 0] = p;
                    SetPictures();
                }
                else flag = false;
            }
            else if (sender == button5)
            {
                if (field[1, 1] == 0)
                {
                    field[1, 1] = p;
                    SetPictures();
                }
                else flag = false;
            }
            else if (sender == button6)
            {
                if (field[1, 2] == 0)
                {
                    field[1, 2] = p;
                    SetPictures();
                }
                else flag = false;
            }
            else if (sender == button7)
            {
                if (field[2, 0] == 0)
                {
                    field[2, 0] = p;
                    SetPictures();
                }
                else flag = false;
            }
            else if (sender == button8)
            {
                if (field[2, 1] == 0)
                {
                    field[2, 1] = p;
                    SetPictures();
                }
                else flag = false;
            }
            else if (sender == button9)
            {
                if (field[2, 2] == 0)
                {
                    field[2, 2] = p;
                    SetPictures();
                }
                else flag = false;
            }
            if (flag)
            {
                WinCheck();
                if (IsPlace() == true && restarted == false)
                {
                    CompAct(hardness, c);
                    SetPictures();
                    WinCheck();
                    restarted = false;
                }
                else restarted = false;
            }
        }

        private bool IfNotRestart() // Проверка, не рестартнута ли игра
        {
            int n = 0;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (field[i, j] == 0)
                        n++;
            if (n == 8)
                return false;
            return true;
        }
        private void WinCheck() // Проверка на победу.
        {
            if (IfWinX() == true)
            {
                DialogResult result = MessageBox.Show("Do you want to play again?", "X has won!",
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Restart();
                }
                else if (result == DialogResult.No)
                {
                    Close();
                }
            }
            if (IfWinO() == true)
            {
                DialogResult result = MessageBox.Show("Do you want to play again?", "O has won!",
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Restart();
                }
                else if (result == DialogResult.No)
                {
                    Close();
                }
            }
            if (IfDraw() == true)
            {
                DialogResult result = MessageBox.Show("Do you want to play again?", "It's draw!",
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Restart();
                }
                else if (result == DialogResult.No)
                {
                    Close();
                }
            }
        }

        private bool IfWinX()   // Проверка, выиграл ли крестик
        {   //---
            if (field[0,0] == 1 && field[0, 1] == 1 && field[0, 2] == 1)
                return true;
            else if (field[1, 0] == 1 && field[1, 1] == 1 && field[1, 2] == 1)
                return true;
            if (field[2, 0] == 1 && field[2, 1] == 1 && field[2, 2] == 1)
                return true;
            // |
            else if (field[0, 0] == 1 && field[1, 0] == 1 && field[2, 0] == 1)
                return true;
            else if (field[0, 1] == 1 && field[1, 1] == 1 && field[2, 1] == 1)
                return true;
            else if (field[0, 2] == 1 && field[1, 2] == 1 && field[2, 2] == 1)
                return true;
            //  \
            else if (field[0, 0] == 1 && field[1, 1] == 1 && field[2, 2] == 1)
                return true;
            // /
            else if (field[0, 2] == 1 && field[1, 1] == 1 && field[2,0] == 1)
                return true;
            else return false;
        }
        private bool IfWinO()   // Проверка, выиграл ли нолик
        {   //---
            if (field[0, 0] == 2 && field[0, 1] == 2 && field[0, 2] == 2)
                return true;
            else if (field[1, 0] == 2 && field[1, 1] == 2 && field[1, 2] == 2)
                return true;
            if (field[2, 0] == 2 && field[2, 1] == 2 && field[2, 2] == 2)
                return true;
            // |
            else if (field[0, 0] == 2 && field[1, 0] == 2 && field[2, 0] == 2)
                return true;
            else if (field[0, 1] == 2 && field[1, 1] == 2 && field[2, 1] == 2)
                return true;
            else if (field[0, 2] == 2 && field[1, 2] == 2 && field[2, 2] == 2)
                return true;
            //  \
            else if (field[0, 0] == 2 && field[1, 1] == 2 && field[2, 2] == 2)
                return true;
            // /
            else if (field[0, 2] == 2 && field[1, 1] == 2 && field[2, 0] == 2)
                return true;
            else return false;
        }
        private bool IfDraw()   // Проверка, была ли ничья
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (field[i, j] == 0)
                        return false;
            return true;
        }

        private bool restarted = false;
        private void Restart()  // Рестарт игры
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    field[i, j] = 0;
            button1.Image = null;
            button2.Image = null;
            button3.Image = null;
            button4.Image = null;
            button5.Image = null;
            button6.Image = null;
            button7.Image = null;
            button8.Image = null;
            button9.Image = null;
            
            if (checkBox1.Checked)
            {
                p = 2;
                c = 1;
                CompAct(hardness, c);
                SetPictures();
            }
            else 
            {
                p = 1;
                c = 2;
                SetPictures();
            }
            restarted = true;
        }

        private void button10_Click(object sender, EventArgs e)  // Обработчик для клавиши Рестарт
        {
            Restart();
            restarted = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) // Выбор минимальной сложности
        {
            hardness = 1;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e) // Выбор средней сложности
        {
            hardness = 2;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) // Выбор максимальной сложности
        {
            hardness = 3;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}