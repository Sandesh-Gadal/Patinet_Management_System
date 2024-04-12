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
    internal class login
    {
        [BsonId, BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public string UserId { get; set; }

        [BsonElement("Firstname"), BsonRepresentation(BsonType.String)]
        public string firstname { get; set; }

        [BsonElement("Lastname"), BsonRepresentation(BsonType.String)]
        public string lastname { get; set; }

        [BsonElement("Age"), BsonRepresentation(BsonType.Decimal128)]
        public decimal age { get; set; }

        [BsonElement("Address"), BsonRepresentation(BsonType.String)]
        public string address { get; set; }

        [BsonElement("Username"), BsonRepresentation(BsonType.String)]
        public string username { get; set; }

        [BsonElement("Password"), BsonRepresentation(BsonType.String)]
        public string password { get; set; }
    }
}
