using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public enum AllOperationType
    {
        Search,
        Sort,
        AboutProgram,
        Save,
        Load,
        AddAuthor
    }

    public class Operation
    {
        public AllOperationType OperationType;
        public Operation() { }
        public string GetString()
        {
            switch (this.OperationType)
            {
                case AllOperationType.Search:
                    return "Поиск";
                case AllOperationType.Sort:
                    return "Сортировка";
                case AllOperationType.AboutProgram:
                    return "О программе";
                case AllOperationType.Save:
                    return "Сохранить";
                case AllOperationType.Load:
                    return "Загрузка";
                    case AllOperationType.AddAuthor:
                    return "Добавить автора";
                default:
                    return "";
            }
        }
    }
}
