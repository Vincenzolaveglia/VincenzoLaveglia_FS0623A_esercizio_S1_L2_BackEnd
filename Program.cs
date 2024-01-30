namespace EsercizioLezione2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.GetName();
            persona.GetSurname();
            persona.GetAge();

            persona.GetDetails();
            Console.WriteLine("Premere INVIO per uscire dal programma");
            Console.ReadLine();
        }
    }

    class Persona
    {
        private string _name;
        private string _surname;
        private int _age;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = value;
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }

        public void GetName()
        {
            Console.WriteLine("Inserisci il nome: ");
            _name = Console.ReadLine();
        }
        public void GetSurname()
        {
            Console.WriteLine("Inserisci il cognome: ");
            _surname = Console.ReadLine();
        }
        public void GetAge()
        {
            Console.WriteLine("Inserisci l'età: ");
            _age = int.Parse(Console.ReadLine());
        }
        public void GetDetails()
        {
            Console.WriteLine($"\n-------------------------------------------\n\nI dettagli della persona sono: \n Nome: {Name} \n Cognome: {Surname} \n Età: {Age} \n");
        }
    }
}
