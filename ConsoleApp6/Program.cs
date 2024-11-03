using System; // Подключение пространства имен System.

namespace ToDoApp // Объявление пространства имен ToDoApp.
{
    class Program // Объявление класса Program.
    {
        static void Main(string[] args) // Главный метод Main, точка входа в программу.
        {
            var todoList = new ToDoList(); // Создание экземпляра класса ToDoList.
            bool exit = false; // Переменная для управления циклом программы.

            while (!exit) // Цикл, работающий до тех пор, пока exit не станет true.
            {
                // Вывод меню
                Console.WriteLine("\n=== To-Do List ==="); // Заголовок меню.
                Console.WriteLine("1. Добавить задачу"); // Опция 1.
                Console.WriteLine("2. Удалить задачу"); // Опция 2.
                Console.WriteLine("3. Отметить задачу как выполненную"); // Опция 3.
                Console.WriteLine("4. Показать все задачи"); // Опция 4.
                Console.WriteLine("5. Выйти"); // Опция 5.
                Console.Write("Выберите опцию: "); // Приглашение для ввода выбора.

                string choice = Console.ReadLine(); // Считывание выбора пользователя.

                switch (choice) // Обработка выбора пользователя.
                {
                    case "1": // Если выбрана опция 1.
                        Console.Write("Введите ID задачи: "); // Запрос ввода ID задачи.
                        int id; // Переменная для хранения ID.
                        while (!int.TryParse(Console.ReadLine(), out id)) // Проверка корректности ввода ID.
                        {
                            Console.Write("Некорректный ввод. Введите числовой ID задачи: "); // Сообщение об ошибке ввода.
                        }
                        Console.Write("Введите описание задачи: "); // Запрос ввода описания задачи.
                        string description = Console.ReadLine(); // Считывание описания задачи.
                        todoList.AddItem(id, description); // Добавление задачи в список.
                        break;

                    case "2": // Если выбрана опция 2.
                        Console.Write("Введите ID задачи для удаления: "); // Запрос ввода ID задачи для удаления.
                        int removeId; // Переменная для хранения ID.
                        while (!int.TryParse(Console.ReadLine(), out removeId)) // Проверка корректности ввода ID.
                        {
                            Console.Write("Некорректный ввод. Введите числовой ID задачи: "); // Сообщение об ошибке ввода.
                        }
                        todoList.RemoveItem(removeId); // Удаление задачи из списка.
                        break;

                    case "3": // Если выбрана опция 3.
                        Console.Write("Введите ID задачи для отметки как выполненной: "); // Запрос ввода ID задачи.
                        int completeId; // Переменная для хранения ID.
                        while (!int.TryParse(Console.ReadLine(), out completeId)) // Проверка корректности ввода ID.
                        {
                            Console.Write("Некорректный ввод. Введите числовой ID задачи: "); // Сообщение об ошибке ввода.
                        }
                        todoList.MarkItemAsCompleted(completeId); // Отметка задачи как выполненной.
                        break;

                    case "4": // Если выбрана опция 4.
                        todoList.ListItems(); // Вывод всех задач.
                        break;

                    case "5": // Если выбрана опция 5.
                        exit = true; // Установка флага выхода из программы.
                        break;

                    default: // Если введен некорректный выбор.
                        Console.WriteLine("Некорректный выбор. Пожалуйста, попробуйте снова."); // Сообщение об ошибке.
                        break;
                }
            }
        }
    }
}
