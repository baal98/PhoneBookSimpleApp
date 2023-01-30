using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersModels;

namespace Business.IRepository
{
    public interface IUserRepository
    {
        public UserModelDTO CreateUser(UserModelDTO objDto);
        public UserModelDTO UpdateUser(UserModelDTO objDto);
        public UserModelDTO DeleteUser(UserModelDTO objDto);
        public UserModelDTO GetUserById(int id);
        public IEnumerable<UserModelDTO> GetAllUsers();
        public List<UserModelDTO> SearchUsers(string objSearch);
    }
}
