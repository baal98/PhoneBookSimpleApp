using AutoMapper;
using Business.IRepository;
using PhoneBook_DataAccess;
using PhoneBook_DataAccess.Data;
using UsersModels;

namespace Business.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDBContext _db;
        private readonly IMapper _mapper;

        public UserRepository(ApplicationDBContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public UserModelDTO CreateUser(UserModelDTO objDto)
        {
            var obj = _mapper.Map<UserModelDTO, User>(objDto);
            var addedObj = _db.Users.Add(obj);
            _db.SaveChanges();
            return _mapper.Map<User, UserModelDTO>(addedObj.Entity);
        }

        public UserModelDTO UpdateUser(UserModelDTO objDto)
        {
            var obj = _db.Users.Find(objDto.Id);
            if (obj != null)
            {
                _mapper.Map(objDto, obj);
                _db.SaveChanges();
                return _mapper.Map<User, UserModelDTO>(obj);
            }
            return null;
        }

        public UserModelDTO DeleteUser(UserModelDTO objDto)
        {
            var objFromDb = _db.Users.Find(objDto.Id);
            if (objFromDb != null)
            {
                _db.Users.Remove(objFromDb);
                _db.SaveChanges();
                return _mapper.Map<User, UserModelDTO>(objFromDb);
            }
            return null;
        }

        public UserModelDTO GetUserById(int id)
        {
            var obj = _db.Users.Find(id);
            if (obj != null)
            {
                return _mapper.Map<User, UserModelDTO>(obj);
            }
            return new UserModelDTO();
        }

        public IEnumerable<UserModelDTO> GetAllUsers()
        {
            var obj = _db.Users.ToList();
            return _mapper.Map<IEnumerable<User>, IEnumerable<UserModelDTO>>(obj);
        }
    }
}

//this is the code for repository pattern !!!
//public UserModelDTO CreateUser(UserModelDTO objDto)
//{
//    User user = new User()
//    {
//        Name = objDto.Name,
//        Email = objDto.Email,
//        Address = objDto.Address,
//        Phone = objDto.Phone,
//        Facebook = objDto.Facebook,
//        CreateDate = DateTime.Now,
//        IsActive = objDto.IsActive
//    };
//    _db.Users.Add(user);
//    _db.SaveChanges();
//    return new UserModelDTO()
//    {
//        Id = user.Id,
//        Name = user.Name,
//        Email = user.Email,
//        Address = user.Address,
//        Phone = user.Phone,
//        Facebook = user.Facebook,
//        CreateDate = DateTime.Now,
//        IsActive = user.IsActive
//    };
//}

//public UserModelDTO UpdateUser(UserModelDTO objDto)
//{
//    User user = _db.Users.FirstOrDefault(u => u.Id == objDto.Id);
//    if (user != null)
//    {
//        user.Name = objDto.Name;
//        user.Email = objDto.Email;
//        user.Address = objDto.Address;
//        user.Phone = objDto.Phone;
//        user.Facebook = objDto.Facebook;
//        user.CreateDate = DateTime.Now;
//        user.IsActive = objDto.IsActive;
//        _db.SaveChanges();
//        return new UserModelDTO()
//        {
//            Id = user.Id,
//            Name = user.Name,
//            Email = user.Email,
//            Address = user.Address,
//            Phone = user.Phone,
//            Facebook = user.Facebook,
//            CreateDate = DateTime.Now,
//            IsActive = user.IsActive
//        };
//    }
//    return null;
//}

//public UserModelDTO DeleteUser(UserModelDTO objDto)
//{
//    User user = _db.Users.FirstOrDefault(u => u.Id == objDto.Id);
//    if (user != null)
//    {
//        _db.Users.Remove(user);
//        _db.SaveChanges();
//        return new UserModelDTO()
//        {
//            Id = user.Id,
//            Name = user.Name,
//            Email = user.Email,
//            Address = user.Address,
//            Phone = user.Phone,
//            Facebook = user.Facebook,
//            CreateDate = DateTime.Now,
//            IsActive = user.IsActive
//        };
//    }
//    return null;
//}

//public UserModelDTO GetUserById(int id)
//{
//    User user = _db.Users.FirstOrDefault(u => u.Id == id);
//    if (user != null)
//    {
//        return new UserModelDTO()
//        {
//            Id = user.Id,
//            Name = user.Name,
//            Email = user.Email,
//            Address = user.Address,
//            Phone = user.Phone,
//            Facebook = user.Facebook,
//            CreateDate = DateTime.Now,
//            IsActive = user.IsActive
//        };
//    }
//    return null;
//}

//public IEnumerable<UserModelDTO> GetAllUsers()
//{
//    List<UserModelDTO> users = new List<UserModelDTO>();
//    foreach (var user in _db.Users)
//    {
//        users.Add(new UserModelDTO()
//        {
//            Id = user.Id,
//            Name = user.Name,
//            Email = user.Email,
//            Address = user.Address,
//            Phone = user.Phone,
//            Facebook = user.Facebook,
//            CreateDate = DateTime.Now,
//            IsActive = user.IsActive
//        });
//    }
//    return users;
//}
