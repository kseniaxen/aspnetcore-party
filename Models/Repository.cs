using System.Collections.Generic;

namespace PartyInvites.Models {
    // имитация хранилища данных - вместо БД
    public static class Repository {
        // для хранения списка моделей в памяти
        private static List<GuestResponse> responses = new List<GuestResponse>();
        // метод чтения списка моделей - абстрация для сокрытия типа списка
        public static IEnumerable<GuestResponse> Responses => responses;
        // метод установки для списка моделей
        public static void AddResponse(GuestResponse response) {
            responses.Add(response);
        }
    }
}