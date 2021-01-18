using MongoDB.Bson.Serialization.Attributes;
using System;

namespace MongoDBTest
{
    public class NameModel
    {
        [BsonId]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
