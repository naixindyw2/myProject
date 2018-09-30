namespace Game.Base
{
    public abstract class Singleton<T> where T : class, new()
    {
        private static T _instance;

        //public static void CreateInstance()
        //{
        //    if (_instance == null) {
        //        _instance = new T();
        //    }
        //}

        //public static void ReleaseInstance()
        //{
        //    if (_instance != null) {
        //        _instance = null;
        //    }
        //}

        public static T Instance
        {
            get
            {
                if (_instance == null) {
                    _instance = new T();
                }
                return _instance;
            }
        }
    }
}
