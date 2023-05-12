namespace FileLoggerDisposableApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Use FileLogger and dispose of it properly
            using (var lggr = new FileLogger("log.txt"))
            {
                lggr.Log("entry 1");
                lggr.Log("entry 2");
            }
        }
    }

    class FileLogger : IDisposable
    {
        private StreamWriter _writer;

        public FileLogger(string filePath)
        {
            // Initialize StreamWriter instance
            _writer= new StreamWriter(filePath,true);
        }
        private bool disposed;
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing) {  
                    _writer.Dispose();
                }
                disposed = true;
            }
        }
        public void Dispose()
        {
            // Implement IDisposable pattern
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Log(string message)
        {
            // Write message to the file
            if (disposed)
                throw new ObjectDisposedException(nameof(FileLogger));
            _writer.WriteLine(message);
                 
            
        }
    }
}