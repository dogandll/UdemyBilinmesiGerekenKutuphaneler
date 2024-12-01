namespace Solid.App.LSPGood
{
    public interface ITakePhoto
    {
        void TakePhoto();
    }
    public   class BasePhone
    {

        public void Call()
        {
            Console.WriteLine("Arama Yapıldı");
        } 

    }
    public class IPhone : BasePhone, ITakePhoto
    {
        public void TakePhoto()
        {
            Console.WriteLine("Fotoğraf çekildi");
        }
    }
    public class Nokia3310 : BasePhone
    {
       
    }
}
