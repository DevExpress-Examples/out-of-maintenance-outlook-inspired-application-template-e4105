using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
namespace TaskManager.TaskDatabase
{

    public partial class Task
    {
        public Task(Session session) : base(session) { }
        public Task() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
