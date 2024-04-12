using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace mongodbConnection
{
    [Serializable]
    internal class bookedappointment
    {
        [BsonId, BsonElement("Ap_id"), BsonRepresentation(BsonType.ObjectId)]
        public string Appointmentid { get; set; }

        [BsonElement("PatientName"), BsonRepresentation(BsonType.String)]
        public string PatientName { get; set; }

        [BsonElement("PatientAge"), BsonRepresentation(BsonType.Int32)]
        public int PatientAge { get; set; }

        [BsonElement("PatientGender"), BsonRepresentation(BsonType.String)]
        public string PatientGender { get; set; }

        [BsonElement("Disease"), BsonRepresentation(BsonType.String)]
        public string Disease { get; set; }

        [BsonElement("Doctor"), BsonRepresentation(BsonType.String)]
        public string Doctor { get; set; }

        [BsonElement("ChosenDate"), BsonRepresentation(BsonType.String)]
        public string ChosenDate { get; set; }
    }
}
