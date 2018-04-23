using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
namespace TaskManager.TaskDatabase
{

    public partial class Person
    {
        public Person(Session session) : base(session) { }
        public Person() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
