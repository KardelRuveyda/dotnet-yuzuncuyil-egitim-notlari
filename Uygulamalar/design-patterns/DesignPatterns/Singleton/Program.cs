//Bu nesneyi hiçbir zaman newleyerek oluşturamam
// Bir kere üretildiğiden emin olacak şekilde üretmiş oluyoruz. 
/*UserManager userManager = new UserManager();*///BÖYLE OLUŞTURAMAM

#region Test İşlemi
//Aşağıdaki örnekle bir kere oluştuğundan emin oldum. 
var userManager = UserManager.CreateAsSignleton();
userManager.Save();
#endregion


#region UserManager Class oluşturulur.
class UserManager
{
    //Property eklenir.
    private static UserManager _userManager;

    #region Thread Safe
    static object _lockObject = new object();
    #endregion

    #region Constructor 
    //Dış erişimi engellemek için private bir UserManager oluşturulur.
    private UserManager()
    {

    }
    #endregion

    #region Singleton ve Thread Safe İçin Oluşturulan Static bir metot
    public static UserManager CreateAsSignleton()
    {
        //Var mı diye kontrol et ?
        //Oluşturulmadıysa o zaman yenisini oluştur.
        //Oluşturulduysa zaten onu döndür. 

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
    #endregion
    //static yazarsam kullanamam. 
    public void Save()
    {
        Console.WriteLine("Kayıt işlemi başarıyla kaydedildi.");
    }
}
#endregion