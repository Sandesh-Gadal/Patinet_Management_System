using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.Collections.Generic;



namespace mongodbConnection
{
    [Serializable]
    internal class Patient
    {
        [BsonId, BsonRepresentation(BsonType.ObjectId)]
        public string PatientId { get; set; }

      
        [BsonElement("PID"), BsonRepresentation(BsonType.Int32)]
        public int Pid { get; set; }

        [BsonElement("FullName"), BsonRepresentation(BsonType.String)]
        public string fullName { get; set; }

       
        [BsonElement("Age"), BsonRepresentation(BsonType.Int32)]
        public int age { get; set; }

        [BsonElement("Gender"), BsonRepresentation(BsonType.String)]
        public string gender { get; set; }

        [BsonElement("Address"), BsonRepresentation(BsonType.String)]
        public string address { get; set; }

        [BsonElement("PhoneNumber"), BsonRepresentation(BsonType.String)]
        public string phoneNumber { get; set; }

        [BsonElement("BloodGroup"), BsonRepresentation(BsonType.String)]
        public string bloodGroup { get; set; }


        [BsonElement("Disease"), BsonRepresentation(BsonType.String)]
        public string disease { get; set; }


    }
}

