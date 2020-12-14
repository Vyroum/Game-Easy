# Игра, лёгкий уровень сложности разработки
Запускается через bin\Release\net5.0\Game (Easy).exe

Тестирование программы

На данном этапе разработки основные функции могут быть протестированы несколькими кейсами
Кейс 1 (проверка работоспособности метода стрельбы):
  1. Запустить программу
  2. Нажать Enter для старта
  3. Выбрать действие "Выстрелить" введя 1 с клавиатуры и нажать Enter
  4. Проверить что значение хп вражеского танка изменилось по формуле Жизни - Урон + Броня. В случае, если возникло сообщение что противник чинится, прибавить 10 к полученному значению
  
 Кейс 2 (проверка работоспособности метода починки)
  1. Запустить программу
  2. Нажать Enter для старта
  3. Выбрать действие "Починка" введя 2 с клавиатуры и нажать Enter
  4. Проверить что значение хп танка игрока изменилось по формуле Жизни + 10. В случае, если возникло сообщение что противник стреляет, рассчитать по формуле Жизни - Урон + Броня + 10
 
 Кейс 3 (проверка конечности игры с победой игрока)
  1. Запустить программу
  2. Нажать Enter для старта
  3. Выбрать действие "Выстрелить" введя 1 с клавиатуры и нажать Enter
  4. Повторять выбор действия "Выстрелить" пока хп вражеского танка не станет меньше или равно 0
  5. Проверить наличие надписи "Игрок победил"
 
 Кейс 4 (проверка конечности игры с победой врага)
  1. Запустить программу
  2. Нажать Enter для старта
  3. Выбрать действие "Починка" введя 1 с клавиатуры и нажать Enter
  4. Повторять выбор действия "Починка" пока хп танка игрока не станет меньше или равно 0
  5. Проверить наличие надписи "Враг победил"
  
 Кейс 5 (валидация пользовательского ввода)
  1. Запустить программу
  2. Нажать Enter для старта
  3. Ввести с клавиатуры символы не являющиеся 1 или 2, например 8, 5, ывп, фыву и нажать Enter
  4. Проверить наличие уведомляющего сообщения о неверном действии
  5. Ввести 1 или 2
 
 
