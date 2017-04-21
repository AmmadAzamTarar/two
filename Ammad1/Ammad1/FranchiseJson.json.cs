using Starcounter;

namespace Ammad1
{
    partial class FranchiseJson : Json
    {
        void Handle(Input.Save action)
        {
            Db.Transact(() =>
            {

                new Franchise
                {

                    Name = this.Name,
                    Street= this.Street,
                    ZipCode = this.ZIPCode,
                    City=this.City,
                    Country=this.Country,
                    Address=this.Address

                };

            }
            );
            Transaction.Commit();
        }
    }
}
