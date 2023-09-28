using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02
{
    internal class Task3
    {
        private static void Main()
        {
            bool first_try = true;
            Console.WriteLine("Введите ключ. При отсутствии ключа нажмите Enter");
            string key = Console.ReadLine();
            DocumentWorker worker = new DocumentWorker();
            if (key == "")
            {
                worker = new DocumentWorker();
            }
            else if (key[0] == 'p' && key[1] == 'r' && key[2] == 'o')
            {
                worker = new ProDocumentWorker();
            }
            else if (key[0] == 'e' && key[1] == 'x' && key[2] == 'p')
            {
                worker = new ExpertDocumentWorker();
            }
            else
            {
                Console.WriteLine("Неверный ключ. Попробуйте снова.\n");
                first_try = false;
                Main();
            }
            if (first_try) worker.TryEverything();
        }
    }
    public class ExpertDocumentWorker : ProDocumentWorker
    {
        protected override void Saving()
        {
            Console.WriteLine("Документ сохранен в новом формате");
        }
    }
    public class ProDocumentWorker : DocumentWorker
    {
        protected override void Editing()
        {
            Console.WriteLine("Документ отредактирован");
        }
        protected override void Saving()
        {
            Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Expert");
        }
    }
    public class DocumentWorker
    {
        public DocumentWorker() { }
        public void TryEverything()
        {
            OpenDocument();
            EditDocument();
            SaveDocument();
        }
        public void OpenDocument() => Opening();
        protected virtual void Opening()
        {
            Console.WriteLine("Документ открыт");
        }
        public void EditDocument() => Editing();
        protected virtual void Editing()
        {
            Console.WriteLine("Редактирование документа доступно в версии Pro");
        }
        public void SaveDocument() => Saving();
        protected virtual void Saving()
        {
            Console.WriteLine("Сохранение документа доступно в версии Pro");
        }
    }
}
