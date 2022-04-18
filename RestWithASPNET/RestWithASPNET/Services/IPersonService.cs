using RestWithASPNET.Model;

namespace RestWithASPNET.Services {
    public interface IPersonService {

        Person Create(Person person);
        Person FindByID(long id);
        Person Update(Person person);
        List<Person> FindAll();
        void Delete(long id);
    }
}
