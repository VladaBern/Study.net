using System.Data.Entity;

namespace HomeTask2
{
    internal class DropCreatePeronMailDb : DropCreateDatabaseIfModelChanges<PersonMailContext>
    {
        protected override void Seed(PersonMailContext context)
        {
            base.Seed(context);

            context.People.Add(new Person { FirstName = "Roman" });
            context.People.Add(new Person { FirstName = "Rita", LastName = "Rogova" });
            context.People.Add(new Person { FirstName = "John" });

            context.SaveChanges();
        }
    }
}
