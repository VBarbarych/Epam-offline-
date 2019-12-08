using LibraryOfInterfacesAndClasses.AdditionalInterfaces;
using Logger;
using TaskOfIOStream.Task1;
using TaskOfIOStream.Task2;

namespace TaskOfIOStream
{
    public class MainClassOfIOStream : IRunable
    {
        private IWriteReadable writeReadOfData;
        private ILogging logger;

        public MainClassOfIOStream(IWriteReadable writeReadOfData, ILogging logger)
        {
            this.writeReadOfData = writeReadOfData;
            this.logger = logger;
        }

        public void Run()
        {
            ImplementOfTask1();
            ImplementOfTask2();
        }

        private void ImplementOfTask1()
        {
            writeReadOfData.Write("\n========IO Stream=======\n");
            writeReadOfData.Write("=====Implement Task1====\n");
            writeReadOfData.Write("Show all file from directory: ");

            FileFromDirectories fileFromDirectories = new FileFromDirectories(writeReadOfData, logger);
            fileFromDirectories.OutputFilesFromDirectory();
        }

        private void ImplementOfTask2()
        {
            writeReadOfData.Write("\n=====Implement Task2====\n");

            SearchFile currentFile = new SearchFile(writeReadOfData, logger);
            currentFile.SearchFileInDirectories();
        }
    }
}
