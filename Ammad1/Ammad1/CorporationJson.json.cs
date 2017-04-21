using Starcounter;

namespace Ammad1
{
    partial class CorporationJson : Json
    {
        void Handle(Input.Save action)
        {
            Db.Transact(() =>
            {

                new Corporation
                {

                    Name = this.Name
                };
                   
            }
            );
            Transaction.Commit();
        }

    }
}
