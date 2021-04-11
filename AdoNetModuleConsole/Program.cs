using System;


namespace AdoNetModuleConsole
{
    class Program
    {
       static Manager magager;

        static void Main(string[] args)
        {
            magager = new Manager();

            magager.Connect();

            Console.WriteLine("Список комманд для работы консоли:");
            Console.WriteLine(Commands.stop + ": прекращение работы");
            Console.WriteLine(Commands.add + ": добавление данных");
            Console.WriteLine(Commands.delete + ": удаление данных");
            Console.WriteLine(Commands.update + ": обновление данных");
            Console.WriteLine(Commands.show + ": просмотр данных");

            Console.WriteLine();

            string command;
            do
            {
                Console.WriteLine("Введите команду:");
                command = Console.ReadLine();
                Console.WriteLine();

                switch (command)
                {
                    case
                        nameof(Commands.add):
                        {
                            Add();
                            break;
                        }

                    case
                        nameof(Commands.delete):
                        {
                            Delete();
                            break;
                        }
                    case
                       nameof(Commands.update):
                        {
                            Update();
                            break;
                        }
                    case
                         nameof(Commands.show):
                        {
                            magager.ShowDataUsers();
                            break;
                        }

                }

            } while (command != nameof(Commands.stop));


            magager.Disconnect();

            Console.ReadKey();

        }

        static void Update()
        {
            Console.WriteLine("Введите логин для обновления:");

            var login = Console.ReadLine();

            Console.WriteLine("Введите имя для обновления:");
            var name = Console.ReadLine();


            var count = magager.UpdateUserByLogin(login, name);

            Console.WriteLine("Строк обновлено" + count);

            magager.ShowDataUsers();
        }

        static void Add()
        {
            Console.WriteLine("Введите логин для добавления:");

            var login = Console.ReadLine();

            Console.WriteLine("Введите имя для добавления:");
            var name = Console.ReadLine();

            magager.AddUser(login, name);

            magager.ShowDataUsers();
        }

        static void Delete()
        {
            Console.WriteLine("Введите логин для удаления:");

            var count = magager.DeleteUserByLogin(Console.ReadLine());

            Console.WriteLine("Количество удаленных строк " + count);

            magager.ShowDataUsers();
        }

        



    }
}
