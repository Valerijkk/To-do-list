using System; // Подключение пространства имен System.
using System.Collections.Generic; // Подключение пространства имен для использования коллекций.

namespace ToDoApp // Объявление пространства имен ToDoApp.
{
    public class ToDoList // Объявление публичного класса ToDoList.
    {
        private List<ToDoItem> items; // Приватное поле items для хранения списка задач.

        public ToDoList() // Конструктор класса ToDoList.
        {
            items = new List<ToDoItem>(); // Инициализация списка задач.
        }

        public void AddItem(int id, string description) // Метод для добавления новой задачи.
        {
            if (items.Exists(i => i.Id == id)) // Проверка, существует ли задача с таким ID.
            {
                Console.WriteLine("Задача с таким ID уже существует."); // Вывод сообщения об ошибке.
            }
            else
            {
                var item = new ToDoItem(id, description); // Создание нового объекта задачи.
                items.Add(item); // Добавление задачи в список.
                Console.WriteLine("Задача добавлена."); // Вывод сообщения об успешном добавлении.
            }
        }

        public void RemoveItem(int id) // Метод для удаления задачи по ID.
        {
            var item = items.Find(i => i.Id == id); // Поиск задачи с указанным ID.
            if (item != null) // Проверка, найдена ли задача.
            {
                items.Remove(item); // Удаление задачи из списка.
                Console.WriteLine("Задача удалена."); // Вывод сообщения об успешном удалении.
            }
            else
            {
                Console.WriteLine("Задача с таким ID не найдена."); // Вывод сообщения, что задача не найдена.
            }
        }

        public void MarkItemAsCompleted(int id) // Метод для отметки задачи как выполненной.
        {
            var item = items.Find(i => i.Id == id); // Поиск задачи с указанным ID.
            if (item != null) // Проверка, найдена ли задача.
            {
                item.MarkAsCompleted(); // Отметка задачи как выполненной.
                Console.WriteLine("Задача отмечена как выполненная."); // Вывод сообщения об успешной операции.
            }
            else
            {
                Console.WriteLine("Задача с таким ID не найдена."); // Вывод сообщения, что задача не найдена.
            }
        }

        public void ListItems() // Метод для вывода всех задач.
        {
            if (items.Count == 0) // Проверка, пуст ли список задач.
            {
                Console.WriteLine("Список задач пуст."); // Вывод сообщения о пустом списке.
            }
            else
            {
                Console.WriteLine("Текущие задачи:"); // Вывод заголовка.
                foreach (var item in items) // Цикл по всем задачам в списке.
                {
                    Console.WriteLine(item); // Вывод информации о задаче.
                }
            }
        }
    }
}
