namespace PhotoService;

public class SingletoneStorage
{
    private static SingletoneStorage _object = null;
    public Context Storage { get; private set; }
    public int UserId { get; private set; }

    private SingletoneStorage()
    {
        Storage = new Context();
    }

    public static SingletoneStorage GetStorage()
    {
        if (_object is null)
        {
            _object = new SingletoneStorage();
        }

        return _object;
    }
    
    public void SetUserId(int userId)
    {
        UserId = userId;
    }
}