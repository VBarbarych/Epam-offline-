using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TaskOfSerealizations.Task1;
using LibraryOfInterfacesAndClasses.AdditionalClasses;
using LibraryOfInterfacesAndClasses.AdditionalInterfaces;
using System.Runtime.Serialization.Formatters.Binary;
using Logger;

namespace TaskOfSerializations
{
    public class MainClassOfSerializations : IRunable
    {
        private IWriteReadable WriteReadOfData;
        private ILogging logger;

        public MainClassOfSerializations(IWriteReadable writeReadOfData, ILogging logger)
        {
            this.WriteReadOfData = writeReadOfData;
            this.logger = logger;
        }

        [XmlArray("CarList"), XmlArrayItem(typeof(Car), ElementName = "prop")]
        public List<Car> listOfCar = new List<Car> {new Car(1, 43244, 87, 783642),
                                              new Car(2, 54354, 34, 136474),
                                              new Car(3, 12348, 67, 534523)};

        public List<Car> deserializedListByBinary = new List<Car>();
        public List<Car> deserializedListByXML = new List<Car>();
        public List<Car> deserializedListByJSON = new List<Car>();

        public void ImplementBinarySerialization()
        {
            BinaryData data = new BinaryData();

            try
            {
                data.Serialization(listOfCar);
                deserializedListByBinary = data.Deserialization();
            }
            catch(Exception ex)
            {
                logger.Log(LogLevel.Error, ex.Message);
            }
        }

        
        public void ImplementXMLSerialization()
        {
            XMLData data = new XMLData();

            try
            { 
            data.Serialization(listOfCar);
            deserializedListByXML = data.Deserialization();
            }
            catch (Exception ex)
            {
                logger.Log(LogLevel.Error, ex.Message);
            }
        }

        public void ImplementJSONSerialization()
        {
            JSONData data = new JSONData();

            try
            { 
            data.Serialization(listOfCar);
            deserializedListByJSON = data.Deserialization();
            }
            catch (Exception ex)
            {
                logger.Log(LogLevel.Error, ex.Message);
            }
        }


        public void Run()
        {
            WriteReadOfData.Write("========Serialization=======\n");
            WriteReadOfData.Write("Serialized and Deserialized. Check related files");

            ImplementBinarySerialization();
            ImplementXMLSerialization();
            ImplementJSONSerialization();
        }

    }
}
