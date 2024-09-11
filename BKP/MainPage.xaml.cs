using BKP.View;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BKP
{
    public partial class MainPage : Window
    {
        public SeriesCollection Task_status_view { get; set; }
        public SeriesCollection Task_dir { get; set; }
        public SeriesCollection Task_exe { get; set; }
        public SeriesCollection Sub_chart { get; set; }
        public string[] Labels { get; set; }
        public Func<int, string> YFormatter { get; set; }

        public MainPage()
        {
            InitializeComponent();
            GetVideoInfo();
            GetTaskInfo();
            GetInfoForEventReport();
            GetGoodsInfo();
            GetEmployeeEfficiency();
            GetEmployeeInfo();
            GetPartPostInfo();
            GetPubStat();
            GetEvent();
            GetVideoStat();
            GetSubInfo();
            GetEmployeeTask();
            GetReserveInfo();
            GetSkillInfo();
            BuildChart();
            DataContext = this;
        }

        public void GetVideoInfo()
        {
            List<VideoInfo> video_table_data = new List<VideoInfo>
            {
                new VideoInfo(1, "Клим Жуков. Мифы о ножах: где правда, а где ложь? 1 часть!", "2023-04-02", "2023-04-09"),
                new VideoInfo(2, "Клим Жуков. Мифы о ножах: где правда, а где ложь? 2 часть!", "2023-04-02", "2023-04-15"),
                new VideoInfo(3, "Выбор первого ножа. Как появляется бессознательный и осознанный нож?", "2023-04-11", "2023-04-19"),
                new VideoInfo(4, "ДЕНИС ТБП личная коллекция! КУХОННИКИ \\ СОВЕТСКИЕ СКЛАДНИ \\МАЧЕТЕ", "2023-04-15", "2023-04-22"),
                new VideoInfo(5, "Какой нож нужен военнослужащему? Анонс нового ножа!", "2023-04-19", "2023-05-06"),
                new VideoInfo(6, "Боевой нож и штык-нож в СССР и России. Razvedos", "2023-04-30", "2023-04-29"),
                new VideoInfo(7, "Ножевые истории / CRKT M16", "2023-05-08", "2023-05-13"),
                new VideoInfo(8, "Антон Ткаченко о дизайне и ножах. Часть 1", "2023-05-08", "2023-05-20")
            };

            Video_info.ItemsSource = video_table_data;
        }
        public void GetEmployeeInfo()
        {
            List<Employee> employee_data = new List<Employee>
            {
                new Employee(1, "Алиев Игорь", "Английский язык","Младший SMM Manager", "89166449289"),
                new Employee(2, "Миронов Александр", "-","Старший SMM-менеджер", "89034567893"),
                new Employee(3, "Сбоев Артур", "Adobe After Effects","Оператор-монтажер", "89032347618"),
                new Employee(4, "Ильин Даниил", "Создание Telegram ботов","Фотограф", "89036578276"),
                new Employee(5, "Астахова Светлана", "-","Главный бухгалтер", "89034567328"),
                new Employee(6, "Стрепетов Алексей", "-","Ведущий", "89161296537"),
                new Employee(7, "Гамбуль Юлия", "-","Ведущий", "89037292356"),
                new Employee(8, "Александров Александр", "-","Ведущий", "89036665463"),
                new Employee(9, "Михаил Ярин", "-","Ведущий", "89038994561"),
                new Employee(10, "Артюнов Александр", "-","Ведущий", "89039183764"),
                new Employee(11, "Шипалова Алена", "-","Ведущий", "89034446572"),
                new Employee(12, "Петров Алексей", "3D моделирование","Ведущий", "89034567832"),
                new Employee(13, "Иванов Дмитрий", "-","Курьер", "89033219957"),
                new Employee(14, "Ильин Евгений", "Английский язык","Генеральный директор", "89037689723"),
                new Employee(15, "Вагиф Исмет Оглы", "-","И.О. Директора", "89032905674"),
                new Employee(16, "Смачный Вячеслав", "-","И.О. Директора", "89037861235"),
                new Employee(17, "Семенов Сергей", "Adobe Photoshop","Старший продавец", "89035681289"),
                new Employee(18, "Трепетов Михаил", "-","Продавец консультант", "89034567862"),
                new Employee(19, "Маргулов Сергей", "-","Продавец консультант", "89034577398")
            };

            Employee.ItemsSource = employee_data;
        }

        public void GetSkillInfo()
        {
            List<Skills> skill_data = new List<Skills>
            {
                new Skills(1, "Английский язык", "Продвинутый уровень владения английским языком. подтвержден сертификатом IELTS C1"),
            };

            Skills.ItemsSource = skill_data;
        }

        public void GetTaskInfo()
        {
            List<TaskInfo> task_table_data = new List<TaskInfo>
            {
                new TaskInfo(1, "Проверить комментарии", "Проверить комментарии на YouTube за последнии 7 дней", "Видеоролик №23", "2023-05-01 9:00", "2023-05-01 13:00", "2023-05-01 12:13", "Миронов Александр", "Выполнено"),
                new TaskInfo(2, "Написать текстовое описание к видеороликам", "Есть ряд коротких роликов, к которым нужно написать текст. \n 1 или 2 коротких абзаца + вопрос. \n Ролики тебе скинут Артур", "-", "2023-05-10 17:30", "2023-05-13 18:00", "2023-05-14 11:48", "Миронов Александр", "Выполнено"),
                new TaskInfo(3, "Сделый посты в соц сетях о новом поступлении", "Новое поступления товара от \"Кузницы Коваль\" \n Создай посты для соц сетей", "Событие №7", "2023-05-11 12:44", "2023-05-13 17:00","2023-05-13 13:54", "Миронов Александр", "Выполнено"),
                new TaskInfo(4, "Загрузить товар на сайт", "Поступление товара от Кузницы Коваль. Нужно залить на сайт", "Событие №7", "2023-05-15 13:34", "2023-05-18 15:00", "-", "Вагиф Исмет Оглы", "В работе"),
                new TaskInfo(5, "Добавить товар на Авито", "Добавить последние новинки с сайта на Авито", "-", "2023-05-19 12:17", "2023-05-25 13:00", "-", "Вагиф Исмет Оглы", "В работе")
            };

            Task_info.ItemsSource = task_table_data;
        }
        public void GetEmployeeTask()
        {
            List<TaskInfo> employee_task_data = new List<TaskInfo>
            {
                new TaskInfo(1, "Загрузить товар на сайт", "Поступление товара от Кузницы Коваль. Нужно залить на сайт", "Событие №7", "2023-05-15 13:34", "2023-05-18 15:00", "-", "Вагиф Исмет Оглы", "В работе")
            };

            Employee_task.ItemsSource = employee_task_data;
        }

        public void GetSubInfo()
        {
            List<SubInfo> sub_info = new List<SubInfo>
            {
                new SubInfo(1, "YouTube","55169", "2023-05-01 18:00"),
                new SubInfo(2, "YouTube","55215", "2023-05-02 18:00"),
                new SubInfo(3, "YouTube","55327", "2023-05-03 18:00"),
                new SubInfo(4, "YouTube","55607", "2023-05-04 18:00"),
                new SubInfo(5, "YouTube","55912", "2023-05-05 18:00"),
                new SubInfo(6, "YouTube","56131", "2023-05-06 18:00"),
                new SubInfo(7, "YouTube","56562", "2023-05-07 18:00"),
                new SubInfo(8, "YouTube","57000", "2023-05-08 18:00"),
                new SubInfo(9, "YouTube","57395", "2023-05-09 18:00"),
                new SubInfo(10, "YouTube","57640", "2023-05-10 18:00"),
                new SubInfo(11, "YouTube","57816", "2023-05-11 18:00"),
                new SubInfo(12, "YouTube","58014", "2023-05-12 18:00"),
                new SubInfo(13, "YouTube","58133", "2023-05-13 18:00"),
                new SubInfo(14, "YouTube","58234", "2023-05-14 18:00"),
                new SubInfo(15, "YouTube","58309", "2023-05-15 18:00"),
                new SubInfo(16, "YouTube","58475", "2023-05-16 18:00"),
                new SubInfo(17, "YouTube","58695", "2023-05-17 18:00"),
                new SubInfo(18, "YouTube","58866", "2023-05-18 18:00"),
                new SubInfo(19, "YouTube","59121", "2023-05-19 18:00"),
                new SubInfo(20, "YouTube","59456", "2023-05-20 18:00"),
                new SubInfo(21, "YouTube","60000", "2023-05-21 18:00"),
                new SubInfo(22, "YouTube","62838", "2023-05-22 18:00"),
                new SubInfo(23, "YouTube","64005", "2023-05-23 18:00"),
                new SubInfo(24, "YouTube","64391", "2023-05-24 18:00"),
                new SubInfo(25, "YouTube","65092", "2023-05-25 18:00"),
                new SubInfo(26, "YouTube","65295", "2023-05-26 18:00"),
                new SubInfo(27, "YouTube","65857", "2023-05-27 18:00"),
                new SubInfo(28, "YouTube","66343", "2023-05-28 18:00"),
                new SubInfo(29, "YouTube","66343", "2023-05-29 18:00"),
                new SubInfo(30, "YouTube","67002", "2023-05-30 18:00"),
                new SubInfo(31, "YouTube","67340", "2023-05-31 18:00"),
            };

            Sub_values.ItemsSource = sub_info;

        }

        public void BuildChart()
        {
            Sub_chart = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "YouTube",
                    Values = new ChartValues<int> 
                    {
                        57395,
                        57640,
                        57816,
                        58014, 
                        58133, 
                        58234,
                        58309, 
                        58475, 
                        58695, 
                        58866,
                        59121,
                        59456,
                        60000, 
                        62838,
                        64005, 
                        64391, 
                        65092,
                        65295, 
                        65857, 
                        66343, 
                        66343,
                        67002, 
                        67340
                    }
                }
            };

            Labels = new[] 
            { 
                "2023-05-01 18:00", 
                "2023-05-02 18:00", 
                "2023-05-03 18:00", 
                "2023-05-04 18:00", 
                "2023-05-05 18:00",
                "2023-05-06 18:00",
                "2023-05-07 18:00",
                "2023-05-08 18:00",
                "2023-05-09 18:00",
                "2023-05-10 18:00",
                "2023-05-11 18:00",
                "2023-05-12 18:00",
                "2023-05-13 18:00",
                "2023-05-14 18:00",
                "2023-05-15 18:00",
                "2023-05-16 18:00",
                "2023-05-17 18:00",
                "2023-05-18 18:00",
                "2023-05-19 18:00",
                "2023-05-20 18:00",
                "2023-05-21 18:00",
                "2023-05-22 18:00",
                "2023-05-23 18:00",
                "2023-05-24 18:00",
                "2023-05-25 18:00",
                "2023-05-26 18:00",
                "2023-05-27 18:00",
                "2023-05-28 18:00",
                "2023-05-29 18:00",
                "2023-05-30 18:00",
                "2023-05-31 18:00"
            };
            YFormatter = value => value.ToString("C");

            DataContext = this;
        }
        public void GetPartPostInfo()
        {
            List<Post> part_post_data = new List<Post>
            {
                new Post(1, "Акция 9 мая", "Конкурс", "2023-04-03 13:18", "Ильин Даниил", "ВКонтакте, Телеграмм"),
                new Post(2, "Утренний пост", "Взаимодействие с аудиторией", "2023-04-11 11:52", "Алиев Игорь", "ВКонтакте, Телеграмм"),
                new Post(3, "Пост от подписчика", "От подписчика", "2023-04-03 13:18", "Ильин Даниил", "ВКонтакте"),
                new Post(4, "Анонс видео", "Информационный", "2023-04-10 18:26", "Ильин Даниил", "ВКонтакте, Телеграмм, YouTube"),
                new Post(5, "Мем", "Взаимодействие с аудиторией", "2023-04-10 15:14", "Алиев Игорь", "ВКонтакте, Телеграмм"),
                new Post(6, "Реклама грядущего поступления HT-1", "Рекламный", "2023-04-10 18:26", "Алиев Игорь", "YouTube, Телеграмм")
            };

            Publication_info.ItemsSource = part_post_data;
        }
        public void GetReserveInfo()
        {
            List<ReserveInfo> reserve_data = new List<ReserveInfo>
            {
                new ReserveInfo(1, "Видео №1", "2023-04-02", "Закрыт"),
                new ReserveInfo(2, "Задание №3", "2023-05-11", "Закрыт"),
                new ReserveInfo(3, "Видео №3", "2023-04-11", "Закрыт"),
                new ReserveInfo(4, "Публикация №6", "2023-04-08 ", "Активен")
            };

            Reserve_info.ItemsSource = reserve_data;
        }
        public void GetEmployeeEfficiency()
        {
            List<TaskInfo> efficiency_table_data = new List<TaskInfo>
            {
                new TaskInfo(1, "Проверить комментарии", "2023-05-01 9:00", "2023-05-01 13:00", "2023-05-01 12:13"),
                new TaskInfo(2, "Написать текстовое описание к видеороликам", "2023-05-10 17:30", "2023-05-13 18:00", "2023-05-14 11:48"),
                new TaskInfo(3, "Сделый посты в соц сетях о новом поступлении", "2023-05-11 12:44", "2023-05-13 17:00","2023-05-13 13:54")
            };

            Employee_efficiency.ItemsSource = efficiency_table_data;
        }

        public void GetInfoForEventReport()
        {
            List<Event_report> event_table_data = new List<Event_report>
            { 
                new Event_report(1, "Встреча SMM", "Встреча с сотрудниками отдела SMM. \n Обсудим новый вектор развития канала на YouTube", "-", "2023-04-25"),
                new Event_report(2, "Поставка", "Новая поставка CRKT. \n Все позиции уже были на сайте. Нового промо не нужно", "-", "2023-05-02"),
                new Event_report(3, "Корпоратив", "Коллеги, собираемся на корпоратив. \nПриятно проведем пятничный вечер за пиццой и разговорами", "-", "2023-05-05"),
                new Event_report(4, "Новый бренд", "Поставка нового бренда \"Кузница Коваль\". \n Готовим новое промо", "Задача №3\nЗадача №4", "2023-05-09")
            };

            Event_report.ItemsSource = event_table_data;
        }
        public void GetEvent()
        {
            List<Event_report> event_data = new List<Event_report>
            {
                new Event_report(1, "Встреча SMM", "2023-04-25"),
                new Event_report(2, "Поставка", "2023-05-02"),
                new Event_report(3, "Корпоратив", "2023-05-05"),
                new Event_report(4, "Новый бренд", "2023-05-09")
            };

            Event.ItemsSource = event_data;
        }

        public void GetGoodsInfo()
        {
            List<Goods> good_info = new List<Goods>
            {
                new Goods(6478, "Складной нож Minimus\nДжинсовая Микарта", "N.C. Custom", "NCC287/1", 3, "Новинка"),
                new Goods(6477, "Складной нож Cicada\nЦикада", "N.C. Custom", "NCC106", 1, "Новинка"),
                new Goods(5464, "Складной нож Ultras-F\nStonewash, Tan", "N.C. Custom", "NCC200-SW/TN", 0, "-"),
                new Goods(3425, "Автоматический фронтальный выкидной\nнож Rover Bl", "Mr. Blade", "MB402-BSW/TN", 20, "Хит продаж"),
                new Goods(6479, "Складной нож Red Cosmo", "Mr.Blade", "-", 0, "Поступление 10.04.2023"),
                new Goods(5647, "Складной нож Bugout Benchmade \nCarbon M4", "Benchmade", "CU535-BK-M4-CF", 1, "-"),
                new Goods(2345, "Складной нож Counter Point XL\nAus-10A", "Cold Steel", "10AA", 3, "-"),
                new Goods(4565, "Автоматический складной нож\nTactical Response 2", "Pro-Tech", "TR-2.67", 0, "-"),
                new Goods(5676, "Складной нож 0308 Coyote", "Zero Tolerance", "0308", 5, "Первое поступление"),
            };

            Goods.ItemsSource = good_info;
        }

        public void GetPubStat()
        {
            List<PubStat> pub_stat = new List<PubStat>
            { 
                new PubStat("Количество лайков", "325", "2023-04-12 14:00"),
                new PubStat("Количество репостов", "52", "2023-04-12 14:00"),
                new PubStat("Количество просмотров", "8000", "2023-04-12 14:00"),
            };
            Stat_pub.ItemsSource = pub_stat;
        }
        public void GetVideoStat()
        {
            List<VidStat> pub_stat = new List<VidStat>
            {
                new VidStat("Количество лайков", "904", "2023-04-12 14:00"),
                new VidStat("Количество комментариев", "127", "2023-04-12 14:00"),
                new VidStat("Количество просмотров", "18000", "2023-04-12 14:00"),
            };
            Stat_vid.ItemsSource = pub_stat;
        }

        /*public void GetTaskStat()
        {
            List<Task_stat> task_table_stat = new List<Task_stat>
            {
                new Task_stat(1, "Проверить комментарии", "Видеоролик №23", "Алиев Игорь","Миронов Александр", "Выполнено"),
                new Task_stat(2, "Написать текстовое описание к видеороликам", "-", "Ильин Даниил","Миронов Александр", "Выполнено"),
                new Task_stat(3, "Сделый посты в соц сетях о новом поступлении", "Событие №7", "Алиев Игорь","Миронов Александр", "Выполнено"),
                new Task_stat(4, "Загрузить товар на сайт", "Событие №7", "Алиев Игорь", "Вагиф Исмет Оглы", "В работе"),
                new Task_stat(5, "Добавить товар на Авито", "-", "Семенов Сергей","Вагиф Исмет Оглы", "В работе")
            };

            Task_stat.ItemsSource = task_table_stat;

            List<Task_status> task_status_amount = new List<Task_status>
            { 
                new Task_status("В работе", 2),
                new Task_status("Выполнено с опозданием", 1),
                new Task_status("Выполнено вовремя", 2)
            };


            SeriesCollection s = new SeriesCollection();
            for (int i = 0; i < task_status_amount.Count; i++)
            {
                s.Add(new PieSeries
                {
                    Title = task_status_amount[i].status_name,
                    Values = new ChartValues<ObservableValue> { new ObservableValue(task_status_amount[i].task_amount) },
                    DataLabels = true
                });
            }

            Task_status_view = s;

            List<Task_employee_director> task_directors = new List<Task_employee_director>
            {
                new Task_employee_director("Миронов Александр", 2),
                new Task_employee_director("Вагиф Исмет Оглы", 2)
            };


            SeriesCollection dir = new SeriesCollection();
            for (int i = 0; i < task_directors.Count; i++)
            {
                dir.Add(new PieSeries
                {
                    Title = task_directors[i].director_name,
                    Values = new ChartValues<ObservableValue> { new ObservableValue(task_directors[i].task_amount) },
                    DataLabels = true
                });
            }

            Task_dir = dir;

            List<Task_employee_executor> task_executor = new List<Task_employee_executor>
            {
                new Task_employee_executor("Алиев Игорь", 2),
                new Task_employee_executor("Ильин Даниил", 1),
                new Task_employee_executor("Семенов Сергей", 1)
            };


            SeriesCollection exe = new SeriesCollection();
            for (int i = 0; i < task_executor.Count; i++)
            {
                exe.Add(new PieSeries
                {
                    Title = task_executor[i].executor_name,
                    Values = new ChartValues<ObservableValue> { new ObservableValue(task_executor[i].task_amount) },
                    DataLabels = true
                });
            }

            Task_exe = exe;
        }*/

        private void Video_info_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            new FullVideoInfo().Show();
        }

        private void Task_info_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            new FullTask().Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new CreateVideo().Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            new NewTask().Show();
        }

        private void Reserve_info_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            new FullReserve().Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            new NewReserve().Show();
        }

        private void Event_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            new FullEvent().Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            new NewVideoStat().Show();
        }
    }
}
