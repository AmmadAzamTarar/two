using System;
using Starcounter;

namespace Ammad1
{
    class Program
    {
        static void Main()
        {
            Db.Transact(() =>
            {


                var corp1 = Db.SQL<Corporation>("Select p from Corporation P").First;
                if (corp1 == null)
                {  

                    new Corporation
                    {
                        
                        Name = "Tarar"
                    };
                    var franchise1 = Db.SQL<Franchise>("Select p from Franchise P").First;
                    new Corporation
                    {

                        Name = "Tarar"
                    };
                }
                else
                {

                }

            }
            );

            Application.Current.Use(new HtmlFromJsonProvider());
            Application.Current.Use(new PartialToStandaloneHtmlProvider());

            Handle.GET("/Ammad1", () =>
            {
                return Db.Scope(() =>
                {
                    var corporation = Db.SQL<Corporation>("SELECT c FROM Corporation c").First;

                    var json = new CorporationJson
                    {
                        Data = corporation
                    };

                    if (Session.Current == null)
                    {
                        Session.Current = new Session(SessionOptions.PatchVersioning);
                    };

                    json.Session = Session.Current;

                    return json;
                });
            });
            Handle.GET("/Ammad1/partial/Franchise/{?}", (string id) =>
            {
                var json = new FranchiseJson();
                json.Data = DbHelper.FromID(DbHelper.Base64DecodeObjectID(id));
                return json;
            });
        }
    }
}