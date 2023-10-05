using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace TemplateMethod
{
    abstract class World
    {
        public string sid;

        public abstract void Creation();

        public abstract void Generation();

        public abstract void Earth();

        public abstract void Nether();

        public abstract void End();

        public abstract void Finish();

        public virtual void Launch()
        {
            Console.WriteLine("\nЗапуск мира:"+GetType().Name);
        }

        public void Make()
        {
            Creation();
            Generation();
            Launch();
            Earth();
            Nether();
            End();
            Finish();
        }
    }

    class Your_name : World
    {
        public override void Creation()
        {
            
            Console.WriteLine("Вводим название мира:Your_name");           
            Console.WriteLine("Выбираем тип генерации мира:Бесконечный");
            Console.WriteLine("Режим игры:Выживание");
            Console.WriteLine("Сид мира:\n1-Вручную\n2-автоматически");
            int a = Convert.ToInt32(Console.ReadLine());
            int df = 0;
            switch (a)
            {
                case 1:
                    while (df == 0)
                    {
                        sid = Console.ReadLine();
                        if ((sid.Length == 19) && (sid.All(Char.IsDigit)))
                        {
                            df = 1;
                        }
                        else
                        {
                            Console.WriteLine("Неверно");
                        }
                    }
                    break;

                case 2:                
                    Random r = new Random();
                    long y = r.Next(100000000,999999999);
                    long j = r.Next(100000000, 999999999);
                    long m = r.Next(0,9);
                    string y1 = y.ToString()+ j.ToString()+m.ToString();
                    ulong y2 = Convert.ToUInt64(y1);
                    Console.WriteLine(y2);
                    break;

                default:
                    return;
            }
            
            Console.WriteLine("Применяем параметры создания мира");
        }

        public override void Generation()
        {
            Console.WriteLine("\nГенерация ландшафта...Генерация биомов...Прогрузка чанков...");
        }

        public override void Earth()
        {
            Console.WriteLine("\nИсследуем мир");
            Console.WriteLine("Добываем материалы для будущих необходимых изготовлений");
            Console.WriteLine("Изготавливаем инструменты и аммунацию");          
            Console.WriteLine("Находим или создаём портал в 'Нижний мир'");
        }

        public override void Nether()
        {
            Console.WriteLine("\nИсследуем данный мир");          
            Console.WriteLine("Находим 'Крепость Нижнего мира' и 'Искажённый лес'");
            Console.WriteLine("Добываем необходимые для прохождения предметы('Огненный стержень','Жемчуг края')");
            Console.WriteLine("Возврощаемся в обычный мир");
        }

        public override void End()
        {
            Console.WriteLine("\nИз найденный нами материалов Нижнего мира изготавливаем'Око края'");
            Console.WriteLine("Благодаря 'око края' находим Цитадель с порталам края");
            Console.WriteLine("Изготовленные 'око края' вставляем в ячейки,тем самым активируя портал");
            Console.WriteLine("Заходим в портал 'Края'");
            
        }

        public override void Finish()
        {
            Console.WriteLine("\nНаходим дракона Края и кристаллы");
            Console.WriteLine("Уничтожаем кристаллы");
            Console.WriteLine("Побеждаем дракона края");
            Console.WriteLine("Заходим в появившийся портал");
            Console.WriteLine("Поздравляю!Вы прошли игру.");
        }
    }
}
