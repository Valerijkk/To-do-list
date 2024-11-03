using System; // Подключение пространства имен System, которое содержит фундаментальные классы.

namespace ToDoApp // Объявление пространства имен ToDoApp.
{
    public class ToDoItem // Объявление публичного класса ToDoItem.
    {
        public int Id { get; set; } // Свойство Id с методами доступа get и set.
        public string Description { get; set; } // Свойство Description с методами доступа get и set.
        public bool IsCompleted { get; set; } // Свойство IsCompleted с методами доступа get и set.

        public ToDoItem(int id, string description) // Конструктор класса ToDoItem с параметрами id и description.
        {
            Id = id; // Присваивание значения параметра id свойству Id.
            Description = description; // Присваивание значения параметра description свойству Description.
            IsCompleted = false; // Инициализация свойства IsCompleted значением false.
        }

        public void MarkAsCompleted() // Метод для отметки задачи как выполненной.
        {
            IsCompleted = true; // Установка свойства IsCompleted в true.
        }

        public override string ToString() // Переопределение метода ToString для удобного вывода информации о задаче.
        {
            string status = IsCompleted ? "Выполнено" : "Не выполнено"; // Определение статуса задачи.
            return $"[{Id}] {Description} - {status}"; // Возврат строки с информацией о задаче.
        }
    }
}
