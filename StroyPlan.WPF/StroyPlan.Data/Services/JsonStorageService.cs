using System;
using System.IO;
using System.Text.Json;

namespace StroyPlan.Data.Services
{
    public class JsonStorageService
    {
        private readonly JsonSerializerOptions _options;

        public JsonStorageService()
        {
            // Настройка: делать JSON красивым (с отступами) и игнорировать регистр букв
            _options = new JsonSerializerOptions
            {
                WriteIndented = true,
                PropertyNameCaseInsensitive = true
            };
        }

        // Сохранение объекта в файл
        public void Save<T>(string filePath, T data)
        {
            string jsonString = JsonSerializer.Serialize(data, _options);
            File.WriteAllText(filePath, jsonString);
        }

        // Загрузка объекта из файла
        public T? Load<T>(string filePath)
        {
            if (!File.Exists(filePath)) return default;

            string jsonString = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<T>(jsonString, _options);
        }
    }
}