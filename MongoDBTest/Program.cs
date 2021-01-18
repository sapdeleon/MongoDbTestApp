using System;

namespace MongoDBTest
{
    class Program
    {
        [Obsolete]
        static void Main(string[] args)
        {
            MongoCRUD db = new MongoCRUD("SchoolDB");

            // 1.) this is the first record
            // db.InsertRecord("Users", new PersonModel { FirstName = "Thomas", LastName = "Mackenzie"});

            // 2.) second data with address book
            //PersonModel joe = new PersonModel
            //{
            //    FirstName = "Joe",
            //    LastName = "Thomas",
            //    PrimaryAddress = new AddressModel
            //    {
            //        StreetAddress = "123 Pike Lane",
            //        City = "Thornhil",
            //        State = "Ontario",
            //        ZipCode = "L3F 1D4"
            //    }
            //};

            //db.InsertRecord("Users", joe);

            // 3.) Show me the records
            // var recs = db.LoadRecords<PersonModel>("Users");
            //foreach(var rec in recs)
            //{
            //    Console.WriteLine($"{rec.Id}: {rec.FirstName} {rec.LastName}");

            //    if (rec.PrimaryAddress != null)
            //    {
            //        Console.WriteLine($"{rec.PrimaryAddress.StreetAddress}, {rec.PrimaryAddress.City}");
            //    }
            //    Console.WriteLine();
            //}

            // 4.) find record by id
            //var oneRec = db.LoadRecordById<PersonModel>("Users", new Guid("fae2828e-2dfd-40b5-9758-1d973ae1a309"));

            // 5.) try the UpsetRecord method - add date of birth field
            // oneRec.DateOfBirth = new DateTime(1970, 10, 21, 0, 0, 0, DateTimeKind.Utc);
            // db.UpsertRecord("Users", oneRec.Id, oneRec);

            // 6.) Now test delete record
            // db.DeleteRecord<PersonModel>("Users", oneRec.Id);

            // 7.) Test Name Model
            var recs = db.LoadRecords<NameModel>("Users");
            foreach (var rec in recs)
            {
                Console.WriteLine($"{rec.FirstName} {rec.LastName}");
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
