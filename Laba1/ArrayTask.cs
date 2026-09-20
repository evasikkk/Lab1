using System;
using System.Collections.Generic;

namespace Laba1
{
    internal class ArrayTask
    {
        // Масив із 5 прізвищ
        public string[] surnames = new string[5];

        // Метод для пошуку прізвищ, що починаються з заданої літери
        public List<string> GetSurnamesStartingWith(char letter)
        {
            List<string> result = new List<string>();

            if (surnames == null) return result;

            foreach (string surname in surnames)
            {
                if (!string.IsNullOrWhiteSpace(surname))
                {
                    // Порівнюємо першу літеру без урахування регістру (велика/мала)
                    if (surname.Trim().StartsWith(letter.ToString(), StringComparison.OrdinalIgnoreCase))
                    {
                        result.Add(surname.Trim());
                    }
                }
            }

            return result;
        }
    }
}