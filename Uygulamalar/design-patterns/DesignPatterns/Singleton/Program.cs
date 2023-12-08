//Bu nesneyi hiçbir zaman newleyerek oluşturamam
// Bir kere üretildiğiden emin olacak şekilde üretmiş oluyoruz. 
/*UserManager userManager = new UserManager();*///BÖYLE OLUŞTURAMAM

//Aşağıdaki örnekle bir kere oluştuğundan emin oldum. 
var userManager = UserManager.CreateAsSignleton();
userManager.Save();


class UserManager
{
    private  static UserManager _userManager;

    //thread safe.
    static object _lockObject = new object();
    //Dış erişimi engellemek için private bir UserManager oluştururlur
    private UserManager()
    {

    }

    public static UserManager CreateAsSignleton()
    {
        //if(_userManager == null)
        //{
        //    _userManager = new UserManager();
        //}

        //return _userManager ?? (_userManager = new UserManager());

        lock (_lockObject)
        {
            if (_userManager == null)
            {
                _userManager = new UserManager();
            }
        }

        return _userManager;

    }
    //static yazarsam kullanamam. 
    public void Save()
    {
        Console.WriteLine("Kayıt işlemi başarıyla kaydedildi.");
    }
}
