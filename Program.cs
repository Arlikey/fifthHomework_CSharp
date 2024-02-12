namespace fifthHomework
{
    /*class MainTask
    {
        static void Main()
        {
            Book[] books = {
                new Book("1984", "Джодж Оруэлл", 1949),
                new Book("Убить пересмешника", "Харпер Ли", 1960),
                new Book("Над пропастью во ржи", "Джером Д. Сэлинджер", 1951)
            };

            Library library = new Library(books);
            foreach (Book book in library.GetBooks())
            {
                Console.WriteLine(book.Info());
            }

            Console.WriteLine("\n\nПОСЛЕ ДОБАВЛЕНИЯ КНИГИ\n\n");

            library.AddBook(new Book("Мастер и Маргарита", "Михаил Булгаков", 1966));

            foreach (Book book in library.GetBooks())
            {
                Console.WriteLine(book.Info());
            }

            library.SortByTitle();

            Console.WriteLine("\n\nСОРТИРОВКА ПО НАЗВАНИЮ\n\n");

            foreach (Book book in library.GetBooks())
            {
                Console.WriteLine(book.Info());
            }

        }

        class Book
        {
            public string Id = Guid.NewGuid().ToString();
            public string Title;
            public string Author;
            public int Date;

            public Book(string title, string author, int date)
            {
                Title = title;
                Author = author;
                Date = date;
            }

            public string Info()
            {
                return $"Id - {Id}, Название - \"{Title}\", Автор - {Author}, Дата - {Date}";
            }
        }

        class Library
        {
            private Book[] books;

            public Library(Book[] books)
            {
                this.books = books;
            }

            public Book[] GetBooks() => books;

            public Book? GetBook(string Id)
            {
                for (int i = 0; i < books.Length; i++)
                {
                    if (books[i].Id.Equals(Id))
                    {
                        return books[i];
                    }
                }
                return null;
            }

            public Book? FindBookByTitle(string Title)
            {
                for (int i = 0; i < books.Length; i++)
                {
                    if (books[i].Title.Equals(Title))
                    {
                        return books[i];
                    }
                }
                return null;
            }

            public void AddBook(Book book)
            {
                Book[] tempBooks = new Book[books.Length + 1];

                for (int i = 0; i < books.Length; i++)
                {
                    tempBooks[i] = books[i];
                }

                tempBooks[books.Length] = book;
                books = tempBooks;
            }

            public void DeleteBook(string Id)
            {
                Book[] tempBooks = new Book[books.Length - 1];

                for (int i = 0, j = 0; i < books.Length; i++)
                {
                    if (books[i].Id.Equals(Id)) continue;

                    tempBooks[j++] = books[i];
                }

                books = tempBooks;
            }

            public void SortByTitle()
            {
                for (int i = 0; i < books.Length-1; i++)
                {
                    for (int j = 0; j < books.Length-i-1; j++)
                    {
                        if (books[j].Title.CompareTo(books[j+1].Title) > 0)
                        {
                            (books[j], books[j+1]) = (books[j+1], books[j]);
                        }
                    }
                }
            }

            public void SortByAuthor()
            {
                for (int i = 0; i < books.Length-1; i++)
                {
                    for (int j = 0; j < books.Length - i - 1; j++)
                    {
                        if (books[j].Author.CompareTo(books[j+1].Author) > 0)
                        {
                            (books[j], books[j + 1]) = (books[j + 1], books[j]);
                        }
                    }
                }
            }
        }
    }*/

    /*class AdditionalTask1
    {
        static void Main()
        {
            Counter counter = new Counter();
            
            for (int i = 0; i < 15; i++)
            {
                if (i < 7) { counter.Decrease(); }
                else { counter.Increase(); }
                Console.WriteLine($"Счётчик - {counter.CurrentValue}");
            }
            
            Console.WriteLine("\n\nНОВЫЙ СЧЁТЧИК ОТ -3 ДО 5\n\n");
            
            counter = new Counter(-3, 5);
            
            for (int i = 0; i < 15; i++)
            {
                if (i < 7) { counter.Decrease(); }
                else { counter.Increase(); }
                Console.WriteLine($"Счётчик - {counter.CurrentValue}");
            }
        }

        class Counter
        {
            public int minValue;
            public int maxValue;
            private int currentValue;
            public int CurrentValue { get => currentValue; }

            public Counter()
            {
                minValue = 0;
                maxValue = 10;
            }

            public Counter(int minValue, int maxValue)
            {
                this.minValue = minValue;
                this.maxValue = maxValue;
                currentValue = minValue;
            }

            public void Increase()
            {
                if (currentValue == maxValue)
                {
                    currentValue = minValue;
                    return;
                }
                currentValue++;
            }

            public void Decrease()
            {
                if (currentValue == minValue)
                {
                    currentValue = maxValue;
                    return;
                }
                currentValue--;
            }
        }
    }*/

    /*class AdditionalTask2
    {
        static void Main()
        {
            User[] users = {
                new User("gser1", "hash1", "aser1@example.com"),
                new User("zser2", "hash2", "bser2@example.com"),
                new User("bser3", "hash3", "hser3@example.com"),
                new User("tser4", "hash4", "zser4@example.com"),
                new User("iser5", "hash5", "tser5@example.com")
            };

            foreach (User user in users)
            {
                Console.WriteLine(user.Info());
            }

            Console.WriteLine("\n\nПосле сортировки по email\n\n");

            User.SortByEmail(users);

            foreach (User user in users)
            {
                Console.WriteLine(user.Info());
            }

            Console.WriteLine("\n\nПосле сортировки по login\n\n");

            User.SortByLogin(users);

            foreach (User user in users)
            {
                Console.WriteLine(user.Info());
            }
        }

        class User 
        {
            public string Id = Guid.NewGuid().ToString();
            public string Login;
            public string PasswordHash;
            public string Email;

            public User(string login, string passwordHash, string email)
            {
                Login = login;
                PasswordHash = passwordHash;
                Email = email;
            }

            public static void SortByEmail(User[] users)
            {
                for (int i = 0; i < users.Length; i++)
                {
                    for (int j = 0; j < users.Length - i - 1; j++)
                    {
                        if (users[j].Email.CompareTo(users[j+1].Email) > 0)
                        {
                            (users[j], users[j + 1]) = (users[j + 1], users[j]);
                        }
                    }
                }
            }

            public static void SortByLogin(User[] users)
            {
                for (int i = 0; i < users.Length; i++)
                {
                    for (int j = 0; j < users.Length - i - 1; j++)
                    {
                        if (users[j].Login.CompareTo(users[j+1].Login) > 0)
                        {
                            (users[j], users[j + 1]) = (users[j + 1], users[j]);
                        }
                    }
                }
            }

            public string Info()
            {
                return $"Id - {Id}, Логин - {Login}, Пароль - {PasswordHash}, Почта - {Email}";
            }
        }
    }*/

    /*class AdditionalTask4
    {
        static void Main()
        {
            Encryptor text = new Encryptor("Home", 7);
            Console.WriteLine(text.value);
            text.Crypt();
            Console.WriteLine(text.value);
            text.Encrypt();
            Console.WriteLine(text.value);
        }

        class Encryptor
        {
            public string value;
            public int key;

            public Encryptor(string value, int key)
            {
                this.value = value;
                this.key = key;
            }

            public void Crypt()
            {
                string crypted = "";
                char firstLetter;
                for (int i = 0; i < value.Length; i++)
                {
                    if (char.IsLetter(value[i]))
                    {

                        firstLetter = char.IsUpper(value[i]) ? 'A' : 'a';

                        crypted += (char)((value[i] - firstLetter + key + 26) % 26 + firstLetter);
                        continue;
                    }
                    crypted += value[i];
                }
                value = crypted;
            }
            public void Encrypt()
            {
                string crypted = "";
                char firstLetter;
                for (int i = 0; i < value.Length; i++)
                {
                    if (char.IsLetter(value[i]))
                    {

                        firstLetter = char.IsUpper(value[i]) ? 'A' : 'a';

                        crypted += (char)((value[i] - firstLetter - key + 26) % 26 + firstLetter);
                        continue;
                    }
                    crypted += value[i];
                }
                value = crypted;
            }

        }
    }*/


}
