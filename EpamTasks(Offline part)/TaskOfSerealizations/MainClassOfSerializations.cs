using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using LibraryOfInterfacesAndClasses.AdditionalInterfaces;
using Logger;
using TaskOfSerealizations.Task1;

namespace TaskOfSerializations
{
    public class MainClassOfSerializations : IRunable
    {
        private IWriteReadable writeReadOfData;
        private ILogging logger;

        [XmlArray("CarList")]
        [XmlArrayItem(typeof(Car), ElementName = "prop")]
        private List<Car> listOfCar = new List<Car>
        {
            new Car(1, 43244, 87, 783642),
            new Car(2, 54354, 34, 136474),
            new Car(3, 12348, 67, 534523),
        };

        private List<Car> deserializedListByBinary = new List<Car>();
        private List<Car> deserializedListByXML = new List<Car>();
        private List<Car> deserializedListByJSON = new List<Car>();

        public MainClassOfSerializations(IWriteReadable writeReadOfData, ILogging logger)
        {
            this.writeReadOfData = writeReadOfData;
            this.logger = logger;
        }

        public void Run()
        {
            writeReadOfData.Write("========Serialization=======\n");
            writeReadOfData.Write("Serialized and Deserialized. Check related files");

            ImplementBinarySerialization();
            ImplementXMLSerialization();
            ImplementJSONSerialization();
        }

        public void ImplementBinarySerialization()
        {
            BinaryData data = new BinaryData();

            try
            {
                data.Serialization(listOfCar);
                deserializedListByBinary = data.Deserialization();
            }
            catch (Exception ex)
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
    }
}
