namespace Solid.App.LSPBad
{

    //Elinizde iki adet   class veya obje olabilir , bu class miras alan sub-class'lar arasına geçiş yaptığı zaman programın kırılmaması lazım.

    // Aşağıdaki kötü örnekde nokia3310 fotoğraf çekme özelliği yok fakat base class 'a biz bu özelliği verdiğimiz için program kırılacak ve bu kural ihlal edilecek.

    public abstract class BasePhone
    {
        public void Call()
        {
            Console.WriteLine("Arama Yapıldı");
        }
        public abstract void TakePhoto();

    }
    public class IPhone : BasePhone
    {
        public override void TakePhoto()
        {
            Console.WriteLine("Fotoğraf çekildi");
        }
    }
    public class Nokia3310 : BasePhone
    {
        public override void TakePhoto()
        {
            throw new NotImplementedException();
        }
    }
}
