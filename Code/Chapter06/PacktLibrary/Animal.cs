namespace PacktLibrary
{
    public class Animal : IDisposable
    {
        public Animal()
        {
            // allocate unmanaged resources
        }
        ~Animal() // Finalizer 
        {
            if (disposed) return;
            Dispose(false);
        }
        bool disposed = false; // have resources been released?
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposed) return;
            // deallocate the *unmanaged* resources
            // ...
            if (disposing)
            {
                // deallocate any other *unmanaged* resources
                // ...
            }
            disposed = true;
        }
    }
}
