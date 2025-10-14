namespace Librarybooling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            library.AddUser(library.CreateUser());
            library.AddBook(library.CreateBook());

            Reservation reservation = library.CreateReservation();
            if (reservation == null)
                return;

            library.AddReservation(reservation);

            library.ShowInfo();

        }
    }
}
