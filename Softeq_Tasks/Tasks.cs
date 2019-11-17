using System;
using System.IO;

namespace Tasks_Softeq
{
    public class Tasks
    {
        public double[] Task_1(string[] array)
        {
            string[] number_from_first_line = array[0].Split(new char[] { ' ' },
                                      StringSplitOptions.RemoveEmptyEntries);//Разделяем числа из первой строки
            int T = int.Parse(number_from_first_line[0]);//Получаем число тестов

            double[] answer = new double[T];

            //Заполним наш вспомогательный массив числами
            for (int i = 0; i < answer.Length; i++)
            {
                answer[i] = Func_for_Task_1(double.Parse(array[i + 1]));
            }

            return answer;
        }
        public double Func_for_Task_1(double x)
        {
            double answer = Math.Round(Math.Pow(x, 4) + 1.2 * Math.Pow(x, 3) - 20 * Math.Pow(x, 2) + 123.456, 3);
            return answer;
        }
        public double Task_2(string[] array)
        {
            double answer = 0;//переменная, в кторую будем получать ответ
            string[] numbers_from_first_line = array[0].Split(new char[] { ' ' },
                                      StringSplitOptions.RemoveEmptyEntries);//Разделяем числа из первой строки
            int N = int.Parse(numbers_from_first_line[0]);//Получаем число N
            int M = int.Parse(numbers_from_first_line[1]);//Получаем число M

            int[] array_tmp = new int[N];//Создадим вспомогательный массив, куда числа из исходного массива преобразованные в тип int

            //Заполним наш вспомогательный массив числами
            for (int i = 0; i < array_tmp.Length; i++)
            {
                array_tmp[i] = int.Parse(array[i + 1]);
            }

            double tmp = 0;
            for (int i = 0; i < N; i += 2)
            {
                tmp += 1 * Math.Pow(array_tmp[i], -1);
            }
            answer = Math.Round(M / (tmp * 2), 3);
            return answer;
        }
        public int Task_3(string int_line)
        {
            int answer = 0;

            string[] int_array = int_line.Split(new char[] { ' ' },
                                      StringSplitOptions.RemoveEmptyEntries);//Разделяем числа из строки
            int A = int.Parse(int_array[0]);
            int B = int.Parse(int_array[1]);
            int N = int.Parse(int_array[2]);

            if (A >= 100) return 0;//Так как по условию N<100

            int a_max = N / A;//макс число вхождений A в N
            int b_max = N / B;//макс число вхождений B в N

            bool a_is_max = A > B ? true : false;

            if (N % A == 0 && !a_is_max)//Если число можно представить как сумму только минимальных чисел (число А минимальное)
            {
                return (int)Math.Pow(A, a_max);
            }

            else if (N % B == 0 && a_is_max)//(число B минимальное) 
            {
                return (int)Math.Pow(B, b_max);
            }

            int sum;
            //Подбираем такую сумму чисел, чтобы количество минимальных чисел было максимально
            if (!a_is_max)
            {
                int i = a_max;
                for (int j = 0; j <= b_max; j++)
                {
                    sum = A * i + B * j;
                    if (sum > N)
                    {
                        sum = 0;
                        j = 0;
                        i--;
                    }
                    if (sum == N)
                        answer = (int)(Math.Pow(A, i) * Math.Pow(B, j));
                }
            }
            else
            {
                int j = b_max;
                for (int i = 0; i <= a_max; i++)
                {
                    sum = A * i + B * j;
                    if (sum > N)
                    {
                        sum = 0;
                        i = 0;
                        j--;
                    }
                    if (sum == N)
                        answer = (int)(Math.Pow(A, i) * Math.Pow(B, j));
                }
            }
            return answer;
        }
        public int Task_4(string path)
        {
            string line;
            using (StreamReader sr = new StreamReader(path))
            {
                line = sr.ReadToEnd();//читаем данные из файла в строку
            }

            string[] numbers_from_line = line.Split(new char[] { ' ' },
                                      StringSplitOptions.RemoveEmptyEntries);//Разделяем числа из строки
            int N = int.Parse(numbers_from_line[0]);//белые мыши
            int M = int.Parse(numbers_from_line[1]);//черные мыши

            int answer = N * (M + 1) + M;
            return answer;
        }
    }
}
