using RestWithASPNET.Model;

namespace RestWithASPNET.Services.Implamentations {
    public class PersonServiceImplementation : IPersonService {
        private volatile int count;

        public Person Create(Person person) {
            return person;
        }

        public void Delete(long id) {
            
        }

        public List<Person> FindAll() {
            List<Person> persons = new List<Person>();
            for (int i = 0; i < 8; i++) {
                Person person = MockPerson(i);
                persons.Add(person);
            }
            return persons;
        }


        public Person FindByID(long id) {
            return new Person {
                Id = IncrementeAndGet(),
                FirstName = "Rogerio",
                LastName = "Silva",
                Address = "Quarto Centenário",
                Gender = "Male"
            };
        }

        public Person Update(Person person) {
            return person;
        }
        
        private Person MockPerson(int i) {
            return new Person {
                Id = IncrementeAndGet(),
                FirstName = "Person " + i + " Name",
                LastName = "Person " + i + " LastName",
                Address = "Address of person " + i,
                Gender = "Gender of person " + i,
            };
        }

        private long IncrementeAndGet() {
            return Interlocked.Increment(ref count);
        }
    }
}
