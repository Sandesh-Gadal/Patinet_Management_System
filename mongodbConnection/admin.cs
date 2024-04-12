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
    internal class admin 
    {
        [BsonId, BsonElement("admin_id"), BsonRepresentation(BsonType.ObjectId)]
        public string AdminId { get; set; }
        [BsonElement("Admin_Username"), BsonRepresentation(BsonType.String)]
        public string admin_username { get; set; }

        [BsonElement("Admin_Password"), BsonRepresentation(BsonType.String)]
        public string admin_password { get; set; }
    }
}
