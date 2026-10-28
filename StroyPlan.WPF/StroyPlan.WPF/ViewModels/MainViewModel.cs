using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows;

namespace StroyPlan.WPF.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        // Команда выбора объекта
        [RelayCommand]
        private void SelectObject()
        {
            MessageBox.Show("Выбор объекта: в разработке (следующий спринт)", "Заглушка");
        }

        // Команда выбора задачи
        [RelayCommand]
        private void SelectTask()
        {
            MessageBox.Show("Просмотр задачи: в разработке (следующий спринт)", "Заглушка");
        }

        // Остальные заглушки кнопок
        [RelayCommand]
        private void CreateObject() => MessageBox.Show("Создание объекта пока не работает", "Заглушка");

        [RelayCommand]
        private void CreateTask() => MessageBox.Show("Создание задачи пока не работает", "Заглушка");

        [RelayCommand]
        private void SaveProject() => MessageBox.Show("Сохранение пока не работает", "Заглушка");

        [RelayCommand]
        private void OpenProject() => MessageBox.Show("Открытие пока не работает", "Заглушка");
    }
}